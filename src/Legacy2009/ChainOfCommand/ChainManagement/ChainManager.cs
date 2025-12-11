using System.Collections.Generic;
using HarpyEagle.Chain;

/***************************************************************************************
 *  Author: Curt C.
 *  Email : harpyeaglecp@aol.com
 *  
 *  This software is released under the Code Project Open License (CPOL)
 *  See official license description at: http://www.codeproject.com/info/cpol10.aspx
 *  
 * This software is provided AS-IS without any warranty of any kind.
 *  
 *  Modification History:
 *  08/10/2009  curtc    Creation of class for www.codeproject.com example.
 ***************************************************************************************/

namespace HarpyEagle.ChainManagement
{

    /// <summary>
    /// The ChainManager is a class that manages a list of IChainHandler objects
    /// for the implementation of a slightly modified version of the "Chain-Of-Command / Chain-Of-Responsibility" design pattern.
    /// This manager maintains a List of IChainHandler object, the form the chain of handlers.
    /// 
    /// -- Deviations from a traditional implementation: --
    /// 
    /// (1) Instead of each handler calling the next handler in the chain (in a linked list fashion),
    /// each successive handler is called by iterating over the List of handlers, 
    /// calling each one's ProcessRequest() method.
    /// 
    /// (2) Each handler returns a HandlerResult, either a CHAIN_DATA_HANDLED, indicating the requeset was
    /// handled (no further processing required), or a CHAIN_DATA_NOT_HANDLED, indicating the request was
    /// NOT handled and the request should be passed to the next handler in the chain.
    /// 
    /// (3) Each handler can also throw a HandlerException, which indicates some exception condition 
    /// with a request. This can be a normal.
    /// 
    /// (4) The chain manager can optionally interate over all handlers, vs the traditional method
    /// of only one handler in the chain processing the request (which would override the HandlerResult values
    /// returned by the handlers).
    /// 
    /// (5) The chain manager also can either stop on the first ChainHandlerException encourtered, or keep iterating
    /// over all handlers. Any exception encountered during processing is retured by the ChainManager.ProcessRequest() method.
    /// This technique can be used for handlers that validate individual data items in a larger, more complex set of data. 
    /// 
    /// 
    /// </summary>
    /// <typeparam name="HANDLER_REQUEST_TYPE">Type of the individual chain handler's request data <see cref="IChainHandler.ProcessRequest()"/></typeparam>
    public class ChainManager<HANDLER_REQUEST_TYPE>
    {
        #region PrivateVariables

        /// <summary>
        /// The "Chain" - List of IChainHandler objects handled by this manager.
        /// </summary>
        private List< IChainHandler<HANDLER_REQUEST_TYPE> > handlerChain = new List< IChainHandler <HANDLER_REQUEST_TYPE>  > ();


        /// <summary>
        /// See StopOnFirstException property documentation - set in constructor
        /// </summary>
        private bool stopOnFirstHandlerException = false;

        /// <summary>
        /// See ProcessEntireChain property documentation - set in constructor
        /// </summary>
        private bool processEntireChain = false;

        #endregion

        #region PublicProperties

        /// <summary>
        /// Indicates whether the manager should stop the chain processing based on if an 
        /// exception is thrown by the current handler being processed, or continue 
        /// down the chain, allowing all handlers to process data regardless of any 
        /// exceptions that have occurred.
        /// This is a read-only property set in the constructor.
        /// </summary>
        public bool StopOnFirstException { get { return this.stopOnFirstHandlerException; } }

        /// <summary>
        /// If true, this flag indicates all handlers in the chain should process the
        /// request, regardless of the HandlerResult value returned by the individual handlers.
        /// This setting overrides the individual HandlerResult returned values.
        /// This is a read-only property set in the constructor.
        /// </summary>
        public bool ProcessEntireChain { get { return this.processEntireChain; } }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainManager"/> class.
        /// The stopOnFirstHandlerException, and the processEntireChain parameters modify
        /// the behavior of the chain processing.
        /// </summary>
        /// <param name="stopOnFirstHandlerException">While processing the chain, if this value is <c>true</c>,
        /// this manager will stop processing when the first HandlerException is encountered.  
        /// If set to false, then all handlers are given an opportunity
        /// to process data regardless of any errors that have occurred perviously in the chain.</param>
        /// <param name="processEntireChain">if set to <c>true</c> then all handlers in the chain are called, regarless of the 
        /// HandlerResult value returned by the individual handlers, if set to <c>false</c>, then the first handler that returns
        /// a HandlerResult.CHAIN_DATA_HANDLED will signal the termination of the chain.</param>
        public ChainManager(bool stopOnFirstHandlerException, bool processEntireChain)
        {
            this.stopOnFirstHandlerException = stopOnFirstHandlerException;
            this.processEntireChain = processEntireChain;
        }


        #region ChainManipulationMethods

        /// <summary>
        /// Appends the supplied IChainHandler object to the handler chain.
        /// </summary>
        /// <param name="handler">The handler.</param>
        public void AppendHandlerToChain(IChainHandler<HANDLER_REQUEST_TYPE> handler)
        {
            if (handlerChain.Contains(handler) == false)
                handlerChain.Add(handler);
        }

        /// <summary>
        /// Removes the supplied handler from chain.
        /// </summary>
        /// <param name="handler">Handler to remove.</param>
        public void RemoveHandlerFromChain(IChainHandler<HANDLER_REQUEST_TYPE> handler)
        {
            if (handlerChain.Contains(handler))
                handlerChain.Remove(handler);
        }
        #endregion

        /// <summary>
        /// Calls handlers in the chain, and returns a list of handler exceptions.
        /// </summary>
        /// <param name="requestData">The handler data, of the generic type, 'HANDLER_REQUEST_DATA'.</param>
        /// <param name="chainHandlerExceptionList">Set to a list of exceptions thrown by one or more chain handlers during the processing of this request.</param>
        /// <returns>
        /// HandlerResult indicating whether at least 1 chain handler processed the request, or that the request was not handled
        /// Note: The exact meaning of this result will depend upon the values set in the constructor: StopOnFirstException, and ProcessEntireChain,
        /// along with the construction of the handlers.
        /// </returns>
        public HandlerResult ProcessRequest(HANDLER_REQUEST_TYPE requestData, out List<ChainHandlerException> chainHandlerExceptionList )
        {
            HandlerResult chainProcessingResult=HandlerResult.CHAIN_DATA_NOT_HANDLED;

            chainHandlerExceptionList = new List<ChainHandlerException>();

            HandlerResult handlerResult = HandlerResult.CHAIN_DATA_NOT_HANDLED;
            chainProcessingResult = HandlerResult.CHAIN_DATA_NOT_HANDLED;

            // For each handler object in the chain
            for (int x = 0;
                (x < handlerChain.Count) &&
                (stopOnFirstHandlerException==false || (stopOnFirstHandlerException == true && (chainHandlerExceptionList.Count > 0 ? false : true))) &&
                (this.processEntireChain == true || handlerResult == HandlerResult.CHAIN_DATA_NOT_HANDLED)
                ;
                x++)
            {
                try
                {   // Invoke the chain's ProcessRequest() method, to give the handler an oportunity 
                    // to do some processing on the data.
                    // The handler will return either CHAIN_DATA_NOT_HANDLED (continue passing data to next chain) or
                    // or CHAIN_DATA_HANDLED (which indicates that the handler has completely handled the request, and thus
                    // the chain should be terminated.)                    
                    handlerResult = handlerChain[x].ProcessRequest(requestData);


                    if (handlerResult == HandlerResult.CHAIN_DATA_HANDLED)
                        // Make sure the caller knows that the request was handled, at least by 1 handler
                        chainProcessingResult = HandlerResult.CHAIN_DATA_HANDLED;
                }
                catch (ChainHandlerException ex)
                {
                    // Handler threw an exception - add this exception to the return exception list.
                    chainHandlerExceptionList.Add(ex);
                }
            }
            return chainProcessingResult;
        }
    }
}








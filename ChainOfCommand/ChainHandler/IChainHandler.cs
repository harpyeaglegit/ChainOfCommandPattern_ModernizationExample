
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
 *  08/10/2009  curtc    Creation of interface for www.codeproject.com example.
 ***************************************************************************************/

namespace HarpyEagle.Chain
{
    /// <summary>
    /// HandlerResult enumeration is a list a possible status values to be 
    /// returned by the IChainHandler.ProcessRequest() method call.
    /// </summary>
    public enum HandlerResult
    {
        /// <summary>
        /// Indicates the handler has completely handled the request
        /// and no further processing is needed (processing should stop).
        /// </summary>
        CHAIN_DATA_HANDLED,
        /// <summary>
        /// Indicates that the handler is not completely handled,
        /// and the next handler in the chain should be called.
        /// </summary>
        CHAIN_DATA_NOT_HANDLED
    };


    /// <summary>
    /// Interface for an object to serve as a handler in a chain-of-command design pattern list of handlers.
    /// </summary>
    /// <typeparam name="HANDLER_REQUEST_TYPE">Type of the individual chain handler's request data.</typeparam>
    public interface IChainHandler<HANDLER_REQUEST_TYPE>
    {
        /// <summary>
        /// Method to process the supplied requestData.
        /// </summary>
        /// <param name="requestData">The data to be processed by a chain handler.</param>
        /// <returns>
        /// Returns a HandlerResult to indicate what should happen next in chain processing
        /// </returns>
        HandlerResult ProcessRequest(HANDLER_REQUEST_TYPE requestData);
       
    }
}

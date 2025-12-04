using ChainOfCommandCore.Core;

/***************************************************************************************
 *  Author: Curt C.
 *  Email : harpyeaglecp@aol.com
 *  
 *  This software is released under the Code Project Open License (CPOL)
 *  See official license description at: http://www.codeproject.com/info/cpol10.aspx
 *  
 * This software is provided AS-IS without any warranty of any kind.
 * 
 ***************************************************************************************/


namespace ChainOfCommandCore.Interfaces
{
    /// <summary>
    /// Interface for an object serving as a handler in a chain-of-command chain (i.e. a link in the chain).
    /// Each handler in the chain is completedly independent of other handlers in the chain. (no knowledge of others) 
    /// </summary>
    /// <typeparam name="TData">Type of the individual chain handler's request data.</typeparam>
    public interface IChainHandler<TData>
    {
        /// <summary>
        /// Method to process the supplied requestData.
        /// </summary>
        /// <param name="requestData">The data to be processed by a chain handler.</param>
        /// <returns>
        /// Returns a HandlerResult to indicate what should happen next in chain processing
        /// </returns>        
        Task<HandlerResult> ProcessAsync(TData request);

    }
}

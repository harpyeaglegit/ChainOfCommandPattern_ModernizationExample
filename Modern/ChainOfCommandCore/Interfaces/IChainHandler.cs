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
    /// Interface for an object to serve as a handler in a chain-of-command design pattern list of handlers.
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
        HandlerResult ProcessRequest(TData requestData);

    }
}

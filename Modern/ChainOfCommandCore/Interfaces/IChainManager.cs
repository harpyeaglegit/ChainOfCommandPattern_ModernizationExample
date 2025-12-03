using ChainOfCommandCore.Core;

namespace ChainOfCommandCore.Interfaces
{
    public interface IChainManager<TData>
    {
        /// <summary>
        /// Appends a give handler to the end of the chain.
        /// </summary>
        /// <param name="handler"></param>
        void AppendHandler(IChainHandler<TData> handler);

        /// <summary>
        /// Removes the given handler from the chain.
        /// </summary>
        /// <param name="handler">Reference to a specific handler to Remove</param>
        void RemoveHandler(IChainHandler<TData> handler);

        /// <summary>
        /// Invokes the chain of handlers with the given request data.
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>Success if all handlers successfully processed requestData, Failure if any/all handlers failed when processing requestData</returns>
        HandlerResult Process(TData requestData);
        
    }
}
using ChainOfCommandCore.Core;

namespace ChainOfCommandCore.Interfaces
{
    /// <summary>
    /// Defines a chain manager (chain of command manager) is responsible for managing the chain of handlers and processing requests through the chain.<br/>
    /// Note: This interfaces specifies what an implementing class must do, but not how it does it.
    /// </summary>
    /// <typeparam name="TData">Generic type representing the type of data passed to the chain for processing</typeparam>
    public interface IChainManager<TData>
    {
        /// <summary>
        /// Appends a given handler to the end of the chain.
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
        /// The return result indicates whether the chain stragtegy produced a success of failed result.
        /// (Dependent on the chain strategy implemented, this could mean all handlers must succeed, or just one handler must succeed, etc).
        /// </summary>
        /// <param name="requestData">Data for the chain to process</param>
        /// <returns>Success requestData, Failure if any/all handlers failed when processing requestData</returns>
        HandlerResult Process(TData requestData);
        
    }
}
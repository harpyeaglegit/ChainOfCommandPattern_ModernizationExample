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
        /// <param name="handler">A chain handler to append to the handler chain</param>
        void AppendHandler(IChainHandler<TData> handler);

        /// <summary>
        /// Invokes the chain of handlers with the given request data.
        /// The return result indicates whether the chain stragtegy produced a success of failed result.
        /// (Dependent on the chain strategy implemented, this could mean all handlers must succeed, or just one handler must succeed, etc).
        /// </summary>
        /// <param name="requestData">Data for the chain to process</param>
        /// <returns>Success if the chain succeeds, or Failure according to specific implementation policy.</returns>
        Task<HandlerResult> ProcessAsync(TData requestData);
        
    }
}
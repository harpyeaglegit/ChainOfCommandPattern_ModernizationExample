using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace ChainOfCommandManagerImpl
{
    /// <summary>
    /// AbstractChainManager<br/>
    /// Abstract chain manager class that implements common functionality for chain managers.<br/>
    /// Functionality included:<br/>
    ///     (1) Appending handlers to the chain<br/>
    ///     (2) Storing exceptions encountered during processing for diagnostics<br/>
    /// 
    /// Subclasses can be created to implement different chain processing strategies, and not effect
    /// core functionality (SOLID Open/Closed, Single Responsibility, Interface principles).<br/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="ChainOfCommandCore.Interfaces.IChainManager&lt;T&gt;" />
    /// <seealso cref="ChainOfCommandCore.Interfaces.IChainManagerDiagnostics" />
    public abstract class AbstractChainManager<T> : IChainManager<T>, IChainManagerDiagnostics  
    {

        #region PROTECTED_FIELDS_AND_ PROPERTIES
        /// <summary>
        /// Chain of handlers implemented internally as a list of handlers
        /// </summary>
        protected readonly List<IChainHandler<T>> _handlers = new();

        /// <summary>
        /// The processing exception(s) encountered during last Process() invocation.
        /// </summary>
        protected readonly List<ChainHandlerException> _processingExceptions = new();
        #endregion

        #region PUBLIC_PROPERTIES
        /// <summary>
        /// Returns a collection of exceptions from the last Process() operation
        /// </summary>
        /// <returns>IEnumerable collection of exceptions encountered in chain</returns>
        public IEnumerable<ChainHandlerException> LastProcessExceptions => _processingExceptions;
        #endregion

        /// <summary>
        /// Appends a given handler to the end of the chain.
        /// </summary>
        /// <param name="handler">A chain handler to append to the handler chain</param>
        public void AppendHandler(IChainHandler<T> handler)
        {
            if (_handlers.Contains(handler) == false)
            {
                _handlers.Add(handler);
            }
        }

        // Abstract method to be implemented by derived classes for async processing of the chain
        public abstract Task<HandlerResult> ProcessAsync(T requestData);
    }
}

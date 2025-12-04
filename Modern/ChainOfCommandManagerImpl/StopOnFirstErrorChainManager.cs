using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;
using System.Runtime.CompilerServices;

namespace ChainOfCommand.Managers
{
    /// <summary>
    /// Chain Manager implementation with the following Execution strategy:
    /// 
    /// Stategy for this implementation:
    ///  - Process each handler in sequence (passing data down the chain)
    ///  - Stop on the first handler that throws a ChainHandlerException, or that returns a result of Failure.
    /// The return result indicates whether the chain stragtegy produced a success of failed result.
    /// 
    /// Diagnostic details are available via IChainManagerDiagnostics.
    /// </summary>
    public class StopOnFirstErrorChainManager<T> : IChainManager<T>, IChainManagerDiagnostics
    {
        /// <summary>
        /// Chain of handlers implemented internally as a list of handlers
        /// </summary>
        private readonly List<IChainHandler<T>> _handlers = new();

        /// <summary>
        /// The processing exception encountered during last Process().
        /// </summary>
        private readonly List<ChainHandlerException> _processingExceptions = new();

        public IEnumerable<ChainHandlerException> LastProcessExceptions => _processingExceptions;

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

        /// <summary>
        /// Invokes the chain of handlers with the given request data.
        /// (Dependent on the chain strategy implemented, this could mean all handlers must succeed, or just one handler must succeed, etc).
        /// </summary>
        /// <param name="requestData">Data for the chain to process</param>
        /// <returns>Success requestData, Failure if any/all handlers failed when processing requestData</returns>
        public async Task<HandlerResult> ProcessAsync(T requestData)
        {
            HandlerResult result = HandlerResult.Success;

            _processingExceptions.Clear();

            // Chain processing loop:
            foreach (IChainHandler<T> handler in _handlers)
            {
                try
                {
                    result = await handler.ProcessAsync(requestData);
                }
                catch (ChainHandlerException ex)
                {
                    _processingExceptions.Add(ex);
                    result = HandlerResult.Failure;
                }
                catch (Exception ex)
                {
                    // Wrap any non-ChainHandlerException exceptions in a ChainHandlerException
                    ChainHandlerException chainEx = new ChainHandlerException(
                        $"Handler of type {handler.GetType().Name} threw an unexpected exception.", ex);
                    _processingExceptions.Add(chainEx);
                    result = HandlerResult.Failure;
                }

                if (result == HandlerResult.Failure)
                {
                    // Stop processing on first handler failure.
                    break;
                }
            }

            return result;
        }

    }
}

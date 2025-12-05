using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace ChainOfCommandManagerImpl
{
    /// <summary>
    /// InvokeAllHandlersChainManager:
    /// Chain Manager implementation with the following Execution strategy:
    /// 
    /// Stategy for this implementation:
    ///  - Process all handler in sequence (passing data down the chain)
    ///  - Exceptions are collected for later analysis
    ///  - If one handler returns Failure, then the overall result is considered Failure.
    /// 
    /// Diagnostic details are available via IChainManagerDiagnostics.
    /// </summary>
    public class InvokeAllHandlersChainManager<T> : AbstractChainManager<T>
    {

        /// <summary>
        /// Invokes the chain of handlers with the given request data.
        /// (Dependent on the chain strategy implemented, this could mean all handlers must succeed, or just one handler must succeed, etc).
        /// </summary>
        /// <param name="requestData">Data for the chain to process</param>
        /// <returns>Success requestData, Failure if any/all handlers failed when processing requestData</returns>
        public override async Task<HandlerResult> ProcessAsync(T requestData)
        {
            HandlerResult result = HandlerResult.Success; // Assume success unless a handler indicates failure

            _processingExceptions.Clear();

            // Chain processing loop:
            foreach (IChainHandler<T> handler in _handlers)
            {
                try
                {
                    if(await handler.ProcessAsync(requestData) == HandlerResult.Failure)
                    {
                        // at least one handler failed, so the overall result is failure
                        result = HandlerResult.Failure;
                    }
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
                        $"Handler of type {handler.GetType().Name} threw an unexpected exception, Message: {ex.Message}", ex);
                    _processingExceptions.Add(chainEx);
                    result = HandlerResult.Failure;
                }
            }

            return result;
        }

    }
}


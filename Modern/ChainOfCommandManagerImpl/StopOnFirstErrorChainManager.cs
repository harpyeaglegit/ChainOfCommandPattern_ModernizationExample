using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;
using ChainOfCommandManagerImpl;

namespace ChainOfCommand.Managers
{
    /// <summary>
    /// Chain Manager implementation with the following Execution strategy:
    /// 
    /// Stategy for this implementation:
    ///  - Process each handler in sequence (passing data down the chain)
    ///  - Stop on the first handler that either throws a ChainHandlerException, or that returns a result of Failure.
    ///  - Any handler that throws an exception or returns Failure causes the overall chain result to be Failure.
    /// The return result indicates whether the chain stragtegy produced a success of failed result.
    /// 
    /// Diagnostic details are available via IChainManagerDiagnostics.
    /// </summary>
    public class StopOnFirstErrorChainManager<T> : AbstractChainManager<T>
    {
        /// <summary>
        /// Invokes all of the chain of handlers with the given request data.        
        /// </summary>
        /// <param name="requestData">Data for the chain to process</param>
        /// <returns>Success if no errors, Failure if any/all handlers failed when processing requestData</returns>
        public override async Task<HandlerResult> ProcessAsync(T requestData)
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

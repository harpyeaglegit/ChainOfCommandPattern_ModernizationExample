using ChainOfCommandCore.Core;

namespace ChainOfCommandCore.Interfaces
{
    /// <summary>
    /// Defines a method to return diagnostics information from a Chain Manager when
    /// one or more chain handlers have failed during processing.
    /// </summary>
    public interface IChainManagerDiagnostics
    {
        /// <summary>
        /// Returns a collection of exceptions from the last Process() operation
        /// </summary>
        /// <returns></returns>
        IEnumerable<ChainHandlerException> GetFailedLastProcessExceptions();
    }
}
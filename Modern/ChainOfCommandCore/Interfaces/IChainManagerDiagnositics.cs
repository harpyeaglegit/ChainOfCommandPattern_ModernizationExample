using ChainOfCommandCore.Core;

namespace ChainOfCommandCore.Interfaces
{
    /// <summary>
    /// Defines a method to return diagnostics information from an IChainManager when
    /// one or more chain handlers have failed during processing.<br/>
    /// Note: This defines optional behavior for an IChainManager implementation.    
    /// </summary>
    public interface IChainManagerDiagnostics
    {
        /// <summary>
        /// Returns a collection of exceptions from the last Process() operation
        /// </summary>
        /// <returns>IEnumerable</returns>
        IEnumerable<ChainHandlerException> LastProcessExceptions { get; }
    }
}
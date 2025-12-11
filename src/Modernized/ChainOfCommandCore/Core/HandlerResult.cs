namespace ChainOfCommandCore.Core
{
    /// <summary>
    /// HandlerResult enumeration is a list a possible status values to be 
    /// returned by the IChainHandler.Process() method call.
    /// </summary>
    public enum HandlerResult
    {
        /// <summary>
        /// Indicates the handler has successfully handled the request.
        /// </summary>
        Success,

        /// <summary>
        /// Indicates that the handler encountered an error during processing.        
        /// </summary>
        Failure
    };
}

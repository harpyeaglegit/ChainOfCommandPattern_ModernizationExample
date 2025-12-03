namespace ChainOfCommandCore.Core
{
    /// <summary>
    /// HandlerResult enumeration is a list a possible status values to be 
    /// returned by the IChainHandler.ProcessRequest() method call.
    /// </summary>
    public enum HandlerResult
    {
        /// <summary>
        /// Indicates the handler has completely handled the request
        /// and no further processing is needed (processing should stop).
        /// </summary>
        CHAIN_DATA_HANDLED,
        /// <summary>
        /// Indicates that the handler is not completely handled,
        /// and the next handler in the chain should be called.
        /// </summary>
        CHAIN_DATA_NOT_HANDLED
    };
}

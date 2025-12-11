namespace ChainOfCommandCore.Core
{
    /// <summary>
    /// Exception to be thrown by IChainHandler objects.
    /// Extensions of this class could include additional information 
    /// (identifying specific data, etc), to be used by an application.
    /// </summary>
    public class ChainHandlerException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainHandlerException"/> class.
        /// </summary>
        /// <param name="msg">The message text for the exception</param>
        public ChainHandlerException(string msg) : base(msg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainHandlerException"/> class.
        /// </summary>
        /// <param name="msg">The message text for the exception</param>
        /// <param name="innerException">The inner exception.</param>
        public ChainHandlerException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }
    }
}

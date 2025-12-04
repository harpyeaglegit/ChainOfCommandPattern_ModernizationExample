namespace ChainOfCommandCore.Core
{
    /// <summary>
    /// Generic exception to be thrown by IChainHandler objects.
    /// Extensions of this class could include additional information 
    /// (identifying specific data, etc), to be used by an application.
    /// </summary>
    public class ChainHandlerException : Exception
    {

        public ChainHandlerException(string msg) : base(msg)
        {
        }

        public ChainHandlerException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }
    }
}

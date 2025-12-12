using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;


namespace AppExampleCofCImpl.ChainOfCommand.Handlers.LoginValidationHandlers
{
    /// <summary>
    /// Chain handler that checks for a zero or negative customer number.
    /// Business Rule enforced by this handler:
    ///      (1) A login identifier must be a positive integer (greater than zero).
    /// </summary>
    /// <exception cref="ChainHandler.ChainHandlerException">
    /// Thrown if the login id is a less than or equal to zero.
    /// </exception>
    public class LoginIdZeroOrNegativeValidationHandler : IChainHandler<LoginData>
    {
        /// <summary>
        /// Method to process the supplied requestData.
        /// Checks to see if customer number is either negative or zero, and throws an
        /// exception indicating an invalid number.
        /// </summary>
        /// <param name="requestData">LoginData object - user information</param>
        /// <returns>
        /// HandlerResult.Failure if an exception is not thrown.
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the integer login id is less than or equal to zero.
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(LoginData requestData)
        {

            // Simulate async work (DB lookup, ledger write, service call, etc)
            await Task.Delay(10);  // For demo only. Replace with real async I/O.

            if (requestData.LoginId <= 0)
            {
                throw new ChainHandlerException($"({GetType().Name}) Invalid login identifier. Number must not less than or equal to zero.");
            }
            return HandlerResult.Success ;
        }
    }
}

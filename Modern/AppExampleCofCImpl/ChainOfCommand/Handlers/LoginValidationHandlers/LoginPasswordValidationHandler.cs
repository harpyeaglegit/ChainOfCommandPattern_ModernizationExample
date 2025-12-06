using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using AppExampleCofCImpl.DataManagement.DataStoreAccess;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;


namespace AppExampleCofCImpl.ChainOfCommand.Handlers.LoginValidationHandlers
{
    /// <summary>
    /// Chain handler that checks to make sure that the password is correct for a given login identifier.
    /// Business Rule enforced by this handler:
    ///      (1) The password must match the login identifier in the data store.
    /// </summary>
    public class LoginPasswordValidationHandler  : IChainHandler<LoginData>
    {
        /// <summary>
        /// Validate password is correct for given login identifier in the requestData.
        /// </summary>
        /// <param name="requestData">The login data to be processed by a chain handler.</param>
        /// <returns>
        /// HandlerResult.Success if password is valid for the user, otherwise throw ChainHandlerException
        /// </returns>
        /// <exception cref="ChainHandlerException">
        /// Thrown if the password is not valid for a given login id.
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(LoginData requestData)
        {
            bool isValidPassword = await DataAccess.Instance.ValidatePasswordAsync(requestData.LoginId, requestData.Password);
            if (isValidPassword == false)
            {
                throw new ChainHandlerException($"({GetType().Name}) Invalid login identifier / password combination.");
            }
            return HandlerResult.Success;
        }

    }
}

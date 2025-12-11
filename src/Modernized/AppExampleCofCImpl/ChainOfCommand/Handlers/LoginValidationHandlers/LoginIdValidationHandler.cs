using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using AppExampleCofCImpl.DataManagement.DataStoreAccess;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.LoginValidationHandlers
{
    /// <summary>
    /// Chain handler to to verify that a login identifier is valid in the data store.
    /// Business Rule enforced by this handler:
    ///      (1) A login identifier must be found in the data store.
    /// </summary>
    public class LoginIdValidationHandler : IChainHandler<LoginData>
    {
        /// <summary>
        /// Make sure the customer number in the contained the requestData parameter,
        /// Return true if success, otherwise throw ChainHandlerException.
        /// </summary>
        /// <param name="requestData">The handler data containing the login identifier to validate.</param>
        /// <returns>
        /// HandlerResult.Success if login id is valid, throws ChainHandlerException if login id is NOT valid.
        /// </returns>
        /// <exception cref="ChainHandlerException">
        /// Thrown if the login id is NOT found in the data store.
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(LoginData requestData)
        {
            // Access data store to validate login identifier.
            bool isValidLoginId = await DataAccess.Instance.ValidateLoginAsync(requestData.LoginId);

            if (isValidLoginId == false)
            {
                throw new ChainHandlerException($"(LoginIdValidationHandler) Invalid login identifier: '{requestData.LoginId}'");
            }
                        
            return HandlerResult.Success;
        }
    }
}

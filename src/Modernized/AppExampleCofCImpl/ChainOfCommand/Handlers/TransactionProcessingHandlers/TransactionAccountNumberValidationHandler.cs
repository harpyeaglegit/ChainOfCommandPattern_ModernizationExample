using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using AppExampleCofCImpl.DataManagement.DataStoreAccess;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.TransactionProcessingHandlers
{
    /// <summary>
    /// Chain handler that checks to see if the supplied account number is a
    /// valid institutional account number in the data store.
    /// Business Rule enforced by this handler:
    ///      (1) An account number must be found in the data store.
    /// </summary>
    public class TransactionAccountNumberValidationHandler : IChainHandler<AccountTransactionData>
    {
        private readonly DataAccess _dataAccess;

        public TransactionAccountNumberValidationHandler(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        /// <summary>
        /// Handler method to determine of an account number contained in the data parameter is a valid number.
        /// </summary>
        /// <param name="rqstData">AccountTransactionData object to examine</param>
        /// <returns>
        /// HandlerResult.Success if this handler determies the account number is valid, throws ChainHandlerException if invalid.
        /// </returns>
        /// <exception cref="ChainHandlerException">
        /// Thrown if the account number is invalid (not found in the data store).
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData rqstData)
        {
            bool isValidAccount = await _dataAccess.ValidateAccountAsync(rqstData.AccountNumber);
            
            if (isValidAccount == false)
            {
                throw new ChainHandlerException($"({GetType().Name}) Invalid Account Number: '{rqstData.AccountNumber}'");
            }
            return HandlerResult.Success;
        }
    }
}

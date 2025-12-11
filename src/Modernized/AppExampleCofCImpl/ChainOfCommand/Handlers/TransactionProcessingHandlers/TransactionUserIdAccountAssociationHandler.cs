using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using AppExampleCofCImpl.DataManagement.DataStoreAccess;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.TransactionProcessingHandlers
{
    /// <summary>
    /// Chain handler that verifies the user id is asscociated with the account number for a transaction request.    
    /// Business Rules assumed enforced by previous handlers:
    ///     (1) A user must own, and be authorized to access, the account for the transaction.
    /// An exception is thrown if an error occurs durig processing.
    /// </summary>
    public class TransactionUserIdAccountAssociationHandler : IChainHandler<AccountTransactionData>
    {
        /// <summary>
        /// Method to process a deposit or withdrawal transaction.
        /// </summary>
        /// <param name="requestData">The transaction data to be processed.</param>
        /// <returns>
        /// HandlerResult.Success if the withdrawal is processed successfully;
        /// </returns>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData requestData)
        {
            if (requestData.Amount <= 0.0)
            {
                throw new ChainHandlerException($"({GetType().Name})Invalid transaction amount: {requestData.Amount}. Amount must be greater than zero.");
            }

            if( (await DataAccess.Instance.ValidateUserAccountAssocAsync(requestData.OwnerId, requestData.AccountNumber)) == false)
            {
                throw new ChainHandlerException($"({GetType().Name})User ID {requestData.OwnerId} is not associated with account number {requestData.AccountNumber}.");
            }
            return HandlerResult.Success;
        }
    }
}

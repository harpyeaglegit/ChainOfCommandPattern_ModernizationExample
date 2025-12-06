using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.TransactionProcessingHandlers
{
    /// <summary>
    /// Chain handler that processes a validated Depost or Withdrawal request.
    /// Assumptions: Previous handlers in the chain have validated the transaction data.
    /// Business Rules assumed enforced by previous handlers:
    ///     (1) Withdrawal amount must be greater than zero.
    ///     (2) Deposit amount must be greater than zero.
    ///     (3) A deposit request is indicated by 'D' transaction type.
    ///     (4) A withdrawal request is indicated by 'W' transaction type.    
    ///     (5) The account number is valid and exists in the data store.
    ///     (6) A correct user is authorized to perform the transaction on the account.
    /// An exception is thrown if an error occurs durig processing.
    /// </summary>
    public class TransactionProcessHandler  : IChainHandler<AccountTransactionData>
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
            if(requestData.Amount <= 0.0)
            {
                throw new ChainHandlerException($"({GetType().Name})Invalid transaction amount: {requestData.Amount}. Amount must be greater than zero.");
            }

            switch (requestData.TransactionType)
            {
                case "W": // Withdrawal request
                    break;
                case "D": // Deposit request
                    break;
                default:  // Safety catch:invalid/unsupported request type
                    // Note: In a propertly constructed chain, this should never occur,
                    // as prior handlers should have filtered out invalid request types.
                    break;
            }

            // Simulate async work (DB lookup, ledger write, service call, etc)
            await Task.Delay(10);  // For demo only. Replace with real async I/O.

            return HandlerResult.Success;
        }
    }
}

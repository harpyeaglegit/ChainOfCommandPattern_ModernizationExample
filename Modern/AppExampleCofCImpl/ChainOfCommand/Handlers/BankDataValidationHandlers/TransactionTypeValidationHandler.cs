using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.BankDataValidationHandlers
{
    /// <summary>
    /// Chain handler that checks to see if a given transaction type
    /// is valid (Either a 'D' for deposit, or 'W' for withdrawal)
    /// </summary>
    public class TransactionTypeValidationHandler : IChainHandler<AccountTransactionData>
    {
        /// <summary>
        /// Checks to see if transaction data has a valid transaction type - either 'W' of 'D'
        /// </summary>
        /// <param name="requestData">The handler data (AccountTransactionData).</param>
        /// <returns>
        /// HandlerResult.CHAIN_DATA_NOT_HANDLED (since account transaction handlers ALL receive the data)
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the transaction type is invalid - (not a 'D' or a 'W' character)
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData requestData)
        {

            // Simulate async work (DB lookup, ledger write, service call, etc)
            await Task.Delay(10);  // For demo only. Replace with real async I/O.

            if (requestData.TransactionType != 'D' &&
                requestData.TransactionType != 'W')
            {
                throw new ChainHandlerException($"({GetType().Name}) Invalid transaction type '" + requestData.TransactionType + "' - must be either a 'W' of 'D'");
            }

            return HandlerResult.Success;
        }
    }
}

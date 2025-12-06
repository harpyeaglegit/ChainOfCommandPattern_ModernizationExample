using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.TransactionProcessingHandlers
{
    /// <summary>
    /// Chain handler that checks for a valid transaction type.
    /// Business Rule enforced by this handler:
    ///      (1) A transaction type must be a single character.
    ///      (2) Valid transaction types characters are: 'D' (deposit), 'W' (withdrawal)
    /// </summary>
    public class TransactionTypeValidationHandler : IChainHandler<AccountTransactionData>
    {
        /// <summary>
        /// Checks to see if transaction data has a valid transaction type - either 'W' of 'D'
        /// </summary>
        /// <param name="requestData">The handler data (AccountTransactionData).</param>
        /// <returns>
        /// HandlerResult.Success
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the transaction type is invalid - (not a 'D' or a 'W' character)
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData requestData)
        {
            // Simulate async work (DB lookup, ledger write, service call, etc)
            await Task.Delay(10);  // For demo only. Replace with real async I/O.

            if (requestData.TransactionType != "D" && requestData.TransactionType != "W")
            {
                throw new ChainHandlerException($"({GetType().Name}) Invalid transaction type '{requestData.TransactionType}' - must be either a 'W' or 'D'");
            }
            return HandlerResult.Success;
        }
    }
}

using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.TransactionProcessingHandlers
{
    /// <summary>
    /// Chain handler that validates that a given amount is greater than zero
    /// for a transaction.
    /// </summary>
    public class TransactionAmountValidationHandler : IChainHandler<AccountTransactionData>
    {

        /// <summary>
        /// Handler to check for valid transaction amount.        
        /// Business Rule enforced by this handler:
        ///      (1) A transaction amount must be greater than zero (i.e. a positive number).
        /// </summary>
        /// <param name="requestData">The handler data (AccountTransactionData object).</param>
        /// <returns>
        /// HandlerResult.Success if the amount value is valid (greater than zero).
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the amount for the transaction data is less than or equal to zero.
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData requestData)
        {

            // Simulate async work (DB lookup, ledger write, service call, etc)
            await Task.Delay(10);  // For demo only. Replace with real async I/O.

            if (requestData.Amount <= 0.0) // invalid amount- only accept positive dollar amounts
            {
                throw new ChainHandlerException($"({GetType().Name}) Invalid Amount:({requestData.Amount}) is less than or equal to zero.");
            }

            return HandlerResult.Success;
        }
    }
}

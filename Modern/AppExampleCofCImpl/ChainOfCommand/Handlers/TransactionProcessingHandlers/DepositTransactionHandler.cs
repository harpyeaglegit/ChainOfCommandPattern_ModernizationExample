using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.TransactionProcessingHandlers
{
    /// <summary>
    /// Chain handler that processes a Deposit request.
    /// </summary>
    public class DepositTransactionHandler : IChainHandler<AccountTransactionData>
    {
        /// <summary>
        /// Method to process a deposit transaction.
        /// </summary>
        /// <param name="requestData">The transaction data to be processer.</param>
        /// <returns>
        /// Returns HandlerResult.Failure if the request data is not a Deposit request with a positive amount.
        /// Returns HandlerResult.Success if the request data is a Deposit request with a deposit amount.
        /// </returns>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData requestData)
        {

            HandlerResult result = HandlerResult.Failure;
            if (requestData.TransactionType == 'D' && requestData.Amount > 0.0)
            {
                // Handle the DEPOSIT here....

                // Simulate async work (DB lookup, ledger write, service call, etc)
                await Task.Delay(10);  // For demo only. Replace with real async I/O.

                // Indicate that this handler has handled the request (a deposit), and the request does not                
                result = HandlerResult.Success;
            }
            return result;
        }

    }
}

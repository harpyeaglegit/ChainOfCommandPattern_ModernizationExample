using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

/***************************************************************************************
 *  Author: Curt C.
 *  Email : harpyeaglecp@aol.com
 *  
 *  This software is released under the Code Project Open License (CPOL)
 *  See official license description at: http://www.codeproject.com/info/cpol10.aspx
 *  
 * This software is provided AS-IS without any warranty of any kind.
 *  
 *  Modification History:
 *  08/10/2009  curtc    Creation of class for www.codeproject.com example.
 *  
 ***************************************************************************************/
namespace AppExampleCofCImpl.ChainOfCommand.Handlers.BankDataValidationHandlers
{
    /// <summary>
    /// Chain handler that validates that a given amount is greater than zero
    /// for a transaction.
    /// </summary>
    public class TransactionAmountValidationHandler : IChainHandler<AccountTransactionData>
    {

        /// <summary>
        /// Checks to see if transaction has a positive amount,
        /// throws validation exception of less than or equal to zero.
        /// </summary>
        /// <param name="requestData">The handler data (AccountTransactionData object).</param>
        /// <returns>
        /// HandlerResult.CHAIN_DATA_NOT_HANDLED (since account transaction handlers ALL receive the data)
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the amount for the transaction data is less than or equal to zero.
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData requestData)
        {

            // Simulate async work (DB lookup, ledger write, service call, etc)
            await Task.Delay(10);  // For demo only. Replace with real async I/O.

            if (requestData.Amount <= 0.0) // invalid amount- only accept positive dollar amounts
                throw new ChainHandlerException("(TransactionAmountValidationHandler) Amount:(" + requestData.Amount + ") is less than or equal to zero.");

            return HandlerResult.Success;
        }
    }
}

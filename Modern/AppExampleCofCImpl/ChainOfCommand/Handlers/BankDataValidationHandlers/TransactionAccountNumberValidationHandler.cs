using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;
using ChainOfCommandExample.Data;

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
 ***************************************************************************************/

namespace AppExampleCofCImpl.ChainOfCommand.Handlers.BankDataValidationHandlers
{
    /// <summary>
    /// Chain handler that checks to see if the supplied account number is a
    /// valid account number in the data store.
    /// </summary>
    public class TransactionAccountNumberValidationHandler : IChainHandler<AccountTransactionData>
    {
        /// <summary>
        /// Method to process the supplied requestData.
        /// </summary>
        /// <param name="rqstData">AccountTransactionData object</param>
        /// <returns>
        /// HandlerResult.Success if this handler determies the account number is valid.
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the account number is invalid (not found in the data store).
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData rqstData)
        {
            // Simulate async work (DB lookup, ledger write, service call, etc)
            await Task.Delay(10);  // For demo only. Replace with real async I/O.

            if (DataStore.IsAccountNumberValid(rqstData.AccountNumber) == false)
                throw new ChainHandlerException("(TransactionAccountNumberValidationHandler) Invalid transaction account number:"+ rqstData.AccountNumber);

            return HandlerResult.Success;
        }
    }
}

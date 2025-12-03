using ChainOfCommandExample.Data;
using HarpyEagle.Chain;

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

namespace ChainOfCommandExample.BankDataValidationHandlers.TransactionHandlers
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
        /// <param name="requestData">AccountTransactionData object</param>
        /// <returns>
        /// HandlerResult.CHAIN_DATA_NOT_HANDLED (since account transaction handlers ALL receive the data)
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the account number is invalid (not found in the data store).
        /// </exception>
        public HandlerResult ProcessRequest(AccountTransactionData requestData)
        {
            if (DataStore.IsAccountNumberValid(requestData.AccountNumber) == false)
                throw new ChainHandlerException("(TransactionAccountNumberValidationHandler) Invalid transaction account number:"+requestData.AccountNumber);

            return HandlerResult.CHAIN_DATA_NOT_HANDLED;
        }
    }
}

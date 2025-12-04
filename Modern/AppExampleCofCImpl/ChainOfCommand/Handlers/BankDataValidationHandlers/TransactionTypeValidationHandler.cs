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
        public HandlerResult ProcessRequest(AccountTransactionData requestData)
        {
            if (requestData.TransactionType != 'D' &&
                requestData.TransactionType != 'W')
                throw new ChainHandlerException("(TransactionTypeValidationHandler) Invalid transaction type '"+requestData.TransactionType+"' - must be either a 'W' of 'D'");

            return HandlerResult.Success;
        }
    }
}

using AppExampleCofCImpl.DataManagement.ApplicationData;
using AppExampleCofCImpl.DataManagement.DataStoreAccess;
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
        /// Handler method to determine of an account number contained in the data parameter is a valid number.
        /// </summary>
        /// <param name="rqstData">AccountTransactionData object to examine</param>
        /// <returns>
        /// HandlerResult.Success if this handler determies the account number is valid, throws ChainHandlerException if invalid.
        /// </returns>
        /// <exception cref="ChainHandlerException">
        /// Thrown if the account number is invalid (not found in the data store).
        /// </exception>
        public async Task<HandlerResult> ProcessAsync(AccountTransactionData rqstData)
        {
            bool isValidAccount = await DataAccess.Instance.ValidateAccountAsync(rqstData.AccountNumber);
            if (isValidAccount == false)
            {
                throw new ChainHandlerException($"(TransactionAccountNumberValidationHandler) Invalid account number: '{rqstData.AccountNumber}'");
            }
            return HandlerResult.Success;
        }
    }
}

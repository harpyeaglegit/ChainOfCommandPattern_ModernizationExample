using HarpyEagle.Chain;
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


namespace ExampleChainHandlers.TransactionProcessingHandlers
{
    /// <summary>
    /// Chain handler that processes a Deposit request.
    /// </summary>
    public class DepositTransactionHandler : IChainHandler<AccountTransactionData>
    {
        /// <summary>
        /// Method to process a deposit transaction.
        /// </summary>
        /// <param name="requestData">The transaction data to be processedr.</param>
        /// <returns>
        /// Returns HandlerResult.CHAIN_DATA_NOT_HANDLED if the request data is not a Deposit request with a positive amount.
        /// Returns HandlerResult.CHAIN_DATA_HANDLED if the request data is a Deposit request with a deposit amount.
        /// </returns>
        public HandlerResult ProcessRequest(AccountTransactionData requestData)
        {
            HandlerResult result = HandlerResult.CHAIN_DATA_NOT_HANDLED;
            if (requestData.TransactionType == 'D' && requestData.Amount > 0.0)
            {
                // Handle the DEPOSIT here....

                // Indicate that this handler has handled the request (a deposit), and the request does not
                // need to passed up the chain.
                result = HandlerResult.CHAIN_DATA_HANDLED;
            }
            return result;
        }

    }
}

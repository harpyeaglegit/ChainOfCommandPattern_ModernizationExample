
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

namespace ChainOfCommandExample.Data
{
    /// <summary>
    /// An oversimplified class for containing the data for one bank account transaction.
    /// </summary>
    public class AccountTransactionData
    {

        #region Private_Field_Data
        // Account number for which the transaction is applied:
        private int accountNumber;

        // Amount of the transaction
        private double amount;

        // Transaction Type: 'W' for withdrawal, 'D' for deposit
        char transactionType;
        #endregion


        #region Properties

        /// <summary>
        /// Gets the transaction account number.
        /// </summary>
        /// <value>The account number.</value>
        public int AccountNumber { get { return accountNumber; } }

        /// <summary>
        /// Gets the transaction amount.
        /// </summary>
        /// <value>The amount.</value>
        public double Amount { get { return amount; } }

        /// <summary>
        /// Gets the type of the transaction ('W' for withdrawal, 'D' for deposit).
        /// </summary>
        /// <value>The type of the transaction.</value>
        public char TransactionType { get { return transactionType; } }

        #endregion

       
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTransactionData"/> class.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="transactionType">Type of the transaction.</param>
        public AccountTransactionData(int accountNumber, double amount, char transactionType)
        {
            this.accountNumber = accountNumber;
            this.amount = amount;
            this.transactionType = transactionType;
        }
    }
}

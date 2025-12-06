
namespace AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts
{
    /// <summary>
    /// An oversimplified class for containing the data for one bank account transaction.
    /// </summary>
    public class AccountTransactionData
    {
        #region Properties

        /// <summary>
        /// Gets or sets the account owner identifier for this transaction
        /// </summary>
        /// <value>
        /// The owner identifier.
        /// </value>
        public int OwnerId { get; set; }    

        /// <summary>
        /// Gets the transaction account number for this transaction.
        /// </summary>
        /// <value>The account number.</value>
        public int AccountNumber { get; private set; }

        /// <summary>
        /// Gets the transaction amount for this transaction
        /// </summary>
        /// <value>The amount.</value>
        public double Amount { get; private set; }

        /// <summary>
        /// Gets the type of the transaction ('W' for withdrawal, 'D' for deposit).
        /// </summary>
        /// <value>The type of the transaction.</value>
        public char TransactionType { get; private set; }

        #endregion

       
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTransactionData"/> class.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="transactionType">Type of the transaction.</param>
        public AccountTransactionData(int accountNumber, double amount, char transactionType)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            TransactionType = transactionType;
        }
    }
}

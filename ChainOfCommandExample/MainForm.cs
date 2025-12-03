using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChainOfCommandExample.BankDataValidationHandlers.TransactionHandlers;
using ChainOfCommandExample.Data;
using ChainOfCommandExample.LoginValidationHandlers;
using ChainOfCommandExample.TransactionHandlers;
using HarpyEagle.Chain;
using HarpyEagle.ChainManagement;
using ExampleChainHandlers.TransactionProcessingHandlers;

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

namespace ChainOfCommandExample
{
    public partial class MainForm : Form
    {
        // Chain to perform login authorization example
        private ChainManager<LoginData> loginAuthorizationChain;

        // Chain to validate transaction example data 
        private ChainManager<AccountTransactionData> transactionValidationChain;

        // Chain to process a transaction
        private ChainManager<AccountTransactionData> transactionProcessingChain;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            ConstructLoginValidationChain();
            ConstructAccountDataValidationChain();
            ConstructTransactionProcessingChain();
        }

        /// <summary>
        /// Constructs the login authorization validation chain.
        /// In a real world application, these chains could be constructed dynamically.
        /// One possibility would be to add assembly names/ class names of handlers to configurations settings,
        /// and use reflection to dynamically create handler objects and build the chains.
        /// </summary>
        private void ConstructLoginValidationChain()
        {
            // variables to pass into constructor
            bool stopOnFirstHandlerException;
            bool processEntireChain;

            //----------------------------------------------------------------------------------
            // Create the login authorization chain:
            //  Requirements for login authorization process:
            //      (1) The login authorization process should STOP when the first error is encountered,
            //          and not keep processsing the rest of the requirements.
            //      (2) An integer login id must not be less than or equal to zero.
            //      (3) The integer login id must be found in the data store.
            //      (4) The password string must match that found in the data store for the login id.


            // Create a chain that will satifisfy requirement (1) listed above.
            stopOnFirstHandlerException = true;
            processEntireChain = true;            
            loginAuthorizationChain = new ChainManager<LoginData>(stopOnFirstHandlerException, processEntireChain);

            // Build the chain - add 3 handlers to satisfiy authorization requirements (2), (3), and (4) listed above
            loginAuthorizationChain.AppendHandlerToChain(new LoginIdZeroOrNegativeValidationHandler());
            loginAuthorizationChain.AppendHandlerToChain(new LoginIdValidationHandler());
            loginAuthorizationChain.AppendHandlerToChain(new LoginPasswordValidationHandler());
        }



        /// <summary>
        /// Constructs the account transaction validation chain.
        /// In a real world application, these chains could be constructed dynamically.
        /// One possibility would be to add assembly names/ class names of handlers to configurations settings,
        /// and use reflection to dynamically create handler objects and build the chains.
        /// </summary>
        private void ConstructAccountDataValidationChain()
        {
            // variables to pass into constructor
            bool stopOnFirstHandlerException;
            bool processEntireChain;

            //----------------------------------------------------------------------------------
            // Create the transaction validation chain:
            // Requirements for transaction validation:
            //   (1) The transaction validation process should validate all data fields of a transaction.
            //       Every handler should have an opportunity to process transaction data).
            //   (2) A transaction 'account number' must be found in the data store
            //   (3) A transaction 'type' must be either a 'D' character for deposit, or a 'W' character for withdrawal.
            //   (4) A transaction 'amount' must be a positive value.

            
            // Build the transaction validation chain to satifisfy transaction requirement (1) listed above.
            // Note that since all handlers in the chain will receive an opportunity to review the
            // request data, that the return values from the ChainManager.ProcessRequest() method are
            // insignificant - rather, the exception list is examined to see if there were any errors
            // encountered by any of the chain handlers. 
            stopOnFirstHandlerException = false;
            processEntireChain = true;
            transactionValidationChain = new ChainManager<AccountTransactionData>(stopOnFirstHandlerException, processEntireChain);

            // Build the transaction validation chain  - add 3 handlers to satisfy transaction requirements: (2), (3), and (4) listed above.
            transactionValidationChain.AppendHandlerToChain(new TransactionAccountNumberValidationHandler());
            transactionValidationChain.AppendHandlerToChain(new TransactionTypeValidationHandler());
            transactionValidationChain.AppendHandlerToChain(new TransactionAmountValidationHandler());
        }


        /// <summary>
        /// Constructs the transaction processing chain.
        /// </summary>
        private void ConstructTransactionProcessingChain()
        {
            // variables to pass into constructor
            bool stopOnFirstHandlerException;
            bool processEntireChain;

            // Create the transaction processing chain:
            // Requirements for processing a transaction:
            //   (1) Only one handler will handle a transaction request.
            //   (2) A transaction with a type of 'D' and a positive amount will be handled as a deposit.
            //   (3) A transaction with a type of 'W' and a positive amount will be treated as a withdrawal.

            stopOnFirstHandlerException = true;
            processEntireChain = false;  // Only ONE handler in this chain should handle the request

            // Build the chain to satisfy requirement (1) above.
            transactionProcessingChain = new ChainManager<AccountTransactionData>(stopOnFirstHandlerException, processEntireChain);

            // Add chain handlers to satisfy requirements (2) and (3) above.
            transactionProcessingChain.AppendHandlerToChain(new DepositTransactionHandler());
            transactionProcessingChain.AppendHandlerToChain(new WithdrawalTransactionHandler());
        }

        /// <summary>
        /// Creates a 'LoginData' object from login values from screen
        /// </summary>
        /// <returns>CustomerData object</returns>
        private LoginData CreateLoginDataFromScreen()
        {
            return new LoginData(Convert.ToInt32(txtBoxLoginId.Text), txtBoxPassword.Text);
        }

        /// <summary>
        /// Creates an 'AccountTransactionData' object from transaction data from the screen.
        /// </summary>
        /// <returns>AccountTransactionData object</returns>
        private AccountTransactionData CreateTransactionDataFromScreen()
        {
            int accountNumber;
            double amount;
            char accountType;
            try
            {
                accountNumber = Convert.ToInt32(txtBoxAccountNumber.Text.Trim());
            }
            catch (Exception)
            {
                accountNumber = 0; //Error in number formatting
            }
            try
            {
                amount = Convert.ToDouble(txtBoxAmount.Text.Trim());
            }
            catch (Exception)
            {
                amount = 0;//Error in number formatting
            }

            if (txtBoxTransactionType.Text.Trim().Length == 1)
                accountType = txtBoxTransactionType.Text.Trim()[0];
            else
                accountType = ' '; // Single character only allowed!

            return new AccountTransactionData(Convert.ToInt32(accountNumber), Convert.ToDouble(amount), txtBoxTransactionType.Text.Trim()[0]);
        }

        /// <summary>
        /// Handles the Click event of the btnValidateCustomer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnValidateLoginData_Click(object sender, EventArgs e)
        {

            rtb.Clear();
            Application.DoEvents();

            // Get the login data from the screen:            
            LoginData loginData = CreateLoginDataFromScreen();

            // List of exception(s) encountered during the login validation process.
            List<ChainHandlerException> validationExceptions;            

            // Submit request for the login validation chain, passing in the login data as argument.
            // Note- since all handlers in the login validation chain can receive the request data, 
            // the ProcessRequest() return value does not having much meaning here.
            loginAuthorizationChain.ProcessRequest(loginData, out validationExceptions);





            if (validationExceptions.Count > 0)
            {
                // If exceptions are encountered, then at least one handler found a problem with the validation
                MessageBox.Show("Login Validation FAILED! - Please Try Again!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Display exceptions returned by the handlers in the customer chain
                foreach (ChainHandlerException currentException in validationExceptions)
                    rtb.Text += currentException.Message + "\n";

                rtb.Text += "\nTotal Exceptions Reported=" + validationExceptions.Count;
            }
            else
            {
                // No exceptions were returned, indicating all handlers validated their portion of the data successfully
                MessageBox.Show("Login Validation SUCCEEDED!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtb.Text = "Login validation chain had zero exceptions - validation succeeded!";
            }

        }

        /// <summary>
        /// Handles the Click event of the btnValidateTransaction control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnValidateTransaction_Click(object sender, EventArgs e)
        {

            rtb.Clear();
            Application.DoEvents();

            // Get the transaction data from the screen:            
            AccountTransactionData transactionData = CreateTransactionDataFromScreen();

            // List of exception(s) encountered during the login validation process.
            List<ChainHandlerException> validationExceptions;

            // Submit request for the transaction validation chain, passing in the transaction data as argument.
            transactionValidationChain.ProcessRequest(transactionData, out validationExceptions);

            if (validationExceptions.Count > 0)
            {
                // If exceptions are encountered, then at least one handler found a problem with the validation
                MessageBox.Show("Transaction Validation FAILED! - Please Try Again!", "Transaction Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Display exceptions returned by the handlers in the transaction chain
                foreach (ChainHandlerException currentException in validationExceptions)
                    rtb.Text += currentException.Message + "\n";

                rtb.Text += "\nTotal Exceptions Reported=" + validationExceptions.Count;
            }
            else
            {
                // No exceptions were returned, indicating all handlers validated their portion of the data successfully
                MessageBox.Show("Transaction Validation SUCCEEDED!", "Transaction Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtb.Text = "Transaction validation chain had zero exceptions - validation succeeded!";
            }
        }

        /// <summary>
        /// Handles the Click event of the btnProcessTransaction control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnProcessTransaction_Click(object sender, EventArgs e)
        {
            rtb.Clear();
            Application.DoEvents();

            // Get the transaction data from the screen:            
            AccountTransactionData transactionData = CreateTransactionDataFromScreen();

            // List of exception(s) encountered during the login validation process.
            List<ChainHandlerException> validationExceptions;

            HandlerResult chainResult = transactionProcessingChain.ProcessRequest(transactionData, out validationExceptions);

            if (validationExceptions.Count > 0)
            {
                MessageBox.Show("Transaction Processing FAILED - Unexpected Exceptions were returned by the handler(s)!", "Transaction Processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chainResult == HandlerResult.CHAIN_DATA_HANDLED)
            {
                MessageBox.Show("The Transaction was Handled!", "Transaction Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtb.Text += "The transaction data was processed successfully.";
            }
            else if (chainResult == HandlerResult.CHAIN_DATA_NOT_HANDLED) 
            {
                MessageBox.Show("The Transaction was NOT Handled!", "Transaction Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtb.Text += "The transaction data was NOT handled.";
            }
        }


    }
}

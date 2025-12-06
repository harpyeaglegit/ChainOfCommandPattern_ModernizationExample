/***************************************************************************************
 *  Author: Curt C.
 *  Email : harpyeaglecp@aol.com
 *  
 *  This software is released under the Code Project Open License (CPOL)
 *  See official license description at: http://www.codeproject.com/info/cpol10.aspx
 *  
 * This software is provided AS-IS without any warranty of any kind.
 * 
 ***************************************************************************************/

using AppExampleCofCImpl.ChainOfCommand.Factory;
using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommandCore.Core;
using ChainOfCommandCore.Interfaces;

namespace CofCExampleUsageWinForms
{
    public partial class MainForm : Form
    {
        // Chain to perform login authorization example
        private readonly IChainManager<LoginData> loginAuthorizationChain;

        // Chain to validate transaction example data 
        private readonly IChainManager<AccountTransactionData> transactionValidationChain;

       
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            loginAuthorizationChain = ChainManagerFactory.CreateLoginAuthorizationChainManager();
            transactionValidationChain = ChainManagerFactory.ConstructAccountTransactionChain();
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
        private async void btnValidateLoginData_Click(object sender, EventArgs e)
        {
            rtb.Clear();

            // Get the login data from the screen:            
            LoginData loginData = new LoginData(Convert.ToInt32(txtBoxLoginId.Text), txtBoxPassword.Text);

            // Submit request for the login validation chain, passing in the login data as argument.
            // Note- since all handlers in the login validation chain can receive the request data, 
            // the ProcessRequest() return value does not having much meaning here.
            HandlerResult loginAuthResult =  await loginAuthorizationChain.ProcessAsync(loginData);

            if (loginAuthResult == HandlerResult.Failure)
            {
                // If exceptions are encountered, then at least one handler found a problem with the validation
                MessageBox.Show("Login Validation FAILED! - Please Try Again!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Display exceptions returned by the handlers in the customer chain
                if(loginAuthorizationChain is IChainManagerDiagnostics diag)
                {
                    foreach (ChainHandlerException currentException in diag.LastProcessExceptions)
                    {
                        rtb.Text += currentException.Message + "\n";
                    }

                    rtb.Text += "\nTotal Exceptions Reported=" + diag.LastProcessExceptions.Count();
                }

               
            }
            else
            {
                // No exceptions were returned, indicating all handlers validated their portion of the data successfully
                MessageBox.Show("Login Validation SUCCEEDED!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtb.Text = "Login validation chain had zero exceptions - validation succeeded!";
            }

        }

        /// <summary>
        /// Handles the Click event of the btnProcessTransaction control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private async void btnProcessTransaction_Click(object sender, EventArgs e)
        {
            rtb.Clear();

            // Get the transaction data from the screen:            
            AccountTransactionData transactionData = CreateTransactionDataFromScreen();

            // Submit request for the transaction validation chain, passing in the transaction data as argument.
            HandlerResult chainResult = await transactionValidationChain.ProcessAsync(transactionData);

            if (chainResult == HandlerResult.Failure)
            {
                // If exceptions are encountered, then at least one handler found a problem with the validation
                MessageBox.Show("Transaction Validation FAILED! - Please Try Again!", "Transaction Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Display exceptions returned by the handlers in the transaction chain
                if (transactionValidationChain is IChainManagerDiagnostics diag)
                {
                    foreach (ChainHandlerException currentException in diag.LastProcessExceptions)
                    {
                        rtb.Text += $"{currentException.Message}\n";
                    }

                    rtb.Text += $"\nTotal Exceptions Reported= {diag.LastProcessExceptions.Count()}";
                }
            }
            else
            {
                // No exceptions were returned, indicating all handlers validated their portion of the data successfully
                MessageBox.Show("Transaction Validation SUCCEEDED!", "Transaction Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtb.Text = "Transaction validation chain had zero exceptions - validation succeeded!";
            }
        }


    }
}

/***************************************************************************************
 *  Author: Curt C.

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
            panelAccountTransaction.Enabled = false; // Disable transaction panel until login validated
            // Initialize validation chains
            loginAuthorizationChain = ChainManagerFactory.CreateLoginAuthorizationChainManager();
            transactionValidationChain = ChainManagerFactory.ConstructAccountTransactionChain();
        }

        /// <summary>
        /// Creates an 'AccountTransactionData' object from transaction data from the screen.
        /// </summary>
        /// <returns>AccountTransactionData object</returns>
        private AccountTransactionData CreateTransactionDataFromScreen()
        {
            int accountNumber = (int)numUpDownAccountNumber.Value;
            double amount = (double)numUpDownAmount.Value;
            return new AccountTransactionData(accountNumber, amount, txtBoxTransactionType.Text);
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
            LoginData loginData = new LoginData((int)numUdLoginId.Value, txtBoxPassword.Text);

            // Submit request for the login validation chain, passing in the login data as argument.
            HandlerResult loginAuthResult = await loginAuthorizationChain.ProcessAsync(loginData);
            panelAccountTransaction.Enabled = (loginAuthResult == HandlerResult.Success);

            if (loginAuthResult == HandlerResult.Failure)
            {
                // If exceptions are encountered, then at least one handler found a problem with the validation
                MessageBox.Show("Login Validation FAILED! - Please Try Again!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (loginAuthorizationChain is IChainManagerDiagnostics diag)
                    DisplayResults(diag);
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
                
                if (transactionValidationChain is IChainManagerDiagnostics diag)
                    DisplayResults(diag);
            }
            else
            {
                // No exceptions were returned, indicating all handlers validated their portion of the data successfully
                MessageBox.Show("Transaction Validation SUCCEEDED!", "Transaction Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Write any exception messages contained in the supplied IChainManagerDiagnostics parameter, 
        /// otherwise write success message.
        /// </summary>
        /// <param name="diag">The diag.</param>
/        private void DisplayResults(IChainManagerDiagnostics diag)
        {
            if (diag?.LastProcessExceptions?.Count() > 0)
            {
                foreach (ChainHandlerException currentException in diag.LastProcessExceptions)
                {
                    rtb.Text += $"{currentException.Message}\n";
                }
                rtb.Text += $"\nTotal Exceptions Reported= {diag.LastProcessExceptions.Count()}";
            }
            else
            {
                rtb.Text = "Chain processing had no exceptions - validation succeeded!";
            }

        }
    }
}

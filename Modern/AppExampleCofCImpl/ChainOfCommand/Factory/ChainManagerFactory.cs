using AppExampleCofCImpl.ChainOfCommand.Handlers.LoginValidationHandlers;
using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using ChainOfCommand.Managers;
using ChainOfCommandCore.Interfaces;

namespace AppExampleCofCImpl.ChainOfCommand.Factory
{
    public static class ChainManagerFactory
    {

        /// <summary>
        /// Creates the login authorization chain manager.
        ///  Requirements for login authorization process:
        ///      (1) The login authorization process should STOP when the first error is encountered,
        ///          and not keep processsing the rest of the requirements.
        ///      (2) An integer login id must not be less than or equal to zero.
        ///      (3) The integer login id must be found in the data store.
        ///      (4) The password string must match that found in the data store for the login id.
        /// 
        /// </summary>
        /// <returns>Chain manager to process login authorization request.</returns>
        public static IChainManager<LoginData> CreateLoginAuthorizationChainManager()
        {
            // Requirement 1: Implemented selecting a StopOnFirstErrorChainManager.
            IChainManager<LoginData> result = new StopOnFirstErrorChainManager<LoginData>();

            // Requirement 2: Implemented by adding LoginIdZeroOrNegativeValidationHandler
            result.AppendHandler(new LoginIdZeroOrNegativeValidationHandler());

            // Requirement 3: Implemented by adding LoginIdValidationHandler
            result.AppendHandler(new LoginIdValidationHandler());

            // Requirement 4: Implemented by adding LoginPasswordValidationHandler
            result.AppendHandler(new LoginPasswordValidationHandler());

            return result;
        }

        /// <summary>
        /// Constructs the account transaction validation chain.
        /// In a real world application, these chains could be constructed dynamically.
        /// One possibility would be to add assembly names/ class names of handlers to configurations settings,
        /// and use reflection to dynamically create handler objects and build the chains.
        /// </summary>
        //public static IChainManager<AccountTransactionData> ConstructAccountDataValidationChain()
        //{
        //    // variables to pass into constructor
        //    bool stopOnFirstHandlerException;
        //    bool processEntireChain;

        //    //----------------------------------------------------------------------------------
        //    // Create the transaction validation chain:
        //    // Requirements for transaction validation:
        //    //   (1) The transaction validation process should validate all data fields of a transaction.
        //    //       Every handler should have an opportunity to process transaction data).
        //    //   (2) A transaction 'account number' must be found in the data store
        //    //   (3) A transaction 'type' must be either a 'D' character for deposit, or a 'W' character for withdrawal.
        //    //   (4) A transaction 'amount' must be a positive value.


        //    // Build the transaction validation chain to satifisfy transaction requirement (1) listed above.
        //    // Note that since all handlers in the chain will receive an opportunity to review the
        //    // request data, that the return values from the ChainManager.ProcessRequest() method are
        //    // insignificant - rather, the exception list is examined to see if there were any errors
        //    // encountered by any of the chain handlers. 
        //    stopOnFirstHandlerException = false;
        //    processEntireChain = true;
        //    transactionValidationChain = new ChainManager<AccountTransactionData>(stopOnFirstHandlerException, processEntireChain);

        //    // Build the transaction validation chain  - add 3 handlers to satisfy transaction requirements: (2), (3), and (4) listed above.
        //    transactionValidationChain.AppendHandlerToChain(new TransactionAccountNumberValidationHandler());
        //    transactionValidationChain.AppendHandlerToChain(new TransactionTypeValidationHandler());
        //    transactionValidationChain.AppendHandlerToChain(new TransactionAmountValidationHandler());
        //}
    }
}

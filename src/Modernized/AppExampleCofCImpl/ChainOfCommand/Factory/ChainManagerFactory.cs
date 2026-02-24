using AppExampleCofCImpl.ChainOfCommand.Handlers.LoginValidationHandlers;
using AppExampleCofCImpl.ChainOfCommand.Handlers.TransactionProcessingHandlers;
using AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts;
using AppExampleCofCImpl.DataManagement.DataStoreAccess;
using AppExampleCofCImpl.DataManagement.Interfaces;
using ChainOfCommand.Managers;
using ChainOfCommandCore.Interfaces;
using ChainOfCommandManagerImpl;

namespace AppExampleCofCImpl.ChainOfCommand.Factory
{
    public static class ChainManagerFactory
    {

        /// <summary>
        /// Creates the login authorization chain manager.<br/>
        ///  Requirements for login authorization process:<br/>
        ///      (1) The login authorization process should give all handlers a chance to process the login data.<br/>        
        ///      (2) An integer login id must not be less than or equal to zero.<br/>
        ///      (3) The integer login id must be found in the data store.<br/>
        ///      (4) The password string must match that found in the data store for the login id.<br/>
        /// </summary>
        /// <returns>Chain manager to process login authorization request.</returns>
        public static IChainManager<LoginData> CreateLoginAuthorizationChainManager()
        {
            IDataStore dataStore = new InMemoryDataStore();
            var dataAccess = new DataAccess(dataStore);


            // Requirement 1: Implemented selecting a InvokeAllHandlersChainManager.
            IChainManager<LoginData> result = new InvokeAllHandlersChainManager<LoginData>();

            // Requirement 2: Implemented by adding LoginIdZeroOrNegativeValidationHandler
            result.AppendHandler(new LoginIdZeroOrNegativeValidationHandler());

            // Requirement 3: Implemented by adding LoginIdValidationHandler
            result.AppendHandler(new LoginIdValidationHandler(dataAccess));

            // Requirement 4: Implemented by adding LoginPasswordValidationHandler
            result.AppendHandler(new LoginPasswordValidationHandler(dataAccess));

            return result;
        }


        /// <summary>
        /// Constructs the account transaction validation/processing chain manager.<br/>
        /// Chain purpose: validate all data fields of a transaction request (account number, amount, and transaction type),
        ///   the process an deposit or withdrawal.<br/>
        /// Requirements for transaction validation:<br/>
        ///   (1) The transaction process should STOP on the first handler that reports a data error.<br/>
        ///   (2) A transaction 'account number' must be found in the data store<br/>
        ///   (3) A transaction 'type' must be either a 'D' character for deposit, or a 'W' character for withdrawal.<br/>
        ///   (4) A transaction 'amount' must be a positive value.<br/>
        ///   (5) After all validations are successfully completed, the transaction should be applied to the account.<br/>
        /// </summary>
        public static IChainManager<AccountTransactionData> ConstructAccountTransactionChain()
        {
            IChainManager<AccountTransactionData> resultChain;

            // For simplicity, we use the same in-memory data store as used for login validation.
            // In a real application, we would likely have a different data store instance for account data.
            IDataStore dataStore = new InMemoryDataStore();

            var dataAccess = new DataAccess(dataStore);

            // Requirement (1) is satisfied by using StopOnFirstErrorChainManager which stops on first handler reporting error.
            resultChain = new StopOnFirstErrorChainManager<AccountTransactionData>();

            // Requirement (2) is satisfied by adding TransactionAccountNumberValidationHandler
            resultChain.AppendHandler(new TransactionAccountNumberValidationHandler(dataAccess));

            // Requirement (3) is satisfied by adding TransactionTypeValidationHandler
            resultChain.AppendHandler(new TransactionTypeValidationHandler());

            // Requirement (4) is satisfied by adding TransactionAmountValidationHandler
            resultChain.AppendHandler(new TransactionAmountValidationHandler());

            // Requirement (5) is satisfied by adding AccountTransactionHandler
            resultChain.AppendHandler(new TransactionProcessHandler());

            return resultChain;
        }
    }
}

using AppExampleCofCImpl.DataManagement.Interfaces;

namespace AppExampleCofCImpl.DataManagement.DataStoreAccess
{
    /// <summary>
    /// Sealed class that provides access to data store operations via an underlying 
    /// data provider (implementing IDataStore interface).
    /// </summary>
    public sealed class DataAccess
    {
        // Underlying data provider
        // This could be a local in-memory data store, ADO.NET access class,
        // or a remote database accessed via an API.
        // The IDataStore interface allows for flexibility in the choice of data provider.
        private IDataStore _store;

        /// <summary>        
        /// Constructor for DataAccess class.        
        /// </summary>
        /// <param name="dataStore">The data access (IDataStore) instance to use for data operations.</param>
        public DataAccess(IDataStore dataStore)
        {
            _store = dataStore;
        }

        // ----------------------- Delegated async calls -----------------------

        /// <summary>
        /// Validates the login asynchronous.
        /// </summary>
        /// <param name="loginId">The login identifier.</param>
        /// <returns>true if valid, false if invalid</returns>
        public async Task<bool> ValidateLoginAsync(int loginId)
        {
            bool result = await _store.ValidateLoginAsync(loginId);
            return result;
        }

        /// <summary>
        /// Validates the password asynchronous.
        /// </summary>
        /// <param name="loginId">The login identifier.</param>
        /// <param name="password">The password.</param>
        /// <returns>true if valid, false if invalid</returns>
        public async Task<bool> ValidatePasswordAsync(int loginId, string password)
        {
            bool result = await _store.ValidatePasswordAsync(loginId, password);
            return result;
        }

        /// <summary>
        /// Validates the account asynchronous.        
        /// </summary>
        /// <param name="number">The account number as integer.</param>
        /// <returns>true if valid account, false if invalid</returns>
        public async Task<bool> ValidateAccountAsync(int number)
        {
            bool result = await _store.ValidateAccountAsync(number);
            return result;
        }

        /// <summary>
        /// Validates the user account assoc asynchronous.
        /// </summary>
        /// <param name="ownerId">The owner identifier.</param>
        /// <param name="accountNumber">The account number.</param>
        /// <returns></returns>
        public async Task<bool> ValidateUserAccountAssocAsync(int ownerId, int accountNumber)
        {
            bool result = await _store.ValidateUserAccountAssocAsync(ownerId, accountNumber);
            return result;
        }
    }
}

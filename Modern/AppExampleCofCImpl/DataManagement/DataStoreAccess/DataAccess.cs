using AppExampleCofCImpl.DataManagement.Interfaces;

namespace AppExampleCofCImpl.DataManagement.DataStoreAccess
{
    /// <summary>
    /// Sealed class that implements the Singleton pattern to provide application wide
    /// access to data store operations via an underlying data provider (implementing IDataStore interface).
    /// </summary>
    public sealed class DataAccess
    {
        // Lazy loading of singleton instance
        private static readonly Lazy<DataAccess> _instance = new(() => new DataAccess());

        // Singleton instance property
        public static DataAccess Instance => _instance.Value;

        // Underlying data provider
        private IDataStore _store;

        /// <summary>
        /// Constructor for DataAccess() singleton class.
        /// Initializes local store as default data provider.
        /// Prevents a default instance of the <see cref="DataAccess"/> class from being created.
        /// </summary>
        private DataAccess()
        {
            _store = new LocalDataStore();
            // later: _store = new AwsDataStore();
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
    }
}

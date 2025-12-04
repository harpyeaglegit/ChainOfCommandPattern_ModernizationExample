namespace AppExampleCofCImpl.DataManagement.Interfaces
{
    /// <summary>
    /// Interface describing services provided by a data store.
    /// </summary>
    public interface IDataStore
    {

        /// <summary>
        /// Validates the login asynchronous.
        /// </summary>
        /// <param name="loginId">The login identifier.</param>
        /// <returns>true if valid, false if invalid</returns>
        Task<bool> ValidateLoginAsync(int loginId);

        /// <summary>
        /// Validates the password asynchronous.
        /// </summary>
        /// <param name="loginId">The login identifier.</param>
        /// <param name="password">The password.</param>
        /// <returns>true if valid, false if invalid</returns>
        Task<bool> ValidatePasswordAsync(int loginId, string password);

        /// <summary>
        /// Validates the account asynchronous.        
        /// </summary>
        /// <param name="number">The account number as integer.</param>
        /// <returns>true if valid account, false if invalid</returns>
        Task<bool> ValidateAccountAsync(int accountNumber);
    }
}

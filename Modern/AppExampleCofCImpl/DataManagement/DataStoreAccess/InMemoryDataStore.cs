using AppExampleCofCImpl.DataManagement.Interfaces;

namespace AppExampleCofCImpl.DataManagement.DataStoreAccess
{
    /// <summary>
    /// Simple in-memory data store for data access.
    /// Implements the "IDataStore" interface, in order to implement the 'Respository' design pattern.
    /// </summary>
    public class InMemoryDataStore : IDataStore
    {
        // --- Internal simulated (local) in-memory data store: ---
        // Note: _loginIds[x] corresponds to _passwords[x], and _accountNumbers[x] (parallel lists).

        // List of valid customer numbers
        private readonly List<int> _loginIds;

        // List of passwords for corresponding login id's
        private readonly List<string> _passwords;

        // List of valid account numbers for corresponding login id's
        private readonly List<int> _accountNumbers;


        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryDataStore"/> class.
        /// Creates in memory data store with sample data.
        /// </summary>
        public InMemoryDataStore()
        {
            // Load the login id's
            _loginIds = [1000, 1001, 1002];

            // Load corresponding passwords
            _passwords = ["password0", "password1", "password2"];

            // Load valid account numbers:
            _accountNumbers = [9990, 9991, 9992];
        }

        /// <summary>
        /// Validates the login asynchronous.
        /// </summary>
        /// <param name="loginId">The login identifier.</param>
        /// <returns>true if valid, false if invalid</returns>
        public async Task<bool> ValidateLoginAsync(int loginId)
        {
            await Task.Delay(1); // Simulate data access delay for async operation
            bool result = _loginIds.Contains(loginId);
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
            await Task.Delay(1); // Simulate data access delay for async operation
            bool result = false;
            if (_loginIds.Contains(loginId))
            {
                result = _passwords[_loginIds.IndexOf(loginId)].Equals(password);
            }
            return result;

        }

        /// <summary>
        /// Validates the account asynchronous.        
        /// </summary>
        /// <param name="number">The account number as integer.</param>
        /// <returns>true if valid account, false if invalid</returns>
        public async Task<bool> ValidateAccountAsync(int number)
        {
            await Task.Delay(1); // Simulate data access delay for async operation
            bool result = _accountNumbers.Contains(number);
            return result;
        }

        /// <summary>
        /// Validates the user id is associated with the given account number.
        /// </summary>
        /// <param name="ownerId">The owner identifier.</param>
        /// <param name="accountNumber">The account number.</param>
        /// <returns>true if a valid user is associated with a valid account</returns>
        public async Task<bool> ValidateUserAccountAssocAsync(int ownerId, int accountNumber)
        {
            bool result = false;
            await Task.Delay(1); // Simulate data access delay for async operation

            int idx = _loginIds.IndexOf(ownerId);
            if(idx >= 0 && idx < _accountNumbers.Count)
            {
                // The user is a valid user.
                // Now check if the account number matches the user's account number.
                result = _accountNumbers[idx] == accountNumber;
            }

            return result;
        }
    }
}


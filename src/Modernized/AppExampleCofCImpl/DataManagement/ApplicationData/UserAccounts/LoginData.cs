namespace AppExampleCofCImpl.DataManagement.ApplicationData.UserAccounts
{
    /// <summary>
    /// Class that contains data fields for a login attempt (mainly login id and password)
    /// </summary>
    public class LoginData
    {
        #region LOGIN_DATA_FIELDS        
        // Login identifier integer
        private int loginId;

        // Password string for 'loginId'
        private string password;
        #endregion

        /// <summary>
        /// Gets the login identifier.
        /// </summary>
        /// <value>The login identifier.</value>        
        public int LoginId { get { return loginId; } }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get { return password; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerData"/> class.
        /// </summary>
        /// <param name="loginId">The login identifier.</param>
        /// <param name="password">The password.</param>
        public LoginData(int loginId, string password)
        {
            this.loginId = loginId;
            this.password = password;
        }
    }
}

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

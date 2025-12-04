using AppExampleCofCImpl.DataManagement.Interfaces;
using System;
using System.Collections.Generic;

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

namespace AppExampleCofCImpl.DataManagement.DataStoreAccess
{
    /// <summary>
    /// Simple data store for login information and account data.
    /// 
    /// In 'real-life' this could be a data access layer, tied to real data,
    /// such as an data base server, file data, etc.
    /// </summary>
    public class LocalDataStore : IDataStore
    {

        // --- Internal simulated (local) data store: ---
        // Note: _loginIds[x] corresponds to _passwords[x], and _accountNumbers[x] (parallel lists).

        // List of valid customer numbers
        private readonly List<int> _loginIds;

        // List of passwords for corresponding login id's
        private readonly List<string> _passwords;

        // List of valid account numbers for corresponding login id's
        private readonly List<int> _accountNumbers;


        public LocalDataStore()
        {
            // Load the login id's
            _loginIds = [1000, 1001, 1002, 1004, 1005, 1006, 1007, 1008];

            // Load corresponding passwords
            _passwords = ["password0", "password1", "password2", "password3", "password4", "password5", "password6", "password7", "password8"];

            // Load valid account numbers:
            _accountNumbers = [9990, 9991, 9992, 9993, 9994, 9995, 9996, 9997, 9998];
        }

        public async Task<bool> ValidateLoginAsync(int loginId)
        {
            await Task.Delay(1); // Simulate data access delay for async operation
            bool result = _loginIds.Contains(loginId);
            return result;
        }

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

        public async Task<bool> ValidateAccountAsync(int number)
        {
            await Task.Delay(1); // Simulate data access delay for async operation
            bool result = _accountNumbers.Contains(number);
            return result;
        }
    }
}


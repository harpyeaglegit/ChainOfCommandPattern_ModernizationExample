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

namespace ChainOfCommandExample.Data
{
    /// <summary>
    /// Simple data store for login information and account data.
    /// 
    /// In 'real-life' this could be a data access layer, tied to real data,
    /// such as an data base server, file data, etc.
    /// </summary>
    public class DataStore
    {        
        // List of valid customer numbers
        private static List<int> loginIdList;

        // List of passwords - each corresponds to id in loginIdList
        // (i.e. loginIdList[1] has password of loginPasswordList[1])
        private static List<string> loginPasswordList;
        
        // List of valid account numbers
        private static List<int> accountNumbers;

        /// <summary>
        /// Initializes the <see cref="DataStore"/> class.
        /// </summary>
        static DataStore()
        {

            // Load the login id's
            loginIdList = new List<int>();
            loginIdList.AddRange(new int[] { 1000, 1001, 1002 });

            // Load corresponding passwords
            loginPasswordList = new List<String>();
            loginPasswordList.AddRange( new string[] {"password_zero", "password_one", "password_two"});

            // Load valid account numbers:
            accountNumbers = new List<int>();
            accountNumbers.AddRange(new int[] { 997, 998, 999 });                       
        }

        /// <summary>
        /// Determines whether the supplied number is a valid customer number
        /// in the data store.
        /// </summary>
        /// <param name="number">Integer customer number.</param>
        /// <returns>
        /// 	<c>true</c> if number is a valid customer number, otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLoginIdValid(int loginId)
        {
            return loginIdList.Contains(loginId);
        }

        /// <summary>
        /// Determines whether the supplied password is valid for the given login id.
        /// </summary>
        /// <param name="loginId">The login id.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// 	<c>true</c> if password is valid for given login id,  otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPasswordValid(int loginId, string password)
        {
            bool result = false;
            if (loginIdList.Contains(loginId))
                result = loginPasswordList[loginIdList.IndexOf(loginId)].Equals(password);
            return result;
        }

        /// <summary>
        /// Determines whether the supplied number is a valid account number
        /// in the data store.
        /// </summary>
        /// <param name="number">The account number.</param>
        /// <returns>
        /// 	<c>true</c> account number is valid, otherwise <c>false</c>.
        /// </returns>
        public static bool IsAccountNumberValid(int number)
        {
            return accountNumbers.Contains(number);
        }


    }
}

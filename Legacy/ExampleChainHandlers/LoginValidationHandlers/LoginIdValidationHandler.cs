using ChainOfCommandExample.Data;
using HarpyEagle.Chain;

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

namespace ChainOfCommandExample.LoginValidationHandlers
{
    /// <summary>
    /// Chain handler to to verify that a login identifier is valid in the data store.
    /// </summary>
    public class LoginIdValidationHandler : IChainHandler<LoginData>
    {
        /// <summary>
        /// Make sure the customer number in the contained CustomerData object (passsed as requestData),
        /// contains a valid customer number.
        /// </summary>
        /// <param name="requestData">The handler data (CustomerData object).</param>
        /// <returns>
        /// HandlerResult.CHAIN_DATA_HANDLED if an exception is not thrown.
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the login id is NOT found in the data store.
        /// </exception>
        public HandlerResult ProcessRequest(LoginData requestData)
        {
            if (DataStore.IsLoginIdValid(requestData.LoginId) == false)
                throw new ChainHandlerException("(LoginIdValidationHandler) Invalid login identifier:" + requestData.LoginId);
            
            // else login id is valid

            return HandlerResult.CHAIN_DATA_HANDLED;
        }
    }
}

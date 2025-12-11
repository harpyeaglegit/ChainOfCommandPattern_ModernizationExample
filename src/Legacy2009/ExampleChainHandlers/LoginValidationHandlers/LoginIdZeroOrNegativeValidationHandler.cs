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
    /// Chain handler that checks for a zero or negative customer number.
    /// </summary>
    /// <exception cref="ChainHandler.ChainHandlerException">
    /// Thrown if the login id is a less than or equal to zero.
    /// </exception>
    public class LoginIdZeroOrNegativeValidationHandler : IChainHandler<LoginData>
    {
        #region IChainHandler Members

        /// <summary>
        /// Method to process the supplied requestData.
        /// Checks to see if customer number is either negative or zero, and throws an
        /// exception indicating an invalid number.
        /// </summary>
        /// <param name="requestData">'CustomerData' object.</param>
        /// <returns>
        ///HandlerResult.CHAIN_DATA_HANDLED if an exception is not thrown.
        /// </returns>
        /// <exception cref="ChainHandler.ChainHandlerException">
        /// Thrown if the integer login id is less than or equal to zero.
        /// </exception>
        public HandlerResult ProcessRequest(LoginData requestData)
        {
            if (requestData.LoginId <= 0)
                throw new ChainHandlerException("(LoginIdZeroOrNegativeValidationHandler) Invalid login identifier. Number must not less than or equal to zero.");
            return HandlerResult.CHAIN_DATA_HANDLED; ;
        }

        #endregion
    }
}

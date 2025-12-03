using System;

/***************************************************************************************
 *  Author: Curt C.
 *  Email : harpyeaglecp@aol.com
 *  
 *  This software is released under the Code Project Open License (CPOL)
 *  See official license description at: http://www.codeproject.com/info/cpol10.aspx
 *  
 * This software is provided AS-IS without any warranty of any kind.
 ***************************************************************************************/

namespace ChainOfCommandCore.Core
{
    /// <summary>
    /// Generic exception to be thrown by IChainHandler objects.
    /// Extensions of this class could include additional information 
    /// (identifying specific data, etc), to be used by an application.
    /// </summary>
    public class ChainHandlerException : Exception
    {
        public ChainHandlerException(string msg)
            : base(msg)
        {
        }
    }
}

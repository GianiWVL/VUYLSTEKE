using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.UserSecurity
{
    [Serializable]
    public class UserSecurityMain
    {
        #region Fields
        private string _authTask = Constants.NullString;
        private string _authCustomer = Constants.NullString;
        private string _authEmployee = Constants.NullString;
        #endregion

        #region Constructor
        public UserSecurityMain()
        {
        }
        #endregion 

        #region Properties
        public string AuthTask
        {
            get { return _authTask; }
            set { _authTask = value; }
        }
        public string AuthCustomer
        {
            get { return _authCustomer; }
            set { _authCustomer = value; }
        }
        public string AuthEmployee
        {
            get { return _authEmployee; }
            set { _authEmployee = value; }
        }
        #endregion
    }
}

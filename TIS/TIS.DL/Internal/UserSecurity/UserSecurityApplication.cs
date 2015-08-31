using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.UserSecurity
{
    [Serializable]
    public class UserSecurityApplication
    {
        #region Fields
        private string _authUser = Constants.NullString;
        private string _authSettings = Constants.NullString;
        private string _authDataSet = Constants.NullString;
        #endregion

        #region Constructor
        public UserSecurityApplication()
        {
        }
        #endregion 

        #region Properties
        public string AuthUser
        {
            get { return _authUser; }
            set { _authUser = value; }
        }
        public string AuthSettings
        {
            get { return _authSettings; }
            set { _authSettings = value; }
        }
        #endregion
    }
}

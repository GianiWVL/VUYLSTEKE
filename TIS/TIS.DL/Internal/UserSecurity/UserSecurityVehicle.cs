using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.UserSecurity
{
    [Serializable]
    public class UserSecurityVehicle
    {
        #region Fields
        private string _authVehicle = Constants.NullString;
        #endregion

        #region Constructor
        public UserSecurityVehicle()
        {
        }
        #endregion

        #region Properties
        public string AuthVehicle
        {
            get { return _authVehicle; }
            set { _authVehicle = value; }
        }
        #endregion
    }
}

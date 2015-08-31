using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.UserSecurity
{
    [Serializable]
    public class UserSecurityCosting
    {
        #region Fields
        private string _authFuel = Constants.NullString;
        private string _authCosting = Constants.NullString;
        private string _authFuelDelivery = Constants.NullString;
        private string _authFuelCorrection = Constants.NullString;
        #endregion

        #region Constructor
        public UserSecurityCosting()
        {
        }
        #endregion

        #region Properties
        public string AuthFuel
        {
            get { return _authFuel; }
            set { _authFuel = value; }
        }
        public string AuthFuelDelivery
        {
            get { return _authFuelDelivery; }
            set { _authFuelDelivery = value; }
        }
        public string AuthFuelCorrection
        {
            get { return _authFuelCorrection; }
            set { _authFuelCorrection = value; }
        }
        public string AuthCosting
        {
            get { return _authCosting; }
            set { _authCosting = value; }
        }
        #endregion
    }
}

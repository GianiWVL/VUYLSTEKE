using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.UserSecurity
{
    [Serializable]
    public class UserSecurityPlanning
    {
        #region Fields
        private string _authPlanning = Constants.NullString;
        private string _authAssignmentTrucks = Constants.NullString;
        #endregion

        #region Constructor
        public UserSecurityPlanning()
        {
        }
        #endregion 

        #region Properties
        public string AuthPlanning
        {
            get { return _authPlanning; }
            set { _authPlanning = value; }
        }
        public string AuthAssignmentTrucks
        {
            get { return _authAssignmentTrucks; }
            set { _authAssignmentTrucks = value; }
        }
        #endregion
    }
}

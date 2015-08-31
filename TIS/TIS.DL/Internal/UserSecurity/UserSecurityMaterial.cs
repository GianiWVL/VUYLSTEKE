using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.UserSecurity
{
    [Serializable]
    public class UserSecurityMaterial
    {
        #region Fields
        private string _authVehicle = Constants.NullString;
        private string _authMaterialMaintenance = Constants.NullString;
        private string _authMaterialMemo = Constants.NullString;
        private string _authMaterialCategory = Constants.NullString;
        #endregion

        #region Constructor
        public UserSecurityMaterial()
        {
        }
        #endregion

        #region Properties
        public string AuthMaterial
        {
            get { return _authVehicle; }
            set { _authVehicle = value; }
        }
        public string AuthMaterialMemo
        {
            get { return _authMaterialMemo; }
            set { _authMaterialMemo = value; }
        }
        public string AuthMaterialMaintenance
        {
            get { return _authMaterialMaintenance; }
            set { _authMaterialMaintenance = value; }
        }
        public string AuthMaterialCategory
        {
            get { return _authMaterialCategory; }
            set { _authMaterialCategory = value; }
        }
        #endregion
    }
}

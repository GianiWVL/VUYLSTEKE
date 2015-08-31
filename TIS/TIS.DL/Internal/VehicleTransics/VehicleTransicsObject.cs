using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIS.DL.Internal.VehicleTransics
{
    public class VehicleTransicsObject
    {
        #region Constructor
        public VehicleTransicsObject()
        {

        }
        #endregion

        #region Fields
        private int _transi_TNR_mat;
        private string _transi_NM_mat;
        #endregion

        #region Properties
        public int Transi_TNR_mat
        {
            get { return _transi_TNR_mat; }
            set { _transi_TNR_mat = value; }
        }
        public string Transi_NM_mat
        {
            get { return _transi_NM_mat; }
            set { _transi_NM_mat = value; }
        }
   
        #endregion
    }
}

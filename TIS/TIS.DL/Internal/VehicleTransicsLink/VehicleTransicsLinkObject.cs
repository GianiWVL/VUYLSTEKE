using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.VehicleTransicsLink
{
    public class VehicleTransicsLinkObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public VehicleTransicsLinkObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "VehicleTransicsLink";
        public const string VEHTI_ID = TABLE + "." + "vehtiID";
        public const string TRANSC_VEHICLEID = TABLE + "." + "transc_VehicleID";
        public const string TRANSI_TNR_MAT = TABLE + "." + "transi_TNR_mat";
        #endregion

        #region Fields

        private int _vehtiID = Constants.NullInt;
        private int _transc_VehicleID = Constants.NullInt;
        private int _transi_TNR_mat = Constants.NullInt;

        private int _loadedTransc_VehicleID = Constants.NullInt;
        private int _loadedTransi_TNR_mat = Constants.NullInt;

        private VehicleTransicsLinkObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public int VehtiID
        {
            get { return _vehtiID; }
            set { _vehtiID = value; }
        }
        public int Transc_VehicleID
        {
            get { return _transc_VehicleID; }
            set { _transc_VehicleID = value; }
        }
        public int Transi_TNR_mat
        {
            get { return _transi_TNR_mat; }
            set { _transi_TNR_mat = value; }
        }

        internal VehicleTransicsLinkObjectCollection Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        public Enumerations.ObjectState State
        {
            get { return _state; }
            set { _state = value; }
        }

        #endregion

        #region Methods
        public VehicleTransicsLinkObject Clone()
        {
            return this.Clone<VehicleTransicsLinkObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.VehtiID == ((VehicleTransicsLinkObject)obj).VehtiID)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void OnVehicleTransicsLinkObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.VehicleTransicsLinkObjectChanged(this);
                }
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion

        #region IEditableObject

        void IEditableObject.BeginEdit()
        {
            try
            {
                if (!_inTxn)
                {
                    _loadedTransc_VehicleID = Transc_VehicleID;
                    _loadedTransi_TNR_mat = Transi_TNR_mat;
                    _inTxn = true;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        void IEditableObject.CancelEdit()
        {
            try
            {
                if (_inTxn)
                {
                    Transi_TNR_mat = _loadedTransi_TNR_mat;
                    Transc_VehicleID = _loadedTransc_VehicleID;
                    _inTxn = false;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        void IEditableObject.EndEdit()
        {
            try
            {
                if (_inTxn)
                {
                    _loadedTransc_VehicleID = Transc_VehicleID;
                    _loadedTransi_TNR_mat = Transi_TNR_mat;
                    _inTxn = true;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion
    }
}

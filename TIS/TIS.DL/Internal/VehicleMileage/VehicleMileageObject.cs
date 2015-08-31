using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using PROF_IT.Common.Data;
using PROF_IT.Common;

namespace TIS.DL.Internal.VehicleMileage
{
    public class VehicleMileageObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public VehicleMileageObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "VehicleMileage";
        public const string VEHM_ID = TABLE + "." + "vehmID";
        public const string TRANSI_TNR_MAT = TABLE + "." + "transi_TNR_mat";
        public const string TRANSI_NM_MAT = TABLE + "." + "transi_NM_mat";
        public const string DATE = TABLE + "." + "Date";
        public const string MILEAGE = TABLE + "." + "Mileage";
        #endregion

        #region Fields

        private Guid _vehmID;
        private int _transi_TNR_mat = Constants.NullInt;
        private string _transi_NM_mat = Constants.NullString;
        private DateTime _date = Constants.NullDateTime;
        private int _mileage = Constants.NullInt;

        private int _loadedTransi_TNR_mat = Constants.NullInt;
        private string _loadedTransi_NM_mat = Constants.NullString;
        private DateTime _loadedDate = Constants.NullDateTime;
        private int _loadedMileage = Constants.NullInt;

        private VehicleMileageObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid VehmID
        {
            get { return _vehmID; }
            set { _vehmID = value; }
        }
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
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        internal VehicleMileageObjectCollection Parent
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
        public VehicleMileageObject Clone()
        {
            return this.Clone<VehicleMileageObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.VehmID == ((VehicleMileageObject)obj).VehmID)
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

        private void OnVehicleMileageObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.VehicleMileageObjectChanged(this);
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
                    _loadedTransi_TNR_mat = Transi_TNR_mat;
                    _loadedTransi_NM_mat = Transi_NM_mat;
                    _loadedDate = Date;
                    _loadedMileage = Mileage;
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
                    Transi_NM_mat = _loadedTransi_NM_mat;
                    Date = _loadedDate;
                    Mileage = _loadedMileage;
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
                    _loadedTransi_TNR_mat = Transi_TNR_mat;
                    _loadedTransi_NM_mat = Transi_NM_mat;
                    _loadedDate = Date;
                    _loadedMileage = Mileage;
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

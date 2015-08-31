using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using PROF_IT.Common.Data;
using PROF_IT.Common;

namespace TIS.DL.Internal.VehicleType
{
    public class VehicleTypeObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public VehicleTypeObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "VehicleType";
        public const string VEHTID = "vehtID";
        public const string TRANSC_VEHICLETYPE = TABLE + "." + "transc_VehicleType";
        public const string TYPE = TABLE + "." + "Type";
        #endregion

        #region Fields

        private int _vehtID;
        private int _transc_VehicleType = Constants.NullInt;
        private string _type = Constants.NullString;

        private int _loadedTransc_VehicleType = Constants.NullInt;
        private string _loadedType = Constants.NullString;

        private VehicleTypeObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public int VehtID
        {
            get { return _vehtID; }
            set { _vehtID = value; }
        }
        public int Transc_VehicleType
        {
            get { return _transc_VehicleType; }
            set { _transc_VehicleType = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        internal VehicleTypeObjectCollection Parent
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
        public VehicleTypeObject Clone()
        {
            return this.Clone<VehicleTypeObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.VehtID == ((VehicleTypeObject)obj).VehtID)
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

        private void OnVehicleTypeObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.VehicleTypeObjectChanged(this);
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
                    _loadedTransc_VehicleType = Transc_VehicleType;
                    _loadedType = Type;
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
                     Transc_VehicleType = _loadedTransc_VehicleType;
                     Type = _loadedType;
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
                    _loadedTransc_VehicleType = Transc_VehicleType;
                    _loadedType = Type;
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

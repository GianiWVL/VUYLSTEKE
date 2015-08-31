using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using TIS.DL.Internal.VehicleTransicsLink;

namespace TIS.DL.Internal.Vehicle
{
    public class VehicleObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public VehicleObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Vehicle";
        public const string VEHID = TABLE + "." + "vehID";
        public const string TRANSC_VEHICLE_ID = TABLE + "." + "transc_VehicleID";
        public const string TRANSC_VEHICLE_TYPE = TABLE + "." + "transc_VehicleType";
        public const string NAME = TABLE + "." + "Name";
        public const string LICENSE_NUMBER = TABLE + "." + "LicenseNumber";
        public const string EURONORM = TABLE + "." + "EuroNorm";
        public const string CHASSIS = TABLE + "." + "Chassis";
        public const string BRAND = TABLE + "." + "Brand";
        public const string ICON = TABLE + "." + "Icon";
        public const string VEHICLETYPE = TABLE + "." + "VehicleType";
        public const string CONTACT_TRANSICS = TABLE + "." + "ContactTransics";
        #endregion

        #region Fields

        private Guid _vehID;
        private int _transc_VehicleID = Constants.NullInt;
        private int _transc_VehicleType = Constants.NullInt;
        private string _name = Constants.NullString;
        private string _licenseNumber = Constants.NullString;
        private int _euronorm = Constants.NullInt;
        private string _chassis = Constants.NullString;
        private string _brand = Constants.NullString;
        private string _icon = Constants.NullString;
        private string _vehicleType = Constants.NullString;
        private VehicleTransicsLinkObject _vehicleTransicsLink;
        private Boolean _contactTransics;

        private int _loadedTransc_VehicleID = Constants.NullInt;
        private int _loadedTransc_VehicleType = Constants.NullInt;
        private string _loadedName = Constants.NullString;
        private string _loadedLicenseNumber = Constants.NullString;
        private int _loadedEuronorm = Constants.NullInt;
        private string _loadedChassis = Constants.NullString;
        private string _loadedBrand = Constants.NullString;
        private string _loadedIcon = Constants.NullString;
        private string _loadedVehicleType = Constants.NullString;
        private VehicleTransicsLinkObject _loadedVehicleTransicsLink;
        private Boolean _loadedContactTransics;

        private VehicleObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid VehID
        {
            get { return _vehID; }
            set { _vehID = value; }
        }
        public int Transc_VehicleID
        {
            get { return _transc_VehicleID; }
            set { _transc_VehicleID = value; }
        }
        public int Transc_VehicleType
        {
            get { return _transc_VehicleType; }
            set { _transc_VehicleType = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LicenseNumber
        {
            get { return _licenseNumber; }
            set { _licenseNumber = value; }
        }
        public int Euronorm
        {
            get { return _euronorm; }
            set { _euronorm = value; }
        }
        public string Chassis
        {
            get { return _chassis; }
            set { _chassis = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }
        public string VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }
        public VehicleTransicsLinkObject VehicleTransicsLink
        {
            get { return _vehicleTransicsLink; }
            set { _vehicleTransicsLink = value; }
        }
        public Boolean ContactTransics
        {
            get { return _contactTransics; }
            set { _contactTransics = value; }
        }

        internal VehicleObjectCollection Parent
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
        public VehicleObject Clone()
        {
            return this.Clone<VehicleObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                //To see if cast is possible
                //could not cast because obj == {} --> obj != null
                //TODO: Check validity
                obj = obj as VehicleObject;

                if (obj != null)
                {
                    if (this.VehID == ((VehicleObject)obj).VehID)
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

        private void OnVehicleObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.VehicleObjectChanged(this);
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
                    _loadedTransc_VehicleType = Transc_VehicleType;
                    _loadedName = Name;
                    _loadedLicenseNumber = LicenseNumber;
                    _loadedEuronorm = Euronorm;
                    _loadedChassis = Chassis;
                    _loadedBrand= Brand;
                    _loadedIcon = Icon;
                    _loadedVehicleType = VehicleType;
                    _loadedVehicleTransicsLink = VehicleTransicsLink;
                    _loadedContactTransics = ContactTransics;
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
                    Transc_VehicleID = _loadedTransc_VehicleID;
                    Transc_VehicleType = _loadedTransc_VehicleType ;
                    Name = _loadedName;
                    LicenseNumber = _licenseNumber;
                    Euronorm = _loadedEuronorm;
                    Chassis = _loadedChassis;
                    Brand = _loadedBrand;
                    Icon = _loadedIcon;
                    VehicleType = _loadedVehicleType;
                    VehicleTransicsLink = _loadedVehicleTransicsLink;
                    ContactTransics = _loadedContactTransics;
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
                    _loadedTransc_VehicleType = Transc_VehicleType;
                    _loadedName = Name;
                    _loadedLicenseNumber = LicenseNumber;
                    _loadedEuronorm = Euronorm;
                    _loadedChassis = Chassis;
                    _loadedBrand = Brand;
                    _loadedIcon = Icon;
                    _loadedVehicleType = VehicleType;
                    _loadedVehicleTransicsLink = VehicleTransicsLink;
                    _loadedContactTransics = ContactTransics;
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

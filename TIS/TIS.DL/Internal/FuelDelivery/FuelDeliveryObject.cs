using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using TIS.DL.Internal.Supplier;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.FuelDelivery
{
    public class FuelDeliveryObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public FuelDeliveryObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "FuelDelivery";
        public const string FUELDEL_ID = TABLE + "." + "fueldelID";
        public const string SUP_ID = TABLE + "." + "supID";
        public const string DATE_DELIVERY = TABLE + "." + "DateDelivery";
        public const string DATE_INVOICE = TABLE + "." + "DateInvoice";
        public const string QUANTITY = TABLE + "." + "Quantity";
        public const string UNITY_PRICE = TABLE + "." + "UnityPrice";
        public const string LOCATION = TABLE + "." + "Location";
        public const string REMARK = TABLE + "." + "Remark";
        #endregion

        #region Fields

        private Guid _fuelDeliveryID;
        private SupplierObject _supplier;
        private string _dateDelivery = Constants.NullString;
        private string _dateInvoice = Constants.NullString;
        private decimal _quantity = Constants.NullDecimal;
        private decimal _unityPrice = Constants.NullDecimal;
        private string _remark = Constants.NullString;
        private Framework.Common.Enumeration.Fuel.Location _location;


        private SupplierObject _loadedSupplier;
        private string _loadedDateDelivery = Constants.NullString;
        private string _loadedDateInvoice = Constants.NullString;
        private decimal _loadedQuantity = Constants.NullDecimal;
        private decimal _loadedUnityPrice = Constants.NullDecimal;
        private string _loadedRemark = Constants.NullString;
        private Framework.Common.Enumeration.Fuel.Location _loadedLocation;

        private FuelDeliveryObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid FuelDeliveryID
        {
            get { return _fuelDeliveryID; }
            set { _fuelDeliveryID = value; }
        }
        public SupplierObject Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        public string DateDelivery
        {
            get { return _dateDelivery; }
            set { _dateDelivery = value; }
        }
        public string DateInvoice
        {
            get { return _dateInvoice; }
            set { _dateInvoice = value; }
        }
        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public decimal UnityPrice
        {
            get { return _unityPrice; }
            set { _unityPrice = value; }
        }
        public decimal UnityPriceBEF
        {
            get { return UnityPrice * Convert.ToDecimal(40.3399); }
        }
        public Framework.Common.Enumeration.Fuel.Location Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        public DateTime DateDeliveryDisplay
        {
            get { return PROF_IT.Common.Convert.DateFunctions.DBDateToDate(_dateDelivery); }
        }
        public DateTime DateInvoiceDisplay
        {
            get { return PROF_IT.Common.Convert.DateFunctions.DBDateToDate(_dateInvoice); }
        }

        internal FuelDeliveryObjectCollection Parent
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
        public FuelDeliveryObject Clone()
        {
            return this.Clone<FuelDeliveryObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.FuelDeliveryID == ((FuelDeliveryObject)obj).FuelDeliveryID)
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

        private void OnFuelDeliveryObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.FuelDeliveryObjectChanged(this);
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
                    _loadedDateDelivery = DateDelivery;
                    _loadedDateInvoice = DateInvoice;
                    _loadedQuantity = Quantity;
                    _loadedRemark = Remark;
                    _loadedSupplier = Supplier;
                    _loadedUnityPrice = UnityPrice;
                    _loadedLocation = Location;
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
                    DateDelivery = _loadedDateDelivery;
                    DateInvoice = _loadedDateInvoice;
                    Quantity = _loadedQuantity;
                    Remark = _loadedRemark;
                    Supplier = _loadedSupplier;
                    UnityPrice = _loadedUnityPrice;
                    Location = _loadedLocation;
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
                    _loadedDateDelivery = DateDelivery;
                    _loadedDateInvoice = DateInvoice;
                    _loadedQuantity = Quantity;
                    _loadedRemark = Remark;
                    _loadedSupplier = Supplier;
                    _loadedUnityPrice = UnityPrice;
                    _loadedLocation = Location;
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

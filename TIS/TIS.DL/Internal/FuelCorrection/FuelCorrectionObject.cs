using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using System.ComponentModel;
using TIS.DL.Internal.Fuel;

namespace TIS.DL.Internal.FuelCorrection
{
    public class FuelCorrectionObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public FuelCorrectionObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "FuelCorrection";
        public const string FUELCOR_ID = TABLE + "." + "fuelcorID";
        public const string DATE_FROM = TABLE + "." + "DateFrom";
        public const string DATE_TO = TABLE + "." + "DateTo";
        public const string QUANTITY = TABLE + "." + "Quantity";
        public const string MAXQUANTITY = TABLE + "." + "MaxQuantity";
        public const string VEHICLES_NOT_INCLUDED = TABLE + "." + "VehiclesNotIncluded";
        public const string SUPPLIERS_INCLUDED = TABLE + "." + "SuppliersIncluded";
        #endregion

        #region Fields

        private Guid _fuelcorID;
        private string _dateFrom = Constants.NullString;
        private string _dateTo = Constants.NullString;
        private decimal _quantity = Constants.NullDecimal;
        private decimal _maxQuantity = Constants.NullDecimal;
        private string _vehiclesNotIncluded = Constants.NullString;
        private string _suppliersIncluded = Constants.NullString;



        private string _loadedDateFrom = Constants.NullString;
        private string _loadedDateTo = Constants.NullString;
        private decimal _loadedQuantity = Constants.NullDecimal;
        private decimal _loadedMaxQuantity = Constants.NullDecimal;
        private string _loadedVehiclesNotIncluded = Constants.NullString;
        private string _loadedSuppliersIncluded = Constants.NullString;
        

        private FuelCorrectionObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid FuelCorID
        {
            get { return _fuelcorID; }
            set { _fuelcorID = value; }
        }
        public string DateFrom
        {
            get { return _dateFrom; }
            set { _dateFrom = value; }
        }
        public string DateTo
        {
            get { return _dateTo; }
            set { _dateTo = value; }
        }
        public DateTime DateFromDisplay
        {
            get { return PROF_IT.Common.Convert.DateFunctions.DBDateToDate(_dateFrom); }
        }
        public DateTime DateToDisplay
        {
            get { return  PROF_IT.Common.Convert.DateFunctions.DBDateToDate(_dateTo); }
        }
        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public decimal MaxQuantity
        {
            get { return _maxQuantity; }
            set { _maxQuantity = value; }
        }
        public string VehiclesNotIncluded
        {
            get { return _vehiclesNotIncluded; }
            set { _vehiclesNotIncluded = value; }
        }
        public string SuppliersIncluded
        {
            get { return _suppliersIncluded; }
            set { _suppliersIncluded = value; }
        }
       
        internal FuelCorrectionObjectCollection Parent
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
        public FuelCorrectionObject Clone()
        {
            return this.Clone<FuelCorrectionObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.FuelCorID == ((FuelCorrectionObject)obj).FuelCorID)
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

        private void OnFuelCorrectionObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.FuelCorrectionObjectChanged(this);
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
                    _loadedDateFrom = DateFrom;
                    _loadedDateTo = DateTo;
                    _loadedQuantity = Quantity;
                    _loadedMaxQuantity = MaxQuantity;
                    _loadedVehiclesNotIncluded = VehiclesNotIncluded;
                    _loadedSuppliersIncluded = SuppliersIncluded;
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
                    DateFrom = _loadedDateFrom;
                    DateTo = _loadedDateTo;
                    Quantity = _loadedQuantity;
                    MaxQuantity = _loadedMaxQuantity;
                    VehiclesNotIncluded = _loadedVehiclesNotIncluded;
                    SuppliersIncluded = _loadedSuppliersIncluded;
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
                    _loadedDateFrom = DateFrom;
                    _loadedDateTo = DateTo;
                    _loadedQuantity = Quantity;
                    _loadedMaxQuantity = MaxQuantity;
                    _loadedVehiclesNotIncluded = VehiclesNotIncluded;
                    _loadedSuppliersIncluded = SuppliersIncluded;
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

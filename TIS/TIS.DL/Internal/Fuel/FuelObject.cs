using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using System.ComponentModel;

namespace TIS.DL.Internal.Fuel
{
    public class FuelObject: PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public FuelObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Fuel";
        public const string FUEL_ID = TABLE + "." + "fuelID";
        public const string TRANSI_TNR_REG = TABLE + "." + "transi_TNR_reg";
        public const string TRANSI_TNR_PERSON = TABLE + "." + "transi_TNR_person";
        public const string TRANSI_TNR_MAT = TABLE + "." + "transi_TNR_mat";
        public const string TRANSI_TNR_PUMP = TABLE + "." + "transi_TNR_pump";
        public const string TRANSI_TNR_TANK = TABLE + "." + "transi_TNR_tank";
        public const string TRANSI_FUELTYPE = TABLE + "." + "transi_FuelType";
        public const string TRANSC_FUELID = TABLE + "." + "transc_FuelId";
        public const string TRANSC_NAWID = TABLE + "." + "transc_NawID";
        public const string TRANSC_DATE = TABLE + "." + "transc_Date";
        public const string TRANSC_PRIVEBEDRIJF = TABLE + "." + "transc_PriveBedrijf";
        public const string TRANSC_PRODUCT = TABLE + "." + "transc_Product";
        public const string DATE = TABLE + "." + "Date";
        public const string EMPLOYEE_NAME = TABLE + "." + "EmployeeName";
        public const string EMPLOYEE= TABLE + "." + "Employee";
        public const string VEHICLE_LICENSEPLATE = TABLE + "." + "VehicleLicensePlate";
        public const string VEHICLE_KILOMETRECOUNTER = TABLE + "." + "VehicleKilometreCounter";
        public const string QUANTITY = TABLE + "." + "Quantity";
        public const string QUANTITY_CORRECTION = TABLE + "." + "QuantityCorrection";
        public const string FULLTANK = TABLE + "." + "Fulltank";
        public const string UNITYPRICE = TABLE + "." + "UnityPrice";
        public const string TOTALPRICE = TABLE + "." + "TotalPrice";
        public const string UNIT = TABLE + "." + "Unit";
        public const string SUPPLIER = TABLE + "." + "Supplier";
        public const string LOCATION = TABLE + "." + "Location";
        public const string FUELTYPE = TABLE + "." + "Fueltype";
        public const string BTW = TABLE + "." + "BTW";
        public const string PRIVATE_TANKING = TABLE + "." + "PrivateTanking";
        public const string COMPANY_TANKING = TABLE + "." + "CompanyTanking";
        public const string INVOICE_RECEIVED = TABLE + "." + "InvoiceReceived";
        public const string INVOICE_OK = TABLE + "." + "InvoiceOK";
        public const string DATEMAIL_FORBIDDENFUELING = TABLE + "." + "DateMailForbiddenFueling";
        #endregion
        
        #region Fields

        private Guid _fuelID;
        private int _transi_TNR_reg = Constants.NullInt;
        private int _transi_TNR_person = Constants.NullInt;
        private int _transi_TNR_mat = Constants.NullInt;
        private int _transi_TNR_pump = Constants.NullInt;
        private int _transi_TNR_tank = Constants.NullInt;
        private int _transi_FuelType = Constants.NullInt;
        private int _transc_FuelId = Constants.NullInt;
        private int _transc_NawID = Constants.NullInt;
        private float _transc_Date = Constants.NullFloat;
        private int _transc_PriveBedrijf = Constants.NullInt;
        private string _transc_Product = Constants.NullString;
        private DateTime _date = Constants.NullDateTime;
        private string _employeeName = Constants.NullString;
        private string _employee = Constants.NullString;
        private string _vehicleLicensePlate = Constants.NullString;
        private int _vehicleKilometreCounter = Constants.NullInt;
        private decimal _quantity = Constants.NullDecimal;
        private decimal _quantityCorrection = Constants.NullDecimal;
        private decimal _fullTank = Constants.NullDecimal;
        private decimal _unityPrice = Constants.NullDecimal;
        private decimal _totalPrice = Constants.NullDecimal;
        private int _unit = Constants.NullInt;
        private string _supplier = Constants.NullString;
        private string _location = Constants.NullString;
        private Framework.Common.Enumeration.Fuel.FuelType _fuelType = Framework.Common.Enumeration.Fuel.FuelType.Diesel;
        private decimal _btw = Constants.NullDecimal;
        private Boolean _privateTanking;
        private Boolean _companyTanking;
        private Boolean _invoiceReceived;
        private Boolean _invoiceOK;
        private DateTime _dateMailForbiddenFueling;


        private int _loadedTransi_TNR_reg = Constants.NullInt;
        private int _loadedTransi_TNR_person = Constants.NullInt;
        private int _loadedTransi_TNR_mat = Constants.NullInt;
        private int _loadedTransi_TNR_pump = Constants.NullInt;
        private int _loadedTransi_TNR_tank = Constants.NullInt;
        private int _loadedTransi_FuelType = Constants.NullInt;
        private int _loadedTransc_FuelId = Constants.NullInt;
        private int _loadedTransc_NawID = Constants.NullInt;
        private float _loadedTransc_Date = Constants.NullFloat;
        private int _loadedTransc_PriveBedrijf = Constants.NullInt;
        private string _loadedTransc_Product = Constants.NullString;
        private DateTime _loadedDate = Constants.NullDateTime;
        private string _loadedEmployeeName = Constants.NullString;
        private string _loadedEmployee = Constants.NullString;
        private string _loadedVehicleLicensePlate = Constants.NullString;
        private int _loadedVehicleKilometreCounter = Constants.NullInt;
        private decimal _loadedQuantity = Constants.NullDecimal;
        private decimal _loadedQuantityCorrection = Constants.NullDecimal;
        private decimal _loadedFullTank = Constants.NullDecimal;
        private decimal _loadedUnityPrice = Constants.NullDecimal;
        private decimal _loadedTotalPrice = Constants.NullDecimal;
        private int _loadedUnit = Constants.NullInt;
        private string _loadedSupplier = Constants.NullString;
        private string _loadedLocation = Constants.NullString;
        private Framework.Common.Enumeration.Fuel.FuelType _loadedFuelType = Framework.Common.Enumeration.Fuel.FuelType.Diesel;
        private decimal _loadedBtw = Constants.NullDecimal;
        private Boolean _loadedPrivateTanking;
        private Boolean _loadedCompanyTanking;
        private Boolean _loadedInvoiceReceived;
        private Boolean _loadedInvoiceOK;
        private DateTime _loadedDateMailForbiddenFueling;

        private FuelObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid FuelID
        {
            get { return _fuelID; }
            set { _fuelID = value; }
        }
        public int Transi_TNR_reg
        {
            get {return _transi_TNR_reg;}
            set { _transi_TNR_reg = value;}
        }
        public int Transi_TNR_person
        {
            get { return _transi_TNR_person; }
            set { _transi_TNR_person = value; }
        }
        public int Transi_TNR_mat
        {
            get { return _transi_TNR_mat; }
            set { _transi_TNR_mat = value; }
        }
        public int Transi_TNR_pump
        {
            get { return _transi_TNR_pump; }
            set { _transi_TNR_pump = value; }
        }
        public int Transi_TNR_tank
        {
            get { return _transi_TNR_tank; }
            set { _transi_TNR_tank = value; }
        }
        public int Transi_FuelType
        {
            get { return _transi_FuelType; }
            set { _transi_FuelType = value; }
        }
        public int Transc_FuelId
        {
            get { return _transc_FuelId; }
            set { _transc_FuelId = value; }
        }
        public int Transc_NawID
        {
            get { return _transc_NawID; }
            set { _transc_NawID = value; }
        }
        public float Transc_Date
        {
            get { return _transc_Date; }
            set { _transc_Date = value; }
        }
        public int Transc_PriveBedrijf
        {
            get { return _transc_PriveBedrijf; }
            set { _transc_PriveBedrijf = value; }
        }
        public string Transc_Product
        {
            get { return _transc_Product; }
            set { _transc_Product = value; }
        }
        public DateTime Date
        {
            get 
            {
                    return _date; 
            }
            set { _date = value; }
        }
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }
        public string Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public string VehicleLicensePlate
        {
            get { return _vehicleLicensePlate; }
            set { _vehicleLicensePlate = value; }
        }
        public int VehicleKilometreCounter
        {
            get { return _vehicleKilometreCounter; }
            set { _vehicleKilometreCounter = value; }
        }
        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public decimal QuantityCorrection
        {
            get 
            {
                if (_quantityCorrection == 0 & _quantity != 0)
                    return _quantity;
                else
                    return _quantityCorrection; 
            }
            set { _quantityCorrection = value; }
        }
        public decimal FullTank
        {
            get { return _fullTank; }
            set { _fullTank = value; }
        }
        public decimal UnityPrice
        {
            get { return _unityPrice; }
            set { _unityPrice = value; }
        }
        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        public int Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        public string Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        public string Location
        {
            get
            {
                if (_location == "")
                {
                    switch (_transi_TNR_pump)
                    {
                        case 1:
                            return "Heestert wit 1";
                        case 2:
                            return "Heestert rood 1";
                        case 3:
                            return "Doornik Wit 1";
                        case 4:
                            return "Doornik Wit 2";
                        case 5:
                            return "Doornik Rood 1";
                        default:
                            return "Ongekend";
                    }
                }
                else
                    return _location;
            }
            set { _location = value;}
        }
        public Framework.Common.Enumeration.Fuel.FuelType FuelType
        {
            get 
            {
                    return _fuelType;
            }
            set { _fuelType = value; }
        }
        public decimal Btw
        {
            get { return _btw; }
            set { _btw = value; }
        }
        public Boolean PrivateTanking
        {
            get
            {
                    return _privateTanking;
            }
            set { _privateTanking = value; }
        }
        public Boolean CompanyTanking
        {
            get 
            {
                    return _companyTanking;
            }
            set { _companyTanking = value; }
        }
        public Boolean InvoiceReceived
        {
            get { return _invoiceReceived; }
            set { _invoiceReceived = value; }
        }
        public Boolean InvoiceOK
        {
            get { return _invoiceOK; }
            set { _invoiceOK = value; }
        }
        public DateTime DateMailForbiddenFueling
        {
            get { return _dateMailForbiddenFueling; }
            set { _dateMailForbiddenFueling = value; }
        }

        internal FuelObjectCollection Parent
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
        public FuelObject Clone()
        {
            return this.Clone<FuelObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.FuelID == ((FuelObject)obj).FuelID)
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

        private void OnFuelObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.FuelObjectChanged(this);
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
                    _loadedTransi_TNR_reg = Transi_TNR_reg;
                    _loadedTransi_TNR_person = Transi_TNR_person;
                    _loadedTransi_TNR_mat = Transi_TNR_mat;
                    _loadedTransi_TNR_pump = Transi_TNR_pump;
                    _loadedTransi_TNR_tank = Transi_TNR_tank;
                    _loadedTransi_FuelType = Transi_FuelType;
                    _loadedTransc_FuelId = Transc_FuelId;
                    _loadedTransc_NawID = Transc_NawID;
                    _loadedTransc_Date = Transc_Date;
                    _loadedTransc_PriveBedrijf = Transc_PriveBedrijf;
                    _loadedTransc_Product = Transc_Product;
                    _loadedDate = Date;
                    _loadedEmployeeName = EmployeeName;
                    _loadedEmployee = Employee;
                    _loadedVehicleLicensePlate = VehicleLicensePlate;
                    _loadedVehicleKilometreCounter = VehicleKilometreCounter;
                    _loadedQuantity = Quantity;
                    _loadedQuantityCorrection = QuantityCorrection;
                    _loadedFullTank = FullTank;
                    _loadedUnityPrice = UnityPrice;
                    _loadedTotalPrice = TotalPrice;
                    _loadedUnit = Unit;
                    _loadedSupplier = Supplier;
                    _loadedLocation = Location;
                    _loadedFuelType = FuelType;
                    _loadedBtw = Btw;
                    _loadedPrivateTanking = PrivateTanking;
                    _loadedCompanyTanking = CompanyTanking;
                    _loadedInvoiceReceived = InvoiceReceived;
                    _loadedInvoiceOK = InvoiceOK;
                    _loadedDateMailForbiddenFueling = DateMailForbiddenFueling;
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
                   Transi_TNR_reg =  _loadedTransi_TNR_reg;
                   Transi_TNR_person =  _loadedTransi_TNR_person;
                   Transi_TNR_mat = _loadedTransi_TNR_mat;
                   Transi_TNR_pump = _loadedTransi_TNR_pump;
                   Transi_TNR_tank = _loadedTransi_TNR_tank ;
                   Transi_FuelType = _loadedTransi_FuelType;
                   Transc_FuelId = _loadedTransc_FuelId;
                   Transc_NawID = _loadedTransc_NawID;
                   Transc_Date = _loadedTransc_Date;
                   Transc_PriveBedrijf = _loadedTransc_PriveBedrijf;
                   Transc_Product = _loadedTransc_Product;
                   Date = _loadedDate ;
                   EmployeeName = _loadedEmployeeName;
                   Employee = _loadedEmployee ;
                   VehicleLicensePlate = _loadedVehicleLicensePlate; 
                   VehicleKilometreCounter = _loadedVehicleKilometreCounter ;
                   Quantity = _loadedQuantity;
                   QuantityCorrection = _loadedQuantityCorrection;
                   FullTank = _loadedFullTank ;
                   UnityPrice = _loadedUnityPrice;
                   TotalPrice = _loadedTotalPrice ;
                   Unit =  _loadedUnit;
                   Supplier = _loadedSupplier ;
                   Location = _loadedLocation ;
                   FullTank = _loadedFullTank ;
                   Btw = _loadedBtw;
                   PrivateTanking = _loadedPrivateTanking;
                   CompanyTanking = _loadedCompanyTanking;
                   InvoiceReceived = _loadedInvoiceReceived;
                   InvoiceOK = _loadedInvoiceOK;
                   DateMailForbiddenFueling = _loadedDateMailForbiddenFueling;
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
                    _loadedTransi_TNR_reg = Transi_TNR_reg;
                    _loadedTransi_TNR_person = Transi_TNR_person;
                    _loadedTransi_TNR_mat = Transi_TNR_mat;
                    _loadedTransi_TNR_pump = Transi_TNR_pump;
                    _loadedTransi_TNR_tank = Transi_TNR_tank;
                    _loadedTransi_FuelType = Transi_FuelType;
                    _loadedTransc_FuelId = Transc_FuelId;
                    _loadedTransc_NawID = Transc_NawID;
                    _loadedTransc_Date = Transc_Date;
                    _loadedTransc_PriveBedrijf = Transc_PriveBedrijf;
                    _loadedTransc_Product = Transc_Product;
                    _loadedDate = Date;
                    _loadedEmployeeName = EmployeeName;
                    _loadedEmployee = Employee;
                    _loadedVehicleLicensePlate = VehicleLicensePlate;
                    _loadedVehicleKilometreCounter = VehicleKilometreCounter;
                    _loadedQuantity = Quantity;
                    _loadedQuantityCorrection = QuantityCorrection;
                    _loadedFullTank = FullTank;
                    _loadedUnityPrice = UnityPrice;
                    _loadedTotalPrice = TotalPrice;
                    _loadedUnit = Unit;
                    _loadedSupplier = Supplier;
                    _loadedLocation = Location;
                    _loadedFuelType = FuelType;
                    _loadedBtw = Btw;
                    _loadedPrivateTanking = PrivateTanking;
                    _loadedCompanyTanking = CompanyTanking;
                    _loadedInvoiceReceived = InvoiceReceived;
                    _loadedInvoiceOK = InvoiceOK;
                    _loadedDateMailForbiddenFueling = DateMailForbiddenFueling;
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

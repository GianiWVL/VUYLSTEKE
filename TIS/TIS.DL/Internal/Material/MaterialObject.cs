using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Vehicle;
using PROF_IT.Common;
using System.Reflection;
using System.ComponentModel;
using TIS.DL.Internal.Supplier;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;
using System.Xml.Serialization;

namespace TIS.DL.Internal.Material
{
    public class MaterialObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MaterialObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Material";
        public const string MAT_ID = TABLE + "." + "matID";
        public const string MATCAT_ID = TABLE + "." + "matcatID";
        public const string MATTYP_ID = TABLE + "." + "mattypID";
        public const string MATSTYP_ID = TABLE + "." + "matstypID";
        public const string EMP_ID_CREATOR = TABLE + "." + "empIDCreator";
        public const string EMP_ID_RESPONSABLE = TABLE + "." + "empIDResponsable";
        public const string VEH_ID = TABLE + "." + "vehID";
        public const string SUP_ID = TABLE + "." + "supID";
        public const string NAME = TABLE + "." + "Name";
        public const string DESCRIPTION = TABLE + "." + "Description";
        public const string TYPE = TABLE + "." + "Type";
        public const string SERIE_NUMBER = TABLE + "." + "SerieNumber";
        public const string INTERNAL_NUMBER = TABLE + "." + "InternalNumber";
        public const string PURCHASEDON = TABLE + "." + "PurchasedOn";
        public const string PRICE = TABLE + "." + "Price";
        public const string NEXT_MAINTENANCE = TABLE + "." + "NextMaintenance";
        public const string MAINTENANCE_FREQUENCY = TABLE + "." + "MaintenanceFrequency";
        public const string ACTIVE = TABLE + "." + "Active";
        public const string BROKEN = TABLE + "." + "Broken";
        #endregion

        #region Fields

        private Guid _matID;
        private MaterialCategoryObject _materialCategory;
        private MaterialTypeObject _materialType;
        private MaterialSubTypeObject _materialSubType;
        private EmployeeObject _employeeCreator;
        private EmployeeObject _employeeResponsable;
        private VehicleObject _vehicle;
        private SupplierObject _supplier;
        private string _name = Constants.NullString;
        private string _description = Constants.NullString;
        private TIS.Framework.Common.Enumeration.Material.Type _type;
        private string _serieNumber = Constants.NullString;
        private string _internalNumber = Constants.NullString;
        private DateTime _purchasedOn = Constants.NullDateTime;
        private decimal _price = Constants.NullDecimal;
        private DateTime _nextMaintenance = Constants.NullDateTime;
        private int _maintenanceFrequency = Constants.NullInt;
        private Boolean _broken;
        private Boolean _active;
        //Child members
        [XmlIgnore]private Memo.MemoObjectCollection _memos;
        [XmlIgnore]private Maintenance.MaintenanceObjectCollection _maintenances;

        private MaterialCategoryObject _loadedMaterialCategory;
        private MaterialTypeObject _loadedMaterialType;
        private MaterialSubTypeObject _loadedMaterialSubType;
        private EmployeeObject _loadedEmployeeCreator;
        private EmployeeObject _loadedEmployeeResponsable;
        private VehicleObject _loadedVehicle;
        private SupplierObject _loadedSupplier;
        private string _loadedName = Constants.NullString;
        private string _loadedDescription = Constants.NullString;
        private TIS.Framework.Common.Enumeration.Material.Type _loadedType;
        private string _loadedSerieNumber = Constants.NullString;
        private string _loadedInternalNumber = Constants.NullString;
        private DateTime _loadedPurchasedOn = Constants.NullDateTime;
        private decimal _loadedPrice = Constants.NullDecimal;
        private DateTime _loadedNextMaintenance = Constants.NullDateTime;
        private int _loadedMaintenanceFrequency = Constants.NullInt;
        private Boolean _loadedActive;
        private Boolean _loadedBroken;
        private Boolean _childsAdded = false;
        //Child members
        [XmlIgnore]private Memo.MemoObjectCollection _loadedMemos;
        [XmlIgnore]private Maintenance.MaintenanceObjectCollection _loadedMaintenances;

        private MaterialObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MatID
        {
            get { return _matID; }
            set { _matID = value; }
        }
        public MaterialCategoryObject MaterialCategory
        {
            get { return _materialCategory; }
            set { _materialCategory = value; }
        }
        public MaterialTypeObject MaterialType
        {
            get { return _materialType; }
            set { _materialType = value; }
        }
        public MaterialSubTypeObject MaterialSubType
        {
            get { return _materialSubType; }
            set { _materialSubType = value; }
        }
        public EmployeeObject EmployeeCreator
        {
            get { return _employeeCreator; }
            set { _employeeCreator = value; }
        }
        public EmployeeObject EmployeeResponsable
        {
            get { return _employeeResponsable; }
            set { _employeeResponsable = value; }
        }
        public VehicleObject Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }
        public SupplierObject Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public TIS.Framework.Common.Enumeration.Material.Type Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string SerieNumber
        {
            get { return _serieNumber; }
            set { _serieNumber = value; }
        }
        public string InternalNumber
        {
            get { return _internalNumber; }
            set { _internalNumber = value; }
        }
        public DateTime PurchasedOn
        {
            get { return _purchasedOn; }
            set { _purchasedOn = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public DateTime NextMaintenance
        {
            get 
            {
                if (ChildsAdded)
                {
                    if (Maintenances.GetActive().Count > 0)
                        return Maintenances.GetNewest().StartMaintenance.AddDays(MaintenanceFrequency);
                    else
                        return DateTime.Now.AddDays(MaintenanceFrequency);
                }
                    return DateTime.Now;
            }
            set { _nextMaintenance = value; }
        }
        public int MaintenanceFrequency
        {
            get { return _maintenanceFrequency; }
            set { _maintenanceFrequency = value; }
        }
        public Boolean Broken
        {
            get { return _broken; }
            set { _broken = value; }
        }
        public Boolean Active
        {
            get { return _active; }
            set { _active = value; }
        }
        public Boolean ChildsAdded
        {
            get { return _childsAdded; }
            set { _childsAdded = value; }
        }
        //Child members
        [XmlIgnore]public Memo.MemoObjectCollection Memos
        {
            get { return _memos; }
            set { _memos = value; }
        }
        [XmlIgnore]public Maintenance.MaintenanceObjectCollection Maintenances
        {
            get { return _maintenances; }
            set { _maintenances = value; }
        }


        internal MaterialObjectCollection Parent
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
        public MaterialObject Clone()
        {
            return this.Clone<MaterialObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MatID == ((MaterialObject)obj).MatID)
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

        private void OnMaterialObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MaterialObjectChanged(this);
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
                    _loadedMaterialCategory = MaterialCategory;
                    _loadedMaterialType = MaterialType;
                    _loadedMaterialSubType = MaterialSubType;
                    _loadedEmployeeCreator = EmployeeCreator;
                    _loadedEmployeeResponsable = EmployeeResponsable;
                    _loadedVehicle = Vehicle;
                    _loadedSupplier = Supplier;
                    _loadedName = Name;
                    _loadedDescription = Description;
                    _loadedType = Type;
                    _loadedSerieNumber = SerieNumber;
                    _loadedInternalNumber = InternalNumber;
                    _loadedPurchasedOn = PurchasedOn;
                    _loadedPrice = Price;
                    _loadedNextMaintenance = NextMaintenance;
                    _loadedMaintenanceFrequency = MaintenanceFrequency;
                    _loadedBroken = Broken;
                    _loadedActive = Active;
                    //Child members
                    _loadedMemos = Memos;
                    _loadedMaintenances = Maintenances;
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
                    MaterialCategory = _loadedMaterialCategory;
                    MaterialType = _loadedMaterialType;
                    MaterialSubType = _loadedMaterialSubType;
                    EmployeeCreator = _loadedEmployeeCreator;
                    EmployeeResponsable = _loadedEmployeeResponsable;
                    Vehicle = _loadedVehicle;
                    Supplier = _loadedSupplier;
                    Name = _loadedName;
                    Description = _loadedDescription;
                    Type = _loadedType;
                    SerieNumber = _loadedSerieNumber;
                    InternalNumber = _loadedInternalNumber;
                    PurchasedOn = _loadedPurchasedOn;
                    Price = _loadedPrice;
                    NextMaintenance = _loadedNextMaintenance;
                    MaintenanceFrequency = _loadedMaintenanceFrequency;
                    Broken = _broken;
                    Active = _active;
                    //Child members
                    Memos = _loadedMemos;
                    Maintenances = _loadedMaintenances;
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
                    _loadedMaterialCategory = MaterialCategory;
                    _loadedMaterialType = MaterialType;
                    _loadedMaterialSubType = MaterialSubType;
                    _loadedEmployeeCreator = EmployeeCreator;
                    _loadedEmployeeResponsable = EmployeeResponsable;
                    _loadedVehicle = Vehicle;
                    _loadedSupplier = Supplier;
                    _loadedName = Name;
                    _loadedDescription = Description;
                    _loadedType = Type;
                    _loadedSerieNumber = SerieNumber;
                    _loadedInternalNumber = InternalNumber;
                    _loadedPurchasedOn = PurchasedOn;
                    _loadedPrice = Price;
                    _loadedNextMaintenance = NextMaintenance;
                    _loadedMaintenanceFrequency = MaintenanceFrequency;
                    _loadedActive = Active;
                    _loadedBroken = Broken;
                    //Child members
                    _loadedMemos = Memos;
                    _loadedMaintenances = Maintenances;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using TIS.DL.Internal.Material;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using System.Xml.Serialization;
using TIS.DL.Internal.Vehicle;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.MaintenanceVehicle;
using TIS.DL.Internal.Revision;
using TIS.DL.Internal.MaterialRevision;

namespace TIS.DL.Internal.Maintenance
{
    public class MaintenanceObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MaintenanceObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Maintenance";
        public const string MAINT_ID = TABLE + "." + "maintID";
        public const string MAINTVEH_ID = TABLE + "." + "maintvehID";
        public const string MAT_ID = TABLE + "." + "matID";
        public const string EMP_ID_EXECUTOR = TABLE + "." + "empIDExecutor";
        public const string START_MAINTENANCE = TABLE + "." + "StartMaintenance";
        public const string REMARK = TABLE + "." + "Remark";
        #endregion

        #region Fields

        private Guid _maintID;
        private MaintenanceVehicleObject _maintenanceVehicle;
        private MaterialObject _material;
        private EmployeeObject _executor;
        private DateTime _startMaintenance = Constants.NullDateTime;
        private string _remark = Constants.NullString;
        private Boolean _childsAdded = false;
        //Child members
        private MaterialRevisionObjectCollection _materialRevisions;

        private MaintenanceVehicleObject _loadedMaintenanceVehicle;
        private MaterialObject _loadedMaterial;
        private EmployeeObject _loadedExecutor;
        private DateTime _loadedStartMaintenance = Constants.NullDateTime;
        private string _loadedRemark = Constants.NullString;
        //Child members
        private MaterialRevisionObjectCollection _loadedMaterialRevisions;


        private MaintenanceObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MaintID
        {
            get { return _maintID; }
            set { _maintID = value; }
        }
        public MaintenanceVehicleObject MaintenanceVehicle
        {
            get { return _maintenanceVehicle; }
            set { _maintenanceVehicle = value; }
        }
        public MaterialObject Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public EmployeeObject Executor
        {
            get { return _executor; }
            set { _executor = value; }
        }
        public DateTime StartMaintenance
        {
            get { return _startMaintenance; }
            set { _startMaintenance = value; }
        }
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        public Boolean ChildsAdded
        {
            get { return _childsAdded; }
            set { _childsAdded = value; }
        }
        //Child members
        public MaterialRevisionObjectCollection MaterialRevisions
        {
            get { return _materialRevisions; }
            set { _materialRevisions = value; }
        }


        internal MaintenanceObjectCollection Parent
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
        public MaintenanceObject Clone()
        {
            return this.Clone<MaintenanceObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MaintID == ((MaintenanceObject)obj).MaintID)
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

        private void OnMaintenanceObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MaintenanceObjectChanged(this);
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
                    _loadedMaintenanceVehicle = MaintenanceVehicle;
                    _loadedMaterial = Material;
                    _loadedExecutor = Executor;
                    _loadedRemark = Remark;
                    _loadedStartMaintenance = StartMaintenance;
                    _loadedMaterialRevisions = MaterialRevisions;
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
                    MaintenanceVehicle = _loadedMaintenanceVehicle;
                    Material = _loadedMaterial;
                    Executor = _loadedExecutor;
                    StartMaintenance = _loadedStartMaintenance;
                    Remark = _loadedRemark;
                    MaterialRevisions = _loadedMaterialRevisions;
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
                    _loadedMaintenanceVehicle = MaintenanceVehicle;
                    _loadedMaterial = Material;
                    _loadedExecutor = Executor;
                    _loadedRemark = Remark;
                    _loadedStartMaintenance = StartMaintenance;
                    _loadedMaterialRevisions = MaterialRevisions;
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

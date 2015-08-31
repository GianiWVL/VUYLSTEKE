using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using TIS.DL.Internal.Vehicle;
using TIS.DL.Internal.Employee;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Xml.Serialization;
using System.Reflection;

namespace TIS.DL.Internal.MaintenanceVehicle
{
    public class MaintenanceVehicleObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public MaintenanceVehicleObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "MaintenanceVehicle";
        public const string MAINTVEH_ID = TABLE + "." + "maintvehID";
        public const string VEH_ID = TABLE + "." + "vehID";
        public const string EMPID_EXECUTOR = TABLE + "." + "EmpIDExecutor";
        public const string START_MAINTENANCE = TABLE + "." + "StartMaintenance";
        public const string REMARK = TABLE + "." + "Remark";
        #endregion

        #region Fields

        private Guid _maintvehID;
        private VehicleObject _vehicle;
        private EmployeeObject _executor;
        private DateTime _startMaintenance = Constants.NullDateTime;
        private string _remark = Constants.NullString;

        private VehicleObject _loadedVehicle;
        private EmployeeObject _loadedExecutor;
        private DateTime _loadedStartMaintenance = Constants.NullDateTime;
        private string _loadedRemark = Constants.NullString;

        private MaintenanceVehicleObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid MaintVehID
        {
            get { return _maintvehID; }
            set { _maintvehID = value; }
        }
        public VehicleObject Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
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

        internal MaintenanceVehicleObjectCollection Parent
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
        public MaintenanceVehicleObject Clone()
        {
            return this.Clone<MaintenanceVehicleObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.MaintVehID == ((MaintenanceVehicleObject)obj).MaintVehID)
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

        private void OnMaintenanceVehicleObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.MaintenanceVehicleObjectChanged(this);
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
                    _loadedVehicle = Vehicle;
                    _loadedExecutor = Executor;
                    _loadedStartMaintenance= StartMaintenance;
                    _loadedRemark= Remark;
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
                    Vehicle = _loadedVehicle;
                    Executor = _loadedExecutor;
                    StartMaintenance = _loadedStartMaintenance;
                    Remark = _loadedRemark;
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
                    _loadedVehicle = Vehicle;
                    _loadedExecutor = Executor;
                    _loadedStartMaintenance = StartMaintenance;
                    _loadedRemark = Remark;
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

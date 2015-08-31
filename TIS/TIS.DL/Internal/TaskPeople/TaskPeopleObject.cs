using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using TIS.DL.Internal.Task;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Supplier;
using TIS.DL.Internal.Customer;
using TIS.DL.Internal.Unknown;
using System.Xml.Serialization;

namespace TIS.DL.Internal.TaskPeople
{

    public class TaskPeopleObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        
        #region Constructor
        public TaskPeopleObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "TaskPeople";
        public const string TPEOP_ID = TABLE + "." + "tpeopID";
        public const string TASK_ID = TABLE + "." + "taskID";
        public const string EMP_ID = TABLE + "." + "empID";
        public const string SUP_ID = TABLE + "." + "supID";
        public const string CUS_ID = TABLE + "." + "cusID";
        public const string UNK_ID = TABLE + "." + "unkID";
        public const string ASSIGNEE = TABLE + "." + "Assignee";
        public const string REPORTER = TABLE + "." + "Reporter";
        #endregion

        #region Fields

        private Guid _tpeopID;
        private  TaskObject _task = null;
        private EmployeeObject _employee = null;
        private SupplierObject _supplier = null;
        private CustomerObject _customer = null;
        private UnknownObject _unknown = null;
        private Boolean _assignee ;
        private Boolean _reporter;


        private TaskObject _loadedTask = null;
        private EmployeeObject _loadedEmployee = null;
        private SupplierObject _loadedSupplier = null;
        private CustomerObject _loadedCustomer = null;
        private UnknownObject _loadedUnknown = null;
        private Boolean _loadedAssignee;
        private Boolean _loadedReporter;

        private TaskPeopleObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid TpeopID
        {
            get { return _tpeopID; }
            set { _tpeopID = value; }
        }
        [XmlIgnore] public TaskObject Task
        {
            get { return _task; }
            set { _task = value; }
        }
        public EmployeeObject Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public SupplierObject Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        public CustomerObject Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
        public UnknownObject Unknown
        {
            get { return _unknown; }
            set { _unknown = value; }
        }
        public Boolean Assignee
        {
            get { return _assignee; }
            set 
            { 
                _assignee = value;
                _reporter = !_assignee;
            }
        }
        public Boolean Reporter
        {
            get { return _reporter; }
            set 
            { 
                _reporter = value;
                _assignee = !_reporter;
            }
        }

        internal TaskPeopleObjectCollection Parent
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
        public TaskPeopleObject Clone()
        {
            return this.Clone<TaskPeopleObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.TpeopID == ((TaskPeopleObject)obj).TpeopID)
                    return true;
                else
                    return false;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void OnTaskPeopleObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.TaskPeopleObjectChanged(this);
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
                if (!inTxn)
                {
                    _loadedTask = this.Task;
                    _loadedEmployee = this.Employee;
                    _loadedSupplier = this.Supplier;
                    _loadedCustomer = this.Customer;
                    _loadedUnknown = this.Unknown;
                    _loadedAssignee = this.Assignee;
                    _loadedReporter = this.Reporter;
                    inTxn = true;
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
                if (inTxn)
                {
                    this.Task = _loadedTask;
                    this.Employee = _loadedEmployee;
                    this.Supplier = _loadedSupplier;
                    this.Customer = _loadedCustomer;
                    this.Unknown = _loadedUnknown;
                    this.Assignee = _loadedAssignee;
                    this.Reporter = _loadedReporter;
                    inTxn = false;
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
                if (inTxn)
                {
                    _loadedTask = this.Task;
                    _loadedEmployee = this.Employee;
                    _loadedSupplier = this.Supplier;
                    _loadedCustomer = this.Customer;
                    _loadedUnknown = this.Unknown;
                    _loadedAssignee = this.Assignee;
                    _loadedReporter = this.Reporter;
                    inTxn = false;
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

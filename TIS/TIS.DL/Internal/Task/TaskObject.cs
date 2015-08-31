using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using TIS.Framework.Common;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace TIS.DL.Internal.Task
{

    public class TaskObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {


        #region Constructor
        public TaskObject()
        {
            AssigneesEmployee = new TaskPeople.TaskPeopleObjectCollection();
            AssigneesSupplier = new TaskPeople.TaskPeopleObjectCollection();
            AssigneesCustomer = new TaskPeople.TaskPeopleObjectCollection();
            AssigneesUnknown = new TaskPeople.TaskPeopleObjectCollection();
            Reporters = new TaskPeople.TaskPeopleObjectCollection();
            Subscriptions = new TaskSchedule.TaskScheduleObjectCollection();
        }
        #endregion

        #region Constants
        public const string TABLE = "Task";
        public const string TASK_ID = TABLE + "." + "taskID";
        public const string TAG = TABLE + "." + "Tag";
        public const string CREATION_DATE = TABLE + "." + "CreationDate";
        public const string UPDATE_DATE = TABLE + "." + "UpdateDate";
        public const string DUE_DATE = TABLE + "." + "DueDate";
        public const string DESCRIPTION = TABLE + "." + "Description";
        public const string STATUS = TABLE + "." + "Status";
        public const string PRIORITY = TABLE + "." + "Priority";
        public const string EFFORT = TABLE + "." + "Effort";
        #endregion

        #region Fields

        private Guid _taskID;
        private string _tag = Constants.NullString;
        private string _creationDate = Constants.NullString;
        private string _updateDate = Constants.NullString;
        private string _dueDate = Constants.NullString;
        private string _description = Constants.NullString;
        private Enumeration.Task.Status _status;
        private Enumeration.Task.Priority _priority;
        private Enumeration.Task.Effort _effort;
        //Child members
        private TaskPeople.TaskPeopleObjectCollection _assigneesEmployee;
        private TaskPeople.TaskPeopleObjectCollection _assigneesSupplier;
        private TaskPeople.TaskPeopleObjectCollection _assigneesCustomer;
        private TaskPeople.TaskPeopleObjectCollection _assigneesUnknown;
        private TaskPeople.TaskPeopleObjectCollection _reporters;
        private TaskSchedule.TaskScheduleObjectCollection _subscriptions;

        private string _loadedTag = Constants.NullString;
        private string _loadedCreationDate = Constants.NullString;
        private string _loadedUpdateDate = Constants.NullString;
        private string _loadedDueDate = Constants.NullString;
        private string _loadedDescription = Constants.NullString;
        private Enumeration.Task.Status _loadedStatus;
        private Enumeration.Task.Priority _loadedPriority;
        private Enumeration.Task.Effort _loadedEffort;
        private Boolean _childsAdded = false;
        //Child members
        private TaskPeople.TaskPeopleObjectCollection _loadedAssigneesEmployee;
        private TaskPeople.TaskPeopleObjectCollection _loadedAssigneesSupplier;
        private TaskPeople.TaskPeopleObjectCollection _loadedAssigneesCustomer;
        private TaskPeople.TaskPeopleObjectCollection _loadedAssigneesUnknown;
        private TaskPeople.TaskPeopleObjectCollection _loadedReporters;
        private TaskSchedule.TaskScheduleObjectCollection _loadedSubscriptions;



        private TaskObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }
        public string Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        public string CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public DateTime CreationDateDisplay
        {
            get 
            {
                if (CreationDate == "")
                    return DateTime.MinValue;
                else
                    return PROF_IT.Common.Convert.DateFunctions.DBDateToDate(CreationDate, false); 
            }
        }
        public string UpdateDate
        {
            get { return _updateDate; }
            set { _updateDate = value; }
        }
        public string DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }
        public DateTime DueDateDisplay
        {
            get 
            {
                if (DueDate != "")
                    return PROF_IT.Common.Convert.DateFunctions.DBDateToDate(DueDate, false);
                else
                    return System.DateTime.MinValue;
            }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string DescriptionDisplay
        {
            get
            {
                System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
                richTextBox.Rtf = Description;
                return richTextBox.Text;
            }
        }
        public Enumeration.Task.Status Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public Enumeration.Task.Priority Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
        public Enumeration.Task.Effort Effort
        {
            get { return _effort; }
            set { _effort = value; }
        }
        public Boolean ChildsAdded
        {
            get { return _childsAdded; }
            set { _childsAdded = value; }
        }
        //Child members
        public TaskPeople.TaskPeopleObjectCollection AssigneesEmployee
        {
            get 
            {
                return _assigneesEmployee; 
            }
            set { _assigneesEmployee = value; }
        }
        public TaskPeople.TaskPeopleObjectCollection AssigneesSupplier
        {
            get
            {

                return _assigneesSupplier; 
            }
            set { _assigneesSupplier = value; }
        }
        public TaskPeople.TaskPeopleObjectCollection AssigneesCustomer
        {
            get
            {
                return _assigneesCustomer;
            }
            set { _assigneesCustomer = value; }
        }
        public TaskPeople.TaskPeopleObjectCollection AssigneesUnknown
        {
            get
            {
                return _assigneesUnknown;
            }
            set { _assigneesUnknown = value; }
        }
        public TaskPeople.TaskPeopleObjectCollection Reporters
        {
            get { return _reporters; }
            set { _reporters = value; }
        }
        public TaskSchedule.TaskScheduleObjectCollection Subscriptions
        {
            get { return _subscriptions; }
            set { _subscriptions = value; }
        }

        internal TaskObjectCollection Parent
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
            set  { _state = value; }
        }

        #endregion

        #region Methods
        public TaskObject Clone()
        {
            return this.Clone<TaskObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.TaskID == ((TaskObject)obj).TaskID)
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
        private void OnTaskObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.TaskObjectChanged(this);
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
                    
                    _loadedTag = this.Tag;
                    _loadedCreationDate = this.CreationDate;
                    _loadedUpdateDate = this.UpdateDate;
                    _loadedDueDate = this.DueDate;
                    _loadedDescription = this.Description;
                    _loadedStatus = this.Status;
                    _loadedPriority = this.Priority;
                    _loadedEffort = this.Effort;
                    //Child members
                    _loadedAssigneesEmployee = this.AssigneesEmployee;
                    _loadedAssigneesSupplier = this.AssigneesSupplier;
                    _loadedAssigneesCustomer = this.AssigneesCustomer;
                    _loadedAssigneesUnknown = this.AssigneesUnknown;
                    _loadedReporters = this.Reporters;
                    _loadedSubscriptions = this.Subscriptions;
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
                    this.Tag = _loadedTag;
                    this.CreationDate = _loadedCreationDate;
                    this.UpdateDate = _loadedUpdateDate;
                    this.DueDate = _loadedDueDate;
                    this.Description = _loadedDescription;
                    this.Status = _loadedStatus;
                    this.Priority = _loadedPriority;
                    this.Effort = _loadedEffort;
                    //Child members
                    this.AssigneesEmployee = _loadedAssigneesEmployee;
                    this.AssigneesSupplier = _loadedAssigneesSupplier;
                    this.AssigneesCustomer = _loadedAssigneesCustomer;
                    this.AssigneesUnknown = _loadedAssigneesUnknown;
                    this.Reporters = _loadedReporters;
                    this.Subscriptions = _loadedSubscriptions;
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
                    _loadedTag = this.Tag;
                    _loadedCreationDate = this.CreationDate;
                    _loadedUpdateDate = this.UpdateDate;
                    _loadedDueDate = this.DueDate;
                    _loadedDescription = this.Description;
                    _loadedStatus = this.Status;
                    _loadedPriority = this.Priority;
                    _loadedEffort = this.Effort;
                    //Child members
                    _loadedAssigneesEmployee = this.AssigneesEmployee;
                    _loadedAssigneesSupplier = this.AssigneesSupplier;
                    _loadedAssigneesCustomer = this.AssigneesCustomer;
                    _loadedAssigneesUnknown = this.AssigneesUnknown;
                    _loadedReporters = this.Reporters;
                    _loadedSubscriptions = this.Subscriptions;
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

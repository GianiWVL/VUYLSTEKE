using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Task;
using TIS.DL.Internal.Schedule;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.TaskSchedule
{

    public class TaskScheduleObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public TaskScheduleObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "TaskSchedule";
        public const string TSCHED_ID = TABLE + "." + "tschedID";
        public const string TASK_ID = TABLE + "." + "taskID";
        public const string SCHED_ID = TABLE + "." + "schedID";
        #endregion

        #region Fields

        private Guid _tschedID;
        private TaskObject _task = null;
        private ScheduleObject _schedule = null;


        private TaskObject _loadedTask = null;
        private ScheduleObject _loadedSchedule = null;

        private TaskScheduleObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid TschedID
        {
            get { return _tschedID; }
            set { _tschedID = value; }
        }
        public TaskObject Task
        {
            get { return _task; }
            set { _task = value; }
        }
        public ScheduleObject Schedule
        {
            get { return _schedule; }
            set { _schedule = value; }
        }
        

        internal TaskScheduleObjectCollection Parent
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
        public TaskScheduleObject Clone()
        {
            return this.Clone<TaskScheduleObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.TschedID == ((TaskScheduleObject)obj).TschedID)
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

        private void OnTaskScheduleObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.TaskScheduleObjectChanged(this);
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
                    _loadedSchedule = this.Schedule;
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
                    this.Schedule = _loadedSchedule;
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
                    _loadedSchedule = this.Schedule;
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

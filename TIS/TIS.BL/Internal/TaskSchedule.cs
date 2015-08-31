using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.TaskSchedule;
using System.Reflection;
using TIS.DATA.Internal;
using TIS.DL.Internal.Task;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class TaskSchedule : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public TaskSchedule()
            : base()
        {
            
        }
        public TaskSchedule(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public TaskScheduleObjectCollection GetSchedulesByTaskID(TaskObject task)
        {
            TaskScheduleObjectCollection taskSchedules;
            try
            {
                taskSchedules = new TaskScheduleDataService().GetByTaskID(task.TaskID);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskSchedules;
        }

        public void Save(TaskScheduleObject taskSchedule)
        {
            try
            {
                CheckTransaction();
                new Schedule(Transaction).Save(taskSchedule.Schedule);
                new TaskScheduleDataService(Transaction).Save(taskSchedule);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        public void Save(TaskScheduleObjectCollection taskSchedules)
        {
            try
            {
                foreach (TaskScheduleObject taskSchedule in taskSchedules)
                {
                    if (taskSchedule.State == PROF_IT.Common.Enumerations.ObjectState.Created |
                            taskSchedule.State == PROF_IT.Common.Enumerations.ObjectState.Modified)
                    {
                        Save(taskSchedule);
                    }
                    if (taskSchedule.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                    {
                        Remove(taskSchedule);
                    }                    
                }  
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(TaskScheduleObject taskSchedule)
        {
            try
            {
                CheckTransaction();
                new TaskScheduleDataService(Transaction).Remove(taskSchedule);
                new Schedule(Transaction).Remove(taskSchedule.Schedule);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        public void RemoveAll(TaskScheduleObjectCollection taskSchedules)
        {
            try
            {
                foreach (TaskScheduleObject taskSchedule in taskSchedules)
                {
                    this.Remove(taskSchedule);
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

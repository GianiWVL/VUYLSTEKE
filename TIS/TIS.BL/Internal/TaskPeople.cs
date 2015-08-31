using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.TaskPeople;
using System.Reflection;
using TIS.DATA.Internal;
using TIS.DL.Internal.Task;
using System.Data.SqlClient;
using TIS.DL.Internal.Employee;

namespace TIS.BL.Internal
{
    public class TaskPeople : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public TaskPeople()
            : base()
        {
            
        }
        public TaskPeople(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public TaskPeopleObjectCollection GetAll()
        {
            TaskPeopleObjectCollection taskPeoples;
            try
            {
                taskPeoples = new TaskPeopleDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetAssigneesCustomerByTaskID(TaskObject task)
        {
            TaskPeopleObjectCollection taskPeoples;
            try
            {
                taskPeoples = new TaskPeopleDataService().GetAssigneesCustomerByTaskID(task.TaskID);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetAssigneesEmployeeByTaskID(TaskObject task)
        {
            TaskPeopleObjectCollection taskPeoples;
            try
            {
                taskPeoples = new TaskPeopleDataService().GetAssigneesEmployeeByTaskID(task.TaskID);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetByEmployee(EmployeeObject employee)
        {
            TaskPeopleObjectCollection taskPeoples;
            try
            {
                taskPeoples = new TaskPeopleDataService().GetByEmployee(employee);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetAssigneesSupplierByTaskID(TaskObject task)
        {
            TaskPeopleObjectCollection taskPeoples;
            try
            {
                taskPeoples = new TaskPeopleDataService().GetAssigneesSupplierByTaskID(task.TaskID);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetAssigneesUnknownByTaskID(TaskObject task)
        {
            TaskPeopleObjectCollection taskPeoples;
            try
            {
                taskPeoples = new TaskPeopleDataService().GetAssigneesUnknownByTaskID(task.TaskID);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetReporterByTaskID(TaskObject task)
        {
            TaskPeopleObjectCollection taskPeoples;
            try
            {
                taskPeoples = new TaskPeopleDataService().GetReporterByTaskID(task.TaskID);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return taskPeoples;
        }

        public void Save(TaskPeopleObject taskPeople)
        {
            try
            {
                CheckTransaction();
                new TaskPeopleDataService(Transaction).Save(taskPeople);
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

        public void Save(TaskPeopleObjectCollection taskPeoples)
        {
            try
            {
                foreach (TaskPeopleObject taskPeople in taskPeoples)
                {
                    if (taskPeople.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                        Remove(taskPeople);
                    if (taskPeople.State == PROF_IT.Common.Enumerations.ObjectState.Modified |
                            taskPeople.State == PROF_IT.Common.Enumerations.ObjectState.Created)
                        Save(taskPeople);
                }
                
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(TaskPeopleObject taskPeople)
        {
            try
            {
                CheckTransaction();
                new TaskPeopleDataService(Transaction).Remove(taskPeople);
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

        public void RemoveAll(TaskPeopleObjectCollection taskPeoples)
        {
            try
            {
                foreach (TaskPeopleObject taskPeople in taskPeoples)
                {
                    Remove(taskPeople);
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

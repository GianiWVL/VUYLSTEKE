using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Task;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Supplier;

namespace TIS.BL.Internal
{
    public class Task : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public Task()
            : base()
        {
            
        }
        public Task(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public TaskObjectCollection GetAll()
        {
            TaskObjectCollection tasks;
            try
            {
                tasks = new TaskDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return tasks;
        }

        public TaskObjectCollection GetActive()
        {
            TaskObjectCollection tasks;
            try
            {
                tasks = new TaskDataService().GetActive();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return tasks;
        }

        public TaskObjectCollection GetFilter(string dateFrom, string dateTo, string description)
        {
            TaskObjectCollection tasks;
            try
            {
                tasks = new TaskDataService().GetFilter(dateFrom, dateTo, description);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return tasks;
        }

        public void Save(TaskObject task)
        {
            try
            {
                CheckTransaction();
                new TaskDataService(Transaction).Save(task);
                if (task.AssigneesCustomer != null)
                    new TaskPeople(Transaction).Save(task.AssigneesCustomer);
                if (task.AssigneesEmployee != null)
                    new TaskPeople(Transaction).Save(task.AssigneesEmployee);
                if (task.AssigneesSupplier != null)
                    new TaskPeople(Transaction).Save(task.AssigneesSupplier);
                if (task.AssigneesUnknown != null)
                    new TaskPeople(Transaction).Save(task.AssigneesUnknown);
                if (task.Reporters != null)
                    new TaskPeople(Transaction).Save(task.Reporters);
                if (task.Subscriptions != null)
                    new TaskSchedule(Transaction).Save(task.Subscriptions);
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

        public void Remove(TaskObject task)
        {
            try
            {
                CheckTransaction();
                if (task.AssigneesCustomer != null)
                    new TaskPeople(Transaction).RemoveAll(task.AssigneesCustomer);
                if (task.AssigneesEmployee != null)
                    new TaskPeople(Transaction).RemoveAll(task.AssigneesEmployee);
                if (task.AssigneesSupplier != null)
                    new TaskPeople(Transaction).RemoveAll(task.AssigneesSupplier);
                if (task.AssigneesUnknown != null)
                    new TaskPeople(Transaction).RemoveAll(task.AssigneesUnknown);
                if (task.Reporters != null)
                    new TaskPeople(Transaction).RemoveAll(task.Reporters);
                if (task.Subscriptions != null)
                    new TaskSchedule(Transaction).RemoveAll(task.Subscriptions);
                new TaskDataService(Transaction).Remove(task);
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

        public void AddChilds(TaskObject task)
        {
            try
            {
                TaskPeople bl = new TaskPeople();
                task.AssigneesCustomer = bl.GetAssigneesCustomerByTaskID(task);
                task.AssigneesEmployee = bl.GetAssigneesEmployeeByTaskID(task);
                task.AssigneesSupplier = bl.GetAssigneesSupplierByTaskID(task);
                task.AssigneesUnknown = bl.GetAssigneesUnknownByTaskID(task);
                task.Reporters = bl.GetReporterByTaskID(task);
                task.Subscriptions = new TaskSchedule().GetSchedulesByTaskID(task);
                task.ChildsAdded = true;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void GetDescription(TaskObject task)
        {
            try
            {
                task.Description = new TaskDataService().GetDescription(task.TaskID);
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

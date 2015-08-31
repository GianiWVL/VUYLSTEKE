using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Task;
using System.Data;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Supplier;
using TIS.DL.Internal.Customer;
using System.Reflection;
using System.Collections;
using TIS.DL.Internal.Unknown;

namespace TIS.DL.Internal.TaskPeople
{
    public static class TaskPeopleConvertor
    {
        public static TaskPeopleObject TaskPeopleRowToObject(DataRow taskPeople)
        {
            TaskPeopleObject obj = new TaskPeopleObject();
            try
            {
                if (taskPeople != null)
                {
                    obj.TpeopID = RowFunctions.GetValueFromRowToGuid(taskPeople, TaskPeopleObject.TPEOP_ID, true, DataRowVersion.Current);
                    obj.Employee = EmployeeConvertor.EmployeeRowToObject(taskPeople, EmployeeObject.TABLE);
                    obj.Supplier = SupplierConvertor.SupplierRowToObject(taskPeople);
                    obj.Customer =  CustomerConvertor.CustomerRowToObject(taskPeople);
                    obj.Unknown = UnknownConvertor.UnknownRowToObject(taskPeople);
                    obj.Assignee = RowFunctions.GetValueFromRowToBoolean(taskPeople, TaskPeopleObject.ASSIGNEE, true, DataRowVersion.Current);
                    obj.Reporter = RowFunctions.GetValueFromRowToBoolean(taskPeople, TaskPeopleObject.REPORTER, true, DataRowVersion.Current);
                    obj.Task = TaskConvertor.TaskRowToObject(taskPeople);
                    return obj;
                }
                obj = null;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return obj;
        }

        public static TaskPeopleObjectCollection DataTableToCollection(DataTable taskPeoples)
        {
            TaskPeopleObjectCollection objectsTotal;
            TaskPeopleObjectCollection objects = new TaskPeopleObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = taskPeoples.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(TaskPeopleRowToObject(current));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                objectsTotal = objects;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return objectsTotal;
        }
    }
}

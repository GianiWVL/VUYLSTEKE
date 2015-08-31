using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using TIS.Framework.Common;
using System.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Task
{
    public static class TaskConvertor
    {
        public static TaskObject TaskRowToObject(DataRow task)
        {
            TaskObject obj = new TaskObject();
            try
            {
                if (task != null)
                {
                    obj.TaskID = RowFunctions.GetValueFromRowToGuid(task, TaskObject.TASK_ID, true, DataRowVersion.Current);
                    obj.Tag = RowFunctions.GetValueFromRowToString(task, TaskObject.TAG, true, DataRowVersion.Current);
                    obj.CreationDate = RowFunctions.GetValueFromRowToString(task, TaskObject.CREATION_DATE, true, DataRowVersion.Current);
                    obj.UpdateDate = RowFunctions.GetValueFromRowToString(task, TaskObject.UPDATE_DATE, true, DataRowVersion.Current);
                    obj.DueDate = RowFunctions.GetValueFromRowToString(task, TaskObject.DUE_DATE, true, DataRowVersion.Current);
                    //Do not upload the task description as default for performance issues.
                    obj.Status = (Enumeration.Task.Status)RowFunctions.GetValueFromRowToInteger(task, TaskObject.STATUS, true, DataRowVersion.Current);
                    obj.Priority = (Enumeration.Task.Priority)RowFunctions.GetValueFromRowToInteger(task, TaskObject.PRIORITY, true, DataRowVersion.Current);
                    obj.Effort = (Enumeration.Task.Effort)RowFunctions.GetValueFromRowToInteger(task, TaskObject.EFFORT, true, DataRowVersion.Current);
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

        public static TaskObjectCollection DataTableToCollection(DataTable tasks)
        {
            TaskObjectCollection objectsTotal;
            TaskObjectCollection objects = new TaskObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = tasks.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(TaskRowToObject(current));
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

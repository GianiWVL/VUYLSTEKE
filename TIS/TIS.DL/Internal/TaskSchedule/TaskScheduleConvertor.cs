using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TIS.DL.Internal.Schedule;
using TIS.DL.Internal.Task;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.TaskSchedule
{
    public static class TaskScheduleConvertor
    {
        public static TaskScheduleObject TaskScheduleRowToObject(DataRow taskSchedule)
        {
            TaskScheduleObject obj = new TaskScheduleObject();
            try
            {
                if (taskSchedule != null)
                {
                    obj.TschedID = RowFunctions.GetValueFromRowToGuid(taskSchedule, TaskScheduleObject.TSCHED_ID, true, DataRowVersion.Current);
                    obj.Schedule = ScheduleConvertor.ScheduleRowToObject(taskSchedule);
                    obj.Task = TaskConvertor.TaskRowToObject(taskSchedule);
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

        public static TaskScheduleObjectCollection DataTableToCollection(DataTable taskSchedules)
        {
            TaskScheduleObjectCollection objectsTotal;
            TaskScheduleObjectCollection objects = new TaskScheduleObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = taskSchedules.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(TaskScheduleRowToObject(current));
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

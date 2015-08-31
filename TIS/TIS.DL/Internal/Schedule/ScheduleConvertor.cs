using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Reflection;
using System.Collections;
using TIS.Framework.Common;

namespace TIS.DL.Internal.Schedule
{
    public static class ScheduleConvertor
    {
        public static ScheduleObject ScheduleRowToObject(DataRow schedule)
        {
            ScheduleObject obj = new ScheduleObject();
            try
            {
                if (schedule != null)
                {
                    obj.SchedID = RowFunctions.GetValueFromRowToGuid(schedule, ScheduleObject.SCHED_ID, true, DataRowVersion.Current);
                    obj.Frequency = (Enumeration.Frequency.TimeFrequency)RowFunctions.GetValueFromRowToInteger(schedule, ScheduleObject.FREQUENCY, true, DataRowVersion.Current);
                    obj.Monday = RowFunctions.GetValueFromRowToBoolean(schedule, ScheduleObject.MONDAY, true, DataRowVersion.Current);
                    obj.Tuesday = RowFunctions.GetValueFromRowToBoolean(schedule, ScheduleObject.TUESDAY, true, DataRowVersion.Current);
                    obj.Wednesday = RowFunctions.GetValueFromRowToBoolean(schedule, ScheduleObject.WEDNESDAY, true, DataRowVersion.Current);
                    obj.Thursday = RowFunctions.GetValueFromRowToBoolean(schedule, ScheduleObject.THURSDAY, true, DataRowVersion.Current);
                    obj.Friday = RowFunctions.GetValueFromRowToBoolean(schedule, ScheduleObject.FRIDAY, true, DataRowVersion.Current);
                    obj.Saterday = RowFunctions.GetValueFromRowToBoolean(schedule, ScheduleObject.SATERDAY, true, DataRowVersion.Current);
                    obj.Sunday = RowFunctions.GetValueFromRowToBoolean(schedule, ScheduleObject.SUNDAY, true, DataRowVersion.Current);
                    obj.StartDate = RowFunctions.GetValueFromRowToString(schedule, ScheduleObject.STARTDATE, true, DataRowVersion.Current);
                    obj.Time = RowFunctions.GetValueFromRowToString(schedule, ScheduleObject.TIME, true, DataRowVersion.Current);
                    obj.LastSend = RowFunctions.GetValueFromRowToString(schedule, ScheduleObject.LAST_SEND, true, DataRowVersion.Current);
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

        public static ScheduleObjectCollection DataTableToCollection(DataTable schedules)
        {
            ScheduleObjectCollection objectsTotal;
            ScheduleObjectCollection objects = new ScheduleObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = schedules.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(ScheduleRowToObject(current));
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

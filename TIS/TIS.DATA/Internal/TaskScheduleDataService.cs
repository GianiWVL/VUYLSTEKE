using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.TaskSchedule;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Schedule;
using TIS.DL.Internal.Task;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class TaskScheduleDataService: DataServiceBase
    {
        public TaskScheduleDataService()
            : base()
        { }
        public TaskScheduleDataService(IDbTransaction txn)
            : base(txn)
        { }

        public string BaseQuery(bool selectTop, int top)
        {
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                if (selectTop == true)
                    builder.SelectTop(top);
                else
                    builder.Select();
                builder.AppendColumn(TaskScheduleObject.TSCHED_ID);
                builder.AppendColumn(TaskScheduleObject.TASK_ID);
                builder.AppendColumn(TaskScheduleObject.SCHED_ID);
                builder.AppendColumn(ScheduleObject.FREQUENCY);
                builder.AppendColumn(ScheduleObject.FRIDAY);
                builder.AppendColumn(ScheduleObject.MONDAY);
                builder.AppendColumn(ScheduleObject.SATERDAY);
                builder.AppendColumn(ScheduleObject.SCHED_ID);
                builder.AppendColumn(ScheduleObject.SUNDAY);
                builder.AppendColumn(ScheduleObject.THURSDAY);
                builder.AppendColumn(ScheduleObject.TIME);
                builder.AppendColumn(ScheduleObject.TUESDAY);
                builder.AppendColumn(ScheduleObject.WEDNESDAY);
                builder.AppendColumn(ScheduleObject.LAST_SEND);
                builder.AppendColumn(ScheduleObject.STARTDATE);
                builder.AppendColumn(TaskObject.CREATION_DATE);
                builder.AppendColumn(TaskObject.DESCRIPTION);
                builder.AppendColumn(TaskObject.DUE_DATE);
                builder.AppendColumn(TaskObject.EFFORT);
                builder.AppendColumn(TaskObject.PRIORITY);
                builder.AppendColumn(TaskObject.STATUS);
                builder.AppendColumn(TaskObject.TAG);
                builder.AppendColumn(TaskObject.TASK_ID);
                builder.AppendColumn(TaskObject.UPDATE_DATE);
                builder.AppendFromTable(TaskScheduleObject.TABLE);
                builder.AppendLeftJoin(ScheduleObject.TABLE, TaskScheduleObject.SCHED_ID, ScheduleObject.SCHED_ID);
                builder.AppendLeftJoin(TaskObject.TABLE, TaskScheduleObject.TASK_ID, TaskObject.TASK_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public TaskScheduleObjectCollection GetAll()
        {
            TaskScheduleObjectCollection taskSchedules = new TaskScheduleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                taskSchedules = TaskScheduleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskSchedules;
        }

        public TaskScheduleObjectCollection GetByTaskID(Guid taskID)
        {
            TaskScheduleObjectCollection taskSchedules = new TaskScheduleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(TaskScheduleObject.TASK_ID, taskID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);
                taskSchedules = TaskScheduleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskSchedules;
        }

        public void Save(TaskScheduleObject taskSchedule)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "TaskSchedule_SAVE",
                    CreateParameter("@tschedID", SqlDbType.UniqueIdentifier, taskSchedule.TschedID, ParameterDirection.InputOutput),
                    CreateParameter("@taskID", SqlDbType.UniqueIdentifier, taskSchedule.Task.TaskID),
                    CreateParameter("@schedID", SqlDbType.UniqueIdentifier, taskSchedule.Schedule.SchedID)
                    );
                taskSchedule.TschedID = (Guid)cmd.Parameters["@tschedID"].Value;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }

        public bool Remove(TaskScheduleObject taskSchedule)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "TaskSchedule_DELETE",
                    CreateParameter("@tschedID", SqlDbType.UniqueIdentifier, taskSchedule.TschedID, ParameterDirection.Input)
                    );
                return true;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }
    }
}

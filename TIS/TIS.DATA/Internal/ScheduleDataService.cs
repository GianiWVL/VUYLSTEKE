using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.Schedule;
using System.Reflection;
using System.Data.SqlClient;
using TIS.Framework;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class ScheduleDataService : DataServiceBase
    {
        public ScheduleDataService()
            : base()
        { }
        public ScheduleDataService(IDbTransaction txn)
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
                builder.AppendColumn(ScheduleObject.SCHED_ID);
                builder.AppendColumn(ScheduleObject.FREQUENCY);
                builder.AppendColumn(ScheduleObject.MONDAY);
                builder.AppendColumn(ScheduleObject.TUESDAY);
                builder.AppendColumn(ScheduleObject.WEDNESDAY);
                builder.AppendColumn(ScheduleObject.THURSDAY);
                builder.AppendColumn(ScheduleObject.FRIDAY);
                builder.AppendColumn(ScheduleObject.WEDNESDAY);
                builder.AppendColumn(ScheduleObject.SATERDAY);
                builder.AppendColumn(ScheduleObject.SUNDAY);
                builder.AppendColumn(ScheduleObject.STARTDATE);
                builder.AppendColumn(ScheduleObject.TIME);
                builder.AppendColumn(ScheduleObject.LAST_SEND);
                builder.AppendFromTable(ScheduleObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public ScheduleObjectCollection GetAll()
        {
            ScheduleObjectCollection parameters = new ScheduleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                parameters = ScheduleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return parameters;
        }

        public void Save(ScheduleObject schedule)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Schedule_SAVE",
                    CreateParameter("@schedID", SqlDbType.UniqueIdentifier, schedule.SchedID, ParameterDirection.InputOutput),
                    CreateParameter("@Frequency", SqlDbType.Int, (int)schedule.Frequency),
                    CreateParameter("@Monday", SqlDbType.Bit, schedule.Monday),
                    CreateParameter("@Tuesday", SqlDbType.Bit, schedule.Tuesday),
                    CreateParameter("@Wednesday", SqlDbType.Bit, schedule.Wednesday),
                    CreateParameter("@Thursday", SqlDbType.Bit, schedule.Thursday),
                    CreateParameter("@Friday", SqlDbType.Bit, schedule.Friday),
                    CreateParameter("@Saterday", SqlDbType.Bit, schedule.Saterday),
                    CreateParameter("@Sunday", SqlDbType.Bit, schedule.Sunday),
                    CreateParameter("@Startdate", SqlDbType.VarChar, schedule.StartDate),
                    CreateParameter("@Time", SqlDbType.VarChar, schedule.Time),
                    CreateParameter("@LastSend", SqlDbType.VarChar, schedule.LastSend)
                    );
                schedule.SchedID = (Guid)cmd.Parameters["@schedID"].Value;
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

        public bool Remove(ScheduleObject schedule)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Schedule_DELETE",
                    CreateParameter("@schedID", SqlDbType.UniqueIdentifier, schedule.SchedID, ParameterDirection.Input)
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

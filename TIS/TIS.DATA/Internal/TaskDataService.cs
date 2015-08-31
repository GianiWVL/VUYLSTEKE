using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.Task;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.TaskPeople;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Supplier;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class TaskDataService : DataServiceBase
    {
        public TaskDataService()
            : base()
        { }
        public TaskDataService(IDbTransaction txn)
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
                builder.AppendColumn(TaskObject.TASK_ID);
                builder.AppendColumn(TaskObject.TAG);
                builder.AppendColumn(TaskObject.CREATION_DATE);
                builder.AppendColumn(TaskObject.UPDATE_DATE);
                builder.AppendColumn(TaskObject.DUE_DATE);
                builder.AppendColumn(TaskObject.STATUS);
                builder.AppendColumn(TaskObject.PRIORITY);
                builder.AppendColumn(TaskObject.EFFORT);
                builder.AppendFromTable(TaskObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public TaskObjectCollection GetAll()
        {
            TaskObjectCollection tasks = new TaskObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                builder.AppendOrderBy(TaskObject.CREATION_DATE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                tasks = TaskConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return tasks;
        }

        public TaskObjectCollection GetActive()
        {
            TaskObjectCollection tasks = new TaskObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereInteger(TaskObject.STATUS, (int)TIS.Framework.Common.Enumeration.Task.Status.Open, QueryBuilder.ParameterLocation.FIRST_LAST);
                builder.AppendOrderBy(TaskObject.CREATION_DATE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                tasks = TaskConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return tasks;
        }

        public TaskObjectCollection GetFilter(string dateFrom, string dateTo, string description)
        {
            TaskObjectCollection tasks = new TaskObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                if (dateFrom != null)
                    builder.AppendWhereString(TaskObject.CREATION_DATE, dateFrom, QueryBuilder.ComparisonOperators.GreaterAndEqual, QueryBuilder.ParameterLocation.FIRST);
                if (dateTo != null)
                    builder.AppendWhereString(TaskObject.CREATION_DATE, dateTo,QueryBuilder.ComparisonOperators.SmallerAndEqual, QueryBuilder.ParameterLocation.MIDDLE);
                if (description != "")
                    builder.AppendWhereString(TaskObject.DESCRIPTION, description, QueryBuilder.ComparisonOperators.Like, QueryBuilder.ParameterLocation.LAST);
                builder.AppendOrderBy(TaskObject.CREATION_DATE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                tasks = TaskConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return tasks;
        }

        public string GetDescription(Guid id)
        {
            string description = "";
            QueryBuilder builder;
            DataSet ds;
            try
            {
                builder = new QueryBuilder();
                builder.Select();
                builder.AppendColumn(TaskObject.DESCRIPTION);
                builder.AppendFromTable(TaskObject.TABLE);
                builder.AppendWhereString(TaskObject.TASK_ID, id.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);
                ds = this.ExecuteDataSet(builder.Query, false);
                if (ds.Tables[0].Rows.Count > 0)
                    description = ds.Tables[0].Rows[0][TaskObject.DESCRIPTION].ToString();
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return description;
        }

        public void Save(TaskObject task)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Task_SAVE",
                    CreateParameter("@taskID", SqlDbType.UniqueIdentifier, task.TaskID, ParameterDirection.InputOutput),
                    CreateParameter("@Tag", SqlDbType.VarChar, task.Tag),
                    CreateParameter("@CreationDate", SqlDbType.VarChar, task.CreationDate),
                    CreateParameter("@UpdateDate", SqlDbType.VarChar, task.UpdateDate),
                    CreateParameter("@DueDate", SqlDbType.VarChar, task.DueDate),
                    CreateParameter("@Description", SqlDbType.VarChar, task.Description),
                    CreateParameter("@Status", SqlDbType.Int, task.Status),
                    CreateParameter("@Priority", SqlDbType.Int, task.Priority),
                    CreateParameter("@Effort", SqlDbType.Int, task.Effort)
                    );
                task.TaskID = (Guid)cmd.Parameters["@taskID"].Value;
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

        public bool Remove(TaskObject task)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Task_DELETE",
                    CreateParameter("@taskID", SqlDbType.UniqueIdentifier, task.TaskID, ParameterDirection.Input)
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

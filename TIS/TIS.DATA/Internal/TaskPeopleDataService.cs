using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.TaskPeople;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Supplier;
using TIS.DL.Internal.Customer;
using TIS.DL.Internal.Task;
using TIS.DL.Internal.Unknown;
using PROF_IT.DLM.DATA.SqlServer;
using TIS.DL.Internal.Language;

namespace TIS.DATA.Internal
{
    public class TaskPeopleDataService : DataServiceBase
    {
        public TaskPeopleDataService()
            : base()
        { }
        public TaskPeopleDataService(IDbTransaction txn)
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
                builder.AppendColumn(TaskPeopleObject.TPEOP_ID);
                builder.AppendColumn(TaskPeopleObject.TASK_ID);
                builder.AppendColumn(TaskPeopleObject.EMP_ID);
                builder.AppendColumn(TaskPeopleObject.SUP_ID);
                builder.AppendColumn(TaskPeopleObject.CUS_ID);
                builder.AppendColumn(TaskPeopleObject.ASSIGNEE);
                builder.AppendColumn(TaskPeopleObject.REPORTER);
                builder.AppendColumn(EmployeeObject.EMP_ID);
                builder.AppendColumn(EmployeeObject.EMAIL);
                builder.AppendColumn(EmployeeObject.TRANSC_ID);
                builder.AppendColumn(EmployeeObject.TRANSI_ID);
                builder.AppendColumn(EmployeeObject.NAME);
                builder.AppendColumn(EmployeeObject.SURNAME);
                builder.AppendColumn(EmployeeObject.ARCHIVE);
                builder.AppendColumn(EmployeeObject.LAN_ID);
                builder.AppendColumn(EmployeeObject.TRANSC_LANGUAGE);
                builder.AppendColumn(EmployeeObject.REPEAT_MAIL);
                builder.AppendColumn(LanguageObject.LAN_ID, "EmployeeLanguage");
                builder.AppendColumn(LanguageObject.LANGUAGE, "EmployeeLanguage");
                builder.AppendColumn(LanguageObject.LANGUAGE_DUTCH, "EmployeeLanguage");
                builder.AppendColumn(SupplierObject.SUP_ID);
                builder.AppendColumn(SupplierObject.EMAIL);
                builder.AppendColumn(SupplierObject.TRANSC_ID);
                builder.AppendColumn(UnknownObject.UNK_ID);
                builder.AppendColumn(UnknownObject.EMAIL);
                builder.AppendColumn(CustomerObject.CUS_ID);
                builder.AppendColumn(CustomerObject.TAS_ID);
                builder.AppendColumn(CustomerObject.NAME);
                builder.AppendColumn(CustomerObject.NAME2);
                builder.AppendColumn(CustomerObject.STREET);
                builder.AppendColumn(CustomerObject.HOUSE_NUMBER);
                builder.AppendColumn(CustomerObject.ZIPCODE);
                builder.AppendColumn(CustomerObject.TOWN);
                builder.AppendColumn(CustomerObject.COUNTRY);
                builder.AppendColumn(CustomerObject.VAT);
                builder.AppendColumn(CustomerObject.PHONE);
                builder.AppendColumn(CustomerObject.LANGUAGE);
                builder.AppendColumn(CustomerObject.CURRENCY);
                builder.AppendColumn(TaskObject.CREATION_DATE);
                builder.AppendColumn(TaskObject.DUE_DATE);
                builder.AppendColumn(TaskObject.EFFORT);
                builder.AppendColumn(TaskObject.PRIORITY);
                builder.AppendColumn(TaskObject.STATUS);
                builder.AppendColumn(TaskObject.TAG);
                builder.AppendColumn(TaskObject.TASK_ID);
                builder.AppendColumn(TaskObject.UPDATE_DATE);
                builder.AppendFromTable(TaskPeopleObject.TABLE);
                builder.AppendLeftJoin(EmployeeObject.TABLE, TaskPeopleObject.EMP_ID, EmployeeObject.EMP_ID);
                builder.AppendLeftJoin(SupplierObject.TABLE, TaskPeopleObject.SUP_ID, SupplierObject.SUP_ID);
                builder.AppendLeftJoin(CustomerObject.TABLE, TaskPeopleObject.CUS_ID, CustomerObject.CUS_ID);
                builder.AppendLeftJoin(UnknownObject.TABLE, TaskPeopleObject.UNK_ID, UnknownObject.UNK_ID);
                builder.AppendLeftJoin(TaskObject.TABLE, TaskPeopleObject.TASK_ID, TaskObject.TASK_ID);
                builder.AppendLeftJoin(LanguageObject.TABLE, "EmployeeLanguage",LanguageObject.ConvertColumnToAlias(LanguageObject.LAN_ID, "EmployeeLanguage"),EmployeeObject.LAN_ID );
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public TaskPeopleObjectCollection GetAll()
        {
            TaskPeopleObjectCollection parameters = new TaskPeopleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                parameters = TaskPeopleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return parameters;
        }

        public TaskPeopleObjectCollection GetAssigneesCustomerByTaskID(Guid taskID)
        {
            TaskPeopleObjectCollection taskPeoples = new TaskPeopleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(TaskPeopleObject.TASK_ID, taskID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + TaskPeopleObject.CUS_ID + " is not null ");
                builder.AppendWhereBoolean(TaskPeopleObject.ASSIGNEE, true, QueryBuilder.ParameterLocation.LAST);
                taskPeoples = TaskPeopleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetAssigneesEmployeeByTaskID(Guid taskID)
        {
            TaskPeopleObjectCollection taskPeoples = new TaskPeopleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(TaskPeopleObject.TASK_ID, taskID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + TaskPeopleObject.EMP_ID + " is not null ");
                builder.AppendWhereBoolean(TaskPeopleObject.ASSIGNEE, true, QueryBuilder.ParameterLocation.LAST);
                taskPeoples = TaskPeopleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetByEmployee(EmployeeObject employee)
        {
            TaskPeopleObjectCollection taskPeoples = new TaskPeopleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(TaskPeopleObject.EMP_ID, employee.EmpID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + TaskPeopleObject.EMP_ID + " is not null ");
                builder.Append("AND " + TaskObject.TASK_ID + " is not null ");
                builder.AppendWhereBoolean(TaskPeopleObject.ASSIGNEE, true, QueryBuilder.ParameterLocation.LAST);
                taskPeoples = TaskPeopleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetAssigneesSupplierByTaskID(Guid taskID)
        {
            TaskPeopleObjectCollection taskPeoples = new TaskPeopleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(TaskPeopleObject.TASK_ID, taskID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + TaskPeopleObject.SUP_ID + " is not null ");
                builder.AppendWhereBoolean(TaskPeopleObject.ASSIGNEE, true, QueryBuilder.ParameterLocation.LAST);
                taskPeoples = TaskPeopleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetAssigneesUnknownByTaskID(Guid taskID)
        {
            TaskPeopleObjectCollection taskPeoples = new TaskPeopleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(TaskPeopleObject.TASK_ID, taskID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + TaskPeopleObject.UNK_ID + " is not null ");
                builder.AppendWhereBoolean(TaskPeopleObject.ASSIGNEE, true, QueryBuilder.ParameterLocation.LAST);
                taskPeoples = TaskPeopleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskPeoples;
        }

        public TaskPeopleObjectCollection GetReporterByTaskID(Guid taskID)
        {
            TaskPeopleObjectCollection taskPeoples = new TaskPeopleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(TaskPeopleObject.TASK_ID, taskID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.AppendWhereBoolean(TaskPeopleObject.REPORTER, true, QueryBuilder.ParameterLocation.LAST);
                taskPeoples = TaskPeopleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return taskPeoples;
        }

        public void Save(TaskPeopleObject taskPeople)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "TaskPeople_SAVE",
                    CreateParameter("@tpeopID", SqlDbType.UniqueIdentifier, taskPeople.TpeopID, ParameterDirection.InputOutput),
                    CreateParameter("@taskID", SqlDbType.UniqueIdentifier, taskPeople.Task.TaskID),
                    CreateParameter("@empID", SqlDbType.UniqueIdentifier, taskPeople.Employee == null ? Guid.Empty : taskPeople.Employee.EmpID),
                    CreateParameter("@supID",SqlDbType.UniqueIdentifier, taskPeople.Supplier == null ? Guid.Empty : taskPeople.Supplier.SupID),
                    CreateParameter("@cusID", SqlDbType.UniqueIdentifier, taskPeople.Customer == null ? Guid.Empty : taskPeople.Customer.CusID),
                    CreateParameter("@unkID", SqlDbType.UniqueIdentifier, taskPeople.Unknown == null ? Guid.Empty : taskPeople.Unknown.UnkID),
                    CreateParameter("@Assignee", SqlDbType.Bit, taskPeople.Assignee),
                    CreateParameter("@Reporter", SqlDbType.Bit, taskPeople.Reporter)
                    );
                taskPeople.TpeopID = (Guid)cmd.Parameters["@tpeopID"].Value;
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

        public bool Remove(TaskPeopleObject taskPeople)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "TaskPeople_DELETE",
                    CreateParameter("@tpeopID", SqlDbType.UniqueIdentifier, taskPeople.TpeopID, ParameterDirection.Input)
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

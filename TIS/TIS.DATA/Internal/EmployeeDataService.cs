using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.Employee;
using System.Reflection;
using System.Data.SqlClient;
using PROF_IT.DLM.DATA.SqlServer;
using TIS.DL.Internal.Language;

namespace TIS.DATA.Internal
{
    public class EmployeeDataService : DataServiceBase
    {
        public EmployeeDataService()
            : base()
        { }
        public EmployeeDataService(IDbTransaction txn)
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
                builder.AppendColumn(EmployeeObject.EMP_ID);
                builder.AppendColumn(EmployeeObject.TRANSC_ID);
                builder.AppendColumn(EmployeeObject.TRANSI_ID);
                builder.AppendColumn(EmployeeObject.NAME);
                builder.AppendColumn(EmployeeObject.SURNAME);
                builder.AppendColumn(EmployeeObject.EMAIL);
                builder.AppendColumn(EmployeeObject.ARCHIVE);
                builder.AppendColumn(EmployeeObject.TRANSC_LANGUAGE);
                builder.AppendColumn(EmployeeObject.LAN_ID);
                builder.AppendColumn(EmployeeObject.REPEAT_MAIL);
                builder.AppendColumn(LanguageObject.LAN_ID);
                builder.AppendColumn(LanguageObject.LANGUAGE);
                builder.AppendColumn(LanguageObject.LANGUAGE_DUTCH);
                builder.AppendFromTable(EmployeeObject.TABLE);
                builder.AppendInnerJoin(LanguageObject.TABLE, LanguageObject.LAN_ID, EmployeeObject.LAN_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public EmployeeObjectCollection GetAll()
        {
            EmployeeObjectCollection employees = new EmployeeObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                builder.AppendWhereBoolean(EmployeeObject.ARCHIVE, false, QueryBuilder.ParameterLocation.FIRST_LAST);
                builder.AppendOrderBy(EmployeeObject.NAME, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                employees = EmployeeConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0], "");
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return employees;
        }

        public EmployeeObject GetEmployeeByID(Guid id)
        {
            EmployeeObject employee = new EmployeeObject();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(EmployeeObject.EMP_ID, id.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);

                DataSet result = this.ExecuteDataSet(builder.Query, false);
                if (result.Tables[0].Rows.Count > 0)
                    employee = EmployeeConvertor.EmployeeRowToObject(result.Tables[0].Rows[0], "");
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return employee;
        }

        public EmployeeObject GetEmployeeByEmail(string email)
        {
            EmployeeObject employee = new EmployeeObject();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(EmployeeObject.EMAIL, email, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);

                DataSet result = this.ExecuteDataSet(builder.Query, false);
                if (result.Tables[0].Rows.Count > 0)
                    employee = EmployeeConvertor.EmployeeRowToObject(result.Tables[0].Rows[0], "");
                else
                    return null;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return employee;
        }

        public void Save(EmployeeObject employee)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Employee_SAVE",
                    CreateParameter("@empID", SqlDbType.UniqueIdentifier, employee.EmpID, ParameterDirection.InputOutput),
                    CreateParameter("@TranscID", SqlDbType.Int, employee.TranscID),
                    CreateParameter("@TransiID",SqlDbType.Int, employee.TransiID),
                    CreateParameter("@Name",SqlDbType.NVarChar, employee.Name),
                    CreateParameter("@Surname",SqlDbType.NVarChar, employee.Surname),
                    CreateParameter("@Email",SqlDbType.NVarChar, employee.Email),
                    CreateParameter("@Archive",SqlDbType.Bit, employee.Archive),
                    CreateParameter("@transcLanguage",SqlDbType.Int, employee.TranscLanguage),
                    CreateParameter("@lanID",SqlDbType.UniqueIdentifier, employee.Language.LanID),
                    CreateParameter("@repeatMail", SqlDbType.Bit, employee.RepeatMail)
                    );
                employee.EmpID = (Guid)cmd.Parameters["@empID"].Value;
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

        public bool Remove(EmployeeObject employee)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Employee_DELETE",
                    CreateParameter("@empID", SqlDbType.UniqueIdentifier, employee.EmpID, ParameterDirection.Input)
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

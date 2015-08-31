using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.DLM;
using PROF_IT.DLM.DATA;
using System.Reflection;
using System.Data.SqlClient;
using PROF_IT.Common.Data;
using TIS.DL.Internal.User;
using TIS.DL.Internal.UserSecurity;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Language;

namespace TIS.DATA.Internal
{
    public class UserDataService: PROF_IT.DLM.DATA.SqlServer.DataServiceBase
    {
        public UserDataService()
            : base()
        { }
        public UserDataService(IDbTransaction txn)
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
                builder.AppendColumn(UserObject.USR_ID);
                builder.AppendColumn(UserObject.EMP_ID);
                builder.AppendColumn(UserObject.SURNAME);
                builder.AppendColumn(UserObject.NAME);
                builder.AppendColumn(UserObject.LOGIN);
                builder.AppendColumn(UserObject.PASSWORD);
                builder.AppendColumn(UserObject.ACTIVE);
                builder.AppendColumn(UserObject.HASPOPUPS);
                builder.AppendColumn(UserObject.SECURITY);
                builder.AppendColumn(EmployeeObject.ARCHIVE);
                builder.AppendColumn(EmployeeObject.EMAIL);
                builder.AppendColumn(EmployeeObject.EMP_ID);
                builder.AppendColumn(EmployeeObject.LAN_ID);
                builder.AppendColumn(EmployeeObject.NAME);
                builder.AppendColumn(EmployeeObject.SURNAME);
                builder.AppendColumn(EmployeeObject.TRANSC_ID);
                builder.AppendColumn(EmployeeObject.TRANSC_LANGUAGE);
                builder.AppendColumn(EmployeeObject.TRANSI_ID);
                builder.AppendColumn(EmployeeObject.REPEAT_MAIL);
                builder.AppendColumn(LanguageObject.LAN_ID);
                builder.AppendColumn(LanguageObject.LANGUAGE);
                builder.AppendColumn(LanguageObject.LANGUAGE_DUTCH);
                builder.AppendFromTable(UserObject.TABLE);
                builder.AppendLeftJoin(EmployeeObject.TABLE, EmployeeObject.EMP_ID, UserObject.EMP_ID);
                builder.AppendLeftJoin(LanguageObject.TABLE, EmployeeObject.LAN_ID, LanguageObject.LAN_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public UserObjectCollection GetAll()
        {
            UserObjectCollection users = new UserObjectCollection();
            string str = "";
            try
            {
                str = this.BaseQuery(false, 0) + " ORDER BY " + UserObject.SURNAME + " ";
                users = UserConvertor.DataTableToCollection(this.ExecuteDataSet(str, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return users;
        }

        public UserObject GetUserByLogin(string login)
        {
            UserObject user = new UserObject();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(UserObject.LOGIN, DBFunctions.FixStringValue(login), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);
                user = UserConvertor.UserRowToObject(DBFunctions.FillDataRow(builder.Query
                                 , true, "Generic", 30));
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return user;
        }

        public UserObject GetUserBySurNameAndName(string surName, string name)
        {
            UserObject user = new UserObject();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(UserObject.SURNAME, DBFunctions.FixStringValue(surName), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);
                builder.AppendWhereString(UserObject.NAME, DBFunctions.FixStringValue(name), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.LAST);
                user = UserConvertor.UserRowToObject(DBFunctions.FillDataRow(builder.Query
                                 , true, "Generic", 30));
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return user;
        }

        public Boolean HasDependencies(UserObject user)
        {
            bool flag;
            try
            {
                flag = false;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return flag;
        }

        public void SetUnknownSecurityParameters(UserObject user)
        {
            SqlCommand cmd = null;
            try
            {
                //user.Security = new UserSecurityObject();
                if (user.Security.Application.AuthSettings == null | user.Security.Application.AuthSettings == "")
                    user.Security.Application.AuthSettings = "000";
                if (user.Security.Application.AuthUser == null | user.Security.Application.AuthUser == "")
                    user.Security.Application.AuthUser = "000";
                if (user.Security.Main.AuthTask == null | user.Security.Main.AuthTask == "")
                    user.Security.Main.AuthTask = "000";
                if (user.Security.Main.AuthCustomer == null | user.Security.Main.AuthCustomer == "")
                    user.Security.Main.AuthCustomer = "000";
                if (user.Security.Main.AuthEmployee == null | user.Security.Main.AuthEmployee == "")
                    user.Security.Main.AuthEmployee = "000";
                if (user.Security.Costing.AuthCosting == null | user.Security.Costing.AuthCosting == "")
                    user.Security.Costing.AuthCosting = "000";
                if (user.Security.Costing.AuthFuel == null | user.Security.Costing.AuthFuel == "")
                    user.Security.Costing.AuthFuel = "000";
                if (user.Security.Costing.AuthFuelDelivery == null | user.Security.Costing.AuthFuelDelivery == "")
                    user.Security.Costing.AuthFuelDelivery = "000";
                if (user.Security.Costing.AuthFuelCorrection == null | user.Security.Costing.AuthFuelCorrection == "")
                    user.Security.Costing.AuthFuelCorrection = "000";
                if (user.Security.Vehicle.AuthVehicle == null | user.Security.Vehicle.AuthVehicle == "")
                    user.Security.Vehicle.AuthVehicle = "000";
                //user.Security.Material
                if (user.Security.Material == null)
                    user.Security.Material = new UserSecurityMaterial();
                if (user.Security.Material.AuthMaterial == null | user.Security.Material.AuthMaterial == "")
                    user.Security.Material.AuthMaterial = "000";
                if (user.Security.Material.AuthMaterialMaintenance == null | user.Security.Material.AuthMaterialMaintenance == "")
                    user.Security.Material.AuthMaterialMaintenance = "000";
                if (user.Security.Material.AuthMaterialMemo == null | user.Security.Material.AuthMaterialMemo == "")
                    user.Security.Material.AuthMaterialMemo = "000";
                if (user.Security.Material.AuthMaterialCategory == null | user.Security.Material.AuthMaterialCategory == "")
                    user.Security.Material.AuthMaterialCategory = "000";
                if(user.Security.Planning == null)
                    user.Security.Planning = new UserSecurityPlanning();
                if (user.Security.Planning.AuthPlanning == null | user.Security.Planning.AuthPlanning == "")
                    user.Security.Planning.AuthPlanning = "000";

                this.Save(user);

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

        public void Save(UserObject user)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Users_SAVE",
                    CreateParameter("@usrID", SqlDbType.UniqueIdentifier, user.UsrID, ParameterDirection.InputOutput),
                    CreateParameter("@empID", SqlDbType.UniqueIdentifier,  user.Employee == null ? Guid.Empty : user.Employee.EmpID),
                    CreateParameter("@Surname", SqlDbType.VarChar, user.Surname),
                    CreateParameter("@Name", SqlDbType.VarChar, user.Name),
                    CreateParameter("@Login", SqlDbType.VarChar, user.Login),
                    CreateParameter("@Password", SqlDbType.VarChar, user.Password),
                    CreateParameter("@Active", SqlDbType.Bit, user.Active),
                    CreateParameter("@Security",SqlDbType.VarBinary, PROF_IT.Common.Convert.Byte.ObjectToByteArray(user.Security)),
                    CreateParameter("@HasPopups",SqlDbType.Bit,user.HasPopups)
                    );
                user.UsrID = (Guid)cmd.Parameters["@usrID"].Value;
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

        public bool Remove(UserObject user)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Users_DELETE",
                    CreateParameter("@usrID", SqlDbType.UniqueIdentifier, user.UsrID, ParameterDirection.Input)
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

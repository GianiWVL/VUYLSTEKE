using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.Maintenance;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Material;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Vehicle;
using TIS.DL.Internal.MaintenanceVehicle;

namespace TIS.DATA.Internal
{
    public class MaintenanceDataService : DataServiceBase
    {
        public MaintenanceDataService()
            : base()
        { }
        public MaintenanceDataService(IDbTransaction txn)
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
                builder.AppendColumn(MaintenanceObject.MAINT_ID);
                builder.AppendColumn(MaintenanceObject.MAT_ID);
                builder.AppendColumn(MaintenanceObject.REMARK);
                builder.AppendColumn(MaintenanceObject.START_MAINTENANCE);
                builder.AppendColumn(EmployeeObject.EMP_ID);
                builder.AppendColumn(EmployeeObject.ARCHIVE);
                builder.AppendColumn(EmployeeObject.EMAIL);
                builder.AppendColumn(EmployeeObject.LAN_ID);
                builder.AppendColumn(EmployeeObject.NAME);
                builder.AppendColumn(EmployeeObject.SURNAME);
                builder.AppendColumn(EmployeeObject.TRANSC_ID);
                builder.AppendColumn(EmployeeObject.TRANSC_LANGUAGE);
                builder.AppendColumn(EmployeeObject.TRANSI_ID);
                builder.AppendColumn(EmployeeObject.REPEAT_MAIL);
                builder.AppendFromTable(MaintenanceObject.TABLE);
                builder.AppendInnerJoin(MaterialObject.TABLE, MaterialObject.MAT_ID, MaintenanceObject.MAT_ID);
                builder.AppendLeftJoin(EmployeeObject.TABLE, EmployeeObject.EMP_ID, MaintenanceObject.EMP_ID_EXECUTOR);
                builder.AppendLeftJoin(MaintenanceVehicleObject.TABLE, MaintenanceVehicleObject.MAINTVEH_ID, MaintenanceObject.MAINTVEH_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MaintenanceObjectCollection GetAll()
        {
            MaintenanceObjectCollection maintenances = new MaintenanceObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(MaintenanceObject.START_MAINTENANCE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                maintenances = MaintenanceConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return maintenances;
        }

        public MaintenanceObjectCollection GetMemosByMaintenanceID(MaterialObject material)
        {
            MaintenanceObjectCollection maintenances = new MaintenanceObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(MaintenanceObject.MAT_ID, material.MatID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + MaintenanceObject.MAT_ID + " is not null ");
                maintenances = MaintenanceConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return maintenances;
        }

        public void Save(MaintenanceObject maintenance)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Maintenance_SAVE",
                    CreateParameter("@maintID", SqlDbType.UniqueIdentifier, maintenance.MaintID, ParameterDirection.InputOutput),
                    CreateParameter("@maintvehID", SqlDbType.UniqueIdentifier, maintenance.MaintenanceVehicle == null? Guid.Empty : maintenance.MaintenanceVehicle.MaintVehID),
                    CreateParameter("@matID", SqlDbType.UniqueIdentifier, maintenance.Material.MatID),
                    CreateParameter("@empIDExecutor", SqlDbType.UniqueIdentifier, maintenance.Executor == null ? Guid.Empty : maintenance.Executor.EmpID),
                    CreateParameter("@Remark", SqlDbType.VarChar, maintenance.Remark),
                    CreateParameter("@StartMaintenance", SqlDbType.VarChar, PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(maintenance.StartMaintenance))
                    );
                maintenance.MaintID = (Guid)cmd.Parameters["@maintID"].Value;
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

        public bool Remove(MaintenanceObject maintenance)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Maintenance_DELETE",
                    CreateParameter("@maintID", SqlDbType.UniqueIdentifier, maintenance.MaintID, ParameterDirection.Input)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.MaintenanceVehicle;
using TIS.DL.Internal.Vehicle;
using TIS.DL.Internal.Employee;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class MaintenanceVehicleDataService : DataServiceBase
    {
        public MaintenanceVehicleDataService()
            : base()
        { }
        public MaintenanceVehicleDataService(IDbTransaction txn)
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
                builder.AppendColumn(MaintenanceVehicleObject.MAINTVEH_ID);
                builder.AppendColumn(MaintenanceVehicleObject.EMPID_EXECUTOR);
                builder.AppendColumn(MaintenanceVehicleObject.REMARK);
                builder.AppendColumn(MaintenanceVehicleObject.VEH_ID);
                builder.AppendColumn(MaintenanceVehicleObject.START_MAINTENANCE);
                builder.AppendFromTable(MaintenanceVehicleObject.TABLE);
                builder.AppendInnerJoin(VehicleObject.TABLE, VehicleObject.VEHID, MaintenanceVehicleObject.VEH_ID);
                builder.AppendLeftJoin(EmployeeObject.TABLE, EmployeeObject.EMP_ID, MaintenanceVehicleObject.EMPID_EXECUTOR);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MaintenanceVehicleObjectCollection GetAll()
        {
            MaintenanceVehicleObjectCollection maintenanceVehicles = new MaintenanceVehicleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(MaintenanceVehicleObject.START_MAINTENANCE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                maintenanceVehicles = MaintenanceVehicleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return maintenanceVehicles;
        }

        public MaintenanceVehicleObjectCollection GetByVehicleID(VehicleObject vehicle)
        {
            MaintenanceVehicleObjectCollection maintenanceVehicles = new MaintenanceVehicleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(MaintenanceVehicleObject.VEH_ID, vehicle.VehID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + MaintenanceVehicleObject.VEH_ID + " is not null ");
                maintenanceVehicles = MaintenanceVehicleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return maintenanceVehicles;
        }

        public void Save(MaintenanceVehicleObject maintenanceVehicle)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaintenanceVehicle_SAVE",
                    CreateParameter("@maintvehID", SqlDbType.UniqueIdentifier, maintenanceVehicle.MaintVehID, ParameterDirection.InputOutput),
                    CreateParameter("@vehID", SqlDbType.UniqueIdentifier, maintenanceVehicle.Vehicle == null ? Guid.Empty : maintenanceVehicle.Vehicle.VehID),
                    CreateParameter("@empIDExecutor", SqlDbType.UniqueIdentifier, maintenanceVehicle.Executor == null ? Guid.Empty : maintenanceVehicle.Executor.EmpID),
                    CreateParameter("@StartMaintenance", SqlDbType.VarChar, PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(maintenanceVehicle.StartMaintenance)),
                    CreateParameter("@Remark", SqlDbType.VarChar, maintenanceVehicle.Remark)
                    );
                maintenanceVehicle.MaintVehID = (Guid)cmd.Parameters["@maintvehID"].Value;
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

        public bool Remove(MaintenanceVehicleObject maintenanceVehicle)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaintenanceVehicle_DELETE",
                    CreateParameter("@maintvehID", SqlDbType.UniqueIdentifier, maintenanceVehicle.MaintVehID, ParameterDirection.Input)
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

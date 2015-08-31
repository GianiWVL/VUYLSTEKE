using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.Vehicle;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.VehicleTransicsLink;
using TIS.DL.Internal.VehicleTransics;

namespace TIS.DATA.Internal
{
    public class VehicleDataService : DataServiceBase
    {
        public VehicleDataService()
            : base()
        { }
        public VehicleDataService(IDbTransaction txn)
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
                builder.AppendColumn(VehicleObject.VEHID);
                builder.AppendColumn(VehicleObject.TRANSC_VEHICLE_ID);
                builder.AppendColumn(VehicleObject.TRANSC_VEHICLE_TYPE);
                builder.AppendColumn(VehicleObject.NAME);
                builder.AppendColumn(VehicleObject.LICENSE_NUMBER);
                builder.AppendColumn(VehicleObject.EURONORM);
                builder.AppendColumn(VehicleObject.CHASSIS);
                builder.AppendColumn(VehicleObject.BRAND);
                builder.AppendColumn(VehicleObject.ICON);
                builder.AppendColumn(VehicleObject.VEHICLETYPE);
                builder.AppendColumn(VehicleObject.CONTACT_TRANSICS);
                builder.AppendColumn(VehicleTransicsLinkObject.VEHTI_ID);
                builder.AppendColumn(VehicleTransicsLinkObject.TRANSC_VEHICLEID);
                builder.AppendColumn(VehicleTransicsLinkObject.TRANSI_TNR_MAT);
                builder.AppendFromTable(VehicleObject.TABLE);
                builder.AppendInnerJoin(VehicleTransicsLinkObject.TABLE, VehicleTransicsLinkObject.TRANSC_VEHICLEID, VehicleObject.TRANSC_VEHICLE_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public VehicleObjectCollection GetAll()
        {
            VehicleObjectCollection vehicles = new VehicleObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(VehicleObject.LICENSE_NUMBER, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                vehicles = VehicleConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return vehicles;
        }

        public VehicleTransicsObjectCollection GetVehiclesTransics()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TRANSICS_Vehicles");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = this.ExecuteNonQuery(cmd, false).Tables[0];

                VehicleTransicsObjectCollection vehicles = new VehicleTransicsObjectCollection();
                VehicleTransicsObject vehicle;
                int i = 0;

                
                foreach (DataRow row in dt.Rows)
                {
                    vehicle = new VehicleTransicsObject();
                    vehicle.Transi_TNR_mat = Convert.ToInt32(row[0].ToString().Trim());
                    vehicle.Transi_NM_mat = row[1].ToString().Trim();
                    vehicles.Add(vehicle);
                    i++;
                }
                return vehicles;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return null;
        }

        public void Save(VehicleObject vehicle)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Vehicle_SAVE",
                    CreateParameter("@vehID", SqlDbType.UniqueIdentifier, vehicle.VehID, ParameterDirection.InputOutput),
                    CreateParameter("@transc_VehicleID", SqlDbType.Int, vehicle.Transc_VehicleID),
                    CreateParameter("@transc_VehicleType", SqlDbType.Int, vehicle.Transc_VehicleType),
                    CreateParameter("@Name", SqlDbType.NChar, vehicle.Name),
                    CreateParameter("@LicenseNumber", SqlDbType.NChar, vehicle.LicenseNumber),
                    CreateParameter("@Euronorm", SqlDbType.Int, vehicle.Euronorm),
                    CreateParameter("@Chassis", SqlDbType.NChar, vehicle.Chassis),
                    CreateParameter("@Brand", SqlDbType.NChar, vehicle.Brand),
                    CreateParameter("@Icon", SqlDbType.NChar, vehicle.Icon),
                    CreateParameter("@VehicleType", SqlDbType.VarChar, vehicle.VehicleType),
                    CreateParameter("@ContactTransics", SqlDbType.Bit, vehicle.ContactTransics)
                    );
                vehicle.VehID = (Guid)cmd.Parameters["@vehID"].Value;
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

        public bool Remove(VehicleObject vehicle)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Vehicle_DELETE",
                    CreateParameter("@vehID", SqlDbType.UniqueIdentifier, vehicle.VehID, ParameterDirection.Input)
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

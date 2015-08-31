using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.VehicleMileage;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Vehicle;

namespace TIS.DATA.Internal
{

    public class VehicleMileageDataService : DataServiceBase
    {
        public VehicleMileageDataService()
            : base()
        { }
        public VehicleMileageDataService(IDbTransaction txn)
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
                builder.AppendColumn(VehicleMileageObject.VEHM_ID);
                builder.AppendColumn(VehicleMileageObject.TRANSI_TNR_MAT);
                builder.AppendColumn(VehicleMileageObject.TRANSI_NM_MAT);
                builder.AppendColumn(VehicleMileageObject.DATE);
                builder.AppendColumn(VehicleMileageObject.MILEAGE);
                builder.AppendFromTable(VehicleMileageObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public VehicleMileageObjectCollection GetAll()
        {
            VehicleMileageObjectCollection vehicleMileages = new VehicleMileageObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(VehicleMileageObject.TRANSI_NM_MAT, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST);
                builder.AppendOrderBy(VehicleMileageObject.DATE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.LAST);
                vehicleMileages = VehicleMileageConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return vehicleMileages;
        }

        public VehicleMileageObjectCollection GetByVehicle(VehicleObject vehicle)
        {
            VehicleMileageObjectCollection vehicleMileages = new VehicleMileageObjectCollection();
            QueryBuilder builder;
            try
            {
                if (vehicle.VehicleTransicsLink != null)
                {
                    builder = new QueryBuilder();
                    builder.Append(this.BaseQuery(false, 0));
                    builder.AppendWhereInteger(VehicleMileageObject.TRANSI_TNR_MAT, vehicle.VehicleTransicsLink.Transi_TNR_mat, QueryBuilder.ParameterLocation.FIRST_LAST);
                    builder.AppendOrderBy(VehicleMileageObject.DATE, QueryBuilder.OrderByType.DESC, QueryBuilder.ParameterLocation.FIRST_LAST);
                    vehicleMileages = VehicleMileageConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
                }
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return vehicleMileages;
        }

        public void Save(VehicleMileageObject vehicleMileage)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "VehicleMileage_SAVE",
                    CreateParameter("@vehmID", SqlDbType.UniqueIdentifier, vehicleMileage.VehmID, ParameterDirection.InputOutput),
                    CreateParameter("@transi_TNR_mat", SqlDbType.Int, vehicleMileage.Transi_TNR_mat),
                    CreateParameter("@transi_NM_mat", SqlDbType.NVarChar, vehicleMileage.Transi_NM_mat),
                    CreateParameter("@Date", SqlDbType.NVarChar, vehicleMileage.Date),
                    CreateParameter("@Mileage", SqlDbType.NVarChar, vehicleMileage.Mileage)
                );
                vehicleMileage.VehmID = (Guid)cmd.Parameters["@vehmID"].Value;
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

        public bool Remove(VehicleMileageObject vehicleMileage)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "VehicleMileage_DELETE",
                    CreateParameter("@vehmID", SqlDbType.UniqueIdentifier, vehicleMileage.VehmID, ParameterDirection.Input)
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

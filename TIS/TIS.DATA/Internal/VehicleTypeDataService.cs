using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using PROF_IT.DLM.DATA.SqlServer;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.VehicleType;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class VehicleTypeDataService : DataServiceBase
    {
        public VehicleTypeDataService()
            : base()
        { }
        public VehicleTypeDataService(IDbTransaction txn)
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
                builder.AppendColumn(VehicleTypeObject.VEHTID);
                builder.AppendColumn(VehicleTypeObject.TRANSC_VEHICLETYPE);
                builder.AppendColumn(VehicleTypeObject.TYPE);
                builder.AppendFromTable(VehicleTypeObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public VehicleTypeObjectCollection GetAll()
        {
            VehicleTypeObjectCollection vehicleTypes = new VehicleTypeObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(VehicleTypeObject.TYPE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                vehicleTypes = VehicleTypeConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return vehicleTypes;
        }

        public void Save(VehicleTypeObject vehicleType)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "VehicleType_SAVE",
                    CreateParameter("@vehtID", SqlDbType.Int, vehicleType.VehtID, ParameterDirection.InputOutput),
                    CreateParameter("@transc_VehicleType", SqlDbType.Int, vehicleType.Transc_VehicleType),
                    CreateParameter("@Type", SqlDbType.VarChar, vehicleType.Type)
                    );
                vehicleType.VehtID = (int)cmd.Parameters["@vehtID"].Value;
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

        public bool Remove(VehicleTypeObject vehicleType)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "VehicleType_DELETE",
                    CreateParameter("@vehtID", SqlDbType.Int, vehicleType.VehtID, ParameterDirection.Input)
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

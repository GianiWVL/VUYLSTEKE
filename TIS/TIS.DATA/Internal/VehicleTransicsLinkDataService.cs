using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using System.Reflection;
using TIS.DL.Internal.VehicleTransicsLink;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class VehicleTransicsLinkDataService : DataServiceBase
    {
        public VehicleTransicsLinkDataService()
            : base()
        { }
        public VehicleTransicsLinkDataService(IDbTransaction txn)
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
                builder.AppendColumn(VehicleTransicsLinkObject.VEHTI_ID);
                builder.AppendColumn(VehicleTransicsLinkObject.TRANSC_VEHICLEID);
                builder.AppendColumn(VehicleTransicsLinkObject.TRANSI_TNR_MAT);
                builder.AppendFromTable(VehicleTransicsLinkObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public VehicleTransicsLinkObjectCollection GetAll()
        {
            VehicleTransicsLinkObjectCollection vehicleTransicsLinks = new VehicleTransicsLinkObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                vehicleTransicsLinks = VehicleTransicsLinkConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return vehicleTransicsLinks;
        }

        public void Save(VehicleTransicsLinkObject vehicleTransicsLink)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "VehicleTransicsLink_SAVE",
                    CreateParameter("@vehtiID", SqlDbType.Int, vehicleTransicsLink.VehtiID, ParameterDirection.InputOutput),
                    CreateParameter("@transc_VehicleID", SqlDbType.Int, vehicleTransicsLink.Transc_VehicleID),
                    CreateParameter("@transi_TNR_mat", SqlDbType.Int, vehicleTransicsLink.Transi_TNR_mat)
                    );
                vehicleTransicsLink.VehtiID = (int)cmd.Parameters["@vehtiID"].Value;
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

        public bool Remove(VehicleTransicsLinkObject vehicleTransicsLink)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "VehicleTransicsLink_DELETE",
                    CreateParameter("@vehtiID", SqlDbType.Int, vehicleTransicsLink.VehtiID, ParameterDirection.Input)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.FuelCorrection;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class FuelCorrectionDataService : DataServiceBase
    {
        public FuelCorrectionDataService()
            : base()
        { }
        public FuelCorrectionDataService(IDbTransaction txn)
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
                builder.AppendColumn(FuelCorrectionObject.FUELCOR_ID);
                builder.AppendColumn(FuelCorrectionObject.DATE_FROM);
                builder.AppendColumn(FuelCorrectionObject.DATE_TO);
                builder.AppendColumn(FuelCorrectionObject.QUANTITY);
                builder.AppendColumn(FuelCorrectionObject.MAXQUANTITY);
                builder.AppendColumn(FuelCorrectionObject.SUPPLIERS_INCLUDED);
                builder.AppendColumn(FuelCorrectionObject.VEHICLES_NOT_INCLUDED);

                builder.AppendFromTable(FuelCorrectionObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public FuelCorrectionObjectCollection GetAll()
        {
            FuelCorrectionObjectCollection fuelCorrections = new FuelCorrectionObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(FuelCorrectionObject.DATE_FROM, QueryBuilder.OrderByType.DESC, QueryBuilder.ParameterLocation.FIRST_LAST);
                fuelCorrections = FuelCorrectionConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuelCorrections;
        }

        public void Save(FuelCorrectionObject fuelCorrection)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "FuelCorrection_SAVE",
                    CreateParameter("@fuelcorID", SqlDbType.UniqueIdentifier, fuelCorrection.FuelCorID, ParameterDirection.InputOutput),
                    CreateParameter("@DateFrom", SqlDbType.VarChar, fuelCorrection.DateFrom),
                    CreateParameter("@DateTo", SqlDbType.VarChar, fuelCorrection.DateTo),
                    CreateParameter("@Quantity", SqlDbType.Decimal, fuelCorrection.Quantity),
                    CreateParameter("@MaxQuantity", SqlDbType.Decimal, fuelCorrection.MaxQuantity),
                    CreateParameter("@VehiclesNotIncluded", SqlDbType.VarChar, fuelCorrection.VehiclesNotIncluded),
                    CreateParameter("@SuppliersIncluded", SqlDbType.VarChar, fuelCorrection.SuppliersIncluded)
                    );
                fuelCorrection.FuelCorID = (Guid)cmd.Parameters["@fuelcorID"].Value;
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

        public bool Remove(FuelCorrectionObject fuelCorrection)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "FuelCorrection_DELETE",
                    CreateParameter("@fuelcorID", SqlDbType.UniqueIdentifier, fuelCorrection.FuelCorID, ParameterDirection.Input)
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

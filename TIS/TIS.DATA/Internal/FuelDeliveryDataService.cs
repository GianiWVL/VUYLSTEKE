using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.FuelDelivery;
using TIS.DL.Internal.Supplier;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class FuelDeliveryDataService : DataServiceBase
    {
        public FuelDeliveryDataService()
            : base()
        { }
        public FuelDeliveryDataService(IDbTransaction txn)
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
                builder.AppendColumn(FuelDeliveryObject.FUELDEL_ID);
                builder.AppendColumn(FuelDeliveryObject.SUP_ID);
                builder.AppendColumn(FuelDeliveryObject.DATE_DELIVERY);
                builder.AppendColumn(FuelDeliveryObject.DATE_INVOICE);
                builder.AppendColumn(FuelDeliveryObject.QUANTITY);
                builder.AppendColumn(FuelDeliveryObject.UNITY_PRICE);
                builder.AppendColumn(FuelDeliveryObject.LOCATION);
                builder.AppendColumn(FuelDeliveryObject.REMARK);

                builder.AppendColumn(SupplierObject.SUP_ID);
                builder.AppendColumn(SupplierObject.TRANSC_ID);
                builder.AppendColumn(SupplierObject.TAS_ID);
                builder.AppendColumn(SupplierObject.NAME);
                builder.AppendColumn(SupplierObject.NAME2);
                builder.AppendColumn(SupplierObject.STREET);
                builder.AppendColumn(SupplierObject.HOUSE_NUMBER);
                builder.AppendColumn(SupplierObject.ZIPCODE);
                builder.AppendColumn(SupplierObject.TOWN);
                builder.AppendColumn(SupplierObject.COUNTRY);
                builder.AppendColumn(SupplierObject.VAT);
                builder.AppendColumn(SupplierObject.PHONE);
                builder.AppendColumn(SupplierObject.LANGUAGE);
                builder.AppendColumn(SupplierObject.CURRENCY);
                builder.AppendColumn(SupplierObject.EMAIL);
                builder.AppendFromTable(FuelDeliveryObject.TABLE);
                builder.AppendInnerJoin(SupplierObject.TABLE, SupplierObject.SUP_ID, FuelDeliveryObject.SUP_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public FuelDeliveryObjectCollection GetAll()
        {
            FuelDeliveryObjectCollection fuelDeliverys = new FuelDeliveryObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(FuelDeliveryObject.DATE_DELIVERY, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                fuelDeliverys = FuelDeliveryConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuelDeliverys;
        }

        public FuelDeliveryObjectCollection GetAllNotZero()
        {
            FuelDeliveryObjectCollection fuelDeliverys = new FuelDeliveryObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.Append(" where " + FuelDeliveryObject.UNITY_PRICE + " <> 0 ");
                builder.AppendOrderBy(FuelDeliveryObject.DATE_DELIVERY, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                fuelDeliverys = FuelDeliveryConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuelDeliverys;
        }

        public FuelDeliveryObjectCollection GetFilter(DateTime dateFromDelivery, DateTime dateToDelivery)
        {
            FuelDeliveryObjectCollection fuelDeliveries;
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString("1", "1", QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                if (dateFromDelivery != DateTime.MinValue)
                    builder.AppendWhereString(FuelDeliveryObject.DATE_INVOICE, PROF_IT.Common.Convert.DateFunctions.DateToStrDate(dateFromDelivery), QueryBuilder.ComparisonOperators.GreaterAndEqual, QueryBuilder.ParameterLocation.MIDDLE);
                if (dateToDelivery != DateTime.MaxValue)
                    builder.AppendWhereString(FuelDeliveryObject.DATE_INVOICE, PROF_IT.Common.Convert.DateFunctions.DateToStrDate(dateToDelivery), QueryBuilder.ComparisonOperators.SmallerAndEqual, QueryBuilder.ParameterLocation.MIDDLE);

                builder.AppendOrderBy(FuelDeliveryObject.DATE_INVOICE, QueryBuilder.OrderByType.DESC, QueryBuilder.ParameterLocation.FIRST_LAST);
                return fuelDeliveries = FuelDeliveryConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);

            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuelDeliveries;
        }

        public void Save(FuelDeliveryObject fuelDelivery)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "FuelDelivery_SAVE",
                    CreateParameter("@fueldelID", SqlDbType.UniqueIdentifier, fuelDelivery.FuelDeliveryID, ParameterDirection.InputOutput),
                    CreateParameter("@supID", SqlDbType.UniqueIdentifier, fuelDelivery.Supplier.SupID),
                    CreateParameter("@DateDelivery", SqlDbType.VarChar, fuelDelivery.DateDelivery),
                    CreateParameter("@DateInvoice", SqlDbType.VarChar, fuelDelivery.DateInvoice),
                    CreateParameter("@Quantity", SqlDbType.Decimal, fuelDelivery.Quantity),
                    CreateParameter("@UnityPrice", SqlDbType.Decimal, fuelDelivery.UnityPrice),
                    CreateParameter("@Location", SqlDbType.Int, (int)fuelDelivery.Location),
                    CreateParameter("@Remark",SqlDbType.NVarChar, fuelDelivery.Remark)
                    );
                fuelDelivery.FuelDeliveryID = (Guid)cmd.Parameters["@fueldelID"].Value;
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

        public bool Remove(FuelDeliveryObject fuelDelivery)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "FuelDelivery_DELETE",
                    CreateParameter("@fueldelID", SqlDbType.UniqueIdentifier, fuelDelivery.FuelDeliveryID, ParameterDirection.Input)
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

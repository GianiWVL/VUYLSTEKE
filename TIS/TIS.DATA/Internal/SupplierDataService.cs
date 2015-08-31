using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.Supplier;
using System.Reflection;
using System.Data.SqlClient;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class SupplierDataService : DataServiceBase
    {
        public SupplierDataService()
            : base()
        { }
        public SupplierDataService(IDbTransaction txn)
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
                builder.AppendFromTable(SupplierObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public SupplierObjectCollection GetAll()
        {
            SupplierObjectCollection suppliers = new SupplierObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                builder.AppendOrderBy(SupplierObject.TRANSC_ID, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                suppliers = SupplierConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return suppliers;
        }

        public SupplierObject GetSupplierByEmail(string email)
        {
            SupplierObject supplier = new SupplierObject();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(SupplierObject.EMAIL, email, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);

                DataSet result = this.ExecuteDataSet(builder.Query, false);
                if (result.Tables[0].Rows.Count > 0)
                    supplier = SupplierConvertor.SupplierRowToObject(result.Tables[0].Rows[0]);
                else
                    return null;

               
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return supplier;
        }

        public void Save(SupplierObject supplier)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Supplier_SAVE",
                    CreateParameter("@supID", SqlDbType.UniqueIdentifier, supplier.SupID, ParameterDirection.InputOutput),
                    CreateParameter("@transcID", SqlDbType.Int, supplier.TranscID),
                    CreateParameter("@tasID", SqlDbType.Int, supplier.TasID),
                    CreateParameter("@Name", SqlDbType.NChar, supplier.Name),
                    CreateParameter("@Name2", SqlDbType.NChar, supplier.Name2),
                    CreateParameter("@Street", SqlDbType.NChar, supplier.Street),
                    CreateParameter("@HouseNumber", SqlDbType.NChar, supplier.HouseNumber),
                    CreateParameter("@Zipcode", SqlDbType.NChar, supplier.Zipcode),
                    CreateParameter("@Town", SqlDbType.NChar, supplier.Town),
                    CreateParameter("@Country", SqlDbType.NChar, supplier.Country),
                    CreateParameter("@VAT", SqlDbType.NChar, supplier.Vat),
                    CreateParameter("@Phone", SqlDbType.NChar, supplier.Phone),
                    CreateParameter("@Language", SqlDbType.NChar, supplier.Language),
                    CreateParameter("@Currency", SqlDbType.NChar, supplier.Currency),
                    CreateParameter("@Email", SqlDbType.NChar, supplier.Email)
                    );
                supplier.SupID = (Guid)cmd.Parameters["@supID"].Value;
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

        public bool Remove(SupplierObject supplier)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Supplier_DELETE",
                    CreateParameter("@supID", SqlDbType.UniqueIdentifier, supplier.SupID, ParameterDirection.Input)
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

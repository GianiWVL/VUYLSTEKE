using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Customer;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class CustomerDataService : DataServiceBase
    {
        public CustomerDataService()
            : base()
        { }
        public CustomerDataService(IDbTransaction txn)
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
                builder.AppendColumn(CustomerObject.CUS_ID);
                builder.AppendColumn(CustomerObject.TAS_ID);
                builder.AppendColumn(CustomerObject.NAME);
                builder.AppendColumn(CustomerObject.NAME2);
                builder.AppendColumn(CustomerObject.STREET);
                builder.AppendColumn(CustomerObject.HOUSE_NUMBER);
                builder.AppendColumn(CustomerObject.ZIPCODE);
                builder.AppendColumn(CustomerObject.TOWN);
                builder.AppendColumn(CustomerObject.COUNTRY);
                builder.AppendColumn(CustomerObject.VAT);
                builder.AppendColumn(CustomerObject.PHONE);
                builder.AppendColumn(CustomerObject.LANGUAGE);
                builder.AppendColumn(CustomerObject.CURRENCY);
                builder.AppendFromTable(CustomerObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public CustomerObjectCollection GetAll()
        {
            CustomerObjectCollection parameters = new CustomerObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                parameters = CustomerConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return parameters;
        }

        public CustomerObjectCollection GetFilter(string name, string vat)
        {
            CustomerObjectCollection customers = new CustomerObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                if (name != "")
                    builder.AppendWhereString(CustomerObject.NAME, name, QueryBuilder.ComparisonOperators.Like, QueryBuilder.ParameterLocation.FIRST);
                if (vat != "")
                    builder.AppendWhereString(CustomerObject.VAT, vat, QueryBuilder.ComparisonOperators.Like, QueryBuilder.ParameterLocation.LAST);
                builder.AppendOrderBy(CustomerObject.NAME, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                customers = CustomerConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return customers;
        }

        public void Save(CustomerObject customer)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Customer_SAVE",
                    CreateParameter("@cusID", SqlDbType.UniqueIdentifier, customer.CusID, ParameterDirection.InputOutput),
                    CreateParameter("@tasID", SqlDbType.Int, customer.TasID),
                    CreateParameter("@Name", SqlDbType.NChar, customer.Name),
                    CreateParameter("@Name2", SqlDbType.NChar, customer.Name2),
                    CreateParameter("@Street", SqlDbType.NChar, customer.Street),
                    CreateParameter("@HouseNumber", SqlDbType.NChar, customer.HouseNumber),
                    CreateParameter("@Zipcode", SqlDbType.NChar, customer.Zipcode),
                    CreateParameter("@Town", SqlDbType.NChar, customer.Town),
                    CreateParameter("@Country", SqlDbType.NChar, customer.Country),
                    CreateParameter("@VAT", SqlDbType.NChar, customer.Vat),
                    CreateParameter("@Phone", SqlDbType.NChar, customer.Phone),
                    CreateParameter("@Language", SqlDbType.NChar, customer.Language),
                    CreateParameter("@Currency", SqlDbType.NChar, customer.Currency)
                    );
                customer.CusID = (Guid)cmd.Parameters["cusID"].Value;
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

        public bool Remove(CustomerObject customer)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Customer_DELETE",
                    CreateParameter("@cusID", SqlDbType.UniqueIdentifier, customer.CusID, ParameterDirection.Input)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.Unknown;
using System.Reflection;
using System.Data.SqlClient;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class UnknownDataService : DataServiceBase
    {
        public UnknownDataService()
            : base()
        { }
        public UnknownDataService(IDbTransaction txn)
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
                builder.AppendColumn(UnknownObject.UNK_ID);
                builder.AppendColumn(UnknownObject.EMAIL);
                builder.AppendFromTable(UnknownObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public UnknownObjectCollection GetAll()
        {
            UnknownObjectCollection unknowns = new UnknownObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(UnknownObject.EMAIL, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                unknowns = UnknownConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return unknowns;
        }

        public UnknownObject GetUnknownByEmail(string email)
        {
            UnknownObject unknown = new UnknownObject();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(UnknownObject.EMAIL, email, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);

                DataSet result = this.ExecuteDataSet(builder.Query, false);
                if (result.Tables[0].Rows.Count > 0)
                    unknown = UnknownConvertor.UnknownRowToObject(result.Tables[0].Rows[0]);
                else
                    return null;


            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return unknown;
        }

        public void Save(UnknownObject unknown)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Unknown_Save",
                    CreateParameter("@unkID", SqlDbType.UniqueIdentifier, unknown.UnkID, ParameterDirection.InputOutput),
                    CreateParameter("@email", SqlDbType.NVarChar, unknown.Email)
                    );
                unknown.UnkID = (Guid)cmd.Parameters["@unkID"].Value;
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

        public bool Remove(UnknownObject unknown)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Unknown_DELETE",
                    CreateParameter("@unkID", SqlDbType.UniqueIdentifier, unknown.UnkID, ParameterDirection.Input)
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

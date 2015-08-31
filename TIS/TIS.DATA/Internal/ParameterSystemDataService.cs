using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.ParameterSystem;
using System.Reflection;
using System.Data.SqlClient;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class ParameterSystemDataService: DataServiceBase
    {
        public ParameterSystemDataService()
            : base()
        { }
        public ParameterSystemDataService(IDbTransaction txn)
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
                builder.AppendColumn(ParameterSystemObject.PAR_ID);
                builder.AppendColumn(ParameterSystemObject.KEYNAME);
                builder.AppendColumn(ParameterSystemObject.VALUE);
                builder.AppendFromTable(ParameterSystemObject.TABLE);

                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public ParameterSystemObjectCollection GetAll()
        {
            ParameterSystemObjectCollection parameters = new ParameterSystemObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(ParameterSystemObject.KEYNAME, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                parameters = ParameterSystemConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return parameters;
        }

        public ParameterSystemObject GetByKeyName(string keyName)
        {
            ParameterSystemObjectCollection parameters = new ParameterSystemObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(ParameterSystemObject.KEYNAME, keyName, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST_LAST);
                builder.AppendOrderBy(ParameterSystemObject.KEYNAME, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                parameters = ParameterSystemConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);

                if (parameters.Count > 0)
                    return parameters[0];
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return null;
        }

        public void Save(ParameterSystemObject parameterSystem)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "ParameterSystem_SAVE",
                    CreateParameter("@parID", SqlDbType.UniqueIdentifier, parameterSystem.ParID, ParameterDirection.InputOutput),
                    CreateParameter("@KeyName", SqlDbType.NVarChar, parameterSystem.KeyName),
                    CreateParameter("@Value", SqlDbType.NVarChar, parameterSystem.Value)
                    );
                parameterSystem.ParID = (Guid)cmd.Parameters["@parID"].Value;
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

        public bool Remove(ParameterSystemObject parameterSystem)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "ParameterSystem_DELETE",
                    CreateParameter("@parID", SqlDbType.UniqueIdentifier, parameterSystem.ParID, ParameterDirection.Input)
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

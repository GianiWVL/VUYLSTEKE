using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.MaterialSubType;
using TIS.DL.Internal.MaterialType;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.MaterialCategory;

namespace TIS.DATA.Internal
{
    public class MaterialSubTypeDataService : DataServiceBase
    {
        public MaterialSubTypeDataService()
            : base()
        { }
        public MaterialSubTypeDataService(IDbTransaction txn)
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
                builder.AppendColumn(MaterialSubTypeObject.MATSTYP_ID);
                builder.AppendColumn(MaterialSubTypeObject.MATTYP_ID);
                builder.AppendColumn(MaterialSubTypeObject.SUBTYPE);
                builder.AppendColumn(MaterialTypeObject.MATCAT_ID);
                builder.AppendColumn(MaterialTypeObject.MATTYP_ID);
                builder.AppendColumn(MaterialTypeObject.TYPE);
                builder.AppendColumn(MaterialCategoryObject.CATEGORY);
                builder.AppendColumn(MaterialCategoryObject.MATCAT_ID);
                builder.AppendFromTable(MaterialSubTypeObject.TABLE);
                builder.AppendInnerJoin(MaterialTypeObject.TABLE, MaterialSubTypeObject.MATTYP_ID, MaterialTypeObject.MATTYP_ID);
                builder.AppendInnerJoin(MaterialCategoryObject.TABLE, MaterialTypeObject.MATCAT_ID, MaterialCategoryObject.MATCAT_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MaterialSubTypeObjectCollection GetAll()
        {
            MaterialSubTypeObjectCollection materialSubTypes = new MaterialSubTypeObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(MaterialSubTypeObject.SUBTYPE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                materialSubTypes = MaterialSubTypeConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materialSubTypes;
        }

        public MaterialSubTypeObjectCollection GetSubTypeByType(MaterialTypeObject type)
        {
            MaterialSubTypeObjectCollection materialSubTypes = new MaterialSubTypeObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(MaterialSubTypeObject.MATTYP_ID, type.MatTypID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + MaterialSubTypeObject.MATTYP_ID + " is not null ");
                builder.AppendOrderBy(MaterialSubTypeObject.SUBTYPE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                materialSubTypes = MaterialSubTypeConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materialSubTypes;
        }

        public void Save(MaterialSubTypeObject materialSubType)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialSubType_SAVE",
                    CreateParameter("@matstypID", SqlDbType.UniqueIdentifier, materialSubType.MatStypID, ParameterDirection.InputOutput),
                    CreateParameter("@mattypID", SqlDbType.UniqueIdentifier, materialSubType.MaterialType.MatTypID),
                    CreateParameter("@SubType", SqlDbType.VarChar, materialSubType.SubType)
                    );
                materialSubType.MatStypID = (Guid)cmd.Parameters["@matstypID"].Value;
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

        public bool Remove(MaterialSubTypeObject materialSubType)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialSubType_DELETE",
                    CreateParameter("@matstypID", SqlDbType.UniqueIdentifier, materialSubType.MatStypID, ParameterDirection.Input)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialCategory;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class MaterialTypeDataService : DataServiceBase
    {
        public MaterialTypeDataService()
            : base()
        { }
        public MaterialTypeDataService(IDbTransaction txn)
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
                builder.AppendColumn(MaterialTypeObject.MATTYP_ID);
                builder.AppendColumn(MaterialTypeObject.MATCAT_ID);
                builder.AppendColumn(MaterialTypeObject.TYPE);
                builder.AppendColumn(MaterialCategoryObject.CATEGORY);
                builder.AppendColumn(MaterialCategoryObject.MATCAT_ID);
                builder.AppendFromTable(MaterialTypeObject.TABLE);
                builder.AppendInnerJoin(MaterialCategoryObject.TABLE, MaterialCategoryObject.MATCAT_ID, MaterialTypeObject.MATCAT_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MaterialTypeObjectCollection GetAll()
        {
            MaterialTypeObjectCollection materialTypes = new MaterialTypeObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(MaterialTypeObject.TYPE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                materialTypes = MaterialTypeConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materialTypes;
        }

        public MaterialTypeObjectCollection GetTypesByCategorie(MaterialCategoryObject category)
        {
            MaterialTypeObjectCollection materialTypes = new MaterialTypeObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(MaterialTypeObject.MATCAT_ID, category.MatcatID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + MaterialTypeObject.MATCAT_ID + " is not null ");
                builder.AppendOrderBy(MaterialTypeObject.TYPE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                materialTypes = MaterialTypeConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materialTypes;
        }

        public void Save(MaterialTypeObject materialType)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialType_SAVE",
                    CreateParameter("@mattypID", SqlDbType.UniqueIdentifier, materialType.MatTypID, ParameterDirection.InputOutput),
                    CreateParameter("@matcatID", SqlDbType.UniqueIdentifier, materialType.MaterialCategory.MatcatID),
                    CreateParameter("@Type", SqlDbType.VarChar, materialType.Type)
                    );
                materialType.MatTypID = (Guid)cmd.Parameters["@mattypID"].Value;
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

        public bool Remove(MaterialTypeObject materialType)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialType_DELETE",
                    CreateParameter("@mattypID", SqlDbType.UniqueIdentifier, materialType.MatTypID, ParameterDirection.Input)
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

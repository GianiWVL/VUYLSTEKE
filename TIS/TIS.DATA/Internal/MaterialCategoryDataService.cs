using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.MaterialCategory;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class MaterialCategoryDataService : DataServiceBase
    {
        public MaterialCategoryDataService()
            : base()
        { }
        public MaterialCategoryDataService(IDbTransaction txn)
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
                builder.AppendColumn(MaterialCategoryObject.MATCAT_ID);
                builder.AppendColumn(MaterialCategoryObject.CATEGORY);
                builder.AppendFromTable(MaterialCategoryObject.TABLE);
               
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MaterialCategoryObjectCollection GetAll()
        {
            MaterialCategoryObjectCollection materialCategorys = new MaterialCategoryObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(MaterialCategoryObject.CATEGORY, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                materialCategorys = MaterialCategoryConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materialCategorys;
        }

        public void Save(MaterialCategoryObject materialCategory)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialCategory_SAVE",
                    CreateParameter("@matcatID", SqlDbType.UniqueIdentifier, materialCategory.MatcatID, ParameterDirection.InputOutput),
                    CreateParameter("@Category", SqlDbType.VarChar, materialCategory.Category)
                    );
                materialCategory.MatcatID = (Guid)cmd.Parameters["@matcatID"].Value;
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

        public bool Remove(MaterialCategoryObject materialCategory)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "MaterialCategory_DELETE",
                    CreateParameter("@matcatID", SqlDbType.UniqueIdentifier, materialCategory.MatcatID, ParameterDirection.Input)
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

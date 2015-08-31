using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.Revision;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class RevisionDataService : DataServiceBase
    {
        public RevisionDataService()
            : base()
        { }
        public RevisionDataService(IDbTransaction txn)
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
                builder.AppendColumn(RevisionObject.REV_ID);
                builder.AppendColumn(RevisionObject.MATCAT_ID);
                builder.AppendColumn(RevisionObject.MATTYP_ID);
                builder.AppendColumn(RevisionObject.MATSTYP_ID);
                builder.AppendColumn(RevisionObject.REVISION);
                builder.AppendColumn(MaterialCategoryObject.CATEGORY);
                builder.AppendColumn(MaterialCategoryObject.MATCAT_ID);
                builder.AppendColumn(MaterialSubTypeObject.MATSTYP_ID);
                builder.AppendColumn(MaterialSubTypeObject.MATTYP_ID);
                builder.AppendColumn(MaterialSubTypeObject.SUBTYPE);
                builder.AppendColumn(MaterialTypeObject.MATCAT_ID);
                builder.AppendColumn(MaterialTypeObject.MATTYP_ID);
                builder.AppendColumn(MaterialTypeObject.TYPE);
                builder.AppendFromTable(RevisionObject.TABLE);
                builder.AppendLeftJoin(MaterialCategoryObject.TABLE, MaterialCategoryObject.MATCAT_ID, RevisionObject.MATCAT_ID);
                builder.AppendLeftJoin(MaterialTypeObject.TABLE, MaterialTypeObject.MATTYP_ID, RevisionObject.MATTYP_ID);
                builder.AppendLeftJoin(MaterialSubTypeObject.TABLE, MaterialSubTypeObject.MATSTYP_ID, RevisionObject.MATSTYP_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public RevisionObjectCollection GetByMaterialCateogry(MaterialCategoryObject materialCategory)
        {
            RevisionObjectCollection revisions = new RevisionObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(RevisionObject.MATCAT_ID, materialCategory.MatcatID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + RevisionObject.MATCAT_ID + " is not null ");
                revisions = RevisionConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return revisions;
        }

        public RevisionObjectCollection GetByMaterialType(MaterialTypeObject materialType)
        {
            RevisionObjectCollection revisions = new RevisionObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(RevisionObject.MATTYP_ID, materialType.MatTypID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + RevisionObject.MATTYP_ID + " is not null ");
                revisions = RevisionConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return revisions;
        }

        public RevisionObjectCollection GetByMaterialSubType(MaterialSubTypeObject materialSubType)
        {
            RevisionObjectCollection revisions = new RevisionObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(RevisionObject.MATSTYP_ID, materialSubType.MatStypID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + RevisionObject.MATSTYP_ID + " is not null ");
                revisions = RevisionConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return revisions;
        }

        public void Save(RevisionObject revision)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Revision_SAVE",
                    CreateParameter("@revID", SqlDbType.UniqueIdentifier, revision.RevID, ParameterDirection.InputOutput),
                    CreateParameter("@matcatID", SqlDbType.UniqueIdentifier, revision.MaterialCategory == null ? Guid.Empty : revision.MaterialCategory.MatcatID),
                    CreateParameter("@mattypID", SqlDbType.UniqueIdentifier, revision.MaterialType == null ? Guid.Empty : revision.MaterialType.MatTypID),
                    CreateParameter("@matstypID", SqlDbType.UniqueIdentifier,  revision.MaterialSubType == null ? Guid.Empty : revision.MaterialSubType.MatStypID),
                    CreateParameter("@Revision", SqlDbType.VarChar, revision.Revision)
                    );
                revision.RevID = (Guid)cmd.Parameters["@revID"].Value;
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

        public bool Remove(RevisionObject revision)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Revision_DELETE",
                    CreateParameter("@revID", SqlDbType.UniqueIdentifier, revision.RevID, ParameterDirection.Input)
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

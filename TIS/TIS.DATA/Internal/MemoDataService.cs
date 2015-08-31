using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.Memo;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Material;

namespace TIS.DATA.Internal
{
    public class MemoDataService : DataServiceBase
    {
        public MemoDataService()
            : base()
        { }
        public MemoDataService(IDbTransaction txn)
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
                builder.AppendColumn(MemoObject.DATETIME);
                builder.AppendColumn(MemoObject.MAT_ID);
                builder.AppendColumn(MemoObject.MEMO);
                builder.AppendColumn(MemoObject.MEMO_ID);
                builder.AppendFromTable(MemoObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MemoObjectCollection GetAll()
        {
            MemoObjectCollection memos = new MemoObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(MemoObject.DATETIME, QueryBuilder.OrderByType.DESC, QueryBuilder.ParameterLocation.FIRST_LAST);
                memos = MemoConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return memos;
        }

        public MemoObjectCollection GetMemosByMaintenanceID(MaterialObject material)
        {
            MemoObjectCollection memos = new MemoObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(MemoObject.MAT_ID, material.MatID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + MemoObject.MAT_ID + " is not null ");
                memos = MemoConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return memos;
        }

        public void Save(MemoObject memo)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Memo_SAVE",
                    CreateParameter("@memoID", SqlDbType.UniqueIdentifier, memo.MemoID, ParameterDirection.InputOutput),
                    CreateParameter("@matID", SqlDbType.UniqueIdentifier, memo.Material == null ? Guid.Empty : memo.Material.MatID),
                    CreateParameter("@datetime", SqlDbType.VarChar, PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(memo.DateTime)),
                    CreateParameter("@memo", SqlDbType.VarChar, memo.Memo)
                    );
                memo.MemoID = (Guid)cmd.Parameters["@memoID"].Value;
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

        public bool Remove(MemoObject memo)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Memo_DELETE",
                    CreateParameter("@memoID", SqlDbType.UniqueIdentifier, memo.Memo, ParameterDirection.Input)
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

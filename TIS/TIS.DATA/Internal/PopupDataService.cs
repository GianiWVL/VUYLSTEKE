using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using System.Reflection;
using TIS.DL.Internal.Popup;
using System.Data.SqlClient;

namespace TIS.DATA.Internal
{
    public class PopupDataService : DataServiceBase
    {
        public PopupDataService()
            : base()
        { }
        public PopupDataService(IDbTransaction txn)
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
                builder.AppendColumn(PopupObject.POPUP_ID);
                builder.AppendColumn(PopupObject.DESCRIPTION);
                builder.AppendColumn(PopupObject.REPEAT);
                builder.AppendColumn(PopupObject.ACTIVE);
                builder.AppendColumn(PopupObject.CREATIONDATE);
                builder.AppendColumn(PopupObject.TIME);
                builder.AppendColumn(PopupObject.SHOW_DIRECT);
                builder.AppendFromTable(PopupObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public PopupObjectCollection GetAll()
        {
            PopupObjectCollection tasks = new PopupObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                tasks = PopupConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return tasks;
        }

        public PopupObjectCollection GetActive()
        {
            PopupObjectCollection tasks = new PopupObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereBoolean(PopupObject.ACTIVE, true, QueryBuilder.ParameterLocation.FIRST_LAST);
                tasks = PopupConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return tasks;
        }

        public void Save(PopupObject popup)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Popup_SAVE",
                    CreateParameter("@popupID", SqlDbType.UniqueIdentifier ,popup.PopupID,ParameterDirection.InputOutput),
                    CreateParameter("@Description", SqlDbType.NVarChar ,popup.Description),
                    CreateParameter("@Repeat", SqlDbType.Int ,popup.Repeation),
                    CreateParameter("@Active", SqlDbType.Bit ,popup.Active),
                    CreateParameter("@CreationDate", SqlDbType.VarChar ,popup.CreationDate),
                    CreateParameter("@Time", SqlDbType.VarChar ,popup.Time),
                    CreateParameter("@ShowDirect", SqlDbType.Bit ,popup.ShowDirect)
                    );
                popup.PopupID = (Guid)cmd.Parameters["@popupID"].Value;
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

        public bool Remove(PopupObject popup)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Popup_DELETE",
                    CreateParameter("@popupID", SqlDbType.UniqueIdentifier, popup.PopupID, ParameterDirection.Input)
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


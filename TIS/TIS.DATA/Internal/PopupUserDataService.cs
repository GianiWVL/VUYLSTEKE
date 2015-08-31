using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.PopupUser;
using TIS.DL.Internal.User;
using TIS.DL.Internal.Popup;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Employee;

namespace TIS.DATA.Internal
{
    public class PopupUserDataService : DataServiceBase
    {
        public PopupUserDataService()
            : base()
        { }
        public PopupUserDataService(IDbTransaction txn)
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
                builder.AppendColumn(PopupUserObject.POPUPUSER_ID);
                builder.AppendColumn(PopupUserObject.POPUP_ID);
                builder.AppendColumn(PopupUserObject.USER_ID);
                builder.AppendColumn(PopupObject.POPUP_ID);
                builder.AppendColumn(PopupObject.DESCRIPTION);
                builder.AppendColumn(PopupObject.REPEAT);
                builder.AppendColumn(PopupObject.ACTIVE);
                builder.AppendColumn(PopupObject.CREATIONDATE);
                builder.AppendColumn(PopupObject.TIME);
                builder.AppendColumn(PopupObject.SHOW_DIRECT);
                builder.AppendColumn(UserObject.USR_ID);
                builder.AppendFromTable(PopupUserObject.TABLE);
                builder.AppendLeftJoin(PopupObject.TABLE, PopupUserObject.POPUP_ID, PopupObject.POPUP_ID);
                builder.AppendLeftJoin(UserObject.TABLE, PopupUserObject.USER_ID, UserObject.USR_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public PopupUserObjectCollection GetAll()
        {
            PopupUserObjectCollection popupUsers = new PopupUserObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false,0));
                popupUsers = PopupUserConverter.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return popupUsers;
        }
  
        public PopupObjectCollection GetAllActiveByEmployee(UserObject user)
        {
            PopupObjectCollection popups = new PopupObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(PopupUserObject.USER_ID, user.UsrID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + PopupUserObject.USER_ID + " is not null ");
                builder.Append("AND " + PopupUserObject.POPUP_ID + " is not null ");
                builder.AppendWhereBoolean(PopupObject.ACTIVE, true, QueryBuilder.ParameterLocation.LAST);
                popups = PopupConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return popups;
        }
        public void Save(PopupUserObject popupUser)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "PopupUser_Save",
                    CreateParameter("@popupuserID", SqlDbType.UniqueIdentifier, popupUser.PopupUserID, ParameterDirection.InputOutput),
                    CreateParameter("@popupID", SqlDbType.UniqueIdentifier, popupUser.Popup.PopupID),
                    CreateParameter("@userID", SqlDbType.UniqueIdentifier, popupUser.User == null ? Guid.Empty : popupUser.User.UsrID)
                    );
                popupUser.PopupUserID = (Guid)cmd.Parameters["@popupuserID"].Value;
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
        public bool Remove(PopupUserObject popupUser)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "PopupUser_DELETE",
                    CreateParameter("@popupuserID", SqlDbType.UniqueIdentifier, popupUser.PopupUserID, ParameterDirection.Input)
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
        public void Save(PopupUserObjectCollection popupUsers)
        {
            try
            {
                foreach (PopupUserObject popupUser in popupUsers)
                {
                    if (popupUser.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                        Remove(popupUser);
                    if (popupUser.State == PROF_IT.Common.Enumerations.ObjectState.Modified |
                            popupUser.State == PROF_IT.Common.Enumerations.ObjectState.Created)
                        Save(popupUser);
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void RemoveAllByPopup(PopupObject popup)
        {
            try
            {
                foreach (PopupUserObject popupUser in popup.PopupUsers)
                {
                    Remove(popupUser);
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
    }
}

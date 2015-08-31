using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Popup;
using TIS.DL.Internal.User;
using TIS.DATA.Internal;
using System.Reflection;

namespace TIS.BL.Internal
{
    public class Popup: PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public Popup()
            : base()
        {
            
        }
        public Popup(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion



        #region Methods

        public PopupObjectCollection GetAll()
        {
            PopupObjectCollection popups;
            try
            {
                popups = new PopupDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return popups;
        }
        public PopupObjectCollection GetallActivePopupsByUser(UserObject user)
        {
            PopupObjectCollection popups;
            try
            {
                popups = new PopupUserDataService().GetAllActiveByEmployee(user);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return popups;
        }
        public void Save(PopupObject popup)
        {
            try
            {
                CheckTransaction();
                new PopupDataService().Save(popup);
                if (popup.PopupUsers != null && popup.PopupUsers.Count > 0)
                    new PopupUserDataService().Save(popup.PopupUsers);
                if(IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }
        public void Remove(PopupObject popup)
        {
            try
            {
                CheckTransaction();
                new PopupDataService().Remove(popup);
                if (popup.PopupUsers != null)
                    new PopupUserDataService().RemoveAllByPopup(popup);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        #endregion

    }
}
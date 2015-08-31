using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.PopupUser
{
    public class PopupUserObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public PopupUserObject()
        {
        }
        #endregion

        #region Constants
        public const string TABLE = "PopupUser";
        public const string POPUPUSER_ID = TABLE + "." + "popupuserID";
        public const string POPUP_ID = TABLE + "." + "popupID";
        public const string USER_ID = TABLE + "." + "userID";

        #endregion

        #region Fields

        private Guid _popupuserID;
        private Popup.PopupObject _popup = null;
        private User.UserObject _user = null;

        private Popup.PopupObject _loadedpopup = null;
        private User.UserObject _loadeduser = null;

        private PopupUserObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid PopupUserID
        {
            get { return _popupuserID; }
            set { _popupuserID = value; }
        }

        public Popup.PopupObject Popup
        {
            get { return _popup; }
            set { _popup = value; }
        }
        public User.UserObject User
        {
            get { return _user; }
            set { _user = value; }
        }

        internal PopupUserObjectCollection Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        public Enumerations.ObjectState State
        {
            get { return _state; }
            set { _state = value; }
        }

        #endregion

        #region Methods
        public PopupUserObject Clone()
        {
            return this.Clone<PopupUserObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.PopupUserID == ((PopupUserObject)obj).PopupUserID)
                    return true;
                else
                    return false;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void OnTaskPeopleObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.PopupUserObjectChanged(this);
                }
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion

        #region IEditableObject

        void IEditableObject.BeginEdit()
        {
            try
            {
                if (!inTxn)
                {
                    _loadedpopup = this.Popup;
                    _loadeduser = this.User;
                    inTxn = true;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        void IEditableObject.CancelEdit()
        {
            try
            {
                if (inTxn)
                {
                    this.Popup = _loadedpopup;
                    this.User = _loadeduser;
                    inTxn = false;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        void IEditableObject.EndEdit()
        {
            try
            {
                if (inTxn)
                {
                    _loadedpopup = this.Popup;
                    _loadeduser = this.User;
                    inTxn = false;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion
    }
}

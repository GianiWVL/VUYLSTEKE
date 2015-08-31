using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using PROF_IT.Common.Data;
using PROF_IT.Common;

namespace TIS.DL.Internal.Unknown
{

    public class UnknownObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public UnknownObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Unknown";
        public const string UNK_ID = TABLE + "." + "unkID";
        public const string EMAIL = TABLE + "." + "Email";
        #endregion

        #region Fields

        private Guid _unkID;
        private string _email = Constants.NullString;

        private string _loadedEmail = Constants.NullString;

        private UnknownObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid UnkID
        {
            get { return _unkID; }
            set { _unkID = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        internal UnknownObjectCollection Parent
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
        public UnknownObject Clone()
        {
            return this.Clone<UnknownObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.UnkID == ((UnknownObject)obj).UnkID)
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

        private void OnUnknownObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.UnknownObjectChanged(this);
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
                    _loadedEmail = this.Email;
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
                    this.Email = _loadedEmail;
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
                    _loadedEmail = this.Email;
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

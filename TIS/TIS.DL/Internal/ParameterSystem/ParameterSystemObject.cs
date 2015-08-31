using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.ParameterSystem
{

    public class ParameterSystemObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public ParameterSystemObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "ParameterSystem";
        public const string PAR_ID = TABLE + "." + "parID";
        public const string KEYNAME = TABLE + "." + "KeyName";
        public const string VALUE = TABLE + "." + "Value";

        //Parameters
        public const string SMTP_VUYLSTEKE = "SMTP_VUYLSTEKE";
        #endregion

        #region Fields

        private Guid _parID;
        private string _keyName = Constants.NullString;
        private string _value = Constants.NullString;


        private string _loadedKeyName = Constants.NullString;
        private string _loadedValue = Constants.NullString;

        private ParameterSystemObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid ParID
        {
            get { return _parID; }
            set { _parID = value; }
        }
        public string KeyName
        {
            get { return _keyName; }
            set { _keyName = value; }
        }
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        internal ParameterSystemObjectCollection Parent
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
        public ParameterSystemObject Clone()
        {
            return this.Clone<ParameterSystemObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.ParID == ((ParameterSystemObject)obj).ParID)
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

        private void OnParameterSystemObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.ParameterSystemObjectChanged(this);
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
                    _loadedKeyName = this.KeyName;
                    _loadedValue = this.Value;
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
                    this.KeyName = _loadedKeyName;
                    this.Value = _loadedValue;
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
                    _loadedKeyName = this.KeyName;
                    _loadedValue = this.Value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using TIS.DL.Internal.Supplier;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.Language
{
    public class LanguageObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public LanguageObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Language";
        public const string LAN_ID = TABLE + "." + "lanID";
        public const string LANGUAGE = TABLE + "." + "Language";
        public const string LANGUAGE_DUTCH = TABLE + "." + "LanguageDutch";
        #endregion

        #region Fields

        private Guid _lanID;
        private string _language = Constants.NullString;
        private string _languageDutch = Constants.NullString;

        private string _loadedLanguage = Constants.NullString;
        private string _loadedLanguageDutch = Constants.NullString;

        private LanguageObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid LanID
        {
            get { return _lanID; }
            set { _lanID = value; }
        }
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        public string LanguageDutch
        {
            get { return _languageDutch; }
            set { _languageDutch = value; }
        }

        internal LanguageObjectCollection Parent
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
        public LanguageObject Clone()
        {
            return this.Clone<LanguageObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.LanID == ((LanguageObject)obj).LanID)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void OnLanguageObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.LanguageObjectChanged(this);
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
                if (!_inTxn)
                {
                    _loadedLanguageDutch = LanguageDutch;
                    _loadedLanguage = Language;
                    _inTxn = true;
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
                if (_inTxn)
                {
                    Language = _language;
                    LanguageDutch = _languageDutch;
                    _inTxn = false;
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
                if (_inTxn)
                {
                    _loadedLanguageDutch = LanguageDutch;
                    _loadedLanguage = Language;
                    _inTxn = true;
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

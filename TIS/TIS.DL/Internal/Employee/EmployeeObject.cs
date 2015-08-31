using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using TIS.DL.Internal.Language;

namespace TIS.DL.Internal.Employee
{

    public class EmployeeObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public EmployeeObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Employee";
        public const string EMP_ID = TABLE + "." + "empID";
        public const string TRANSC_ID = TABLE + "." + "transcID";
        public const string TRANSI_ID = TABLE + "." + "transiID";
        public const string NAME = TABLE + "." + "Name";
        public const string SURNAME = TABLE + "." + "Surname";
        public const string EMAIL = TABLE + "." + "Email";
        public const string ARCHIVE = TABLE + "." + "Archive";
        public const string TRANSC_LANGUAGE = TABLE + "." + "transcLanguage";
        public const string LAN_ID = TABLE + "." + "LanID";
        public const string REPEAT_MAIL = TABLE + "." + "RepeatMail";
        #endregion
        
        #region Fields

        private Guid _empID;
        private int _transcID = Constants.NullInt;
        private int _transiID = Constants.NullInt;
        private string _name = Constants.NullString;
        private string _surname = Constants.NullString;
        private string _email = Constants.NullString;
        private Boolean _archive;
        private int _transcLanguage = Constants.NullInt;
        private LanguageObject _language;
        private bool _repeatMail;
        
        private int _loadedTranscID = Constants.NullInt;
        private int _loadedTransiID = Constants.NullInt;
        private string _loadedName = Constants.NullString;
        private string _loadedSurname = Constants.NullString;
        private string _loadedEmail = Constants.NullString;
        private Boolean _loadedArchive;
        private int _loadedTranscLanguage = Constants.NullInt;
        private LanguageObject _loadedLanguage;
        private bool _loadedRepeatMail;

        private EmployeeObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool _inTxn = false;
        #endregion

        #region Properties

        public Guid EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        public int TranscID
        {
            get { return _transcID; }
            set { _transcID = value; }
        }

        public int TransiID
        {
            get { return _transiID; }
            set { _transiID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Boolean Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public int TranscLanguage
        {
            get { return _transcLanguage; }
            set { _transcLanguage = value; }
        }

        public LanguageObject Language 
        {
            get { return _language; }
            set { _language = value; }
        }

        public string DisplayName
        {
            get { return Name + " " + Surname; }
        }

        public bool RepeatMail
        {
            get { return _repeatMail; }
            set { _repeatMail = value; }
        }

        internal EmployeeObjectCollection Parent
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
        public EmployeeObject Clone()
        {
            return this.Clone<EmployeeObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    if (this.EmpID == ((EmployeeObject)obj).EmpID)
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

        private void OnEmployeeObjectChanged()
        {
            try
            {
                if (_inTxn && Parent != null)
                {
                    Parent.EmployeeObjectChanged(this);
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
                    _loadedTranscID = this.TranscID;
                    _loadedTransiID = this.TransiID;
                    _loadedSurname = this.Surname;
                    _loadedName = this.Name;
                    _loadedEmail = this.Email;
                    _loadedArchive = this.Archive;
                    _loadedTranscLanguage = this.TranscLanguage;
                    _loadedLanguage = this.Language;
                    _loadedRepeatMail = this.RepeatMail;
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
                    this.TranscID = _loadedTranscID;
                    this.TransiID = _loadedTransiID;
                    this.Name = _loadedName;
                    this.Surname = _loadedSurname;
                    this.Email = _loadedEmail;
                    this.Archive = _loadedArchive;
                    this.TranscLanguage = _loadedTranscLanguage;
                    this.Language = _loadedLanguage;
                    this.RepeatMail = _loadedRepeatMail;
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
                    _loadedTranscID = this.TranscID;
                    _loadedTransiID = this.TransiID;
                    _loadedSurname = this.Surname;
                    _loadedName = this.Name;
                    _loadedEmail = this.Email;
                    _loadedArchive = this.Archive;
                    _loadedTranscLanguage = this.TranscLanguage;
                    _loadedLanguage = this.Language;
                    _loadedRepeatMail = this.RepeatMail;
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

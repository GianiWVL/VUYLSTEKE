using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;
using System.Reflection;
using TIS.DL.Internal.UserSecurity;
using TIS.DL.Internal.Employee;

namespace TIS.DL.Internal.User
{
    public class UserObject: IEditableObject
    {
        #region Constructor
        public UserObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Users";
        public const string USR_ID = TABLE + "." + "usrID";
        public const string EMP_ID = TABLE + "." + "empID";
        public const string SURNAME = TABLE + "." + "Surname";
        public const string NAME = TABLE + "." + "Name";
        public const string LOGIN = TABLE + "." + "Login";
        public const string PASSWORD = TABLE + "." + "Password";
        public const string ACTIVE = TABLE + "." + "Active";
        public const string HASPOPUPS = TABLE + "." + "HasPopups";
        public const string SECURITY = TABLE + "." + "Security";
        #endregion

        #region Fields

        private Guid _usrID;
        private EmployeeObject _employee;
        private string _surname = Constants.NullString;
        private string _name = Constants.NullString;
        private string _login = Constants.NullString;
        private string _password = Constants.NullString;
        private UserSecurityObject _security = new UserSecurityObject();
        private Boolean _active = false;
        private Boolean _hasPopups = false;

        private EmployeeObject _loadedEmployee;
        private string _loadedSurname = Constants.NullString;
        private string _loadedName = Constants.NullString;
        private string _loadedLogin = Constants.NullString;
        private string _loadedPassword = Constants.NullString;
        private UserSecurityObject _loadedSecurity = new UserSecurityObject();
        private Boolean _loadedActive = false;
        private Boolean _loadedhasPopups = false;
        private bool _initialValueSet = false;

        private UserObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid UsrID
        {
            get { return _usrID; }
            set { _usrID = value; }
        }

        public EmployeeObject Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Boolean Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public Boolean HasPopups
        {
            get { return _hasPopups; }
            set { _hasPopups = value; }
        }

        public UserSecurityObject Security
        {
            get { return _security; }
            set { _security = value; }
        }

        internal UserObjectCollection Parent
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

        public bool LoginChanged
        {
            get
            {
                if (!_initialValueSet)
                {
                    throw new System.Exception("Initial values have not been set.");
                }
                return !this.Login.ToUpper().Trim().Equals(this._loadedLogin.ToUpper().Trim());
            }
        }

        public bool NameChanged
        {
            get
            {
                if (!this._initialValueSet)
                {
                    throw new Exception("Initial values have not been set.");
                }
                return !this.Name.ToUpper().Trim().Equals(this._loadedName.ToUpper().Trim());
            }

        }

        public bool SurNameChanged
        {
            get
            {
                if (!this._initialValueSet)
                {
                    throw new Exception("Initial values have not been set.");
                }
                return !this.Surname.ToUpper().Trim().Equals(this._surname.ToUpper().Trim());
            }
        }

        #endregion

        #region Methods

        public void SetInitialValues()
        {
            try
            {
                if (!inTxn)
                {
                    _loadedActive = this.Active;
                    _loadedhasPopups = this.HasPopups;
                    _loadedLogin = this.Login;
                    _loadedName = this.Name;
                    _loadedPassword = this.Password;
                    _loadedSurname = this.Surname;
                    _initialValueSet = true;
                    inTxn = true;
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public override bool Equals(object obj)
        {
            obj = obj as UserObject;
            if (obj == null)
                return false;

            if (this.UsrID == ((UserObject)obj).UsrID)
                return true;
            else
                return false;
        }

        private void OnUserObjectChanged()
        {
            if (inTxn && Parent != null)
            {
                Parent.UserObjectChanged(this);
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
                    _loadedEmployee = this.Employee;
                    _loadedActive = this.Active;
                    _loadedhasPopups = this.HasPopups;
                    _loadedLogin = this.Login;
                    _loadedName = this.Name;
                    _loadedPassword = this.Password;
                    _loadedSurname = this.Surname;
                    _loadedSecurity = this.Security;
                    _initialValueSet = true;
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
                    this.Employee = _loadedEmployee;
                    this.Active = _loadedActive;
                    this.HasPopups = _loadedhasPopups;
                    this.Login = _loadedLogin;
                    this.Name = _loadedName;
                    this.Password = _loadedPassword;
                    this.Surname = _loadedSurname;
                    this.Security = _loadedSecurity;
                    _initialValueSet = false;
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
                    _loadedEmployee = this.Employee;
                    _loadedActive = this.Active;
                    _loadedhasPopups = this.HasPopups;
                    _loadedLogin = this.Login;
                    _loadedName = this.Name;
                    _loadedPassword = this.Password;
                    _loadedSurname = this.Surname;
                    _loadedSecurity = this.Security;
                    _initialValueSet = false;
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

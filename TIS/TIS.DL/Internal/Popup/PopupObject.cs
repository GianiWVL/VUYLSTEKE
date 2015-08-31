using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using TIS.Framework.Common;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.Popup
{
    public class PopupObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {

        #region Constructor
        public PopupObject()
        {
            PopupUsers = new PopupUser.PopupUserObjectCollection();
        }
        #endregion

        #region Constants
        public const string TABLE = "Popup";
        public const string POPUP_ID = TABLE + "." + "popupID";
        public const string DESCRIPTION = TABLE + "." + "Description";
        public const string REPEAT = TABLE + "." + "Repeat";
        public const string ACTIVE = TABLE + "." + "Active";
        public const string CREATIONDATE= TABLE + "." + "CreationDate";
        public const string SHOW_DIRECT = TABLE + "." + "ShowDirect";
        public const string TIME = TABLE + "." + "Time";
        #endregion

        #region Fields

        private Guid _popupID;
        private string _description = Constants.NullString;
        private Enumeration.Frequency.TimeFrequency _repeat;
        private bool _active;
        private string _creationDate = Constants.NullString;
        private string _time = Constants.NullString;
        private bool _showDirect;
        //Child members
        private PopupUser.PopupUserObjectCollection _popupusers;


        private string _loadeddescription = Constants.NullString;
        private Enumeration.Frequency.TimeFrequency _loadedrepeat;
        private bool _loadedactive;
        private string _loadedcreationDate = Constants.NullString;
        private string _loadedtime = Constants.NullString;
        private bool _loadedShowDirect;
        
        private Boolean _childsAdded = false;
        //Child members
        private PopupUser.PopupUserObjectCollection _loadedpopupusers;

        private PopupObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid PopupID
        {
            get { return _popupID; }
            set { _popupID = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public DateTime CreationDateDisplay
        {
            get 
            {
                if (CreationDate == "")
                    return DateTime.MinValue;
                else
                    return PROF_IT.Common.Convert.DateFunctions.DBDateToDate(CreationDate, false); 
            }
        }
        public bool Active
        {
           get{ return _active;}
            set{ _active = value;}
        }
        public bool ShowDirect
        {
            get { return _showDirect; }
            set { _showDirect = value; }
        }
        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public string TimeDisplay
        {
            get
            {
                if (Time.Length == 6)
                    return Time.Substring(0, 2) + ":" + Time.Substring(2, 2) + ":" + Time.Substring(4, 2);
                else
                    return "";
            }
        }
        public string DescriptionDisplay
        {
            get
            {
                System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
                richTextBox.Rtf = Description;
                return richTextBox.Text;
            }
        }
        public Enumeration.Frequency.TimeFrequency Repeation
        {
            get {return _repeat;}
            set { _repeat = value;}
        }

        public Boolean ChildsAdded
        {
            get { return _childsAdded; }
            set { _childsAdded = value; }
        }
        //Child members

        public PopupUser.PopupUserObjectCollection PopupUsers
        {
            get{ return _popupusers;}
            set{ _popupusers = value;}
        }
       

        internal PopupObjectCollection Parent
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
            set  { _state = value; }
        }

        #endregion

        #region Methods
        public PopupObject Clone()
        {
            return this.Clone<PopupObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.PopupID == ((PopupObject)obj).PopupID)
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
        private void OnPopupObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.PopupObjectChanged(this);
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
                    _loadeddescription =this.Description;
                    _loadedrepeat = this.Repeation;
                    _loadedactive = this.Active;
                    _loadedcreationDate = this.CreationDate;
                    _loadedtime = this.Time;
                    _loadedShowDirect = this.ShowDirect;

                    //Child members
                    _loadedpopupusers = this.PopupUsers;
                    
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
                    this.Description=_loadeddescription;
                    this.Repeation =_loadedrepeat;
                    this.Active =_loadedactive;
                    this.CreationDate =_loadedcreationDate;
                    this.Time =_loadedtime;
                    this.ShowDirect = _loadedShowDirect;

                    //Child members
                    this.PopupUsers =_loadedpopupusers;
                    
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
                    _loadeddescription = this.Description;
                    _loadedrepeat = this.Repeation;
                    _loadedactive = this.Active;
                    _loadedcreationDate = this.CreationDate;
                    _loadedtime = this.Time;
                    _loadedShowDirect = this.ShowDirect;

                    //Child members
                    _loadedpopupusers = this.PopupUsers;

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

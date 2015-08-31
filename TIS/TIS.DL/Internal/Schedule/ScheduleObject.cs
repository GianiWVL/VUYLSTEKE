using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using TIS.Framework.Common;
using PROF_IT.Common;
using System.Reflection;

namespace TIS.DL.Internal.Schedule
{

    public class ScheduleObject : PROF_IT.DLM.DL.BaseObject, IEditableObject
    {
        #region Constructor
        public ScheduleObject()
        {

        }
        #endregion

        #region Constants
        public const string TABLE = "Schedule";
        public const string SCHED_ID = TABLE + "." + "schedID";
        public const string FREQUENCY = TABLE + "." + "Frequency";
        public const string MONDAY = TABLE + "." + "Monday";
        public const string TUESDAY = TABLE + "." + "Tuesday";
        public const string WEDNESDAY = TABLE + "." + "Wednesday";
        public const string THURSDAY = TABLE + "." + "Thursday";
        public const string FRIDAY = TABLE + "." + "Friday";
        public const string SATERDAY = TABLE + "." + "Saterday";
        public const string SUNDAY = TABLE + "." + "Sunday";
        public const string STARTDATE = TABLE + "." + "Startdate";
        public const string TIME = TABLE + "." + "Time";
        public const string LAST_SEND = TABLE + "." + "LastSend";
        #endregion

        #region Fields

        private Guid _schedID;
        private Enumeration.Frequency.TimeFrequency _frequency;
        private Boolean _monday = false;
        private Boolean _tuesday = false;
        private Boolean _wednesday = false;
        private Boolean _thursday = false;
        private Boolean _friday = false;
        private Boolean _saterday = false;
        private Boolean _sunday = false;
        private string _startDate = Constants.NullString;
        private string _time = Constants.NullString;
        private string _lastSend = Constants.NullString;

        private Enumeration.Frequency.TimeFrequency _loadedFrequency;
        private Boolean _loadedMonday = false;
        private Boolean _loadedTuesday = false;
        private Boolean _loadedWednesday = false;
        private Boolean _loadedThursday = false;
        private Boolean _loadedFriday = false;
        private Boolean _loadedSaterday = false;
        private Boolean _loadedSunday = false;
        private string _loadedStartdate = Constants.NullString;
        private string _loadedTime = Constants.NullString;
        private string _loadedLastSend = Constants.NullString;

        private ScheduleObjectCollection _parent;
        private Enumerations.ObjectState _state = Enumerations.ObjectState.Loaded;
        private bool inTxn = false;
        #endregion

        #region Properties

        public Guid SchedID
        {
            get { return _schedID; }
            set { _schedID = value; }
        }
        public Enumeration.Frequency.TimeFrequency Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        public Boolean Monday
        {
            get { return _monday; }
            set { _monday = value; }
        }
        public Boolean Tuesday
        {
            get { return _tuesday; }
            set { _tuesday = value; }
        }
        public Boolean Wednesday
        {
            get { return _wednesday; }
            set { _wednesday = value; }
        }
        public Boolean Thursday
        {
            get { return _thursday; }
            set { _thursday = value; }
        }
        public Boolean Friday
        {
            get { return _friday; }
            set { _friday = value; }
        }
        public Boolean Saterday
        {
            get { return _saterday; }
            set { _saterday = value; }
        }
        public Boolean Sunday
        {
            get { return _sunday; }
            set { _sunday = value; }
        }
        public string StartDate
        {
            get { return _loadedStartdate; }
            set { _loadedStartdate = value; }
        }
        public DateTime StartDateDisplay
        {
            get
            {
                if (StartDate == "")
                    return DateTime.MinValue;
                else
                    return PROF_IT.Common.Convert.DateFunctions.DBDateToDate(StartDate, false);
            }
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
        public string LastSend
        {
            get { return _lastSend; }
            set { _lastSend = value; }
        }

        internal ScheduleObjectCollection Parent
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
        public ScheduleObject Clone()
        {
            return this.Clone<ScheduleObject>(this);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this.SchedID == ((ScheduleObject)obj).SchedID)
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

        private void OnScheduleObjectChanged()
        {
            try
            {
                if (inTxn && Parent != null)
                {
                    Parent.ScheduleObjectChanged(this);
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
                    _loadedFrequency = this.Frequency;
                    _loadedMonday = this.Monday;
                    _loadedTuesday = this.Tuesday;
                    _loadedWednesday = this.Wednesday;
                    _loadedThursday = this.Thursday;
                    _loadedFriday = this.Friday;
                    _loadedSaterday = this.Saterday;
                    _loadedSunday = this.Sunday;
                    _loadedStartdate = this.StartDate;
                    _loadedTime = this.Time;
                    _loadedLastSend = this.LastSend;

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
                    this.Frequency = _loadedFrequency;
                    this.Monday = _loadedMonday;
                    this.Tuesday = _loadedTuesday;
                    this.Wednesday = _loadedWednesday;
                    this.Thursday = _loadedThursday;
                    this.Friday = _loadedFriday;
                    this.Saterday = _loadedSaterday;
                    this.Sunday = _loadedSunday;
                    this.StartDate = _loadedStartdate;
                    this.Time = _loadedTime;
                    this.LastSend = _lastSend;
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
                    _loadedFrequency = this.Frequency;
                    _loadedMonday = this.Monday;
                    _loadedTuesday = this.Tuesday;
                    _loadedWednesday = this.Wednesday;
                    _loadedThursday = this.Thursday;
                    _loadedFriday = this.Friday;
                    _loadedSaterday = this.Saterday;
                    _loadedSunday = this.Sunday;
                    _loadedStartdate = this.StartDate;
                    _loadedTime = this.Time;
                    _lastSend = this.LastSend;
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

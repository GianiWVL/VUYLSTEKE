using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using PROF_IT.Common.Data;
using PROF_IT.Common;

namespace TIS.DL.External.TAS.TurnOver
{
    public class TurnOverObject : PROF_IT.DLM.DL.BaseObject
    {
        #region Constructor
        public TurnOverObject()
        {

        }
        #endregion

        #region Constants
        public const string TNR_ID =  "TNR_ID";
        public const string YEAR =  "year";
        public const string MONTH =  "month";
        public const string DATE = "Date";
        public const string VEHICLE = "Vehicle";
        public const string TURNOVER =  "turnover";
        #endregion

        #region Fields
        private int _tnrID = Constants.NullInt;
        private int _year = Constants.NullInt;
        private int _month = Constants.NullInt;
        private string _date = Constants.NullString;
        private string _vehicle = Constants.NullString;
        private decimal _turnOver = Constants.NullDecimal;

        private TurnOverObjectCollection _parent;
        #endregion

        #region Properties

        public int TnrID
        {
            get { return _tnrID ; }
            set { _tnrID = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }

        public decimal TurnOver
        {
            get { return _turnOver; }
            set { _turnOver = value; }
        }

        public DateTime YearMonth
        {
            get
            {
                return new DateTime(Year, Month, 1);
            }
        }

        internal TurnOverObjectCollection Parent
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

        #endregion


    }
}

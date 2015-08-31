using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace TIS.Model.Internal
{
    public class Absence : XPCustomObject
    {
        #region Constructors
        public Absence(Session session): base(session)
        {
        }
        public Absence(): base(Session.DefaultSession)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        #endregion

        #region Fields
        private Int64 _fId;
        private Int64 _planningId;
        private Guid _fDriverID;
        private String _fDriverName;
        private String _fReason;
        private DateTime _fDate;
        #endregion

        #region Properties

        [Key(true)]
        public long Id
        {
            get { return this._fId; }
            set { SetPropertyValue("Id", ref this._fId, value); }
        }

        public Int64 Planning
        {
            get { return _planningId; }
            set { SetPropertyValue<Int64>("Planning", ref _planningId, value); }
        }

        public Guid DriverId
        {
            get { return this._fDriverID; }
            set { SetPropertyValue("DriverId", ref this._fDriverID, value); }
        }

        public String DriverName
        {
            get { return this._fDriverName; }
            set { SetPropertyValue("DriverName", ref this._fDriverName, value); }
        }
        public String Reason
        {
            get { return this._fReason; }
            set { SetPropertyValue("Reason", ref this._fReason, value); }
        }
        public DateTime Date
        {
            get { return this._fDate; }
            set { SetPropertyValue("Date", ref this._fDate, value); }
        }
        #endregion

        #region Methods
        public List<Absence> GetAll(Int64 planningId, DateTime date)
        {
            try
            {
                List<Absence> result = new List<Absence>();

                result = new XPCollection<Absence>(this.Session).Where(x => x.Planning == planningId).ToList();
                result = result.Where(x => x.Date == date).ToList();

                return result;
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
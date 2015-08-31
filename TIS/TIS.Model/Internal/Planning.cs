using System;
using System.Linq;
using System.Reflection;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace TIS.Model.Internal
{
    public class Planning : XPCustomObject
    {
        #region Constructors

        public Planning(Session session) : base(session)
        {
        }

        public Planning() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #endregion

        #region Fields
        private Int64 _fId;
        private Guid _fDispatcher;
        private Guid _fReplacingDispatcher;
        #endregion

        #region Properties

        [Key(true)]
        public long Id
        {
            get { return this._fId; }
            set { SetPropertyValue("Id", ref this._fId, value); }
        }

        public Guid Dispatcher
        {
            get { return this._fDispatcher; }
            set { SetPropertyValue("Id", ref this._fDispatcher, value); }
        }

        public Guid ReplacingDispatcher
        {
            get { return this._fReplacingDispatcher; }
            set { SetPropertyValue("Id", ref this._fReplacingDispatcher, value); }
        }

        #endregion

        #region Methods

        public Planning GetPlanning(Guid dispatcher)
        {
            var planning = new XPCollection<Planning>(this.Session);
            var result = (from Planning plan in planning
                where plan.Dispatcher == dispatcher
                select plan).ToList();

            if (result.Count > 0)
                return result[0];

            return null;
        }
        #endregion
    }
}
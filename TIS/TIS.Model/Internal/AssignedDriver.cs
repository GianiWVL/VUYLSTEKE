using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DevExpress.Xpo;

namespace TIS.Model.Internal
{
    public class AssignedDriver : XPCustomObject
    {
        #region Constructors
        public AssignedDriver(Session session) : base(session) { }
        public AssignedDriver() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        #endregion

        #region Fields
        private Int64 _fId;
        private Int64 _fPlanning;
        private Guid _fDriver;
        private String _fDrivername;

        #endregion

        #region Properties
        [Key(true)]
        public Int64 Id
        {
            get { return _fId; }
            set { SetPropertyValue<Int64>("Id", ref _fId, value); }
        }

        public Int64 Planning
        {
            get { return _fPlanning; }
            set { SetPropertyValue<Int64>("PlanningId", ref _fPlanning, value); }
        }

        public Guid Driver
        {
            get { return _fDriver; }
            set { SetPropertyValue<Guid>("Id", ref _fDriver, value); }
        }

        public String DriverName
        {
            get { return _fDrivername; }
            set { SetPropertyValue<String>("Id", ref _fDrivername, value); }
        }


        #endregion

        #region Methods
        public List<AssignedDriver> GetAll()
        {
            try
            {
                List<AssignedDriver> result = new List<AssignedDriver>();
                result = new XPCollection<AssignedDriver>(Session).ToList();

                return result;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public List<AssignedDriver> GetAll(Int64 planning)
        {
            try
            {
                List<AssignedDriver> result = new XPCollection<AssignedDriver>(Session).ToList().Where(x => x.Planning == planning).ToList();
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

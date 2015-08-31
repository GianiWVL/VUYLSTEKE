using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DevExpress.Xpo;

namespace TIS.Model.Internal
{
    public class AssignedVehicle : XPCustomObject
    {
        #region Constructors
        public AssignedVehicle(Session session) : base(session) { }
        public AssignedVehicle() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        #endregion

        #region Fields
        private Int64 _fId;
        private Int64 _fPlanning;
        private Guid _fTruck;
        private String _fTruckName;

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

        public Guid Truck
        {
            get { return _fTruck; }
            set { SetPropertyValue<Guid>("Id", ref _fTruck, value); }
        }

        public String TruckName
        {
            get { return _fTruckName; }
            set { SetPropertyValue<String>("Id", ref _fTruckName, value); }
        }
        
        
        #endregion

        #region Methods
        public List<AssignedVehicle> GetAll()
        {
            try
            {
                List<AssignedVehicle> result = new List<AssignedVehicle>();
                result = new XPCollection<AssignedVehicle>(Session).ToList();

                return result;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public List<AssignedVehicle> GetAll(Int64 planning)
        {
            try
            {
                List<AssignedVehicle> result = new XPCollection<AssignedVehicle>(Session).ToList().Where(x => x.Planning == planning).ToList();
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

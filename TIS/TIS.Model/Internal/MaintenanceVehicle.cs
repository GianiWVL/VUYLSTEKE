using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class MaintenanceVehicle
    {
        public MaintenanceVehicle(Session session) : base(session) { }
        public MaintenanceVehicle() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

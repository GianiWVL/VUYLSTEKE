using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class VehicleType
    {
        public VehicleType(Session session) : base(session) { }
        public VehicleType() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class VehicleTransicsLink
    {
        public VehicleTransicsLink(Session session) : base(session) { }
        public VehicleTransicsLink() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

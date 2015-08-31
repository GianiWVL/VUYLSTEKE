using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class ParameterSystem
    {
        public ParameterSystem(Session session) : base(session) { }
        public ParameterSystem() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

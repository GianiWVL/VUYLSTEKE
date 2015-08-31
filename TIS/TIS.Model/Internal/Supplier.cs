using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class Supplier
    {
        public Supplier(Session session) : base(session) { }
        public Supplier() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


    }

}

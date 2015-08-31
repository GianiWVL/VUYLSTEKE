using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIS.Model.Internal
{
    public partial class Tire : XPCustomObject
    {
        public Tire(Session session) : base(session) { }
        public Tire() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        Int64 fID;
        [Key(true)]
        public Int64 Id
        {
            get { return fID; }
            set { SetPropertyValue<Int64>("Id", ref fID, value); }
        }


        Int64 fRadius;
        public Int64 Radius
        {
            get { return fRadius; }
            set { SetPropertyValue<Int64>("Radius", ref fRadius, value); }
        }
        
    }
}

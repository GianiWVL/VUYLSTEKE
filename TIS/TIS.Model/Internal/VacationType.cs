using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIS.Model.Internal
{
    public partial class VacationType : XPCustomObject
    {
        public VacationType(Session session) : base(session) { }
        public VacationType() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        Int64 fID;
        [Key(true)]
        public Int64 Id
        {
            get { return fID; }
            set { SetPropertyValue<Int64>("Id", ref fID, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
    }
}

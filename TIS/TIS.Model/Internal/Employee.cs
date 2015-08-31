using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class Employee
    {
        public Employee(Session session) : base(session) { }
        public Employee() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [NonPersistent]
        public string DisplayName
        {
            get { return Surname + " " + Name; }
        }
    }

}

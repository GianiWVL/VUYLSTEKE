using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace TIS.Model.Internal
{

    public partial class TaskPeople
    {
        public TaskPeople(Session session) : base(session) { }
        public TaskPeople() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

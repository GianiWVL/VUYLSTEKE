using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections.Generic;
namespace TIS.Model.Internal
{

    public partial class Vacation : XPCustomObject
    {
        public Vacation(Session session) : base(session) { }
        public Vacation() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        Int64 fID;
        [Key(true)]
        public Int64 Id
        {
            get { return fID; }
            set { SetPropertyValue<Int64>("Id", ref fID, value); }
        }

        VacationType fVacationType;
        public VacationType VacationType
        {
            get { return fVacationType; }
            set { SetPropertyValue<VacationType>("VacationType", ref fVacationType, value); }
        }
        Employee fEmployee;
        public Employee Employee
        {
            get { return fEmployee; }
            set { SetPropertyValue<Employee>("Employee", ref fEmployee, value); }
        }

        Employee fDispatcher;
        public Employee Dispatcher
        {
            get { return fDispatcher; }
            set { SetPropertyValue<Employee>("Dispatcher", ref fDispatcher, value); }
        }


        DateTime fDateFrom;
        public DateTime DateFrom
        {
            get { return fDateFrom; }
            set { SetPropertyValue<DateTime>("DateFrom", ref fDateFrom, value); }
        }
        DateTime fDateTo;
        public DateTime DateTo
        {
            get { return fDateTo; }
            set { SetPropertyValue<DateTime>("DateTo", ref fDateTo, value); }
        }
        DateTime fTimeTo;
        public DateTime TimeTo
        {
            get { return fTimeTo; }
            set { SetPropertyValue<DateTime>("TimeTo", ref fTimeTo, value); }
        }
        DateTime fTimeFrom;
        public DateTime TimeFrom
        {
            get { return fTimeFrom; }
            set { SetPropertyValue<DateTime>("TimeFrom", ref fTimeFrom, value); }
        }
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }

        public void Add(Vacation vac)
        {
            try
            {
                //Vacation vacation = new Vacation(Session);
                //vacation.Employee = vac.Employee;
                //vacation.Dispatcher = vac.Dispatcher;
                //vacation.Date = vac.Date;

                Session.Save(vac);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public XPCollection<Vacation> GetAll()
        {
            try
            {
                XPCollection<Vacation> vacations = new XPCollection<Vacation>(Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", DevExpress.Xpo.DB.SortingDirection.Ascending));
                vacations.Sorting = sc;
                return vacations;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public XPCollection<Vacation> GetByDispatcher(Employee dispatcher)
        {
            try
            {
                XPCollection<Vacation> vacations = new XPCollection<Vacation>(Session, Dispatcher.empID == dispatcher.empID);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", DevExpress.Xpo.DB.SortingDirection.Ascending));
                vacations.Sorting = sc;
                return vacations;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, ex);
            }
        }
        public XPCollection<Vacation> GetByDate(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                XPCollection<Vacation> vacations = new XPCollection<Vacation>(Session, DateFrom.Date >= dateFrom.Date && DateTo.Date <= dateTo.Date);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", DevExpress.Xpo.DB.SortingDirection.Ascending));
                vacations.Sorting = sc;
                return vacations;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, ex);
            }
        }
        public XPCollection<Vacation> GetAllAlphabetical()
        {
            try
            {
                XPCollection<Vacation> vacations = new XPCollection<Vacation>(Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Employee.Name", DevExpress.Xpo.DB.SortingDirection.Ascending));
                vacations.Sorting = sc;
                return vacations;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, ex);
            }
        }
        public XPCollection<Vacation> GetAllChronological()
        {
            try
            {
                XPCollection<Vacation> vacations = new XPCollection<Vacation>(Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Date", DevExpress.Xpo.DB.SortingDirection.Ascending));
                vacations.Sorting = sc;
                return vacations;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, ex);
            }
        }
    }

}

using System;
using System.Reflection;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace TIS.Model.Internal
{
    public class Job : XPCustomObject
    {
        #region Constructors

        public Job(Session session) : base(session)
        {
        }

        public Job() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #endregion

        #region Fields

        private long _fId;
        private long _fPlanning;
        //private Guid _fDispatcher;
        private string _fTruck;
        private string _fDriver;
        private string _fLoad;
        private string _fComment;
        private bool _fFileOk;
        private bool _fNotified;
        private DateTime _fJobDate;

        #endregion

        #region Properties

        [Key(true)]
        public long Id
        {
            get { return this._fId; }
            set { SetPropertyValue("Id", ref this._fId, value); }
        }

        public long Planning
        {
            get { return this._fPlanning; }
            set { SetPropertyValue("Planning", ref this._fPlanning, value); }
        }

        //public Guid Dispatcher
        //{
            //get { return this._fDispatcher; }
            //set { SetPropertyValue("Dispatcher", ref this._fDispatcher, value); }
        //}

        public string Truck
        {
            get { return this._fTruck; }
            set { SetPropertyValue("Truck", ref this._fTruck, value); }
        }

        public string Driver
        {
            get { return this._fDriver; }
            set { SetPropertyValue("Driver", ref this._fDriver, value); }
        }

        public string Load
        {
            get { return this._fLoad; }
            set { SetPropertyValue("Load", ref this._fLoad, value); }
        }

        public string Comment
        {
            get { return this._fComment; }
            set { SetPropertyValue("Comment", ref this._fComment, value); }
        }

        public bool FileOk
        {
            get { return this._fFileOk; }
            set { SetPropertyValue("FileOK", ref this._fFileOk, value); }
        }

        public bool Notified
        {
            get { return this._fNotified; }
            set { SetPropertyValue("Notified", ref this._fNotified, value); }
        }

        public DateTime JobDate
        {
            get { return this._fJobDate; }
            set { SetPropertyValue("JobDate", ref this._fJobDate, value); }
        }

        #endregion

        #region Methods

        public XPCollection<Job> GetAll()
        {
            try
            {
                //List<Job> jobs = new XPCollection<Job>(Session).OrderBy(bc => bc.Id).ToList();

                var jobs = new XPCollection<Job>(this.Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", SortingDirection.Ascending));
                jobs.Sorting = sc;
                return jobs;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public XPCollection<Job> GetAll(Int64 planningId, DateTime date)
        {
            try
            {
                //List<Job> jobs = new XPCollection<Job>(Session).OrderBy(bc => bc.Id).ToList();
                //TODO: Find better fix

                var jobs = new XPCollection<Job>(this.Session);
                var jobsTwo = new XPCollection<Job>(this.Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", SortingDirection.Ascending));
                jobs.Sorting = sc;

                foreach (Job job in jobs)
                {
                    if (job.Planning != planningId || job.JobDate.Date != date.Date)
                        jobsTwo.Remove(job);
                }

                return jobsTwo;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion
    }
}
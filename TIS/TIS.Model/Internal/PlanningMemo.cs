using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DevExpress.Xpo;

namespace TIS.Model.Internal
{
    public partial class PlanningMemo: XPBaseObject 
    {
        #region Constructors
        public PlanningMemo(Session session) : base(session) { }
        public PlanningMemo() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        #endregion

        #region Fields
        private Int64 _fId;
        private Int64 _fPlanning;
        private DateTime _fPlanningMemoDate;
        private string _fPlanningMemoComment;
        #endregion

        #region Properties
        [Key(true)]
        public Int64 Id
        {
            get { return _fId; }
            set { SetPropertyValue<Int64>("Id", ref _fId, value); }
        }

        public Int64 Planning
        {
            get { return _fPlanning; }
            set { SetPropertyValue<Int64>("Planning", ref _fPlanning, value); }
        }
        
        public DateTime PlanningMemoDate
        {
            get { return _fPlanningMemoDate; }
            set { SetPropertyValue("PlanningMemoDate", ref _fPlanningMemoDate, value); }
        }
        
        public String PlanningMemoComment
        {
            get { return _fPlanningMemoComment; }
            set { SetPropertyValue("PlanningMemoComment", ref _fPlanningMemoComment, value); }
        }
        #endregion

        #region Methods
        public XPCollection<PlanningMemo> GetAll()
        {
            try
            {
                XPCollection<PlanningMemo> planningMemos = new XPCollection<PlanningMemo>(Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", DevExpress.Xpo.DB.SortingDirection.Ascending));
                planningMemos.Sorting = sc;
                return planningMemos;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public XPCollection<PlanningMemo> GetAll(Int64 planningId, DateTime date)
        {
            try
            {
                XPCollection<PlanningMemo> planningMemos = new XPCollection<PlanningMemo>(Session);
                XPCollection<PlanningMemo> planningMemosTwo = new XPCollection<PlanningMemo>(Session);
                SortingCollection sc = new SortingCollection();
                sc.Add(new SortProperty("Id", DevExpress.Xpo.DB.SortingDirection.Ascending));
                planningMemos.Sorting = sc;

                foreach (PlanningMemo memo in planningMemos)
                {
                    if (memo.Planning != planningId || memo.PlanningMemoDate.Date != date.Date)
                        planningMemosTwo.Remove(memo);
                }

                return planningMemosTwo;
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
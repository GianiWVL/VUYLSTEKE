using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using PROF_IT.Exceptionhandling;
using TIS.Client.General;
using TIS.DL.Internal.User;
using TIS.Framework.Security;
using TIS.Model.Internal;
using User = TIS.BL.Internal.User;

namespace TIS.Client.Planning
{
    public partial class Planning : BaseChildForm
    {
        #region Constructor
        public Planning()
        {
            InitializeComponent();
            this.Uow = new UnitOfWork();
        }
        #endregion

        #region fields
        private Model.Internal.Planning _planning;
        #endregion

        #region Events
        private void Planning_Load(object sender, EventArgs e)
        {
            FillCboDispatcher();
            GetPlanning();

            this.dateDate.DateTime = DateTime.Today;
        }
        private void cboDispatcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPlanning();
            CheckOwnership();
            FindAllJobs();
            FindAllMemos();
            FindAllAbsences();
        }
        private void dateDate_EditValueChanged(object sender, EventArgs e)
        {
            CheckOwnership();
            FindAllJobs();
            FindAllMemos();
            FindAllAbsences();
        }
        private void btnAssigningVehicles_Click(object sender, EventArgs e)
        {
            VehicleAssignment vehicleAssignment = new VehicleAssignment();
            vehicleAssignment.ShowDialog();
        }
        private void btnReplacement_Click(object sender, EventArgs e)
        {
            Replacement replacement = new Replacement(this._planning);
            replacement.ShowDialog();
        }

        #region Jobs
        private void btnNewJob_Click(object sender, EventArgs e)
        {
            JobDetail newJob = new JobDetail(this._planning);
            newJob.ShowDialog();

            if (newJob.DialogResult == DialogResult.OK)
            FindAllJobs();
        }
        private void btnEditJob_Click(object sender, EventArgs e)
        {
            Job job = (Job) this.gridviewPlanning.GetRow(this.gridviewPlanning.FocusedRowHandle);

            if (job == null)
                return;

            JobDetail editJob = new JobDetail(this._planning, job);
            editJob.ShowDialog();

            if (editJob.DialogResult == DialogResult.OK)
            FindAllJobs();
        }
        private void btnRemoveJob_Click(object sender, EventArgs e)
        {
            this.Uow = new UnitOfWork();

            Job job = (Job) this.gridviewPlanning.GetRow(this.gridviewPlanning.FocusedRowHandle);

            if (job == null)
                return;

            job = new XPQuery<Job>(this.Uow).FirstOrDefault(q => q.Id == job.Id);

            if (XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat u deze job wilt verwijderen?", "Verwijderen?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                job.Delete();
                this.Uow.CommitChanges();
                FindAllJobs();
            }
        }
        private void gridviewPlanning_DoubleClick(object sender, EventArgs e)
        {
            //Todo: check if mouse is on a row
            if (((ComboBoxItem) this.cboDispatcher.SelectedItem).Value.UsrID != Context.User.UsrID)
                return;

            try
            {
                Job job = (Job) this.gridviewPlanning.GetRow(this.gridviewPlanning.FocusedRowHandle);
                if (job == null)
                    return;

                JobDetail jobDetail = new JobDetail(this._planning, job);
                jobDetail.ShowDialog();

                if (jobDetail.DialogResult == DialogResult.OK)
                FindAllJobs();
            }
            catch (Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Memos
        private void btnNewMemo_Click(object sender, EventArgs e)
        {
            MemoDetail memo = new MemoDetail(this._planning);
            memo.ShowDialog();

            if (memo.DialogResult == DialogResult.OK)
            FindAllMemos();
        }
        private void btnEditMemo_Click(object sender, EventArgs e)
        {
            PlanningMemo memo = (PlanningMemo) this.gridvMemo.GetRow(this.gridvMemo.FocusedRowHandle);

            if (memo == null)
                return;

            MemoDetail editMemo = new MemoDetail(memo);
            editMemo.ShowDialog();

            if (editMemo.DialogResult == DialogResult.OK)
                FindAllMemos();
        }
        private void btnDeleteMemo_Click(object sender, EventArgs e)
        {
            this.Uow = new UnitOfWork();
            PlanningMemo memo = (PlanningMemo) this.gridvMemo.GetRow(this.gridvMemo.FocusedRowHandle);

            if (memo == null)
                return;

            memo = new XPQuery<PlanningMemo>(this.Uow).FirstOrDefault(q => q.Id == memo.Id);

            if (memo == null)
                return;
            if (XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat u deze memo wilt verwijderen?", "Verwijderen?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                memo.Delete();
                this.Uow.CommitChanges();
                FindAllMemos();
            }
        }
        private void gridvMemo_DoubleClick(object sender, EventArgs e)
        {
            //Todo: check if mouse is on a row
            if (((ComboBoxItem) this.cboDispatcher.SelectedItem).Value.UsrID != Context.User.UsrID)
                return;

            try
            {
                PlanningMemo memo = (PlanningMemo) this.gridvMemo.GetRow(this.gridvMemo.FocusedRowHandle);
                if (memo == null)
                    return;

                MemoDetail MemoDetail = new MemoDetail(memo);
                MemoDetail.ShowDialog();

                if(MemoDetail.DialogResult == DialogResult.OK)
                    FindAllJobs();
            }
            catch (Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Absences
        private void btnNewAbsent_Click(object sender, EventArgs e)
        {
            AbsentDetail absentDetail = new AbsentDetail(this._planning);
            absentDetail.ShowDialog();
            if (absentDetail.DialogResult == DialogResult.OK)
                FindAllAbsences();
        }
        private void btnEditAbsence_Click(object sender, EventArgs e)
        {
            Absence absence = (Absence)this.gridvAbsent.GetRow(this.gridvAbsent.FocusedRowHandle);

            if (absence == null)
                return;

            AbsentDetail editAbsence = new AbsentDetail(this._planning, absence);
            editAbsence.ShowDialog();

            if (editAbsence.DialogResult == DialogResult.OK)
                FindAllAbsences();
        }
        private void btnRemoveAbsence_Click(object sender, EventArgs e)
        {
            this.Uow = new UnitOfWork();

            Absence absence = (Absence)this.gridvAbsent.GetRow(this.gridvAbsent.FocusedRowHandle);

            if (absence == null)
                return;

            absence = new XPQuery<Absence>(this.Uow).FirstOrDefault(q => q.Id == absence.Id);

            if (XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat u deze afwezigheid wilt verwijderen?", "Verwijderen?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                absence.Delete();
                this.Uow.CommitChanges();
                FindAllAbsences();
            }
        }
        private void gridvAbsent_DoubleClick(object sender, EventArgs e)
        {
            if (((ComboBoxItem)this.cboDispatcher.SelectedItem).Value.UsrID != Context.User.UsrID)
                return;

            //TODO: check if mouse is on row
            Absence absence = (Absence)this.gridvAbsent.GetRow(this.gridvAbsent.FocusedRowHandle);

            if (absence == null)
                return;

            AbsentDetail editAbsence = new AbsentDetail(this._planning, absence);
            editAbsence.ShowDialog();

            if (editAbsence.DialogResult == DialogResult.OK)
                FindAllAbsences();
        }
        #endregion

        #endregion

        #region Methods
        private void FindAllJobs()
        {

            if (this._planning == null)
                     return;

            try
            {
                this.Uow = new UnitOfWork();
                this.gridctrlPlanning.DataSource = null;
                this.gridctrlPlanning.DataSource = new Job(this.Uow).GetAll(this._planning.Id, this.dateDate.DateTime.Date);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void FindAllMemos()
        {

            if (this._planning == null)
                return;

            try
            {
                this.Uow = new UnitOfWork();
                this.gridctrlMemo.DataSource = null;
                this.gridctrlMemo.DataSource = new PlanningMemo(this.Uow).GetAll(this._planning.Id,this.dateDate.DateTime.Date);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void FillCboDispatcher()
        {
            //TODO: Re-check this
            UserObjectCollection users = new User().GetAll();
            foreach (UserObject user in users)
            {
                if(user.Security.Planning != null)
                    if (Functions.AllowMaintain(user.Security.Planning.AuthPlanning))
                    {
                        ComboBoxItem item = new ComboBoxItem { Value = user };
                        this.cboDispatcher.Items.Add(item);
                    }

                if (user.UsrID == Context.User.UsrID)
                    this.cboDispatcher.SelectedIndex = this.cboDispatcher.Items.Count - 1;
            }
        }
        private void CheckOwnership()
        {
            if ((Context.User.UsrID != this._planning.Dispatcher ||
                !Functions.AllowMaintain(Context.User.Security.Planning.AuthPlanning)) &&
                (Context.User.UsrID != this._planning.ReplacingDispatcher || 
                !Functions.AllowMaintain(Context.User.Security.Planning.AuthPlanning)))
            {
                this.btnNewJob.Enabled = false;
                this.btnEditJob.Enabled = false;
                this.btnRemoveJob.Enabled = false;

                this.btnNewMemo.Enabled = false;
                this.btnEditMemo.Enabled = false;
                this.btnDeleteMemo.Enabled = false;

                this.btnNewAbsent.Enabled = false;
                this.btnEditAbsence.Enabled = false;
                this.btnRemoveAbsence.Enabled = false;
            }
            else
            {
                this.btnNewJob.Enabled = true;
                this.btnEditJob.Enabled = true;

                this.btnRemoveJob.Enabled = Functions.AllowDelete(Context.User.Security.Planning.AuthPlanning);

                this.btnNewMemo.Enabled = true;
                this.btnEditMemo.Enabled = true;
                this.btnDeleteMemo.Enabled = true;

                this.btnNewAbsent.Enabled = true;
                this.btnEditAbsence.Enabled = true;
                this.btnRemoveAbsence.Enabled = true;
            }

            //TODO: Add special permission to maintain when someone is absent unforseen
            if ((Context.User.UsrID != this._planning.Dispatcher ||
                 !Functions.AllowMaintain(Context.User.Security.Planning.AuthPlanning)))
            {
                btnReplacement.Enabled = false;
            }
            else
            {
                btnReplacement.Enabled = true;
            }
            this.btnAssigningVehicles.Enabled = Functions.AllowMaintain(Context.User.Security.Planning.AuthAssignmentTrucks);

        }
        private void GetPlanning()
        {
            if ((new TIS.Model.Internal.Planning(this.Uow).GetPlanning(((ComboBoxItem)this.cboDispatcher.SelectedItem).Value.UsrID)) == null)
            {
                this.Uow = new UnitOfWork();
                this._planning = new Model.Internal.Planning(this.Uow);
                this._planning.Dispatcher = ((ComboBoxItem)this.cboDispatcher.SelectedItem).Value.UsrID;
                this.Uow.CommitChanges();
            }
            else
            {
                this._planning = new TIS.Model.Internal.Planning(this.Uow).GetPlanning(((ComboBoxItem)this.cboDispatcher.SelectedItem).Value.UsrID);
            }
        }
        private void FindAllAbsences()
        {
            if (this._planning == null)
                return;

            try
            {
                this.Uow = new UnitOfWork();
                this.gridCoAbsent.DataSource = null;
                this.gridCoAbsent.DataSource = new Absence(this.Uow).GetAll(this._planning.Id, this.dateDate.DateTime.Date);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        private void btnAssignDrivers_Click(object sender, EventArgs e)
        {
            DriverAssignment driverAssignment = new DriverAssignment();
            driverAssignment.ShowDialog();
        }
    }
}
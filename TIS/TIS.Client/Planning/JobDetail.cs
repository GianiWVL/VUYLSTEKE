using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.DL.Internal.Employee;
using TIS.Model.Internal;

namespace TIS.Client.Planning
{
    public partial class JobDetail : XtraForm
    {
        #region Constructors

        public JobDetail(Model.Internal.Planning planning)
        {
            InitializeComponent();

            this._uow = new UnitOfWork();
            this._job = new Job(this._uow);
            this._planning = planning;
            this._planningId = this._planning.Id;
            this.dteJobDate.DateTime = DateTime.Now;

            FillComboboxes();
        }

        public JobDetail(Model.Internal.Planning planning, Job job)
        {
            InitializeComponent();

            this._uow = new UnitOfWork();
            this._job = new XPQuery<Job>(this._uow).FirstOrDefault(q => q.Id == job.Id);
            this._planningId = this._job.Planning;
            this._planning = planning;

            FillComboboxes();
            FillDetails();

            this.dteJobDate.DateTime = DateTime.Now;
        }

        #endregion

        #region Fields

        private UnitOfWork _uow;
        private Job _job;
        private long _planningId;
        private Model.Internal.Planning _planning;

        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._job.Truck = this.cboTrucks.SelectedItem.ToString();
            this._job.Driver = this.cboDriver.SelectedItem.ToString();
            this._job.Load = this.txtLoad.Text;
            this._job.Comment = this.txtComment.Text;
            this._job.FileOk = this.chkFile.Checked;
            this._job.Notified = this.chkNotified.Checked;
            this._job.JobDate = this.dteJobDate.DateTime.Date;
            this._job.Planning = this._planningId;
            this._uow.CommitChanges();

            this.DialogResult = DialogResult.OK;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dteJobDate_EditValueChanged(object sender, EventArgs e)
        {
            FillComboboxes();
        }

        private void cboTrucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValidForm();
        }

        private void cboDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValidForm();
        }

        #endregion

        #region Methods

        private void FillComboboxes()
        {
            this.cboTrucks.Items.Clear();
            this.cboDriver.Items.Clear();
            FillCboDrivers();
            FillCboTrucks();
        }

        private void FillCboDrivers()
        {
            var absences = new Absence(new UnitOfWork()).GetAll(this._planningId, this.dteJobDate.DateTime.Date);
            var jobs = new Job(new UnitOfWork()).GetAll(this._planningId, this.dteJobDate.DateTime.Date);
            List<AssignedDriver> assignedDrivers = new AssignedDriver(new UnitOfWork()).GetAll(this._planningId);

            if (this._job.Driver != null)
            {
                this.cboDriver.Items.Add(this._job.Driver);
                this.cboDriver.SelectedIndex = 0;
            }

            foreach (Absence absence in absences)
            {
                var result = assignedDrivers.Where(x => x.DriverName.Equals(absence.DriverName));

                if (result.ToList()[0] != null)
                    assignedDrivers.Remove(result.ToList()[0]);
            }

            foreach (Job job in jobs)
            {
                var result = assignedDrivers.Where(x => x.DriverName == job.Driver);
                assignedDrivers.Remove(result.ToList()[0]);
            }

            foreach (AssignedDriver assignedDriver in assignedDrivers)
            {
                this.cboDriver.Items.Add(assignedDriver.DriverName);
                if (assignedDriver.DriverName == this._job.Driver)
                    this.cboDriver.SelectedIndex = this.cboDriver.Items.Count - 1;
            }
        }

        private void FillCboTrucks()
        {
            if (this._job.Truck != null)
            {
                this.cboTrucks.Items.Add(this._job.Truck);
                this.cboTrucks.SelectedIndex = 0;
            }

            var assignedVehicles = new AssignedVehicle(new UnitOfWork()).GetAll(this._planningId);
            var jobs = new Job(new UnitOfWork()).GetAll(this._planningId, this.dteJobDate.DateTime.Date);

            foreach (Job job in jobs)
            {
                var result = assignedVehicles.Where(x => x.TruckName == job.Truck);
                assignedVehicles.Remove(result.ToList()[0]);
            }

            foreach (AssignedVehicle assignedVehicle in assignedVehicles)
            {
                //TODO: Wat moet getoond worden?
                this.cboTrucks.Items.Add(assignedVehicle.TruckName);
                if (assignedVehicle.TruckName == this._job.Truck)
                    this.cboTrucks.SelectedIndex = this.cboTrucks.Items.Count - 1;
            }
        }

        private void FillDetails()
        {
            this.cboTrucks.SelectedItem = this._job.Truck;
            this.cboDriver.SelectedItem = this._job.Driver;
            this.txtLoad.Text = this._job.Load;
            this.txtComment.Text = this._job.Comment;
            this.chkFile.Checked = this._job.FileOk;
            this.chkNotified.Checked = this._job.Notified;
            this.dteJobDate.DateTime = this._job.JobDate;
        }

        private void CheckValidForm()
        {
            if (this.cboTrucks.SelectedItem == null || this.cboDriver.SelectedItem == null)
            {
                this.btnSave.Enabled = false;
            }
            else
            {
                this.btnSave.Enabled = true;
            }
        }

        #endregion
    }
}
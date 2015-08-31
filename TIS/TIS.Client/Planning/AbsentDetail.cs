using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Data.Helpers;
using DevExpress.Data.WcfLinq.Helpers;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.DL.Internal.Employee;
using TIS.Model.Internal;

namespace TIS.Client.Planning
{
    //TODO: Wat gebeuren wanneer een chauffeur ingepland is terwijl hij op afwezig staat
    public partial class AbsentDetail : XtraForm
    {
        #region Constructors
        public AbsentDetail(Model.Internal.Planning planning)
        {
            InitializeComponent();

            this._uow = new UnitOfWork();
            this._absence = new Absence(this._uow);
            this._planning = planning;
            this._planningId = this._planning.Id;

            FillCboDrivers();
            this.dteDate.DateTime = DateTime.Today.Date;
        }
        public AbsentDetail(Model.Internal.Planning planning, Absence absence)
        {
            InitializeComponent();

            this._uow = new UnitOfWork();
            this._absence = new XPQuery<Absence>(this._uow).FirstOrDefault(q => q.Id == absence.Id);
            this._planning = planning;
            this._planningId = this._planning.Id;

            FillDetails();

            FillCboDrivers();
            this.dteDate.DateTime = DateTime.Today.Date;
        }
        #endregion

        #region Fields
        private Absence _absence;
        private Model.Internal.Planning _planning;
        private long _planningId;
        private UnitOfWork _uow;
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cboDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValidForm();
        }
        private void rdbWerkloos_CheckedChanged(object sender, EventArgs e)
        {
            CheckValidForm();
        }
        private void rdbVerlof_CheckedChanged(object sender, EventArgs e)
        {
            CheckValidForm();
        }
        private void rdbZiek_CheckedChanged(object sender, EventArgs e)
        {
            CheckValidForm();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this._absence.DriverName = this.cboDrivers.SelectedItem.ToString();

            if (this.rdbWerkloos.Checked)
                this._absence.Reason = "Werkloos";
            if (this.rdbVerlof.Checked)
                this._absence.Reason = "Verlof";
            if (this.rdbZiek.Checked)
                this._absence.Reason = "Ziek";

            this._absence.Date = this.dteDate.DateTime.Date;
            this._absence.Planning = this._planningId;

            this._uow.CommitChanges();
            this.DialogResult = DialogResult.OK;

            Close();
        }
        private void dteDate_EditValueChanged(object sender, EventArgs e)
        {
            FillCboDrivers();
        }
        #endregion

        #region Methods
        private void FillDetails()
        {
            if (this._absence.Reason.Equals("Verlof"))
                this.rdbVerlof.Checked = true;
            if (this._absence.Reason.Equals("Ziek"))
                this.rdbZiek.Checked = true;
            if (this._absence.Reason.Equals("Werkloos"))
                this.rdbWerkloos.Checked = true;

            this.dteDate.DateTime = this._absence.Date;
        }
        private void FillCboDrivers()
        {
            cboDrivers.Items.Clear();

            List<Absence> absences = new Absence(new UnitOfWork()).GetAll(this._planningId, dteDate.DateTime.Date);
            List<AssignedDriver> assignedDrivers = new AssignedDriver(new UnitOfWork()).GetAll(this._planningId);

            foreach (var absence in absences)
            {
                var result = assignedDrivers.Where(x => x.DriverName.Equals(absence.DriverName));

                if (result.ToList()[0] != null)
                    assignedDrivers.Remove(result.ToList()[0]);
            }

            foreach (AssignedDriver assignedDriver in assignedDrivers)
            {
                this.cboDrivers.Items.Add(assignedDriver.DriverName);

                if (assignedDriver.DriverName.Equals(this._absence.DriverName))
                    this.cboDrivers.SelectedIndex = this.cboDrivers.Items.Count - 1;
            }
        }
        private void CheckValidForm()
        {
            if (this.cboDrivers.SelectedItem == null ||
                (!this.rdbWerkloos.Checked && !this.rdbVerlof.Checked && !this.rdbZiek.Checked))
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
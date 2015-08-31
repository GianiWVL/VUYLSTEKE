using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.Task;
using TIS.DL.Internal.TaskPeople;
using TIS.Framework.Common;
using TIS.DL.Internal.TaskSchedule;
using DevExpress.XtraGrid.Views.Grid;
using TIS.DL.Internal.Employee;

namespace TIS.Client.Task
{
    public partial class Task : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Task.TaskObject _task;
        private TaskObject _taskOriginal;
        #endregion

        #region Constructor
        public Task(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    Initialize();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public Task(PROF_IT.Common.Enumerations.TypeForm typeForm, TaskObject task)
        {
            try
            {
                _taskOriginal = task.Clone();
                InitializeComponent();
                _task = task;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    InitializePropertyForm();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public TaskObject TaskMember
        {
            get { return _task; }
            set { _task = value; }
        }
        #endregion

        #region Events
        private void cbxAddSubscription_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxAddSubscription.Checked)
                    gpbSubscription.Enabled = true;
                else
                    gpbSubscription.Enabled = false;

            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddSubscription_Click(object sender, EventArgs e)
        {
            try
            {
                Schedule.Schedule schedule = new Schedule.Schedule(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (schedule.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TaskScheduleObject taskSchedule = new TaskScheduleObject();
                    taskSchedule.Schedule = schedule.ScheduleMember;
                    taskSchedule.Task = TaskMember;
                    taskSchedule.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                    TaskMember.Subscriptions.Add(taskSchedule);
                    gdcSubscription.DataSource = TaskMember.Subscriptions.GetActive();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddAssigneeEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee.EmployeeSearch empSearch = new Employee.EmployeeSearch();
                if (empSearch.ShowDialog() == DialogResult.OK)
                {
                    TaskPeopleObject taskPeople = new TaskPeopleObject();
                    taskPeople.Assignee = true;
                    taskPeople.Reporter = false;
                    taskPeople.Employee = empSearch.Employee;
                    taskPeople.Task = TaskMember;
                    taskPeople.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                    TaskMember.AssigneesEmployee.Add(taskPeople);
                    gdcAssigneeEmployee.DataSource = TaskMember.AssigneesEmployee.GetActive();
                }
                
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddAssigneeSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier.SupplierSearch supSearch = new Supplier.SupplierSearch();
                if (supSearch.ShowDialog() == DialogResult.OK)
                {
                    TaskPeopleObject taskPeople = new TaskPeopleObject();
                    taskPeople.Assignee = true;
                    taskPeople.Reporter = false;
                    taskPeople.Supplier = supSearch.Supplier;
                    taskPeople.Task = TaskMember;
                    taskPeople.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                    TaskMember.AssigneesSupplier.Add(taskPeople);
                    gdcAssigneeSupplier.DataSource = TaskMember.AssigneesSupplier.GetActive();
                }
                
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddAssigneeUnknown_Click(object sender, EventArgs e)
        {
            Unknown.UnknownSearch unkSearch = new Unknown.UnknownSearch();
            if (unkSearch.ShowDialog() == DialogResult.OK)
            {
                TaskPeopleObject taskPeople = new TaskPeopleObject();
                taskPeople.Assignee = true;
                taskPeople.Reporter = false;
                taskPeople.Unknown = unkSearch.Unknown;
                taskPeople.Task = TaskMember;
                taskPeople.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                TaskMember.AssigneesUnknown.Add(taskPeople);
                this.gdcAssigneeUnknown.DataSource = TaskMember.AssigneesUnknown.GetActive();
            }
        }

        private void btnRemoveAssigneeEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                TaskMember.AssigneesEmployee.GetActive()[gdvAssigneeEmployee.FocusedRowHandle].State =  PROF_IT.Common.Enumerations.ObjectState.Deleted;
                gdcAssigneeEmployee.DataSource = TaskMember.AssigneesEmployee.GetActive();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemoveAssigneeSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                TaskMember.AssigneesSupplier.GetActive()[gdvAssigneeSupplier.FocusedRowHandle].State = PROF_IT.Common.Enumerations.ObjectState.Deleted;
                gdcAssigneeSupplier.DataSource = TaskMember.AssigneesSupplier.GetActive();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemoveSubscription_Click(object sender, EventArgs e)
        {
            try
            {
                TaskMember.Subscriptions.GetActive()[this.gdvSubscription.FocusedRowHandle].State = PROF_IT.Common.Enumerations.ObjectState.Deleted;
                gdcSubscription.DataSource = TaskMember.Subscriptions.GetActive();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemoveAssigneeUnknown_Click(object sender, EventArgs e)
        {
            try
            {
                TaskMember.AssigneesUnknown.GetActive()[this.gdvAssigneeUnknown.FocusedRowHandle].State = PROF_IT.Common.Enumerations.ObjectState.Deleted;
                this.gdcAssigneeUnknown.DataSource = TaskMember.AssigneesUnknown.GetActive();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void gdvSubscription_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                TaskScheduleObject taskSchedule = (TaskScheduleObject)view.GetRow(view.FocusedRowHandle);
                TIS.Client.Schedule.Schedule schedule = new TIS.Client.Schedule.Schedule(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, taskSchedule);
                if (schedule.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    taskSchedule.State = PROF_IT.Common.Enumerations.ObjectState.Modified;
                }
                
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                TaskMember = _taskOriginal;
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                Boolean error = false;
                if (glouReporter.EditValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please choose first a reporter!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                }
                if (cmbEffort.EditValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please choose first an effort!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                }
                if (cmbPriority.EditValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please choose first a priority!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                }
                if (cmbStatus.EditValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please choose first a status!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                }
                if (this.txtTaskID.Text == "")
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please enter first a task ID!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                }
                if (error == false)
                {
                    TIS.BL.Internal.Task taskBL = new TIS.BL.Internal.Task();
                    //Add Reporter
                    foreach (TaskPeopleObject reporter in TaskMember.Reporters)
                    {
                        reporter.State = PROF_IT.Common.Enumerations.ObjectState.Deleted;
                    }
                    TaskPeopleObject _reporter = new TaskPeopleObject();
                    _reporter.Task = TaskMember;
                    if (glouReporter.EditValue != null)
                        _reporter.Employee = new BL.Internal.Employee().GetEmployeeByID((Guid)glouReporter.EditValue);
                    _reporter.Assignee = false;
                    _reporter.Reporter = true;
                    _reporter.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                    TaskMember.Reporters.Add(_reporter);

                    //Add others
                    TaskMember.Tag = txtTaskID.Text;
                    if (this.dateEditDueDate.Text == "")
                        TaskMember.DueDate = "";
                    else
                        TaskMember.DueDate = PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(dateEditDueDate.DateTime);
                    if (TaskMember.CreationDate.Length == 0)
                        TaskMember.CreationDate = PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(System.DateTime.Now);
                    TaskMember.Description = richeditDescription.RtfText;

                    TaskMember.Effort = (Enumeration.Task.Effort)cmbEffort.EditValue;
                    TaskMember.Priority = (Enumeration.Task.Priority)cmbPriority.EditValue;
                    TaskMember.Status = (Enumeration.Task.Status)cmbStatus.EditValue;
                    TaskMember.State = PROF_IT.Common.Enumerations.ObjectState.Modified;
                    taskBL.Save(TaskMember);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
                
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        public void Initialize()
        {
            try
            {
                _task = new TaskObject();
                gdcAssigneeSupplier.DataSource = TaskMember.AssigneesSupplier.GetActive();
                gdcAssigneeEmployee.DataSource = TaskMember.AssigneesEmployee.GetActive();
                gdcAssigneeUnknown.DataSource = TaskMember.AssigneesUnknown.GetActive();
                gdcSubscription.DataSource = TaskMember.Subscriptions.GetActive();
                
                glouReporter.Properties.DataSource= new BL.Internal.Employee().GetAll();
                glouReporter.Properties.ValueMember = "EmpID";
                glouReporter.Properties.DisplayMember = "Email";
                cmbEffort.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Task.Effort)));
                cmbPriority.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Task.Priority)));
                cmbStatus.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Task.Status)));

            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void InitializePropertyForm()
        {
            try
            {
                //Get Childs
                if (!TaskMember.ChildsAdded)
                    new BL.Internal.Task().AddChilds(TaskMember);
                //Get Description
                if (TaskMember.Description == "")
                    new BL.Internal.Task().GetDescription(TaskMember);

                gdcAssigneeSupplier.DataSource = TaskMember.AssigneesSupplier.GetActive();
                gdcAssigneeEmployee.DataSource = TaskMember.AssigneesEmployee.GetActive();
                gdcAssigneeUnknown.DataSource = TaskMember.AssigneesUnknown.GetActive();

                gdcSubscription.DataSource = TaskMember.Subscriptions.GetActive();
                if (TaskMember.Subscriptions.Count >0)
                    cbxAddSubscription.Checked = true;

                
                glouReporter.Properties.DataSource = new BL.Internal.Employee().GetAll();
                glouReporter.Properties.ValueMember = "EmpID";
                glouReporter.Properties.DisplayMember = "Email";
                cmbEffort.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Task.Effort)));
                cmbPriority.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Task.Priority)));
                cmbStatus.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Task.Status)));

                if (TaskMember.Reporters.Count > 0)
                {
                        glouReporter.EditValue = TaskMember.Reporters[0].Employee.EmpID;
                }
                    

                txtTaskID.Text = TaskMember.Tag;
                if (TaskMember.DueDate.Length > 0)
                    dateEditDueDate.DateTime = PROF_IT.Common.Convert.DateFunctions.DBDateToDateTime(TaskMember.DueDate);
                richeditDescription.RtfText = TaskMember.Description;

                cmbEffort.EditValue = TaskMember.Effort;
                cmbPriority.EditValue = TaskMember.Priority;
                cmbStatus.EditValue = TaskMember.Status;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion


    }
}
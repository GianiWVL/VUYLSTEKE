using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.Employee;
using System.Xml;
using TIS.DL.Internal.TaskPeople;
using TIS.DL.Internal.Task;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.Model.BL;
using TIS.Model.Internal;

namespace TIS.Client.Employee
{
    public partial class Employee : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private TIS.DL.Internal.Employee.EmployeeObject _employee;
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TaskObjectCollection _tasks;
        private EmployeeBL _employeeBL;
        private VacationBL _vacationBL;
        private VacationTypeBL _vacationTypeBL;
        private UnitOfWork _uow;
        private List<TIS.Model.Internal.Vacation> _vacations;
        #endregion

        #region Constructor
        public Employee(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                Uow = new UnitOfWork();
                Initialize();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
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
        public Employee(PROF_IT.Common.Enumerations.TypeForm typeForm, EmployeeObject employee)
        {
            try
            {
                InitializeComponent();
                Uow = new UnitOfWork();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    EmployeeMember = employee;
                    InitializePropertyForm();
                }
                Initialize();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Methods
        private void Initialize()
        {
            _employeeBL = new EmployeeBL(Uow);
            _vacationBL = new VacationBL(Uow);
            _vacationTypeBL = new VacationTypeBL(Uow);


            //VacationType type = new VacationType(Uow);
            //type.Name = "Verlof";
            //Uow.CommitChanges();

            List<TIS.Model.Internal.Employee> employees = _employeeBL.GetAll();
            List<TIS.Model.Internal.VacationType> vacationTypes = _vacationTypeBL.GetAll();
            _vacations = _vacationBL.GetByEmployee(EmployeeModel);
            gdcVacation.DataSource = _vacations;

            glouDispatcher.Properties.DataSource = employees;
            glouDispatcher.Properties.DisplayMember = "DisplayName";
            glouDispatcher.Properties.ValueMember = "empID";

            glouVacationType.Properties.DataSource = vacationTypes;
            glouVacationType.Properties.DisplayMember = "Name";
            glouVacationType.Properties.ValueMember = "Id";
        }
        #endregion

        #region Properties
        public EmployeeObject EmployeeMember
        {
            get { return _employee; }
            set 
            { 
                _employee = value;
                if (_employee != null && Uow != null)
                {
                    EmployeeModel = new XPQuery<TIS.Model.Internal.Employee>(Uow).FirstOrDefault(q => q.empID == _employee.EmpID);
                    this.Text = EmployeeModel.Surname + ' ' + EmployeeModel.Name;
                }

            }
        }
        public TIS.Model.Internal.Employee EmployeeModel { get; set; }
        public UnitOfWork Uow
        {
            get { return _uow; }
            set { _uow = value; }
        }
        #endregion 

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeMember.RepeatMail = cbxRepeatMail.Checked;
                new BL.Internal.Employee().Save(EmployeeMember);
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void InitializePropertyForm()
        {
            try
            {
                txtEmail.Text = EmployeeMember.Email;
                txtName.Text = EmployeeMember.Name;
                txtSurname.Text = EmployeeMember.Surname;
                cbxRepeatMail.Checked = EmployeeMember.RepeatMail;

                //Tasks
                TaskPeopleObjectCollection taskPeoples = new BL.Internal.TaskPeople().GetByEmployee(EmployeeMember);
                _tasks = new TaskObjectCollection();
                foreach (TaskPeopleObject taskPeople in taskPeoples)
                {
                    _tasks.Add(taskPeople.Task);
                }

                this.gdcTask.DataSource = _tasks;
                this.repositoryItemDateEditDueDate.NullDate = repositoryItemDateEditDueDate.MinValue;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void gdvTask_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                TaskObject taskObj = (TaskObject)view.GetRow(view.FocusedRowHandle);
                new TIS.BL.Internal.Task().AddChilds(taskObj);
                Client.Task.Task task = new Client.Task.Task(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, taskObj);
                task.ShowDialog();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvTask_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                TaskObject taskObj = (TaskObject)view.GetRow(view.FocusedRowHandle);
                if (!taskObj.ChildsAdded)
                    new TIS.BL.Internal.Task().AddChilds(taskObj);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            try
            {

                if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Are you sure you want to delete the task?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    TaskObject task = (TaskObject)gdvTask.GetRow(this.gdvTask.FocusedRowHandle);
                    new BL.Internal.Task().Remove(task);
                    _tasks.Remove(task);
                    gdcTask.Refresh();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Task.Task task = new Client.Task.Task(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (task.ShowDialog() == DialogResult.OK)
                {
                    _tasks.Add(task.TaskMember);
                    gdcTask.Refresh();
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        private void btnAddVacation_Click(object sender, EventArgs e)
        {
            try
            {
                TIS.Model.Internal.Employee disp = ((TIS.Model.Internal.Employee)glouDispatcher.GetSelectedDataRow());
                TIS.Model.Internal.VacationType type = ((TIS.Model.Internal.VacationType)glouVacationType.GetSelectedDataRow());

                if (!CheckDateAndTime())
                {
                    XtraMessageBox.Show("Gelieve de datum en tijd te controleren.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dteDateFrom.DateTime != null && dteDateFrom.DateTime != DateTime.MinValue
                        && type != null)
                {

                    TIS.Model.Internal.Vacation vac = new TIS.Model.Internal.Vacation(Uow)
                    {
                        Employee = EmployeeModel,
                        Dispatcher = disp,
                        DateFrom = dteDateFrom.DateTime.Date, 
                        DateTo = dteDateTo.DateTime.Date,
                        TimeFrom = teTimeFrom.Time,
                        TimeTo = teTimeTo.Time,
                        VacationType = type,
                        Description = txtDescription.Text
                    };
                    Uow.CommitChanges();
                    _vacations.Add(vac);
                    gdvVacation.RefreshData();
                    dteDateFrom.EditValue = null;
                    dteDateTo.EditValue = null;
                }
                else
                    XtraMessageBox.Show("Gelieve alle velden in te vullen.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btnRemoveVacation_Click(object sender, EventArgs e)
        {
            try
            {

                if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat u het verlof wilt verwijderen", "Verwijderen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    TIS.Model.Internal.Vacation vacation = (TIS.Model.Internal.Vacation)gdvVacation.GetRow(this.gdvVacation.FocusedRowHandle);
                    vacation.Delete();
                    Uow.CommitChanges();
                    _vacations.Remove(vacation);
                    gdvVacation.RefreshData();
                    //_vacationBL.Remove(vacation);
                    //_tasks.Remove(task);
                    //gdcTask.Refresh();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void dteDateFrom_EditValueChanged(object sender, EventArgs e)
        {
            //if (dteDateTo.DateTime == DateTime.MinValue)
            //    dteDateTo.DateTime = dteDateFrom.DateTime;
        }
        
        private bool CheckDateAndTime()
        {
            try
            {
                //if (dteDateTo.DateTime < dteDateFrom.DateTime)
                //    return false;
                //if (teTimeTo.Time < teTimeFrom.Time)
                //    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

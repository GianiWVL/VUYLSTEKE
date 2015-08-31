using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROF_IT.Exceptionhandling;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using TIS.DL.Internal.Task;
using TIS.DL.Internal.Employee;
using TIS.Model.Internal;
using DevExpress.Xpo;
using TIS.Model.BL;
using TIS.Client.Vacation;

namespace TIS.Client.Employee
{
    public partial class Employees : General.BaseChildForm
    {

        #region Fields
        DL.Internal.Employee.EmployeeObjectCollection _employees;
        List<TIS.Model.Internal.Vacation> _vacationList;
        List<TIS.Model.Internal.Vacation> _vacationSessionList;
        EmployeeBL _employeeBL;
        VacationBL _vacationBL;
        #endregion

        #region Constructor
        public Employees()
        {
            try
            {
                InitializeComponent();
                _vacationList = new List<TIS.Model.Internal.Vacation>();
                _vacationSessionList = new List<TIS.Model.Internal.Vacation>();
                _employeeBL = new EmployeeBL(Uow);
                _vacationBL = new VacationBL(Uow);
                FindAll();
                Initialize();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public DL.Internal.Employee.EmployeeObjectCollection EmployeesMember
        {
            get { return _employees; }
            set { _employees = value; }
        }
        #endregion 

        #region Events
        private void gdvEmployee_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                EmployeeObject employee = (EmployeeObject)view.GetRow(view.FocusedRowHandle);
                if (employee != null)
                {
                    Employee form = new Employee(PROF_IT.Common.Enumerations.TypeForm.PropertyForm,employee);
                    form.ShowDialog();
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
        private void Initialize()
        {
            List<TIS.Model.Internal.Employee> employees = _employeeBL.GetAll();

            glouReportEmployee.Properties.DataSource = employees;
            glouReportEmployee.Properties.DisplayMember = "DisplayName";
            glouReportEmployee.Properties.ValueMember = "empID";

            glouReportDispatcher.Properties.DataSource = employees;
            glouReportDispatcher.Properties.DisplayMember = "DisplayName";
            glouReportDispatcher.Properties.ValueMember = "empID";
        }
        private void FindAll()
        {
            try
            {
                EmployeeObjectCollection employees = new BL.Internal.Employee().GetAll();
                this.gdcEmployee.DataSource = employees;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        private void btnReportAlphabetical_Click(object sender, EventArgs e)
        {
            Vacations vacForm = new Vacations();
            vacForm.gdcVacation.DataSource = _vacationBL.GetAll().OrderBy(v => v.Employee.DisplayName);
            vacForm.Show();
        }
        private void btnReportChronological_Click(object sender, EventArgs e)
        {
            Vacations vacForm = new Vacations();
            vacForm.gdcVacation.DataSource = _vacationBL.GetAll();
            vacForm.Show();
        }
        private void btnReportEmployee_Click(object sender, EventArgs e)
        {
            Vacations vacForm = new Vacations();
            TIS.Model.Internal.Employee emp = ((TIS.Model.Internal.Employee)glouReportEmployee.GetSelectedDataRow());
            vacForm.gdcVacation.DataSource = _vacationBL.GetByEmployee(emp);
            vacForm.Show();
        }
        private void btnReportDispatcher_Click(object sender, EventArgs e)
        {
            Vacations vacForm = new Vacations();
            vacForm.gdcVacation.DataSource = _vacationBL.GetByDispatcher((TIS.Model.Internal.Employee)glouReportDispatcher.GetSelectedDataRow());
            vacForm.Show();
        }
        private void btnReportDate_Click(object sender, EventArgs e)
        {
            Vacations vacForm = new Vacations();
            vacForm.gdcVacation.DataSource = _vacationBL.GetByDate(dteReportFrom.DateTime, dteReportTo.DateTime);
            vacForm.Show();
        }

        
        

 

       

        

       




    }
}

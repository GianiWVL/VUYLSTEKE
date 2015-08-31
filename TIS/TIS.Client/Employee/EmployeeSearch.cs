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

namespace TIS.Client.Employee
{
    public partial class EmployeeSearch : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private TIS.DL.Internal.Employee.EmployeeObject _employee;
        #endregion

        #region Constructor
        public EmployeeSearch()
        {
            try
            {
                InitializeComponent();
                FindAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public EmployeeObject Employee
        {
            get { return _employee; }
            set { _employee = value;}
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
        private void FindAll()
        {
            try
            {
                BL.Internal.Employee blEmp = new BL.Internal.Employee();
                gdcEmployee.DataSource = blEmp.GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvEmployee.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    Employee = (EmployeeObject)gdvEmployee.GetRow(gdvEmployee.FocusedRowHandle);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please select first a employee!", "Attention", MessageBoxButtons.OK);
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

        
    }
}

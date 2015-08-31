using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Vehicle;
using TIS.Model.Internal;

namespace TIS.Client.Planning
{
    public partial class DriverAssignment : DevExpress.XtraEditors.XtraForm
    {
        public DriverAssignment()
        {
            InitializeComponent();

            FillGrids();
        }

        private void FillGrids()
        {
            gridUnassigned.DataSource = null;
            gridAssigned.DataSource = null;

            //TODO: Check for refactoring
            EmployeeObjectCollection employees = new BL.Internal.Employee().GetAll();
            EmployeeObjectCollection employeesTwo = new BL.Internal.Employee().GetAll();
            List<AssignedDriver> assignedDrivers = new AssignedDriver(new UnitOfWork()).GetAll();

            foreach (EmployeeObject employeeObject in employees)
            {
                foreach (AssignedDriver assignedDriver in assignedDrivers)
                {
                    if (employeeObject.EmpID == assignedDriver.Driver)
                    {
                        employeesTwo.Remove(employeeObject);
                    }
                }
            }

            gridUnassigned.DataSource = employeesTwo;
            gridAssigned.DataSource = assignedDrivers;
        }

        private void gridUnassigned_DoubleClick(object sender, EventArgs e)
        {
            AssignDriver assignDriver = new AssignDriver((EmployeeObject)this.gridvUnassigned.GetRow(this.gridvUnassigned.FocusedRowHandle));
            assignDriver.ShowDialog();

            FillGrids();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
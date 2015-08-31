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
using TIS.BL.Internal;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.User;
using TIS.Framework.Security;
using TIS.Model.Internal;

namespace TIS.Client.Planning
{
    public partial class AssignDriver : DevExpress.XtraEditors.XtraForm
    {

        private EmployeeObject _employee;
        private UnitOfWork _uow;

        public AssignDriver(EmployeeObject employee)
        {
            InitializeComponent();

            this._employee = employee;

            txtDriver.Text = this._employee.DisplayName;

            FillCboDispatcher();
        }

        private void FillCboDispatcher()
        {
            //TODO: Re-check this
            UserObjectCollection users = new User().GetAll();
            foreach (UserObject user in users)
            {
                if (user.Security.Planning != null)
                    if (Functions.AllowMaintain(user.Security.Planning.AuthPlanning))
                    {
                        ComboBoxItem item = new ComboBoxItem { Value = user };
                        this.cboDispatcher.Items.Add(item);
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._uow = new UnitOfWork();
            AssignedDriver assignedDriver = new AssignedDriver(this._uow);
            assignedDriver.DriverName = this._employee.DisplayName;
            assignedDriver.Planning = new TIS.Model.Internal.Planning(this._uow).GetPlanning(((ComboBoxItem) this.cboDispatcher.SelectedItem).Value.UsrID).Id;
            assignedDriver.Driver = this._employee.EmpID;
            this._uow.CommitChanges();

            Close();
        }

        private void cboDispatcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = cboDispatcher.SelectedItem != null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
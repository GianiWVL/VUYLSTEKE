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
using PROF_IT.Exceptionhandling.DL.User;
using TIS.Framework.Security;
using TIS.Framework;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.UserSecurity;

namespace TIS.Client.General
{
    public partial class User : DevExpress.XtraEditors.XtraForm
    {
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.User.UserObject _user;

        #region Constructor

        public User(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                SetPermissions();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    _user = new TIS.DL.Internal.User.UserObject();
                }
                else
                {
                    _user = Context.User;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }

        }

        #endregion 

        #region Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.SaveUser();
            }
            catch (Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        #endregion

        #region Methods

        public void SaveUser()
        {
            TIS.BL.Internal.User userBL = new TIS.BL.Internal.User();
            string invalidMessage = "";
            try
            {
                _user.Active = this.cbxActive.Checked;
                _user.Login = this.txtLogin.Text.Trim();
                _user.Name = this.txtName.Text.Trim();
                _user.Password = this.txtPassword.Text.Trim();
                _user.Employee = (EmployeeObject)this.louEmployee.EditValue;
                _user.Surname = this.txtSurname.Text.Trim();
                _user.Security.Application.AuthUser = Convert.ToInt16(this.cbxUserDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxUserMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxUserDelete.Checked).ToString();
                _user.Security.Main.AuthTask = Convert.ToInt16(this.cbxTaskDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxTaskMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxTaskDelete.Checked).ToString();
                _user.Security.Main.AuthCustomer = Convert.ToInt16(this.cbxCustomerDisplay.Checked).ToString()
                                    + "0"
                                    + "0";
                _user.Security.Main.AuthEmployee = Convert.ToInt16(this.cbxEmployeeDisplay.Checked).ToString()
                                    + "0"
                                    + "0";
                _user.Security.Costing.AuthCosting = (string)Convert.ToInt16(this.cbxCostingDisplay.Checked).ToString()
                                    + "0"
                                    + "0";
                _user.Security.Costing.AuthFuel = Convert.ToInt16(this.cbxFuelDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxFuelMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxFuelDelete.Checked).ToString();

                _user.Security.Costing.AuthFuelDelivery = Convert.ToInt16(this.cbxFuelDeliveryDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxFuelDeliveryMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxFuelDeliveryDelete.Checked).ToString();

                _user.Security.Costing.AuthFuelCorrection = Convert.ToInt16(this.cbxFuelCorrectionDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxFuelCorrectionMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxFuelCorrectionDelete.Checked).ToString();
                //Vehicle
                _user.Security.Vehicle.AuthVehicle = (string)Convert.ToInt16(this.cbxVehicleDisplay.Checked).ToString()
                                    + "0"
                                    + "0";
                //Material
                _user.Security.Material.AuthMaterial = (string)Convert.ToInt16(this.cbxMaterialDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialDelete.Checked).ToString();
                _user.Security.Material.AuthMaterialMaintenance = (string)Convert.ToInt16(this.cbxMaterialMaintenanceDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialMaintenanceMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialMaintenanceDelete.Checked).ToString();
                _user.Security.Material.AuthMaterialMemo = (string)Convert.ToInt16(this.cbxMaterialMemoDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialMemoMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialMemoDelete.Checked).ToString();
                _user.Security.Material.AuthMaterialCategory = (string)Convert.ToInt16(this.cbxMaterialCategoryDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialCategoryMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.cbxMaterialCategoryDelete.Checked).ToString();
                //Application
                _user.Security.Application.AuthSettings = "0"
                                    + (string)Convert.ToInt16(this.cbxSettingsMaintain.Checked).ToString()
                                    + "0";

                if(_user.Security.Planning == null)
                    _user.Security.Planning = new UserSecurityPlanning();
                //Planning
                _user.Security.Planning.AuthPlanning = (string)Convert.ToInt16(this.chkPlanningDisplay.Checked).ToString()
                                    + (string)Convert.ToInt16(this.chkPlanningMaintain.Checked).ToString()
                                    + (string)Convert.ToInt16(this.chkPlanningDelete.Checked).ToString();
                _user.Security.Planning.AuthAssignmentTrucks = "0"
                                    + (string)Convert.ToInt16(this.chkVehiclesMaintain.Checked).ToString()
                                    + "0";
                
                _user.SetInitialValues();

                if (userBL.ValidUser(_typeForm, _user, ref invalidMessage))
                {
                    switch (_typeForm)
                    {
                        case PROF_IT.Common.Enumerations.TypeForm.NewForm:
                            _user.UsrID = Guid.Empty;
                            userBL.Save(_user);
                            break;
                        case PROF_IT.Common.Enumerations.TypeForm.PropertyForm:
                            userBL.Save(_user);
                            break;
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unable to save user. Reason: " + invalidMessage, "Attention", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Exclamation);
                }

            }
            catch (System.Exception exception1)
            {
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
        }

        public void ShowUser()
        {
            try
            {
                this.louEmployee.Properties.DataSource = new BL.Internal.Employee().GetAll();
                if (_user.Employee != null)
                    this.louEmployee.EditValue = _user.Employee;
                this.cbxActive.Checked = _user.Active;
                this.txtLogin.Text = _user.Login;
                this.txtName.Text = _user.Name;
                this.txtPassword.Text = _user.Password;
                this.txtSurname.Text = _user.Surname;

                this.cbxUserDisplay.Checked = _user.Security.Application.AuthUser.Substring(0, 1).Equals("1");
                this.cbxUserMaintain.Checked = _user.Security.Application.AuthUser.Substring(1, 1).Equals("1");
                this.cbxUserDelete.Checked = _user.Security.Application.AuthUser.Substring(2, 1).Equals("1");

                this.cbxTaskDisplay.Checked = _user.Security.Main.AuthTask.Substring(0, 1).Equals("1");
                this.cbxTaskMaintain.Checked = _user.Security.Main.AuthTask.Substring(1, 1).Equals("1");
                this.cbxTaskDelete.Checked = _user.Security.Main.AuthTask.Substring(2, 1).Equals("1");
                
                this.cbxCustomerDisplay.Checked = _user.Security.Main.AuthCustomer.Substring(0,1).Equals("1");

                this.cbxEmployeeDisplay.Checked = _user.Security.Main.AuthEmployee.Substring(0, 1).Equals("1");

                this.cbxCostingDisplay.Checked = _user.Security.Costing.AuthCosting.Substring(0, 1).Equals("1");

                //Fuel
                this.cbxFuelDisplay.Checked = _user.Security.Costing.AuthFuel.Substring(0, 1).Equals("1");
                this.cbxFuelMaintain.Checked = _user.Security.Costing.AuthFuel.Substring(1, 1).Equals("1");
                this.cbxFuelDelete.Checked = _user.Security.Costing.AuthFuel.Substring(2, 1).Equals("1");

                this.cbxFuelDeliveryDisplay.Checked = _user.Security.Costing.AuthFuelDelivery.Substring(0, 1).Equals("1");
                this.cbxFuelDeliveryMaintain.Checked = _user.Security.Costing.AuthFuelDelivery.Substring(1, 1).Equals("1");
                this.cbxFuelDeliveryDelete.Checked = _user.Security.Costing.AuthFuelDelivery.Substring(2, 1).Equals("1");

                this.cbxFuelCorrectionDisplay.Checked = _user.Security.Costing.AuthFuelCorrection.Substring(0, 1).Equals("1");
                this.cbxFuelCorrectionMaintain.Checked = _user.Security.Costing.AuthFuelCorrection.Substring(1, 1).Equals("1");
                this.cbxFuelCorrectionDelete.Checked = _user.Security.Costing.AuthFuelCorrection.Substring(2, 1).Equals("1");
                //Vehicle
                this.cbxVehicleDisplay.Checked = _user.Security.Vehicle.AuthVehicle.Substring(0, 1).Equals("1");

                //Material
                this.cbxMaterialDisplay.Checked = _user.Security.Material.AuthMaterial.Substring(0, 1).Equals("1");
                this.cbxMaterialMaintain.Checked = _user.Security.Material.AuthMaterial.Substring(1, 1).Equals("1");
                this.cbxMaterialDelete.Checked = _user.Security.Material.AuthMaterial.Substring(2, 1).Equals("1");

                this.cbxMaterialMaintenanceDisplay.Checked = _user.Security.Material.AuthMaterialMaintenance.Substring(0, 1).Equals("1");
                this.cbxMaterialMaintenanceMaintain.Checked = _user.Security.Material.AuthMaterialMaintenance.Substring(1, 1).Equals("1");
                this.cbxMaterialMaintenanceDelete.Checked = _user.Security.Material.AuthMaterialMaintenance.Substring(2, 1).Equals("1");

                this.cbxMaterialMemoDisplay.Checked = _user.Security.Material.AuthMaterialMemo.Substring(0, 1).Equals("1");
                this.cbxMaterialMemoMaintain.Checked = _user.Security.Material.AuthMaterialMemo.Substring(1, 1).Equals("1");
                this.cbxMaterialMemoDelete.Checked = _user.Security.Material.AuthMaterialMemo.Substring(2, 1).Equals("1");

                this.cbxMaterialCategoryDisplay.Checked= _user.Security.Material.AuthMaterialCategory.Substring(0, 1).Equals("1");
                this.cbxMaterialCategoryMaintain.Checked=_user.Security.Material.AuthMaterialCategory.Substring(1, 1).Equals("1");
                this.cbxMaterialCategoryDelete.Checked = _user.Security.Material.AuthMaterialCategory.Substring(2, 1).Equals("1"); 
                //Application
                this.cbxSettingsMaintain.Checked = _user.Security.Application.AuthSettings.Substring(1, 1).Equals("1");
                
                //Planning
                //TODO: Check this fix: Why do i have to do this
                if (_user.Security.Planning != null)
                {
                    this.chkPlanningDisplay.Checked = _user.Security.Planning.AuthPlanning.Substring(0, 1).Equals("1");
                    this.chkPlanningMaintain.Checked = _user.Security.Planning.AuthPlanning.Substring(1, 1).Equals("1");
                    this.chkPlanningDelete.Checked = _user.Security.Planning.AuthPlanning.Substring(2, 1).Equals("1");

                    this.chkVehiclesMaintain.Checked = _user.Security.Planning.AuthAssignmentTrucks.Substring(1, 1).Equals("1");
                }
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void SetPermissions()
        {
            try
            {
                if (!Functions.AllowMaintain(Context.User.Security.Application.AuthUser))
                    this.btnSave.Enabled = false;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #endregion

        #region Properties

        public TIS.DL.Internal.User.UserObject SetUser
        {
            set
            {
                _user = value;
                this.ShowUser();
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TIS.DL.Internal.Customer;
using System.Reflection;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.Vehicle;
using System.Collections;
using TIS.DL.Internal.Material;
using DevExpress.XtraGrid.Views.Grid;
using TIS.Framework.Security;

namespace TIS.Client.Vehicle
{
    public partial class Vehicle : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Vehicle.VehicleObject _vehicle;
        #endregion

        #region Constructor
        public Vehicle(PROF_IT.Common.Enumerations.TypeForm typeForm, VehicleObject vehicle)
        {
            try
            {
                InitializeComponent();
                _vehicle = vehicle;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    InitializePropertyForm();
                    SetPermissions();
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
        public VehicleObject VehicleMember
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }
        #endregion

        #region Events
        private void btnSearchTransicsVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                
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
                VehicleMember.VehicleTransicsLink.Transi_TNR_mat = (int)louVehiclesTransics.EditValue;
                VehicleMember.ContactTransics = cbxContactTransics.Checked;
                new BL.Internal.Vehicle().Save(VehicleMember);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }    
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

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                Material.Material material = new Material.Material(PROF_IT.Common.Enumerations.TypeForm.NewForm, VehicleMember);
                if (material.ShowDialog() == DialogResult.OK)
                {
                    this.gdcMaterial.DataSource = new BL.Internal.Material().GetByVehicle(VehicleMember);
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvMaterial.FocusedRowHandle >= 0)
                {
                    if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat je het materiaal wilt verwijderen?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        new BL.Internal.Material().Remove((MaterialObject)gdvMaterial.GetRow(gdvMaterial.FocusedRowHandle));
                        this.gdcMaterial.DataSource = new BL.Internal.Material().GetByVehicle(VehicleMember);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvMaterial_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialObject materialObj = (MaterialObject)view.GetRow(view.FocusedRowHandle);
                if (!materialObj.ChildsAdded)
                    new TIS.BL.Internal.Material().AddChilds(materialObj);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvMaterial_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialObject materialObj = (MaterialObject)view.GetRow(view.FocusedRowHandle);
                Material.Material material = new Material.Material(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, materialObj);
                material.ShowDialog();
                this.gdcMaterial.DataSource = new BL.Internal.Material().GetByVehicle(VehicleMember);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        public void InitializePropertyForm()
        {
            try
            {
                txtName.Text = VehicleMember.Name;
                txtLicenseNumber.Text = VehicleMember.LicenseNumber;
                txtChassis.Text = VehicleMember.Chassis;
                txtBrand.Text = VehicleMember.Brand;
                txtType.Text = VehicleMember.VehicleType;

                this.louVehiclesTransics.Properties.DataSource = new BL.Internal.Vehicle().GetVehiclesTransics();
                this.louVehiclesTransics.EditValue = VehicleMember.VehicleTransicsLink.Transi_TNR_mat;

                this.gdcVehicleMileage.DataSource = new BL.Internal.VehicleMileage().GetByVehicle(VehicleMember);
                this.gdcMaterial.DataSource = new BL.Internal.Material().GetByVehicle(VehicleMember);

                this.cbxContactTransics.Checked = VehicleMember.ContactTransics;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void SetPermissions()
        {
            try
            {
                if (!Functions.AllowMaintain(Context.User.Security.Material.AuthMaterial))
                    this.btnAddMaterial.Enabled = false;
                if (!Functions.AllowDelete(Context.User.Security.Material.AuthMaterial))
                    this.btnRemoveMaterial.Enabled = false;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TIS.DL.Internal.Fuel;
using System.Reflection;
using PROF_IT.Exceptionhandling;
using TIS.Framework.Security;

namespace TIS.Client.Fuel
{
    public partial class FuelDetail : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Fuel.FuelObject _fuel;
        #endregion

        #region Constructor
        public FuelDetail(PROF_IT.Common.Enumerations.TypeForm typeForm, TIS.DL.Internal.Fuel.FuelObject fuel)
        {
            try
            {
                InitializeComponent();
                _fuel = fuel;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    InitializePropertyForm();
                }
                FindAll();
                SetPermissions();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public FuelDetail(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    FuelMember = new FuelObject();
                    FindAll();
                }
                else
                {
                    throw new NotImplementedException();
                }
                SetPermissions();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public FuelObject FuelMember
        {
            get { return _fuel; }
            set { _fuel = value; }
        }
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
                FuelMember.Employee = cmbEmployee.Text;
                FuelMember.FuelType = (Framework.Common.Enumeration.Fuel.FuelType)Enum.Parse(typeof(Framework.Common.Enumeration.Fuel.FuelType), cmbFuelType.Text);
                FuelMember.Supplier = cmbSupplier.Text;
                FuelMember.VehicleLicensePlate = cmbVehicle.Text;

                FuelMember.Date = dteDate.DateTime;
                FuelMember.InvoiceOK = cbxInvoiceOK.Checked;
                FuelMember.InvoiceReceived = cbxInvoiceReceived.Checked;
                FuelMember.PrivateTanking = cbxPrivate.Checked;

                FuelMember.UnityPrice = calcUnityPrice.Value;
                FuelMember.Quantity = calcQuantity.Value;
                FuelMember.TotalPrice = calcQuantity.Value * calcUnityPrice.Value;

                TIS.BL.Internal.Fuel fuelBL = new BL.Internal.Fuel();
                fuelBL.Save(FuelMember);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void calcQuantity_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void calcUnityPrice_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        private void FindAll()
        {
            try
            {
                string[] suppliers = new BL.Internal.Fuel().GetSuppliers();
                foreach (string supplier in suppliers)
                {
                    this.cmbSupplier.Properties.Items.Add(supplier);
                }

                string[] vehicles = new BL.Internal.Fuel().GetVehicles();
                foreach (string vehicle in vehicles)
                {
                    this.cmbVehicle.Properties.Items.Add(vehicle);
                }

                string[] employees = new BL.Internal.Fuel().GetEmployees();
                foreach (string employee in employees)
                {
                    this.cmbEmployee.Properties.Items.Add(employee);
                }

                foreach (string fuelType in Enum.GetNames(typeof(Framework.Common.Enumeration.Fuel.FuelType)))
                {
                    this.cmbFuelType.Properties.Items.Add(fuelType);
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void Calculate()
        {
            try
            {
                txtTotalExcl.Text = Convert.ToString(calcQuantity.Value * calcUnityPrice.Value);
                txtTotalVAT.Text = Convert.ToString(calcQuantity.Value * calcUnityPrice.Value * (decimal)0.21);
                txtTotalIncl.Text = Convert.ToString(calcQuantity.Value * calcUnityPrice.Value * (decimal)1.21);

                txtLiterExcl.Text = calcUnityPrice.Value.ToString();
                txtLiterVAT.Text = Convert.ToString(calcUnityPrice.Value * (decimal)0.21);
                txtLiterIncl.Text = Convert.ToString(calcUnityPrice.Value * (decimal)1.21);
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
                cmbEmployee.Text = FuelMember.Employee;
                cmbFuelType.Text = FuelMember.FuelType.ToString();
                cmbSupplier.Text = FuelMember.Supplier;
                cmbVehicle.Text = FuelMember.VehicleLicensePlate;

                dteDate.DateTime = FuelMember.Date;

                cbxInvoiceOK.Checked = FuelMember.InvoiceOK;
                cbxInvoiceReceived.Checked = FuelMember.InvoiceReceived;
                cbxPrivate.Checked = FuelMember.PrivateTanking;

                calcUnityPrice.Value = FuelMember.UnityPrice;
                calcQuantity.Value = FuelMember.Quantity;

                txtTotalExcl.Text = FuelMember.TotalPrice.ToString();
                txtTotalVAT.Text = Convert.ToString(FuelMember.TotalPrice * (decimal)0.21);
                txtTotalIncl.Text = Convert.ToString(FuelMember.TotalPrice * (decimal)1.21);

                txtLiterExcl.Text = FuelMember.UnityPrice.ToString();
                txtLiterVAT.Text = Convert.ToString(FuelMember.UnityPrice * (decimal)0.21);
                txtLiterIncl.Text = Convert.ToString(FuelMember.UnityPrice * (decimal)1.21);
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
                if (!Functions.AllowMaintain(Context.User.Security.Costing.AuthFuel))
                    this.btnSave.Enabled = false;
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

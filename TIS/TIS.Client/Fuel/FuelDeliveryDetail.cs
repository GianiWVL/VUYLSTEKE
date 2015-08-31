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
using TIS.Framework.Security;
using TIS.DL.Internal.FuelDelivery;
using TIS.DL.Internal.Supplier;
using TIS.Framework.Common;

namespace TIS.Client.Fuel
{
    public partial class FuelDeliveryDetail : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.FuelDelivery.FuelDeliveryObject _fuelDelivery;
        #endregion

        #region Constructor
        public FuelDeliveryDetail(PROF_IT.Common.Enumerations.TypeForm typeForm, TIS.DL.Internal.FuelDelivery.FuelDeliveryObject fuel)
        {
            try
            {
                InitializeComponent();
                _fuelDelivery = fuel;
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
        public FuelDeliveryDetail(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    FuelDeliveryMember = new FuelDeliveryObject();
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
        public FuelDeliveryObject FuelDeliveryMember
        {
            get { return _fuelDelivery; }
            set { _fuelDelivery = value; }
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

                FuelDeliveryMember.DateDelivery = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(dteDateDelivery.DateTime) ;
                FuelDeliveryMember.DateInvoice = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(dteInvoice.DateTime);
                FuelDeliveryMember.Remark = memoRemark.Text;

                FuelDeliveryMember.Supplier = (SupplierObject)louSupplier.EditValue;
                FuelDeliveryMember.UnityPrice = calcUnityPrice.Value;
                FuelDeliveryMember.Quantity = calcQuantity.Value;

                FuelDeliveryMember.Location = (Enumeration.Fuel.Location)Enum.Parse(typeof(Enumeration.Fuel.Location), cmbLocation.Text);

                TIS.BL.Internal.FuelDelivery fuelDeliveryBL = new BL.Internal.FuelDelivery();
                fuelDeliveryBL.Save(FuelDeliveryMember);
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
                louSupplier.Properties.DataSource = new BL.Internal.Supplier().GetAll();

                foreach (string fuelLocation in Enum.GetNames(typeof(Framework.Common.Enumeration.Fuel.Location)))
                {
                    this.cmbLocation.Properties.Items.Add(fuelLocation);
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
                louSupplier.EditValue =  FuelDeliveryMember.Supplier;
                dteDateDelivery.DateTime = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(FuelDeliveryMember.DateDelivery);
                dteInvoice.DateTime = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(FuelDeliveryMember.DateInvoice);
                memoRemark.Text =  FuelDeliveryMember.Remark;
                cmbLocation.Text = FuelDeliveryMember.Location.ToString();

                calcUnityPrice.Value = FuelDeliveryMember.UnityPrice;
                calcQuantity.Value = FuelDeliveryMember.Quantity;

                txtTotalExcl.Text = Convert.ToString(FuelDeliveryMember.UnityPrice * FuelDeliveryMember.Quantity);
                txtTotalVAT.Text = Convert.ToString(FuelDeliveryMember.UnityPrice * FuelDeliveryMember.Quantity * (decimal)0.21);
                txtTotalIncl.Text = Convert.ToString(FuelDeliveryMember.UnityPrice * FuelDeliveryMember.Quantity * (decimal)1.21); 
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
                if (!Functions.AllowMaintain(Context.User.Security.Costing.AuthFuelDelivery))
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

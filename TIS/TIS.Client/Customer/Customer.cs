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

namespace TIS.Client.Customer
{
    public partial class Customer : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Customer.CustomerObject _customer;
        #endregion

        #region Constructor
        public Customer(PROF_IT.Common.Enumerations.TypeForm typeForm, CustomerObject customer)
        {
            try
            {
                InitializeComponent();
                _customer = customer;
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
        public CustomerObject CustomerMember
        {
            get { return _customer; }
            set { _customer = value; }
        }
        #endregion

        #region Events
        private void bbiTurnover_Click(object sender, EventArgs e)
        {
            try
            {
                Report.TurnOver chtVwr = new Report.TurnOver(CustomerMember);
                chtVwr.Show();
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
        #endregion

        #region Methods
        public void InitializePropertyForm()
        {
            try
            {
                txtName.Text = CustomerMember.Name;
                txtName2.Text = CustomerMember.Name2;
                txtStreet.Text = CustomerMember.Street;
                txtHouseNumber.Text = CustomerMember.HouseNumber;
                txtZipcode.Text = CustomerMember.Zipcode;
                txtTown.Text = CustomerMember.Town;
                txtCountry.Text = CustomerMember.Country;
                txtVAT.Text = CustomerMember.Vat;
                txtPhone.Text = CustomerMember.Phone;
                txtLanguage.Text = CustomerMember.Language;
                txtCurrency.Text = CustomerMember.Currency;
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

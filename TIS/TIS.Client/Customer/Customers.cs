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
using TIS.DL.Internal.Customer;

namespace TIS.Client.Customer
{
    public partial class Customers : General.BaseChildForm
    {

        #region Fields
        DL.Internal.Customer.CustomerObjectCollection _customers;
        #endregion

        #region Constructor
        public Customers()
        {
            try
            {
                InitializeComponent();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public DL.Internal.Customer.CustomerObjectCollection CustomersMember
        {
            get { return _customers; }
            set { _customers = value; }
        }
        #endregion 

        #region Events
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    FindAll();
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void txtVAT_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    FindAll();
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                FindAll();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvCustomer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                CustomerObject customerObj = (CustomerObject)view.GetRow(view.FocusedRowHandle);
                Customer customer = new Customer(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, customerObj);
                customer.ShowDialog();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        private void FindAll()
        {
            try
            {
                string vat = "";
                if (txtVAT.Text == "")
                    vat = "";
                else
                    vat = "%" + txtVAT.Text + "%";

                string name = "";
                if (txtName.Text == "")
                    name = "";
                else
                    name = "%" + txtName.Text + "%";

                BL.Internal.Customer blCustomer = new BL.Internal.Customer();
                CustomersMember = blCustomer.GetFilter(name, vat);
                
                this.gdcCustomer.DataSource = CustomersMember;
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

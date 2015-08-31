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
using TIS.DL.Internal.Supplier;

namespace TIS.Client.Supplier
{
    public partial class SupplierSearch : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private TIS.DL.Internal.Supplier.SupplierObject _supplier;
        #endregion

        #region Constructor
        public SupplierSearch()
        {
            try
            {
                InitializeComponent();
                _supplier = new SupplierObject();
                FindAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Methods
        public SupplierObject Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvSupplier.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    Supplier = (SupplierObject)gdvSupplier.GetRow(gdvSupplier.FocusedRowHandle);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please select first a supplier!", "Attention", MessageBoxButtons.OK);
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

        #region Methods
        public void FindAll()
        {
            try
            {
                BL.Internal.Supplier blSup = new BL.Internal.Supplier();
                gdcSupplier.DataSource = blSup.GetAll();
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

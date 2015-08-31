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
using DevExpress.Xpo;
using TIS.Model.Internal;

namespace TIS.Client.Supplier
{
    public partial class Suppliers : General.BaseChildForm
    {

        #region Fields
        #endregion

        #region Constructor
        public Suppliers()
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
        #endregion 

        #region Events
        private void btnSearchSupplier_Click(object sender, EventArgs e)
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

        #endregion

        #region Methods
        private void FindAll()
        {
            try
            {
                this.gdcSupplier.DataSource = new XPCollection<TIS.Model.Internal.Supplier>(Uow).OrderBy(q => q.Name);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        private void gdvSupplier_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Model.Internal.Supplier supplierObj = (Model.Internal.Supplier)view.GetRow(view.FocusedRowHandle);
                Report.CostSupplier costSupplier = new Report.CostSupplier(supplierObj, Uow) ;
                costSupplier.ShowDialog();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }

        

        





        

 

       

        

       




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PROF_IT.Exceptionhandling;
using DevExpress.XtraGrid.Views.Grid;
using TIS.DL.Internal.Popup;
using System.Reflection;

namespace TIS.Client.Popup
{
    public partial class Popups : General.BaseChildForm
    {

        #region Constructor
        public Popups()
        {
            InitializeComponent();
            FindAll();
        }
        #endregion

        #region Events
        private void btnAddPoup_Click(object sender, EventArgs e)
        {
            try
            {
                Popup popup = new Popup(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (popup.ShowDialog() == DialogResult.OK)
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
        private void btnRemovePopup_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat je de popup wilt verwijderen?", "Verwijderen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    new BL.Internal.Popup().Remove((PopupObject)gdvPopups.GetRow(this.gdvPopups.FocusedRowHandle));
                    FindAll();
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
        private void FindAll()
        {
            try
            {
                gdcPopups.DataSource = new BL.Internal.Popup().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        private void gdvPopups_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                PopupObject popupObj = (PopupObject)view.GetRow(view.FocusedRowHandle);
                Popup popup = new Popup(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, popupObj);
                popup.ShowDialog();
                FindAll();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }

        
        
    }
}

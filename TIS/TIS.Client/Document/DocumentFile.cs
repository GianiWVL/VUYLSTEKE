using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PROF_IT.Exceptionhandling;
using System.Reflection;

namespace TIS.Client.Document
{
    public partial class DocumentFile : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private bool _delete = false;
        #endregion

        #region Constructor
        public DocumentFile(DevExpress.Utils.ImageCollection iclLarge, String name)
        {
            try
            {
                InitializeComponent();
                for (int i = 0; i < iclLarge.Images.Count; i++)
                    icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", i, i));
                icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Geen"));
                icbxIcon.Properties.LargeImages = iclLarge;
                txtName.Text = name;
                btnDelete.Visible = false;
            }

            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public DocumentFile(DevExpress.Utils.ImageCollection iclLarge, String name, int imageIndex,String title)
        {
            try
            {
                //new DocumentFile(iclLarge, name);
                InitializeComponent();
                for (int i = 0; i < iclLarge.Images.Count; i++)
                    icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", i, i));
                icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Geen"));
                icbxIcon.Properties.LargeImages = iclLarge;
                txtName.Text = name;
                this.Text = title;
                icbxIcon.SelectedIndex = imageIndex >0 && imageIndex < iclLarge.Images.Count?imageIndex:iclLarge.Images.Count;
            }

            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bent u zeker dat u dit wil verwijderen?", "Verwijderen", MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _delete = true;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Properties
        public String DocName
        {
            get { return txtName.Text; }
        }
        public int Index
        {
            get { return icbxIcon.SelectedIndex; }
        }
        public bool isDeleted
        {
            get { return _delete; }
        }
        #endregion

    }
}
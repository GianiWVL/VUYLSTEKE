using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Reflection;
using PROF_IT.Exceptionhandling;

namespace TIS.Client.Document
{
    public partial class DocumentLink : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private bool _delete = false;
        #endregion

        #region Constructor
        public DocumentLink(ImageCollection iclLarge,string name,int imageIndex,string url)
        {
            try
            {
                InitializeComponent();
                for (int i = 0; i < iclLarge.Images.Count; i++)
                    icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", i, i));
                icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Geen"));
                icbxIcon.Properties.LargeImages = iclLarge;
                txtUrl.Text = url;
                txtName.Text = name;

                icbxIcon.SelectedIndex = imageIndex >= 0 && imageIndex < iclLarge.Images.Count ? imageIndex : iclLarge.Images.Count;

            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Events
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
        public string NodeName
        {
            get { return txtName.Text; }
        }
        public int Index
        {
            get { return icbxIcon.SelectedIndex; }
        }
        public string Url
        {
            get { return txtUrl.Text; }
        }
        public bool isDeleted
        {
            get { return _delete; }
        }
        #endregion

    }
}
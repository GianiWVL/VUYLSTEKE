using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PROF_IT.Exceptionhandling;
using DevExpress.Utils;
using System.Reflection;

namespace TIS.Client.Document
{
    public partial class DocumentNodeOrLink : DevExpress.XtraEditors.XtraForm
    {
        #region Constructor
        public DocumentNodeOrLink(ImageCollection iclLarge)
        {
            try
            {
                InitializeComponent();
                for (int i = 0; i < iclLarge.Images.Count; i++)
                    icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", i, i));
                icbxIcon.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Geen"));
                icbxIcon.Properties.LargeImages = iclLarge;
                radioGroup.SelectedIndex = 1;
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
        private void radioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioGroup.SelectedIndex == 1)
                {
                    txtUrl.Enabled = true;
                }
                else
                {
                    txtUrl.Enabled = false;
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
        public bool isLink
        {
            get { return radioGroup.SelectedIndex == 1; }
        }
        #endregion
    }
}
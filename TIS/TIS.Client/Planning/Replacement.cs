using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.BL.Internal;
using TIS.DL.Internal.User;
using TIS.Framework.Security;

namespace TIS.Client.Planning
{
    public partial class Replacement : DevExpress.XtraEditors.XtraForm
    {
        #region Constructors
        public Replacement(Model.Internal.Planning planning)
        {
            InitializeComponent();

            this._uow = new UnitOfWork();
            this._planning = new XPQuery<Model.Internal.Planning>(this._uow).FirstOrDefault(q => q.Id == planning.Id); ;

            FillCboReplacements();
        }
        #endregion

        #region Fields
        private Model.Internal.Planning _planning;
        private UnitOfWork _uow;
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboReplacement.SelectedItem == null)
            {
                MessageBox.Show("Kies een vervanger");
                return;
            }


            if (chkActive.Checked)
            {
                this._planning.ReplacingDispatcher = ((ComboBoxItem)cboReplacement.SelectedItem).Value.UsrID;
                this._uow.CommitChanges();
            }
            else
            {
                this._planning.ReplacingDispatcher = Guid.Empty;
                this._uow.CommitChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboReplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkActive.Checked = true;
            CheckValidForm();

        }
        #endregion

        #region Methods
        private void FillCboReplacements()
        {
            UserObjectCollection users = new User().GetAll();
            foreach (UserObject user in users)
            {
                if (user.Security.Planning != null)
                {
                    if (Functions.AllowMaintain(user.Security.Planning.AuthPlanning))
                    {
                        if (user.UsrID != this._planning.Dispatcher)
                        {
                            ComboBoxItem item = new ComboBoxItem { Value = user };
                            this.cboReplacement.Items.Add(item);

                            if (item.Value.UsrID == this._planning.ReplacingDispatcher)
                            {
                                cboReplacement.SelectedIndex = cboReplacement.Items.Count - 1;
                                chkActive.Checked = this._planning.ReplacingDispatcher != Guid.Empty;
                            }
                        }
                    }
                }
            }
        }
        private void CheckValidForm()
        {
            this.btnSave.Enabled = this.cboReplacement.SelectedItem != null;
        }
        #endregion
    }
}
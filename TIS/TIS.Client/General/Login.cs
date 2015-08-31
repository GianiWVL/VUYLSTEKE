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
using TIS.DL.Internal.User;
using TIS.Framework.Security;

namespace TIS.Client.General
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        #region Constructor
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void VerifyUser()
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;
                if (this.ValidData())
                {
                    UserObject user = new TIS.BL.Internal.User().GetUserByLogin(this.txtLogin.Text.Trim());
                    if (user != null)
                    {
                        if (user.Active)
                        {
                            if (user.Password.Trim().Equals(this.txtPassword.Text.Trim()))
                            {
                                Context.User = user;
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                                Program.CLOSE = false;
                                Program.LOGIN = false;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid password for this login", "Login", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("User is not active anymore", "Login", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("No user found with this login.", "Login", MessageBoxButtons.OK,
                                                     MessageBoxIcon.Exclamation);



                    }
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private bool ValidData()
        {
            bool flag;
            try
            {
                if (txtLogin.Text.Trim().Length == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("No required login specified.", "Login", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                    return false;
                }
                if (this.txtPassword.Text.Trim().Length == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("No required password specified.", "Login", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                    return false;
                }
                flag = true;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return flag;
        }
        #endregion

        #region Events
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.txtLogin.CanFocus)
                {
                    txtLogin.Focus();
                }
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                Program.CLOSE = true;
                Program.LOGIN = false;
                Application.Exit();
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.VerifyUser();
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Keys keyCode = e.KeyCode;
                if ((keyCode == Keys.Return) && this.txtPassword.CanFocus)
                {
                    this.txtPassword.Focus();
                }
            }
            catch (Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.VerifyUser();
                }
            }
            catch (Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Program.CLOSE = true;
                Program.LOGIN = false;
            }
            catch (Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.User;
using TIS.Framework.Security;

namespace TIS.Client.General
{
    public partial class Users : DevExpress.XtraEditors.XtraForm
    {

        #region Constructor
        public Users()
        {
            try
            {
                InitializeComponent();
                SetPermissions();
            }
            catch (System.Exception exception1)
            {
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
        }
        #endregion

        #region Methods
        public void FindAll()
        {
            try
            {
                UserObjectCollection users = new UserObjectCollection();
                users = new TIS.BL.Internal.User().GetAll();
                gdcUsers.DataSource = users;
            }
            catch (System.Exception exception1)
            {
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
        }
        private void RemoveUser()
        {
            TIS.BL.Internal.User userBL = new TIS.BL.Internal.User();
            UserObject user;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (gdvUsers.IsRowSelected(gdvUsers.FocusedRowHandle))
                {
                    user = (UserObject)gdvUsers.GetRow(this.gdvUsers.FocusedRowHandle);
                    if (userBL.HasDependencies(user))
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Selected user cannot be removed. Other records depend on this user.", "Remove", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
                    }
                    else if  (DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to remove the selected user?", "Remove", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userBL.Remove(user);
                        this.FindAll();
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
                user = null;
                userBL = null;
                this.Cursor = Cursors.Default;
            }
        }
        public void SetPermissions()
        {
            try
            {
                sbtnAddUser.Enabled = Functions.AllowMaintain(Context.User.Security.Application.AuthUser);
                sbtnRemoveUser.Enabled = Functions.AllowDelete(Context.User.Security.Application.AuthUser);
                sbtnDetailUser.Enabled = Functions.AllowDisplay(Context.User.Security.Application.AuthUser);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            
        }
        #endregion

        #region Events
        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                FindAll();
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
        }
        private void sbtnAddUser_Click(object sender, EventArgs e)
        {
            User user = null;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                user = new User(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (user.ShowDialog() == DialogResult.OK)
                {
                    this.FindAll();
                }
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
            finally
            {
                if (user != null)
                {
                    user.Dispose();
                }
                user = null;
                this.Cursor = Cursors.Default;
            }
        }
        private void sbtnDetailUser_Click(object sender, EventArgs e)
        {
            User user = null;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (gdvUsers.IsRowSelected(gdvUsers.FocusedRowHandle))
                {
                    user = new User(PROF_IT.Common.Enumerations.TypeForm.PropertyForm)
                    {
                        SetUser = (TIS.DL.Internal.User.UserObject)gdvUsers.GetRow(gdvUsers.FocusedRowHandle)
                    };
                    if (user.ShowDialog() == DialogResult.OK)
                    {
                        this.FindAll();
                    }
                }
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
            finally
            {
                if (user != null)
                {
                    user.Dispose();
                }
                user = null;
                this.Cursor = Cursors.Default;
            }
        }
        private void sbtnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveUser();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }

        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
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

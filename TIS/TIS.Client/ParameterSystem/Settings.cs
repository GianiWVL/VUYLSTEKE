using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.Schedule;
using System.Reflection;
using TIS.Framework.Common;
using TIS.DL.Internal.TaskSchedule;
using TIS.DL.Internal.ParameterSystem;
using TIS.DL.Internal.User;

namespace TIS.Client.ParameterSystem
{
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        #endregion

        #region Constructor
        public Settings()
        {
            try
            {
                InitializeComponent();
                Initialize();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            BL.Internal.ParameterSystem bl;
            DL.Internal.ParameterSystem.ParameterSystemObject parameterSystem;
            try
            {
                bl = new BL.Internal.ParameterSystem();

                //SMTP_VUYLSTEKE
                parameterSystem = bl.GetByKeyName(ParameterSystemObject.SMTP_VUYLSTEKE);
                parameterSystem.Value = txtSMTP_Vuylsteke.Text;
                parameterSystem.State = PROF_IT.Common.Enumerations.ObjectState.Modified;
                bl.Save(parameterSystem);

                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSetUknownSecurityParameters_Click(object sender, EventArgs e)
        {
            if  (DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to set the unknown security parameters?", "Set unknown security parameters", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BL.Internal.User bl;
                UserObjectCollection users;
                try
                {
                    bl = new BL.Internal.User();
                    users = bl.GetAll();

                    foreach (UserObject user in users)
                    {
                        bl.SetUnknownSecurityParameters(user);
                    }
                }
                catch (System.Exception exception1)
                {
                    System.Exception thisException = exception1;
                    Management.ShowException(thisException);
                }
            }
            
        }
        #endregion

        #region Methods
        private void Initialize()
        {
            BL.Internal.ParameterSystem bl;
            DL.Internal.ParameterSystem.ParameterSystemObject parameterSystem;
            try
            {
                bl = new BL.Internal.ParameterSystem();

                //SMTP_VUYLSTEKE
                parameterSystem = bl.GetByKeyName(ParameterSystemObject.SMTP_VUYLSTEKE);
                txtSMTP_Vuylsteke.Text = parameterSystem.Value;
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

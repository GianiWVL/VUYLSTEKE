using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TIS.DL.Internal.Customer;
using System.Reflection;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.Vehicle;
using System.Collections;
using TIS.DL.Internal.Material;
using TIS.DL.Internal.Maintenance;
using TIS.DL.Internal.Memo;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Supplier;
using TIS.Framework.Security;
using DevExpress.XtraGrid.Views.Card;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;
using DevExpress.XtraGrid.Views.Grid;
using TIS.DL.Internal.Popup;
using TIS.Framework.Common;
using TIS.DL.Internal.User;
using TIS.DL.Internal.PopupUser;

namespace TIS.Client.Popup
{
    public partial class Popup : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Popup.PopupObject _popup;
        private MaterialObject _popupOriginal;
        #endregion

        #region Constructor
        public Popup(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();

                _typeForm = typeForm;
                _popup = new PopupObject();
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    Initialize();
                    SetPermissions();
                }
                else
                {
                    throw new NotImplementedException(); 
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public Popup(PROF_IT.Common.Enumerations.TypeForm typeForm, PopupObject popup)
        {
            try
            {
                InitializeComponent();

                _popup = popup;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    InitializePropertyForm();
                    SetPermissions();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public PopupObject PopupMember
        {
            get { return _popup; }
            set { _popup = value; }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _popup.Description = memoDescription.Text;
                _popup.Active = cbxActive.Checked;
                _popup.CreationDate = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(dteStartDate.DateTime);
                _popup.Repeation = (Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue;
                if (txtTimeOfDay.Text.Length == 7)
                    _popup.Time = "0" + txtTimeOfDay.Text.Replace(":", "");
                else
                    _popup.Time = txtTimeOfDay.Text.Replace(":", "");
                //Save parent to have the correct GUID ID
                new BL.Internal.Popup().Save(PopupMember);

                //Link Popup to all users
                UserObjectCollection users = new BL.Internal.User().GetAll();
                foreach (UserObject user in users)
                {
                    PopupUserObject popupUser = new PopupUserObject();
                    popupUser.Popup = _popup;
                    popupUser.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                    popupUser.User = user;
                    _popup.PopupUsers.Add(popupUser);
                }

                //Save Parent with childs
                new BL.Internal.Popup().Save(PopupMember);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }    
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
        #endregion

        #region Methods
        public void Initialize()
        {
            try
            {
                _popup = new PopupObject();
                _popup.ShowDirect = true;
                dteStartDate.DateTime = System.DateTime.Now;
                cmbFrequency.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Frequency.TimeFrequency)));
                dteStartDate.DateTime = System.DateTime.Now;
                txtTimeOfDay.Text = System.DateTime.Now.TimeOfDay.Hours + ":" + System.DateTime.Now.TimeOfDay.Minutes + ":" + System.DateTime.Now.TimeOfDay.Seconds;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void InitializePropertyForm()
        {
            try
            {
                cmbFrequency.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Frequency.TimeFrequency)));
                cmbFrequency.SelectedIndex = (int)_popup.Repeation;
                memoDescription.Text = _popup.Description;
                dteStartDate.DateTime = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(_popup.CreationDate);
                txtTimeOfDay.Text = _popup.TimeDisplay;
                cbxActive.Checked = _popup.Active;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void SetPermissions()
        {
            try
            {
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

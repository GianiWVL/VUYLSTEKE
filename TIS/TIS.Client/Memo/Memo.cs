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

namespace TIS.Client.Memo
{
    public partial class Memo : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Memo.MemoObject _memo;
        #endregion

        #region Constructor
        public Memo(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    Initialize();
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
        public Memo(PROF_IT.Common.Enumerations.TypeForm typeForm, MemoObject memo)
        {
            try
            {
                InitializeComponent();
                _memo = memo;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    InitializePropertyForm();
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
        public MemoObject MemoMember
        {
            get { return _memo; }
            set { _memo = value; }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemoMember.DateTime = DateTime.Now;
                MemoMember.Memo = memoMemo.Text;
               
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (System.Exception exception1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
                MemoMember = new MemoObject();

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
                this.memoMemo.Text = MemoMember.Memo;
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

using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.Framework.Security;
using TIS.Model.Internal;

namespace TIS.Client.Planning
{
    public partial class MemoDetail : XtraForm
    {
        #region Constructors
        public MemoDetail(Model.Internal.Planning planning)
        {
            InitializeComponent();
            this._uow = new UnitOfWork();
            this._memo = new PlanningMemo(this._uow);
            this._planning = planning.Id;
            this.dteMemoDate.DateTime = DateTime.Today;
        }
        public MemoDetail(PlanningMemo memo)
        {
            InitializeComponent();
            this._uow = new UnitOfWork();

            this._memo = new XPQuery<PlanningMemo>(this._uow).FirstOrDefault(q => q.Id == memo.Id);
            this._planning = this._memo.Planning;

            FillDetails();
            this.dteMemoDate.DateTime = DateTime.Today;
        }
        #endregion

        #region fields
        private PlanningMemo _memo;
        private UnitOfWork _uow;
        private Int64 _planning;
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtMemoComment.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Vul de memo in");
                return;
            }
            

            this._memo.PlanningMemoDate = this.dteMemoDate.DateTime;
            this._memo.PlanningMemoComment = this.txtMemoComment.Text;
            this._memo.Planning = this._planning;

            this._uow.CommitChanges();

            this.DialogResult = DialogResult.OK;

            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtMemoComment_TextChanged(object sender, EventArgs e)
        {
            CheckValidForm();
        }
        #endregion

        #region Methods
        private void FillDetails()
        {
            this.dteMemoDate.DateTime = this._memo.PlanningMemoDate;
            this.txtMemoComment.Text = this._memo.PlanningMemoComment;
        }
        private void CheckValidForm()
        {

            if (txtMemoComment.Text.Trim().Equals(String.Empty))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }

        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Reflection;
using PROF_IT.Exceptionhandling;

namespace TIS.Client.Vehicle
{
    public partial class BoardComputers : General.BaseChildForm
    {
        #region Fields
        DL.Internal.Employee.EmployeeObjectCollection _employees;
        #endregion

        #region Constructor
        public BoardComputers()
        {
            try
            {
                InitializeComponent();
                Uow = new DevExpress.Xpo.UnitOfWork();
                FindAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public DL.Internal.Employee.EmployeeObjectCollection EmployeesMember
        {
            get { return _employees; }
            set { _employees = value; }
        }
        #endregion 

        #region Events
        private void btnSearchBoardComputers_Click(object sender, EventArgs e)
        {
            try
            {
                FindAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddBoardComputer_Click(object sender, EventArgs e)
        {
            try
            {
                BoardComputer boardComputer = new BoardComputer(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (boardComputer.ShowDialog() == DialogResult.OK)
                {
                    FindAll();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSearchBoardComputers_Click_1(object sender, EventArgs e)
        {
            try
            {
                FindAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    Model.Internal.BoardComputer boardComputer =  (Model.Internal.BoardComputer)gdvBoardComputer.GetRow(this.gdvBoardComputer.FocusedRowHandle);
                    if (boardComputer == null)
                        return;
                    if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat u de boordcomputer wilt verwijderen?", "Verwijderen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        boardComputer.Delete();
                        Uow.CommitChanges();
                        FindAll();
                    }
                }
                catch (System.Exception exception1)
                {
                    System.Exception thisException = exception1;
                    Management.ShowException(thisException);
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvBoardComputer_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                Model.Internal.BoardComputer boardComputer = (Model.Internal.BoardComputer)gdvBoardComputer.GetRow(this.gdvBoardComputer.FocusedRowHandle);
                if (boardComputer == null)
                    return;
                BoardComputer form = new BoardComputer(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, boardComputer);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FindAll();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        private void FindAll()
        {
            try
            {
                gdcBoardComputer.DataSource = new TIS.Model.BL.BoardComputerBL(Uow).GetAll();
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

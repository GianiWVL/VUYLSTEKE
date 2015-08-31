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
using DevExpress.XtraGrid.Views.Grid;
using TIS.DL.Internal.Task;
using TIS.Framework.Security;

namespace TIS.Client.Task
{
    public partial class Tasks : General.BaseChildForm
    {

        #region Fields
        DL.Internal.Task.TaskObjectCollection _tasks;
        #endregion

        #region Constructor
        public Tasks()
        {
            try
            {
                InitializeComponent();
                this.dteCreationDateFrom.DateTime = Convert.ToDateTime("2011/01/01");
                this.dteCreationDateTo.DateTime = System.DateTime.Now.AddDays(1);
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
        public DL.Internal.Task.TaskObjectCollection TasksMember
        {
            get { return _tasks; }
            set { _tasks = value; }
        }
        #endregion 

        #region Events
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (task.ShowDialog() == DialogResult.OK)
                {
                    TasksMember.Add(task.TaskMember);
                    FindAll();
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvTask_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                TaskObject taskObj = (TaskObject)view.GetRow(view.FocusedRowHandle);
                new TIS.BL.Internal.Task().AddChilds(taskObj);
                Task task = new Task(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, taskObj);
                task.ShowDialog();
                FindAll();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvTask_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                TaskObject taskObj = (TaskObject)view.GetRow(view.FocusedRowHandle);
                if (!taskObj.ChildsAdded)
                    new TIS.BL.Internal.Task().AddChilds(taskObj);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel,"Are you sure you want to delete the task?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button3)  == DialogResult.Yes)
                {
                    new BL.Internal.Task().Remove((TaskObject)gdvTask.GetRow(this.gdvTask.FocusedRowHandle));
                    FindAll();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSearchTask_Click(object sender, EventArgs e)
        {
            try
            {
                FindAll();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        private void FindAll()
        {
            try
            {
                string description = "";
                if (txtDescription.Text == "")
                    description = "";
                else
                    description = "%" + txtDescription.Text + "%";

                BL.Internal.Task blTask = new BL.Internal.Task();
                TasksMember = blTask.GetFilter(PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(dteCreationDateFrom.DateTime),
                                                    PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(dteCreationDateTo.DateTime),
                                                    description);
                
                this.gdcTask.DataSource = TasksMember;
                this.repositoryItemDateEditDueDate.NullDate = repositoryItemDateEditDueDate.MinValue;
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

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
using TIS.DL.Internal.Vehicle;
using TIS.DL.Internal.Material;
using TIS.Framework.Security;

namespace TIS.Client.Material
{
    public partial class Materials : General.BaseChildForm
    {

        #region Fields
        DL.Internal.Employee.EmployeeObjectCollection _employees;
        #endregion

        #region Constructor
        public Materials()
        {
            try
            {
                InitializeComponent();
                SetPermissions();
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
        private void btnSearchMaterials_Click(object sender, EventArgs e)
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
        private void gdvMaterial_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialObject materialObj = (MaterialObject)view.GetRow(view.FocusedRowHandle);
                Material material = new Material(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, materialObj);
                material.ShowDialog();
                FindAll();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvMaterial_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialObject materialObj = (MaterialObject)view.GetRow(view.FocusedRowHandle);
                if (!materialObj.ChildsAdded)
                    new TIS.BL.Internal.Material().AddChilds(materialObj);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                Material material = new Material(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (material.ShowDialog() == DialogResult.OK)
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
        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvMaterial.FocusedRowHandle >= 0)
                {
                    if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Bent u zeker dat je het materiaal wilt verwijderen?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        new BL.Internal.Material().Remove((MaterialObject)gdvMaterial.GetRow(gdvMaterial.FocusedRowHandle));
                        FindAll();
                    }
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
                this.gdcMaterial.DataSource = new BL.Internal.Material().GetAll();
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
                if (!Functions.AllowMaintain(Context.User.Security.Material.AuthMaterial))
                    this.btnAddMaterial.Enabled = false;
                if (!Functions.AllowDelete(Context.User.Security.Material.AuthMaterial))
                    this.btnRemoveMaterial.Enabled = false;
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

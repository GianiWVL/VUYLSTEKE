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
using TIS.DL.Internal.MaterialCategory;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;
using DevExpress.XtraGrid.Views.Base;

namespace TIS.Client.Material
{
    public partial class MaterialCategories : General.BaseChildForm
    {

        #region Fields
        #endregion

        #region Constructor
        public MaterialCategories()
        {
            try
            {
                InitializeComponent();
                FindAll();
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
        #endregion 

        #region Events
        private void gdcMaterial_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            try
            {
                GridControlNavigator nav = (GridControlNavigator)sender;
                GridControl grid = (GridControl)nav.NavigatableControl;
                GridView view = (GridView)grid.FocusedView;
                switch (e.Button.ButtonType)
                {
                    case NavigatorButtonType.Remove:
                        if (MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (gdcMaterialCategory.FocusedView.Name == "gdvCategory")
                            {
                                new TIS.BL.Internal.MaterialCategory().Remove((MaterialCategoryObject)view.GetRow(view.FocusedRowHandle));
                                e.Handled = false;
                            }
                            if (gdcMaterialCategory.FocusedView.Name == "gdvType")
                            {
                                new TIS.BL.Internal.MaterialType().Remove((MaterialTypeObject)view.GetRow(view.FocusedRowHandle));
                                e.Handled = false;
                            }
                            if (gdcMaterialCategory.FocusedView.Name == "gdvSubTypes")
                            {
                                new TIS.BL.Internal.MaterialSubType().Remove((MaterialSubTypeObject)view.GetRow(view.FocusedRowHandle));
                                e.Handled = false;
                            }
                        }
                        else
                            if (e != null)
                                e.Handled = true;
                       
                        break;
                }
            }
            catch (System.Exception exception1)
            {
                e.Handled = true;
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvCategory_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (gdvCategory.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    int rowHandle;
                    if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                        rowHandle = view.DataRowCount - 1;
                    else
                        rowHandle = view.FocusedRowHandle;
                    MaterialCategoryObject category = (MaterialCategoryObject)this.gdvCategory.GetRow(rowHandle);
                    if (category != null)
                    {
                        new BL.Internal.MaterialCategory().Save(category);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvType_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    int rowHandle;
                    if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                        rowHandle = view.DataRowCount - 1;
                    else
                        rowHandle = view.FocusedRowHandle;
                    MaterialTypeObject type = (MaterialTypeObject)view.GetRow(rowHandle);
                    if (type != null)
                    {
                        new BL.Internal.MaterialType().Save(type);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvSubTypes_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;

                if (view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    int rowHandle;
                    if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                        rowHandle = view.DataRowCount - 1;
                    else
                        rowHandle = view.FocusedRowHandle;
                    MaterialSubTypeObject subType = (MaterialSubTypeObject)view.GetRow(rowHandle);
                    if (subType != null)
                    {
                        new BL.Internal.MaterialSubType().Save(subType);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void gdvCategory_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialCategoryObject category = (MaterialCategoryObject)view.GetRow(e.RowHandle);
                category.Types = new DL.Internal.MaterialType.MaterialTypeObjectCollection();
                category.Revisions = new DL.Internal.Revision.RevisionObjectCollection();
                category.Category = " ";

                new BL.Internal.MaterialCategory().Save(category);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvType_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialTypeObject type = (MaterialTypeObject)view.GetRow(e.RowHandle);
                MaterialCategoryObject category = (MaterialCategoryObject)gdvCategory.GetRow(gdvCategory.FocusedRowHandle);
                type.Type = " ";
                type.MaterialCategory = category;
                type.SubTypes = new DL.Internal.MaterialSubType.MaterialSubTypeObjectCollection();

                new BL.Internal.MaterialType().Save(type);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvSubTypes_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                
                MaterialSubTypeObject subType = (MaterialSubTypeObject)view.GetRow(e.RowHandle);
                MaterialTypeObject type = (MaterialTypeObject)view.ParentView.GetRow(view.SourceRowHandle);
                subType.SubType = " ";
                subType.MaterialType = type;
                new BL.Internal.MaterialSubType().Save(subType);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void gdvCategory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialCategoryObject obj = (MaterialCategoryObject)view.GetRow(view.FocusedRowHandle);
                TIS.Client.Material.MaterialCateogry materialCategory = new TIS.Client.Material.MaterialCateogry(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, obj);
                if (materialCategory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    obj.State = PROF_IT.Common.Enumerations.ObjectState.Modified;
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvType_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialTypeObject obj = (MaterialTypeObject)view.GetRow(view.FocusedRowHandle);
                TIS.Client.Material.MaterialCateogry materialCategory = new TIS.Client.Material.MaterialCateogry(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, obj);
                if (materialCategory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    obj.State = PROF_IT.Common.Enumerations.ObjectState.Modified;
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvSubTypes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaterialSubTypeObject obj = (MaterialSubTypeObject)view.GetRow(view.FocusedRowHandle);
                TIS.Client.Material.MaterialCateogry materialCategory = new TIS.Client.Material.MaterialCateogry(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, obj);
                if (materialCategory.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    obj.State = PROF_IT.Common.Enumerations.ObjectState.Modified;
                }
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
                MaterialCategoryObjectCollection materialCategories = new BL.Internal.MaterialCategory().GetAll();
                foreach (MaterialCategoryObject materialCategory in materialCategories)
                {
                    new BL.Internal.MaterialCategory().AddChilds(materialCategory);
                }

                this.gdcMaterialCategory.DataSource = materialCategories;
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
                if (!TIS.Framework.Security.Functions.AllowMaintain(Context.User.Security.Material.AuthMaterialCategory))
                {
                    gdcMaterialCategory.EmbeddedNavigator.Buttons.Append.Enabled = false;
                    gdcMaterialCategory.EmbeddedNavigator.Buttons.Edit.Enabled = false;
                }
                if (!TIS.Framework.Security.Functions.AllowDelete(Context.User.Security.Material.AuthMaterialCategory))
                    gdcMaterialCategory.EmbeddedNavigator.Buttons.Remove.Enabled = false;
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

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
using TIS.DL.Internal.Revision;

namespace TIS.Client.Material
{
    public partial class MaterialCateogry : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.MaterialCategory.MaterialCategoryObject _materialCategory;
        private TIS.DL.Internal.MaterialType.MaterialTypeObject _materialType;
        private TIS.DL.Internal.MaterialSubType.MaterialSubTypeObject _materialSubType;
        private TIS.DL.Internal.Revision.RevisionObjectCollection _revisions;
        #endregion

        #region Constructor
        public MaterialCateogry(PROF_IT.Common.Enumerations.TypeForm typeForm, MaterialCategoryObject materialCategory)
        {
            try
            {
                InitializeComponent();

                MaterialCategoryMember = materialCategory;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    Initialize();
                    InitializePropertyFormMaterialCategory();
                    SetPermissions();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public MaterialCateogry(PROF_IT.Common.Enumerations.TypeForm typeForm, MaterialTypeObject materialType)
        {
            try
            {
                InitializeComponent();

                MaterialTypeMember = materialType;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    Initialize();
                    InitializePropertyFormMaterialType();
                    SetPermissions();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public MaterialCateogry(PROF_IT.Common.Enumerations.TypeForm typeForm, MaterialSubTypeObject materialSubType)
        {
            try
            {
                InitializeComponent();

                MaterialSubTypeMember = materialSubType;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    Initialize();
                    InitializePropertyFormMaterialSubType();
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
        public MaterialCategoryObject MaterialCategoryMember
        {
            get { return _materialCategory; }
            set { _materialCategory = value; }
        }
        public MaterialTypeObject MaterialTypeMember
        {
            get { return _materialType; }
            set { _materialType = value; }
        }
        public MaterialSubTypeObject MaterialSubTypeMember
        {
            get { return _materialSubType; }
            set { _materialSubType = value; }
        }
        public RevisionObjectCollection Revisions
        {
            get { return _revisions; }
            set { _revisions = value; }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaterialCategoryMember != null)
                {
                    MaterialCategoryMember.Category = txtName.Text;
                    new BL.Internal.MaterialCategory().Save(MaterialCategoryMember);
                }
                    
                if (MaterialTypeMember != null)
                {
                    MaterialTypeMember.Type = txtName.Text;
                    new BL.Internal.MaterialType().Save(MaterialTypeMember);
                }
                    
                if (MaterialSubTypeMember != null)
                {
                    MaterialSubTypeMember.SubType = txtName.Text;
                    new BL.Internal.MaterialSubType().Save(MaterialSubTypeMember);
                }
                    

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

        private void gdvRevision_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (gdvRevision.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    RevisionObject obj = (RevisionObject)gdvRevision.GetRow(gdvRevision.FocusedRowHandle);
                    if (obj != null)
                    {
                        if (MaterialCategoryMember != null)
                            obj.MaterialCategory = MaterialCategoryMember;
                        if (MaterialTypeMember != null)
                            obj.MaterialType = MaterialTypeMember;
                        if (MaterialSubTypeMember != null)
                            obj.MaterialSubType = MaterialSubTypeMember;
                        if (obj.Revision != "")
                            new BL.Internal.Revision().Save(obj);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddRevision_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                gdvRevision.ClearColumnsFilter();
                // Get the handle of the source data row
                // the row will provide group column values for a new row
                int rowHandle = gdvRevision.GetDataRowHandleByGroupRowHandle(gdvRevision.FocusedRowHandle);
                //store group column values
                object[] groupValues = null;
                int groupColumnCount = gdvRevision.GroupedColumns.Count;
                if (groupColumnCount > 0)
                {
                    groupValues = new object[groupColumnCount];
                    for (int i = 0; i < groupColumnCount; i++)
                    {
                        groupValues[i] = gdvRevision.GetRowCellValue(rowHandle, gdvRevision.GroupedColumns[i]);
                    }
                }
                //Add a new Row
                gdvRevision.AddNewRow();
                //Get the handle of the new row
                int newRowHandle = gdvRevision.FocusedRowHandle;
                object newRow = gdvRevision.GetRow(newRowHandle);
                //Set cell values corresponding to group columns
                if (groupColumnCount > 0)
                {
                    for (int i = 0; i < groupColumnCount; i++)
                    {
                        gdvRevision.SetRowCellValue(newRowHandle, gdvRevision.GroupedColumns[i], groupValues[i]);
                    }

                    //MTSObject mts = new MTSObject();
                    //mts = (MTSObject)gdvRevision.GetRow(newRowHandle);
                    //mts.FinishingType = new BL.FinishingType().GetByID(mts.FinishingType.FinTypeID);
                }


                // Accept the new row
                gdvRevision.UpdateCurrentRow();
                // The row moves to a new position according to the current group settings
                // Locate the new row
                for (int n = 0; n < gdvRevision.DataRowCount; n++)
                {
                    if (gdvRevision.GetRow(n).Equals(newRow))
                    {
                        gdvRevision.FocusedRowHandle = n;
                        break;
                    }
                }

            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void btnRemoveRevision_Click(object sender, EventArgs e)
        {
            try
            {
                RevisionObject revision = (RevisionObject)gdvRevision.GetRow(gdvRevision.FocusedRowHandle);
                revision.State = PROF_IT.Common.Enumerations.ObjectState.Deleted;
                new BL.Internal.Revision().Remove(revision);
                gdcRevision.DataSource = Revisions.GetActive();
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
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void InitializePropertyFormMaterialCategory()
        {
            try
            {
                Revisions = new BL.Internal.Revision().GetByMaterialCategory(MaterialCategoryMember);
                gdcRevision.DataSource = Revisions;
                txtName.Text = MaterialCategoryMember.Category;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void InitializePropertyFormMaterialType()
        {
            try
            {
                Revisions = new BL.Internal.Revision().GetByMaterialType(MaterialTypeMember);
                gdcRevision.DataSource = Revisions;
                txtName.Text = MaterialTypeMember.Type;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void InitializePropertyFormMaterialSubType()
        {
            try
            {
                Revisions = new BL.Internal.Revision().GetByMaterialSubType(MaterialSubTypeMember);
                gdcRevision.DataSource = Revisions;
                txtName.Text = MaterialSubTypeMember.SubType;
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

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

namespace TIS.Client.Material
{
    public partial class Material : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Material.MaterialObject _material;
        private MaterialObject _materialOriginal;
        #endregion

        #region Constructor
        public Material(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();

                _typeForm = typeForm;
                _material = new MaterialObject();
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
        public Material(PROF_IT.Common.Enumerations.TypeForm typeForm, MaterialObject material)
        {
            try
            {
                InitializeComponent();

                _material = material;
                _materialOriginal = material.Clone();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    Initialize();
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
        public Material(PROF_IT.Common.Enumerations.TypeForm typeForm, VehicleObject vehicle)
        {
            try
            {
                InitializeComponent();

                _typeForm = typeForm;
                _material = new MaterialObject();
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    Initialize();
                    louVehicle.EditValue = vehicle;
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
        #endregion

        #region Properties
        public MaterialObject MaterialMember
        {
            get { return _material; }
            set { _material = value; }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialMember.Description = memoDescription.Text;
                MaterialMember.EmployeeCreator = (EmployeeObject)louCreator.EditValue;
                MaterialMember.EmployeeResponsable = (EmployeeObject)louResponsable.EditValue;
                MaterialMember.InternalNumber = txtInternalNumber.Text;
                MaterialMember.MaintenanceFrequency = Convert.ToInt32(spinMaintenanceFrequency.Value);
                MaterialMember.Maintenances = (MaintenanceObjectCollection)gdcMaintenance.DataSource ;
                MaterialMember.Memos = (MemoObjectCollection)gdcMemo.DataSource;
                MaterialMember.Name = txtName.Text;
                MaterialMember.NextMaintenance = dteNextMaintenance.DateTime;
                MaterialMember.Price = calcPrice.Value;
                MaterialMember.PurchasedOn = dtePurchasedOn.DateTime;
                MaterialMember.SerieNumber = txtSerieNumber.Text;
                MaterialMember.Supplier = (SupplierObject)louSupplier.EditValue;
                if (louCategory.EditValue != null)
                    MaterialMember.MaterialCategory = (MaterialCategoryObject)louCategory.EditValue;
                if (louType.EditValue != null)
                    MaterialMember.MaterialType = (MaterialTypeObject)louType.EditValue;
                if (louSubType.EditValue != null)
                    MaterialMember.MaterialSubType = (MaterialSubTypeObject)louSubType.EditValue;
                
                MaterialMember.Vehicle = (VehicleObject)louVehicle.EditValue;

                MaterialMember.Active = cbxActive.Checked;
                MaterialMember.Broken = cbxBroken.Checked;

                new BL.Internal.Material().Save(MaterialMember);
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
                MaterialMember = _materialOriginal;
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btnAddMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                Maintenance.Maintenance maintenance = new Maintenance.Maintenance(PROF_IT.Common.Enumerations.TypeForm.NewForm, MaterialMember);
                if (maintenance.ShowDialog() == DialogResult.OK)
                {
                    maintenance.MaintenanceMember.State = PROF_IT.Common.Enumerations.ObjectState.Modified;
                    MaterialMember.Maintenances.Add(maintenance.MaintenanceMember);
                    dteNextMaintenance.DateTime = MaterialMember.NextMaintenance;
                    gdcMaintenance.DataSource = MaterialMember.Maintenances.GetActive();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemoveMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                MaintenanceObject maintenance = (MaintenanceObject)gdvMaintenance.GetRow(gdvMaintenance.FocusedRowHandle);
                maintenance.State = PROF_IT.Common.Enumerations.ObjectState.Deleted;
                if (!maintenance.ChildsAdded)
                    maintenance.MaterialRevisions = new BL.Internal.MaterialRevision().GetByMaintenance(maintenance);
                new BL.Internal.Maintenance().Remove(maintenance);
                gdcMaintenance.DataSource = MaterialMember.Maintenances.GetActive();
                dteNextMaintenance.DateTime = MaterialMember.NextMaintenance;
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btnAddMemo_Click(object sender, EventArgs e)
        {
            try
            {
                Memo.Memo memo = new Memo.Memo(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (memo.ShowDialog() == DialogResult.OK)
                {
                    memo.MemoMember.Material = this.MaterialMember;
                    memo.MemoMember.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                    if (MaterialMember.Memos == null)
                        MaterialMember.Memos = new MemoObjectCollection();
                    MaterialMember.Memos.Add(memo.MemoMember);
                    gdcMemo.DataSource = MaterialMember.Memos.GetActive();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemoveMemo_Click(object sender, EventArgs e)
        {
            try
            {
                MemoObject memo = (MemoObject)gdvMemo.GetRow(gdvMemo.FocusedRowHandle);
                memo.State = PROF_IT.Common.Enumerations.ObjectState.Deleted;
                gdcMemo.DataSource = MaterialMember.Memos.GetActive();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvMemo_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                CardView view = (CardView)sender;
                if (view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    MemoObject memo = (MemoObject)view.GetRow(view.FocusedRowHandle);
                    if (memo != null)
                    {
                        memo.Material = MaterialMember;
                        new BL.Internal.Memo().Save(memo);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvMaintenance_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                CardView view = (CardView)sender;
                if (view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    MaintenanceObject maintenance = (MaintenanceObject)view.GetRow(view.FocusedRowHandle);
                    if (maintenance != null)
                    {
                        maintenance.Material = MaterialMember;
                        new BL.Internal.Maintenance().Save(maintenance);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvMaintenance_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                MaintenanceObject maintObj = (MaintenanceObject)view.GetRow(view.FocusedRowHandle);
                Maintenance.Maintenance maintenance = new Maintenance.Maintenance(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, MaterialMember, maintObj);
                maintenance.ShowDialog();
                gdcMaintenance.DataSource = MaterialMember.Maintenances.GetActive();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }

        private void louCategory_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (louCategory.EditValue != null)
                {
                    MaterialCategoryObject category = (MaterialCategoryObject)louCategory.EditValue;
                    louType.Properties.DataSource = new BL.Internal.MaterialType().GetByCategory(category);
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void louType_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (louType.EditValue != null)
                {
                    MaterialTypeObject type = (MaterialTypeObject)louType.EditValue;
                    louSubType.Properties.DataSource = new BL.Internal.MaterialSubType().GetSubTypesByType(type);
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
        public void Initialize()
        {
            try
            {
                this.louCategory.Properties.DataSource = new BL.Internal.MaterialCategory().GetAll();
                EmployeeObjectCollection employees = new BL.Internal.Employee().GetAll();
                this.louCreator.Properties.DataSource = employees;
                this.louResponsable.Properties.DataSource = employees;
                this.louSupplier.Properties.DataSource = new BL.Internal.Supplier().GetAll();
                this.louVehicle.Properties.DataSource = new BL.Internal.Vehicle().GetAll();
                this.louCategory.Properties.DataSource = new BL.Internal.MaterialCategory().GetAll();

                if (Context.User.Employee != null)
                {
                    this.louCreator.EditValue = Context.User.Employee;
                    this.louResponsable.EditValue = Context.User.Employee;
                }
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
                new BL.Internal.Material().AddChilds(MaterialMember);

                louCategory.Properties.DataSource = new BL.Internal.MaterialCategory().GetAll();

                txtInternalNumber.Text = MaterialMember.InternalNumber;
                txtName.Text = MaterialMember.Name;
                txtSerieNumber.Text = MaterialMember.SerieNumber;

                dtePurchasedOn.DateTime = MaterialMember.PurchasedOn;

                dteNextMaintenance.DateTime = MaterialMember.NextMaintenance;

                spinMaintenanceFrequency.Value = MaterialMember.MaintenanceFrequency;
                calcPrice.Value = MaterialMember.Price;

                if (MaterialMember.MaterialCategory != null)
                {
                    louCategory.EditValue = MaterialMember.MaterialCategory;
                }
                if (MaterialMember.MaterialCategory != null & MaterialMember.MaterialType != null)
                {
                    louType.Properties.DataSource = new BL.Internal.MaterialType().GetByCategory(MaterialMember.MaterialCategory);
                    louType.EditValue = MaterialMember.MaterialType;
                }
                if (MaterialMember.MaterialType != null & MaterialMember.MaterialSubType != null)
                {
                    louSubType.Properties.DataSource = new BL.Internal.MaterialSubType().GetSubTypesByType(MaterialMember.MaterialType);
                    louSubType.EditValue = MaterialMember.MaterialSubType;
                }

                memoDescription.Text = MaterialMember.Description;

                louCreator.EditValue = MaterialMember.EmployeeCreator;
                louResponsable.EditValue = MaterialMember.EmployeeResponsable;
                louSupplier.EditValue = MaterialMember.Supplier;
                louVehicle.EditValue = MaterialMember.Vehicle;

                cbxBroken.Checked = MaterialMember.Broken;
                cbxActive.Checked = MaterialMember.Active;

                this.gdcMaintenance.DataSource = MaterialMember.Maintenances;
                this.gdcMemo.DataSource = MaterialMember.Memos;

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
                    this.btnSave.Enabled = false;

                if (!Functions.AllowMaintain(Context.User.Security.Material.AuthMaterialMaintenance))
                    this.btnAddMaintenance.Enabled = false;
                if (!Functions.AllowDelete(Context.User.Security.Material.AuthMaterialMaintenance))
                    this.btnRemoveMaintenance.Enabled = false;

                if (!Functions.AllowMaintain(Context.User.Security.Material.AuthMaterialMemo))
                    this.btnAddMemo.Enabled = false;
                if (!Functions.AllowDelete(Context.User.Security.Material.AuthMaterialMemo))
                    this.btnRemoveMemo.Enabled = false;
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

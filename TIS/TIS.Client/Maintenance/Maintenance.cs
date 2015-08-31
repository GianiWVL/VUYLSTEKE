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
using TIS.DL.Internal.MaterialRevision;
using TIS.DL.Internal.Revision;

namespace TIS.Client.Maintenance
{
    public partial class Maintenance : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Maintenance.MaintenanceObject _maintenance;
        private MaterialRevisionObjectCollection _materialRevisions;
        private MaterialObject _material;
        #endregion

        #region Constructor
        public Maintenance(PROF_IT.Common.Enumerations.TypeForm typeForm, MaterialObject material)
        {
            try
            {
                InitializeComponent();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    Material = material;
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
        public Maintenance(PROF_IT.Common.Enumerations.TypeForm typeForm, MaterialObject material, MaintenanceObject maintenance)
        {
            try
            {
                InitializeComponent();
                _material = material;
                _maintenance = maintenance;
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
        public MaintenanceObject MaintenanceMember
        {
            get { return _maintenance; }
            set { _maintenance = value; }
        }
        public MaterialRevisionObjectCollection MaterialRevisions
        {
            get { return _materialRevisions; }
            set { _materialRevisions = value; }
        }
        public MaterialObject Material
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
                if (dteStartMaintenance.DateTime == DateTime.MinValue)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vul eerst een datum in van het onderhoud!", "Opgepast", MessageBoxButtons.OK);
                }
                else
                {
                    MaintenanceMember.Remark = memoRemark.Text;
                    MaintenanceMember.StartMaintenance = dteStartMaintenance.DateTime;
                    new BL.Internal.Maintenance().Save(MaintenanceMember);
                    new BL.Internal.MaterialRevision().Save(MaterialRevisions);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
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
                MaintenanceMember = new MaintenanceObject();
                MaintenanceMember.Material = Material;
                CreateNewMaterialRevisions();
                gdcRevision.DataSource = MaterialRevisions;
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
                dteStartMaintenance.DateTime = MaintenanceMember.StartMaintenance;
                memoRemark.Text = MaintenanceMember.Remark;
                MaintenanceMember.Material = Material;
                MaterialRevisions = new BL.Internal.MaterialRevision().GetByMaintenance(MaintenanceMember);
                gdcRevision.DataSource = MaterialRevisions;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void CreateNewMaterialRevisions()
        {
            try
            {
                MaterialRevisionObjectCollection materialRevisions = new MaterialRevisionObjectCollection();
                RevisionObjectCollection revisions;
                if (Material.MaterialCategory != null)
                {
                    revisions = new BL.Internal.Revision().GetByMaterialCategory(Material.MaterialCategory);
                    foreach (RevisionObject revision in revisions)
                    {
                        MaterialRevisionObject materialRevision = new MaterialRevisionObject();
                        materialRevision.Revision = revision.Revision;
                        materialRevision.Maintenance = MaintenanceMember;
                        materialRevision.Category = revision.MaterialCategory.Category;
                        materialRevision.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                        materialRevisions.Add(materialRevision);
                    }
                }
                if (Material.MaterialType != null)
                {
                    revisions = new BL.Internal.Revision().GetByMaterialType(Material.MaterialType);
                    foreach (RevisionObject revision in revisions)
                    {
                        MaterialRevisionObject materialRevision = new MaterialRevisionObject();
                        materialRevision.Revision = revision.Revision;
                        materialRevision.Maintenance = MaintenanceMember;
                        materialRevision.Category = revision.MaterialType.Type;
                        materialRevision.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                        materialRevisions.Add(materialRevision);
                    }
                }
                if (Material.MaterialSubType != null)
                {
                    revisions = new BL.Internal.Revision().GetByMaterialSubType(Material.MaterialSubType);
                    foreach (RevisionObject revision in revisions)
                    {
                        MaterialRevisionObject materialRevision = new MaterialRevisionObject();
                        materialRevision.Revision = revision.Revision;
                        materialRevision.Maintenance = MaintenanceMember;
                        materialRevision.Category = revision.MaterialSubType.SubType;
                        materialRevision.State = PROF_IT.Common.Enumerations.ObjectState.Created;
                        materialRevisions.Add(materialRevision);
                    }
                }

                MaterialRevisions = materialRevisions;
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

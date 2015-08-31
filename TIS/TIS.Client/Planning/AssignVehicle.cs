using System;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.BL.Internal;
using TIS.DL.Internal.User;
using TIS.DL.Internal.Vehicle;
using TIS.Framework.Security;
using TIS.Model.Internal;

namespace TIS.Client.Planning
{
    public partial class AssignVehicle : XtraForm
    {
        #region Constructors
        public AssignVehicle(VehicleObject vehicle)
        {
            InitializeComponent();

            this._vehicle = vehicle;
            this.txtVehicle.Text = vehicle.Name;

            FillCboDispatcher();
        }
        #endregion

        #region Fields
        private UnitOfWork _uow;
        private VehicleObject _vehicle;
        #endregion
        
        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            this._uow = new UnitOfWork();
            AssignedVehicle assignedVehicle = new AssignedVehicle(this._uow)
            {
                Truck = this._vehicle.VehID,
                TruckName = this._vehicle.Name,
                Planning = new TIS.Model.Internal.Planning(this._uow).GetPlanning(((ComboBoxItem)this.cboDispatcher.SelectedItem).Value.UsrID).Id
            };

            this._uow.CommitChanges();

            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cboDispatcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = this.cboDispatcher.SelectedItem != null;
        }
        #endregion

        #region Methods
        private void FillCboDispatcher()
        {
            //TODO: Re-check this
            UserObjectCollection users = new User().GetAll();
            foreach (UserObject user in users)
            {
                if (user.Security.Planning != null)
                    if (Functions.AllowMaintain(user.Security.Planning.AuthPlanning))
                    {
                        ComboBoxItem item = new ComboBoxItem { Value = user };
                        this.cboDispatcher.Items.Add(item);
                    }
            }
        }
        #endregion
    }
}
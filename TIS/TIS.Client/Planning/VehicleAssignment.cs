using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using TIS.DL.Internal.Vehicle;
using TIS.Model.Internal;

namespace TIS.Client.Planning
{
    public partial class VehicleAssignment : DevExpress.XtraEditors.XtraForm
    {
        #region Constructors
        public VehicleAssignment()
        {
            InitializeComponent();

            FillGrids();
        }
        #endregion

        #region Events
        private void gridvUnassigned_DoubleClick(object sender, EventArgs e)
        {
            AssignVehicle assignVehicle = new AssignVehicle((VehicleObject)this.gridvUnassigned.GetRow(this.gridvUnassigned.FocusedRowHandle));
            assignVehicle.ShowDialog();

            FillGrids();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        private void FillGrids()
        {
            gridUnassigned.DataSource = null;
            gridAssigned.DataSource = null;

            //TODO: Check for refactoring
            VehicleObjectCollection vehicles = new BL.Internal.Vehicle().GetAll();
            VehicleObjectCollection vehiclesTwo = new BL.Internal.Vehicle().GetAll();
            List<AssignedVehicle> assignedVehicles = new AssignedVehicle(new UnitOfWork()).GetAll();

            foreach (VehicleObject vehicleObject in vehicles)
            {
                foreach (AssignedVehicle assignedVehicle in assignedVehicles)
                {
                    if (vehicleObject.VehID == assignedVehicle.Truck)
                    {
                        vehiclesTwo.Remove(vehicleObject);
                    }
                }
            }

            gridUnassigned.DataSource = vehiclesTwo;
            gridAssigned.DataSource = assignedVehicles;
        }
        #endregion
    }
}
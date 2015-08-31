using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using TIS.Model.BL;
using System.Reflection;
using PROF_IT.Exceptionhandling;

namespace TIS.Client.Vehicle
{
    public partial class BoardComputer : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.Model.Internal.BoardComputer _boardComputer;
        private UnitOfWork _uow;
        private BoardComputerBL _boardComputerBL;
        #endregion

        #region Constructor
        public BoardComputer(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                Uow = new UnitOfWork();

                _typeForm = typeForm;
                _boardComputer = new TIS.Model.Internal.BoardComputer(Uow);
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
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
        public BoardComputer(PROF_IT.Common.Enumerations.TypeForm typeForm, TIS.Model.Internal.BoardComputer boardComputer)
        {
            try
            {
                InitializeComponent();
                Uow = new UnitOfWork();

                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    _boardComputer = new XPQuery<TIS.Model.Internal.BoardComputer>(Uow).Where(q => q.Id == boardComputer.Id).FirstOrDefault();
                    Initialize();
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
        public TIS.Model.Internal.BoardComputer BoardComputerMember
        {
            get { return _boardComputer; }
            set { _boardComputer = value; }
        }
        public UnitOfWork Uow
        {
            get { return _uow; }
            set { _uow = value; }
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TIS.Model.Internal.Supplier supplier = ((TIS.Model.Internal.Supplier)glouSupplier.GetSelectedDataRow());
                TIS.Model.Internal.Vehicle vehicle = ((TIS.Model.Internal.Vehicle)glouVehicleBuildIn.GetSelectedDataRow());

                _boardComputer.Brand = txtBrand.Text;
                _boardComputer.SerialNumber = txtSerialNumber.Text;
                _boardComputer.Supplier = supplier;
                _boardComputer.VehicleBuildIn = vehicle;
                _boardComputer.DateBuildIn = dteBuildIn.DateTime;

                Uow.CommitChanges();
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
        #endregion

        #region Methods
        public void Initialize()
        {
            try
            {
                _boardComputerBL = new BoardComputerBL(Uow);

                glouSupplier.Properties.DataSource = null;
                glouSupplier.Properties.DataSource = new SupplierBL(Uow).GetAll();
                glouSupplier.Properties.DisplayMember = "Name";
                glouSupplier.Properties.ValueMember = "supID";

                glouVehicleBuildIn.Properties.DataSource = new VehicleBL(Uow).GetAll();
                glouVehicleBuildIn.Properties.DisplayMember = "Name";
                glouVehicleBuildIn.Properties.ValueMember = "vehID";

                if (_boardComputer.Id != 0)
                {
                    txtBrand.Text = _boardComputer.Brand;
                    txtSerialNumber.Text = _boardComputer.SerialNumber;
                    glouSupplier.EditValue = _boardComputer.Supplier.supID;
                    glouVehicleBuildIn.EditValue = _boardComputer.VehicleBuildIn.vehID;
                    dteBuildIn.DateTime = _boardComputer.DateBuildIn;
                }
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

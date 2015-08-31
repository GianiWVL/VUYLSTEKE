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

namespace TIS.Client.Vehicle
{
    public partial class Vehicles : General.BaseChildForm
    {

        #region Fields
        DL.Internal.Employee.EmployeeObjectCollection _employees;
        #endregion

        #region Constructor
        public Vehicles()
        {
            try
            {
                InitializeComponent();
               
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
        private void btnSearchTransicsVehicle_Click(object sender, EventArgs e)
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
        private void gdvVehicle_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                VehicleObject vehicleObj = (VehicleObject)view.GetRow(view.FocusedRowHandle);
                Vehicle vehicle = new Vehicle(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, vehicleObj);
                vehicle.ShowDialog();
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
                this.gdcVehicle.DataSource = new BL.Internal.Vehicle().GetAll();
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

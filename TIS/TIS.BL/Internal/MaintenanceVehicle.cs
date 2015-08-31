using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.MaintenanceVehicle;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.Vehicle;

namespace TIS.BL.Internal
{
    public class MaintenanceVehicle : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public MaintenanceVehicle()
            : base()
        {

        }
        public MaintenanceVehicle(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MaintenanceVehicleObjectCollection GetAll()
        {
            MaintenanceVehicleObjectCollection maintenanceVehicles;
            try
            {
                maintenanceVehicles = new MaintenanceVehicleDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return maintenanceVehicles;
        }

        public MaintenanceVehicleObjectCollection GetByVehicleID(VehicleObject vehicle)
        {
            MaintenanceVehicleObjectCollection maintenanceVehicles;
            try
            {
                maintenanceVehicles = new MaintenanceVehicleDataService().GetByVehicleID(vehicle);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return maintenanceVehicles;
        }

        public void Save(MaintenanceVehicleObject maintenanceVehicle)
        {
            try
            {
                CheckTransaction();
                new MaintenanceVehicleDataService(Transaction).Save(maintenanceVehicle);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        public void Save(MaintenanceVehicleObjectCollection maintenanceVehicles)
        {
            try
            {
                foreach (MaintenanceVehicleObject maintenanceVehicle in maintenanceVehicles)
                {
                    if (maintenanceVehicle.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                        Remove(maintenanceVehicle);
                    if (maintenanceVehicle.State == PROF_IT.Common.Enumerations.ObjectState.Modified |
                            maintenanceVehicle.State == PROF_IT.Common.Enumerations.ObjectState.Created)
                        Save(maintenanceVehicle);
                }

            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(MaintenanceVehicleObject maintenanceVehicle)
        {
            try
            {
                CheckTransaction();
                new MaintenanceVehicleDataService(Transaction).Remove(maintenanceVehicle);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        public void RemoveAll(MaintenanceVehicleObjectCollection maintenanceVehicles)
        {
            try
            {
                foreach (MaintenanceVehicleObject maintenanceVehicle in maintenanceVehicles)
                {
                    Remove(maintenanceVehicle);
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion
    }
}

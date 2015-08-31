using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Vehicle;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.VehicleTransics;

namespace TIS.BL.Internal
{
    public class Vehicle : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Vehicle()
            : base()
        {

        }
        public Vehicle(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public VehicleObjectCollection GetAll()
        {
            VehicleObjectCollection vehicles;
            try
            {
                vehicles = new VehicleDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicles;
        }

        public VehicleTransicsObjectCollection GetVehiclesTransics()
        {
            VehicleTransicsObjectCollection vehicles;
            try
            {
                vehicles = new VehicleDataService().GetVehiclesTransics();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicles;
        }

        public void Save(VehicleObject vehicle)
        {
            try
            {
                CheckTransaction();
                new VehicleDataService(Transaction).Save(vehicle);
                if (vehicle.VehicleTransicsLink != null)
                    new VehicleTransicsLink(Transaction).Save(vehicle.VehicleTransicsLink);
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

        public void Remove(VehicleObject vehicle)
        {
            try
            {
                CheckTransaction();
                new VehicleDataService(Transaction).Remove(vehicle);
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

        #endregion
    }
}

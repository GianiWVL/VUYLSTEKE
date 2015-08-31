using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.VehicleMileage;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.Vehicle;

namespace TIS.BL.Internal
{
    public class VehicleMileage : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public VehicleMileage()
            : base()
        {

        }
        public VehicleMileage(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public VehicleMileageObjectCollection GetAll()
        {
            VehicleMileageObjectCollection vehicleMileages;
            try
            {
                vehicleMileages = new VehicleMileageDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicleMileages;
        }

        public VehicleMileageObjectCollection GetByVehicle(VehicleObject vehicle)
        {
            VehicleMileageObjectCollection vehicleMileages;
            try
            {
                vehicleMileages = new VehicleMileageDataService().GetByVehicle(vehicle);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicleMileages;
        }

        public void Save(VehicleMileageObject vehicleMileage)
        {
            try
            {
                CheckTransaction();
                new VehicleMileageDataService(Transaction).Save(vehicleMileage);
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

        public void Remove(VehicleMileageObject vehicleMileage)
        {
            try
            {
                CheckTransaction();
                new VehicleMileageDataService(Transaction).Remove(vehicleMileage);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.VehicleType;
using System.Data.SqlClient;
using TIS.DATA.Internal;
using System.Reflection;

namespace TIS.BL.Internal
{
    public class VehicleType : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public VehicleType()
            : base()
        {

        }
        public VehicleType(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public VehicleTypeObjectCollection GetAll()
        {
            VehicleTypeObjectCollection vehicleTypes;
            try
            {
                vehicleTypes = new VehicleTypeDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicleTypes;
        }

        public void Save(VehicleTypeObject vehicleType)
        {
            try
            {
                CheckTransaction();
                new VehicleTypeDataService(Transaction).Save(vehicleType);
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

        public void Remove(VehicleTypeObject vehicleType)
        {
            try
            {
                CheckTransaction();
                new VehicleTypeDataService(Transaction).Remove(vehicleType);
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

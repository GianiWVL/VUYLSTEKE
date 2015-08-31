using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.VehicleTransicsLink;
using System.Reflection;
using TIS.DATA.Internal;

namespace TIS.BL.Internal
{
    public class VehicleTransicsLink : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public VehicleTransicsLink()
            : base()
        {

        }
        public VehicleTransicsLink(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public VehicleTransicsLinkObjectCollection GetAll()
        {
            VehicleTransicsLinkObjectCollection vehicleTransicsLinks;
            try
            {
                vehicleTransicsLinks = new VehicleTransicsLinkDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicleTransicsLinks;
        }

        public void Save(VehicleTransicsLinkObject vehicleTransicsLink)
        {
            try
            {
                CheckTransaction();
                new VehicleTransicsLinkDataService(Transaction).Save(vehicleTransicsLink);
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

        public void Remove(VehicleTransicsLinkObject vehicleTransicsLink)
        {
            try
            {
                CheckTransaction();
                new VehicleTransicsLinkDataService(Transaction).Remove(vehicleTransicsLink);
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

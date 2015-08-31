using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.FuelCorrection;
using TIS.DATA.Internal;
using System.Reflection;

namespace TIS.BL.Internal
{
    public class FuelCorrection : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public FuelCorrection()
            : base()
        {

        }
        public FuelCorrection(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public FuelCorrectionObjectCollection GetAll()
        {
            FuelCorrectionObjectCollection fuelCorrections;
            try
            {
                fuelCorrections = new FuelCorrectionDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return fuelCorrections;
        }

        public void Save(FuelCorrectionObject fuelCorrection)
        {
            try
            {
                CheckTransaction();
                new FuelCorrectionDataService(Transaction).Save(fuelCorrection);
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

        public void Remove(FuelCorrectionObject fuelCorrection)
        {
            try
            {
                CheckTransaction();
                new FuelCorrectionDataService(Transaction).Remove(fuelCorrection);
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

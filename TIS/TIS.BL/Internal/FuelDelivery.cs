using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.FuelDelivery;
using TIS.DATA.Internal;
using System.Reflection;

namespace TIS.BL.Internal
{
    public class FuelDelivery : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public FuelDelivery()
            : base()
        {

        }
        public FuelDelivery(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public FuelDeliveryObjectCollection GetAll()
        {
            FuelDeliveryObjectCollection fuelDeliverys;
            try
            {
                fuelDeliverys = new FuelDeliveryDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return fuelDeliverys;
        }

        public FuelDeliveryObjectCollection GetAllNotZero()
        {
            FuelDeliveryObjectCollection fuelDeliverys;
            try
            {
                fuelDeliverys = new FuelDeliveryDataService().GetAllNotZero();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return fuelDeliverys;
        }

        public FuelDeliveryObjectCollection GetFilter(DateTime dateFromDelivery, DateTime dateToDelivery)
        {
            FuelDeliveryObjectCollection fuelDeliverys;
            try
            {
                fuelDeliverys = new FuelDeliveryDataService().GetFilter(dateFromDelivery,dateToDelivery);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return fuelDeliverys;
        }

        public void Save(FuelDeliveryObject fuelDelivery)
        {
            try
            {
                CheckTransaction();
                new FuelDeliveryDataService(Transaction).Save(fuelDelivery);
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

        public void Remove(FuelDeliveryObject fuelDelivery)
        {
            try
            {
                CheckTransaction();
                new FuelDeliveryDataService(Transaction).Remove(fuelDelivery);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Supplier;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class Supplier : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Supplier()
            : base()
        {
            
        }
        public Supplier(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public SupplierObjectCollection GetAll()
        {
            SupplierObjectCollection suppliers;
            try
            {
                suppliers = new SupplierDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return suppliers;
        }

        public SupplierObject GetSupplierByEmail(string email)
        {
            SupplierObject supplier;
            try
            {
                supplier = new SupplierDataService().GetSupplierByEmail(email);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return supplier;
        }

        public void Save(SupplierObject supplier)
        {
            try
            {
                CheckTransaction();
                new SupplierDataService(Transaction).Save(supplier);
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

        public void Remove(SupplierObject supplier)
        {
            try
            {
                CheckTransaction();
                new SupplierDataService(Transaction).Remove(supplier);
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

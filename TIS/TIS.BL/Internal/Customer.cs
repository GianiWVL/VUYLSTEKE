using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Customer;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class Customer : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Customer()
            : base()
        {
            
        }
        public Customer(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public CustomerObjectCollection GetAll()
        {
            CustomerObjectCollection customers;
            try
            {
                customers = new CustomerDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return customers;
        }

        public CustomerObjectCollection GetFilter(string name, string vat)
        {
            CustomerObjectCollection customers;
            try
            {
                customers = new CustomerDataService().GetFilter(name, vat);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return customers;
        }

        public void Save(CustomerObject customer)
        {
            try
            {
                CheckTransaction();
                new CustomerDataService(Transaction).Save(customer);
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

        public void Remove(CustomerObject customer)
        {
            try
            {
                CheckTransaction();
                new CustomerDataService(Transaction).Remove(customer);
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

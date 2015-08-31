using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Employee;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class Employee : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Employee()
            : base()
        {
            
        }
        public Employee(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public EmployeeObjectCollection GetAll()
        {
            EmployeeObjectCollection employees;
            try
            {
                employees = new EmployeeDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return employees;
        }

        public EmployeeObject GetEmployeeByID(Guid id)
        {
            EmployeeObject employee;
            try
            {
                employee = new EmployeeDataService().GetEmployeeByID(id);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return employee;
        }

        public EmployeeObject GetEmployeeByEmail(string email)
        {
            EmployeeObject employee;
            try
            {
                employee = new EmployeeDataService().GetEmployeeByEmail(email);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return employee;
        }

        public void Save(EmployeeObject employee)
        {
            try
            {
                CheckTransaction();
                new EmployeeDataService(Transaction).Save(employee);
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

        public void Remove(EmployeeObject employee)
        {
            try
            {
                CheckTransaction();
                new EmployeeDataService(Transaction).Remove(employee);
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

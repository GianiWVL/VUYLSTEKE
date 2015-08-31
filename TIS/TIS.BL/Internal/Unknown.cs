using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Unknown;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class Unknown : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Unknown()
            : base()
        {

        }
        public Unknown(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public UnknownObjectCollection GetAll()
        {
            UnknownObjectCollection unknowns;
            try
            {
                unknowns = new UnknownDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return unknowns;
        }

        public UnknownObject GetUnknownByEmail(string email)
        {
            UnknownObject unknown;
            try
            {
                unknown = new UnknownDataService().GetUnknownByEmail(email);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return unknown;
        }

        public void Save(UnknownObject unknown)
        {
            try
            {
                CheckTransaction();
                new UnknownDataService(Transaction).Save(unknown);
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

        public void Remove(UnknownObject unknown)
        {
            try
            {
                CheckTransaction();
                new UnknownDataService(Transaction).Remove(unknown);
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

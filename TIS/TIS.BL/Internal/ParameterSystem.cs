using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.ParameterSystem;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class ParameterSystem : PROF_IT.DLM.BL.SqlServer.BaseObject
    { 

        #region Constructor
        public ParameterSystem()
            : base()
        {
            
        }
        public ParameterSystem(SqlTransaction transaction)
            : base(transaction)
        {
            
        }
        #endregion

        #region Methods

        public ParameterSystemObjectCollection GetAll()
        {
            ParameterSystemObjectCollection parameters;
            try
            {
                parameters = new ParameterSystemDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return parameters;
        }

        public ParameterSystemObject GetByKeyName(string keyName)
        {
            ParameterSystemObject parameter;
            try
            {
                parameter = new ParameterSystemDataService().GetByKeyName(keyName);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return parameter;
        }

        public void Save(ParameterSystemObject parameter)
        {
            try
            {
                CheckTransaction();
                new ParameterSystemDataService(Transaction).Save(parameter);
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

        public void Remove(ParameterSystemObject parameter)
        {
            try
            {
                CheckTransaction();
                new ParameterSystemDataService(Transaction).Remove(parameter);
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

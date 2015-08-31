using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.MaterialSubType;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.MaterialType;

namespace TIS.BL.Internal
{
    public class MaterialSubType : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public MaterialSubType()
            : base()
        {

        }
        public MaterialSubType(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MaterialSubTypeObjectCollection GetAll()
        {
            MaterialSubTypeObjectCollection materialSubTypes;
            try
            {
                materialSubTypes = new MaterialSubTypeDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materialSubTypes;
        }

        public MaterialSubTypeObjectCollection GetSubTypesByType(MaterialTypeObject type)
        {
            MaterialSubTypeObjectCollection materialSubTypes;
            try
            {
                materialSubTypes = new MaterialSubTypeDataService().GetSubTypeByType(type);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materialSubTypes;
        }

        public void Save(MaterialSubTypeObject materialSubType)
        {
            try
            {
                CheckTransaction();
                new MaterialSubTypeDataService(Transaction).Save(materialSubType);
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

        public void Remove(MaterialSubTypeObject materialSubType)
        {
            try
            {
                CheckTransaction();
                new MaterialSubTypeDataService(Transaction).Remove(materialSubType);

                Revision blREv = new Revision(Transaction);
                blREv.RemoveAll(materialSubType.Revisions);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.MaterialRevision;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.Maintenance;

namespace TIS.BL.Internal
{
    public class MaterialRevision : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public MaterialRevision()
            : base()
        {

        }
        public MaterialRevision(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MaterialRevisionObjectCollection GetByMaintenance(MaintenanceObject maintenance)
        {
            MaterialRevisionObjectCollection materialRevisions;
            try
            {
                materialRevisions = new MaterialRevisionDataService().GetByMaintenance(maintenance);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materialRevisions;
        }

        public void Save(MaterialRevisionObject materialRevision)
        {
            try
            {
                CheckTransaction();
                
                new MaterialRevisionDataService(Transaction).Save(materialRevision);
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

        public void Save(MaterialRevisionObjectCollection materialRevisions)
        {
            try
            {
                foreach (MaterialRevisionObject materialRevision in materialRevisions)
                {
                    if (materialRevision.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                        Remove(materialRevision);
                    else
                        Save(materialRevision);
                    Transaction = null;
                }

            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(MaterialRevisionObject materialRevision)
        {
            try
            {
                CheckTransaction();
                new MaterialRevisionDataService(Transaction).Remove(materialRevision);
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

        public void RemoveAll(MaterialRevisionObjectCollection materialRevisions)
        {
            try
            {
                foreach (MaterialRevisionObject materialRevision in materialRevisions)
                {
                    Remove(materialRevision);
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion
    }
}

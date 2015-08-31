using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Maintenance;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.Material;

namespace TIS.BL.Internal
{
    public class Maintenance : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public Maintenance()
            : base()
        {

        }
        public Maintenance(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MaintenanceObjectCollection GetAll()
        {
            MaintenanceObjectCollection maintenances;
            try
            {
                maintenances = new MaintenanceDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return maintenances;
        }

        public MaintenanceObjectCollection GetMaintenancesByMaterialID(MaterialObject material)
        {
            MaintenanceObjectCollection maintenances;
            try
            {
                maintenances = new MaintenanceDataService().GetMemosByMaintenanceID(material);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return maintenances;
        }

        public void Save(MaintenanceObject maintenance)
        {
            try
            {
                CheckTransaction();
                new MaintenanceDataService(Transaction).Save(maintenance);
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

        public void Save(MaintenanceObjectCollection maintenances)
        {
            try
            {
                foreach (MaintenanceObject maintenance in maintenances)
                {
                    if (maintenance.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                        Remove(maintenance);
                    if (maintenance.State == PROF_IT.Common.Enumerations.ObjectState.Modified |
                            maintenance.State == PROF_IT.Common.Enumerations.ObjectState.Created)
                        Save(maintenance);
                }

            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(MaintenanceObject maintenance)
        {
            try
            {
                CheckTransaction();
                if (maintenance.MaterialRevisions.Count != 0)
                    new BL.Internal.MaterialRevision(Transaction).RemoveAll(maintenance.MaterialRevisions);
                new MaintenanceDataService(Transaction).Remove(maintenance);
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

        public void RemoveAll(MaintenanceObjectCollection maintenances)
        {
            try
            {
                foreach (MaintenanceObject maintenance in maintenances)
                {
                    Remove(maintenance);
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

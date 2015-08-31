using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Material;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.Vehicle;

namespace TIS.BL.Internal
{
    public class Material : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Material()
            : base()
        {

        }
        public Material(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MaterialObjectCollection GetAll()
        {
            MaterialObjectCollection materials;
            try
            {
                materials = new MaterialDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materials;
        }

        public MaterialObjectCollection GetByVehicle(VehicleObject vehicle)
        {
            MaterialObjectCollection materials;
            try
            {
                materials = new MaterialDataService().GetByVehicle(vehicle);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materials;
        }

        public void Save(MaterialObject material)
        {
            try
            {
                CheckTransaction();
                new MaterialDataService(Transaction).Save(material);
                if (material.Memos != null)
                    new Memo(Transaction).Save(material.Memos);
                if (material.Maintenances != null)
                    new Maintenance(Transaction).Save(material.Maintenances);
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

        public void Remove(MaterialObject material)
        {
            try
            {
                CheckTransaction();
                new MaterialDataService(Transaction).Remove(material);
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

        public void AddChilds(MaterialObject material)
        {
            try
            {
                material.Memos = new BL.Internal.Memo().GetMemosByMaterialID(material);
                material.Maintenances = new BL.Internal.Maintenance().GetMaintenancesByMaterialID(material);
                material.ChildsAdded = true;
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

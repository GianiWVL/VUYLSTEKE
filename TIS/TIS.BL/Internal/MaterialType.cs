using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.MaterialType;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialSubType;

namespace TIS.BL.Internal
{
    public class MaterialType : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public MaterialType()
            : base()
        {

        }
        public MaterialType(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MaterialTypeObjectCollection GetAll()
        {
            MaterialTypeObjectCollection materialTypes;
            try
            {
                materialTypes = new MaterialTypeDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materialTypes;
        }

        public MaterialTypeObjectCollection GetByCategory(MaterialCategoryObject category)
        {
            MaterialTypeObjectCollection materialTypes;
            try
            {
                materialTypes = new MaterialTypeDataService().GetTypesByCategorie(category);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materialTypes;
        }

        public void Save(MaterialTypeObject materialType)
        {
            try
            {
                CheckTransaction();
                new MaterialTypeDataService(Transaction).Save(materialType);
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

        public void Remove(MaterialTypeObject materialType)
        {
            try
            {
                CheckTransaction();
                foreach (MaterialSubTypeObject subtype in materialType.SubTypes)
                {
                    new MaterialSubType(Transaction).Remove(subtype);
                }
                Revision blREv = new Revision(Transaction);
                blREv.RemoveAll(materialType.Revisions);

                new MaterialTypeDataService(Transaction).Remove(materialType);
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

        public void AddChilds(MaterialTypeObject materialType)
        {
            try
            {
                MaterialSubType bl = new MaterialSubType();
                materialType.SubTypes = bl.GetSubTypesByType(materialType);
                materialType.ChildsAdded = true;
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

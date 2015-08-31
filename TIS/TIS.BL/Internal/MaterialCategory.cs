using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.MaterialCategory;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;

namespace TIS.BL.Internal
{
    public class MaterialCategory : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public MaterialCategory()
            : base()
        {

        }
        public MaterialCategory(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MaterialCategoryObjectCollection GetAll()
        {
            MaterialCategoryObjectCollection materialCategorys;
            try
            {
                materialCategorys = new MaterialCategoryDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return materialCategorys;
        }

        public void Save(MaterialCategoryObject materialCategory)
        {
            try
            {
                CheckTransaction();
                new MaterialCategoryDataService(Transaction).Save(materialCategory);
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

        public void Remove(MaterialCategoryObject materialCategory)
        {
            try
            {
                CheckTransaction();
                foreach (MaterialTypeObject type in materialCategory.Types)
                {
                    foreach (MaterialSubTypeObject subType in type.SubTypes)
                    {
                        new MaterialSubType(Transaction).Remove(subType);
                    }
                    new MaterialType(Transaction).Remove(type);
                }
                Revision blREv = new Revision(Transaction);
                blREv.RemoveAll(materialCategory.Revisions);

                new MaterialCategoryDataService(Transaction).Remove(materialCategory);
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

        public void AddChilds(MaterialCategoryObject materialCategory)
        {
            try
            {
                Revision blRev = new Revision();
                MaterialType bl = new MaterialType();
                materialCategory.Types = bl.GetByCategory(materialCategory);
                materialCategory.Revisions = blRev.GetByMaterialCategory(materialCategory);
                foreach (MaterialTypeObject materialType in  materialCategory.Types)
                {
                    materialType.SubTypes = new MaterialSubType().GetSubTypesByType(materialType);
                    materialType.Revisions = blRev.GetByMaterialType(materialType);
                    materialType.ChildsAdded = true;
                    foreach (MaterialSubTypeObject materialSubType in materialType.SubTypes)
                    {
                        materialSubType.Revisions = blRev.GetByMaterialSubType(materialSubType);
                        materialSubType.ChildsAdded = true;
                    }
                    
                }
                materialCategory.ChildsAdded = true;
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

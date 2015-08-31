using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Revision;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;
using TIS.DL.Internal.MaterialCategory;

namespace TIS.BL.Internal
{
    public class Revision : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public Revision()
            : base()
        {

        }
        public Revision(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public RevisionObjectCollection GetByMaterialCategory(MaterialCategoryObject materialCategory)
        {
            RevisionObjectCollection revisions;
            try
            {
                revisions = new RevisionDataService().GetByMaterialCateogry(materialCategory);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return revisions;
        }

        public RevisionObjectCollection GetByMaterialSubType(MaterialSubTypeObject materialSubType)
        {
            RevisionObjectCollection revisions;
            try
            {
                revisions = new RevisionDataService().GetByMaterialSubType(materialSubType);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return revisions;
        }

        public RevisionObjectCollection GetByMaterialType(MaterialTypeObject materialType)
        {
            RevisionObjectCollection revisions;
            try
            {
                revisions = new RevisionDataService().GetByMaterialType(materialType);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return revisions;
        }

        public void Save(RevisionObject revision)
        {
            try
            {
                CheckTransaction();
                new RevisionDataService(Transaction).Save(revision);
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

        public void Save(RevisionObjectCollection revisions)
        {
            try
            {
                foreach (RevisionObject revision in revisions)
                {
                    if (revision.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                        Remove(revision);
                    if (revision.State == PROF_IT.Common.Enumerations.ObjectState.Modified |
                            revision.State == PROF_IT.Common.Enumerations.ObjectState.Created)
                        Save(revision);
                }

            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(RevisionObject revision)
        {
            try
            {
                CheckTransaction();
                new RevisionDataService(Transaction).Remove(revision);
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

        public void RemoveAll(RevisionObjectCollection revisions)
        {
            try
            {
                foreach (RevisionObject revision in revisions)
                {
                    Remove(revision);
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

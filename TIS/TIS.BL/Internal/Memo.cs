using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Memo;
using TIS.DATA.Internal;
using System.Reflection;
using TIS.DL.Internal.Material;

namespace TIS.BL.Internal
{
    public class Memo : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public Memo()
            : base()
        {

        }
        public Memo(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public MemoObjectCollection GetAll()
        {
            MemoObjectCollection memos;
            try
            {
                memos = new MemoDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return memos;
        }

        public MemoObjectCollection GetMemosByMaterialID(MaterialObject material)
        {
            MemoObjectCollection memos;
            try
            {
                memos = new MemoDataService().GetMemosByMaintenanceID(material);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return memos;
        }

        public void Save(MemoObject memo)
        {
            try
            {
                CheckTransaction();
                new MemoDataService(Transaction).Save(memo);
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

        public void Save(MemoObjectCollection memos)
        {
            try
            {
                foreach (MemoObject memo in memos)
                {
                    if (memo.State == PROF_IT.Common.Enumerations.ObjectState.Deleted)
                        Remove(memo);
                    if (memo.State == PROF_IT.Common.Enumerations.ObjectState.Modified |
                            memo.State == PROF_IT.Common.Enumerations.ObjectState.Created)
                        Save(memo);
                }

            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(MemoObject memo)
        {
            try
            {
                CheckTransaction();
                new MemoDataService(Transaction).Remove(memo);
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

        public void RemoveAll(MemoObjectCollection memos)
        {
            try
            {
                foreach (MemoObject memo in memos)
                {
                    Remove(memo);
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

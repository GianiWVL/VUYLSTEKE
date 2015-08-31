using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Language;
using TIS.DATA.Internal;
using System.Reflection;
using System.Data.SqlClient;

namespace TIS.BL.Internal
{
    public class Language : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Language()
            : base()
        {

        }
        public Language(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public LanguageObjectCollection GetAll()
        {
            LanguageObjectCollection languages;
            try
            {
                languages = new LanguageDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return languages;
        }

        public void Save(LanguageObject language)
        {
            try
            {
                CheckTransaction();
                new LanguageDataService(Transaction).Save(language);
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

        public void Remove(LanguageObject language)
        {
            try
            {
                CheckTransaction();
                new LanguageDataService(Transaction).Remove(language);
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

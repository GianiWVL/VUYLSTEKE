using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA;
using System.Data;
using TIS.DL.Internal.Language;
using System.Reflection;
using System.Data.SqlClient;
using PROF_IT.DLM.DATA.SqlServer;

namespace TIS.DATA.Internal
{
    public class LanguageDataService : DataServiceBase
    {
        public LanguageDataService()
            : base()
        { }
        public LanguageDataService(IDbTransaction txn)
            : base(txn)
        { }

        public string BaseQuery(bool selectTop, int top)
        {
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                if (selectTop == true)
                    builder.SelectTop(top);
                else
                    builder.Select();
                builder.AppendColumn(LanguageObject.LAN_ID);
                builder.AppendColumn(LanguageObject.LANGUAGE);
                builder.AppendColumn(LanguageObject.LANGUAGE_DUTCH);
                builder.AppendFromTable(LanguageObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public LanguageObjectCollection GetAll()
        {
            LanguageObjectCollection languages = new LanguageObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(LanguageObject.LANGUAGE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                languages = LanguageConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return languages;
        }

        public void Save(LanguageObject language)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Language_SAVE",
                    CreateParameter("@lanID", SqlDbType.UniqueIdentifier, language.LanID, ParameterDirection.InputOutput),
                    CreateParameter("@Language", SqlDbType.VarChar, language.Language),
                    CreateParameter("@LanguageDutch", SqlDbType.VarChar, language.LanguageDutch)
                    );
                language.LanID = (Guid)cmd.Parameters["@lanID"].Value;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }

        public bool Remove(LanguageObject language)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Language_DELETE",
                    CreateParameter("@lanID", SqlDbType.UniqueIdentifier, language.LanID, ParameterDirection.Input)
                    );
                return true;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }
    }
}

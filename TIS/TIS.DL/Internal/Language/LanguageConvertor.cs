using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Supplier;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Language
{
    public static class LanguageConvertor
    {
        public static LanguageObject LanguageRowToObject(DataRow Language, string alias)
        {
            LanguageObject obj = new LanguageObject();
            try
            {
                if (Language != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Language, LanguageObject.ConvertColumnToAlias(LanguageObject.LAN_ID, alias), false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.LanID = RowFunctions.GetValueFromRowToGuid(Language, LanguageObject.ConvertColumnToAlias(LanguageObject.LAN_ID, alias), true, DataRowVersion.Current);
                        obj.Language = RowFunctions.GetValueFromRowToString(Language, LanguageObject.ConvertColumnToAlias(LanguageObject.LANGUAGE, alias), false, DataRowVersion.Current);
                        obj.LanguageDutch = RowFunctions.GetValueFromRowToString(Language, LanguageObject.ConvertColumnToAlias(LanguageObject.LANGUAGE_DUTCH, alias), false, DataRowVersion.Current);
                    }
                    return obj;
                }
                obj = null;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return obj;
        }

        public static LanguageObjectCollection DataTableToCollection(DataTable Languages)
        {
            LanguageObjectCollection objectsTotal;
            LanguageObjectCollection objects = new LanguageObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = Languages.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(LanguageRowToObject(current, LanguageObject.TABLE));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                objectsTotal = objects;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return objectsTotal;
        }
    }
}

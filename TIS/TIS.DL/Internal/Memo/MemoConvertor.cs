using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Material;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Memo
{
    public static class MemoConvertor
    {
        public static MemoObject MemoRowToObject(DataRow Memo)
        {
            MemoObject obj = new MemoObject();
            try
            {
                if (Memo != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Memo, MemoObject.MEMO_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MemoID = RowFunctions.GetValueFromRowToGuid(Memo, MemoObject.MEMO_ID, true, DataRowVersion.Current);
                        //obj.Material = MaterialConvertor.MaterialRowToObject(Memo);
                        obj.DateTime = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(RowFunctions.GetValueFromRowToString(Memo, MemoObject.DATETIME, false, DataRowVersion.Current));
                        obj.Memo = RowFunctions.GetValueFromRowToString(Memo, MemoObject.MEMO, false, DataRowVersion.Current);
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

        public static MemoObjectCollection DataTableToCollection(DataTable Memos)
        {
            MemoObjectCollection objectsTotal;
            MemoObjectCollection objects = new MemoObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = Memos.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MemoRowToObject(current));
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

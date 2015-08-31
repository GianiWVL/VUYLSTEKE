using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Unknown
{
    public static class UnknownConvertor
    {
        public static UnknownObject UnknownRowToObject(DataRow unknown)
        {
            UnknownObject obj = new UnknownObject();
            try
            {
                if (unknown != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(unknown, UnknownObject.UNK_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.UnkID = RowFunctions.GetValueFromRowToGuid(unknown, UnknownObject.UNK_ID, true, DataRowVersion.Current);
                        obj.Email = RowFunctions.GetValueFromRowToString(unknown, UnknownObject.EMAIL, true, DataRowVersion.Current);
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

        public static UnknownObjectCollection DataTableToCollection(DataTable unknowns)
        {
            UnknownObjectCollection objectsTotal;
            UnknownObjectCollection objects = new UnknownObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = unknowns.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(UnknownRowToObject(current));
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

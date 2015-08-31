using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Revision
{
    public static class RevisionConvertor
    {
        public static RevisionObject RevisionRowToObject(DataRow Revision)
        {
            RevisionObject obj = new RevisionObject();
            try
            {
                if (Revision != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Revision, RevisionObject.REV_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.RevID = RowFunctions.GetValueFromRowToGuid(Revision, RevisionObject.REV_ID, true, DataRowVersion.Current);
                        obj.MaterialCategory = MaterialCategoryConvertor.MaterialCategoryRowToObject(Revision, "");
                        obj.MaterialType = MaterialTypeConvertor.MaterialTypeRowToObject(Revision, "");
                        obj.MaterialSubType = MaterialSubTypeConvertor.MaterialSubTypeRowToObject(Revision, "");
                        obj.Revision = RowFunctions.GetValueFromRowToString(Revision, RevisionObject.REVISION, false, DataRowVersion.Current);
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

        public static RevisionObjectCollection DataTableToCollection(DataTable Revisions)
        {
            RevisionObjectCollection objectsTotal;
            RevisionObjectCollection objects = new RevisionObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = Revisions.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(RevisionRowToObject(current));
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

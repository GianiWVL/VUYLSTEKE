using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Maintenance;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.MaterialRevision
{
    public static class MaterialRevisionConvertor
    {
        public static MaterialRevisionObject MaterialRevisionRowToObject(DataRow MaterialRevision)
        {
            MaterialRevisionObject obj = new MaterialRevisionObject();
            try
            {
                if (MaterialRevision != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(MaterialRevision, MaterialRevisionObject.MATREV_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MatRevID = RowFunctions.GetValueFromRowToGuid(MaterialRevision, MaterialRevisionObject.MATREV_ID, true, DataRowVersion.Current);
                        obj.Maintenance = MaintenanceConvertor.MaintenanceRowToObject(MaterialRevision);
                        obj.Revision = RowFunctions.GetValueFromRowToString(MaterialRevision, MaterialRevisionObject.REVISION, false, DataRowVersion.Current);
                        obj.Answer = RowFunctions.GetValueFromRowToString(MaterialRevision, MaterialRevisionObject.ANSWER, false, DataRowVersion.Current);
                        obj.Category = RowFunctions.GetValueFromRowToString(MaterialRevision, MaterialRevisionObject.CATEGORY, false, DataRowVersion.Current);
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

        public static MaterialRevisionObjectCollection DataTableToCollection(DataTable MaterialRevisions)
        {
            MaterialRevisionObjectCollection objectsTotal;
            MaterialRevisionObjectCollection objects = new MaterialRevisionObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = MaterialRevisions.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MaterialRevisionRowToObject(current));
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

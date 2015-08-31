using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;
using TIS.DL.Internal.MaterialType;

namespace TIS.DL.Internal.MaterialSubType
{
    public static class MaterialSubTypeConvertor
    {
        public static MaterialSubTypeObject MaterialSubTypeRowToObject(DataRow MaterialSubType, string alias)
        {
            MaterialSubTypeObject obj = new MaterialSubTypeObject();
            try
            {
                if (MaterialSubType != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(MaterialSubType, MaterialSubTypeObject.ConvertColumnToAlias(MaterialSubTypeObject.MATSTYP_ID, alias), false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MatStypID = RowFunctions.GetValueFromRowToGuid(MaterialSubType, MaterialSubTypeObject.ConvertColumnToAlias(MaterialSubTypeObject.MATSTYP_ID, alias), true, DataRowVersion.Current);
                        obj.MaterialType = MaterialTypeConvertor.MaterialTypeRowToObject(MaterialSubType, alias);
                        obj.SubType = RowFunctions.GetValueFromRowToString(MaterialSubType, MaterialSubTypeObject.ConvertColumnToAlias(MaterialSubTypeObject.SUBTYPE, alias), false, DataRowVersion.Current);
                        return obj;
                    }
                    else
                        return null;
                   
                }
                return null;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public static MaterialSubTypeObjectCollection DataTableToCollection(DataTable MaterialSubTypes)
        {
            MaterialSubTypeObjectCollection objectsTotal;
            MaterialSubTypeObjectCollection objects = new MaterialSubTypeObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = MaterialSubTypes.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MaterialSubTypeRowToObject(current, ""));
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

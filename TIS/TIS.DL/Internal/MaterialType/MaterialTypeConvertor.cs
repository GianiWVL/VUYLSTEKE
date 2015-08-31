using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Reflection;
using System.Collections;
using TIS.DL.Internal.MaterialCategory;

namespace TIS.DL.Internal.MaterialType
{
    public static class MaterialTypeConvertor
    {
        public static MaterialTypeObject MaterialTypeRowToObject(DataRow MaterialType, string alias)
        {
            MaterialTypeObject obj = new MaterialTypeObject();
            try
            {
                if (MaterialType != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(MaterialType, MaterialTypeObject.ConvertColumnToAlias(MaterialTypeObject.MATTYP_ID, alias), false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MatTypID = RowFunctions.GetValueFromRowToGuid(MaterialType, MaterialTypeObject.ConvertColumnToAlias(MaterialTypeObject.MATTYP_ID, alias), true, DataRowVersion.Current);
                        obj.MaterialCategory = MaterialCategoryConvertor.MaterialCategoryRowToObject(MaterialType, alias);
                        obj.Type = RowFunctions.GetValueFromRowToString(MaterialType, MaterialTypeObject.ConvertColumnToAlias(MaterialTypeObject.TYPE, alias), false, DataRowVersion.Current);
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

        public static MaterialTypeObjectCollection DataTableToCollection(DataTable MaterialTypes)
        {
            MaterialTypeObjectCollection objectsTotal;
            MaterialTypeObjectCollection objects = new MaterialTypeObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = MaterialTypes.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MaterialTypeRowToObject(current, ""));
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

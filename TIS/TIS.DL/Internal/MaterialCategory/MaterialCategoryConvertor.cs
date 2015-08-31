using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.MaterialCategory
{
    public static class MaterialCategoryConvertor
    {
        public static MaterialCategoryObject MaterialCategoryRowToObject(DataRow MaterialCategory, string alias)
        {
            MaterialCategoryObject obj = new MaterialCategoryObject();
            try
            {
                if (MaterialCategory != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(MaterialCategory, MaterialCategoryObject.ConvertColumnToAlias(MaterialCategoryObject.MATCAT_ID, alias), false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MatcatID = RowFunctions.GetValueFromRowToGuid(MaterialCategory, MaterialCategoryObject.ConvertColumnToAlias(MaterialCategoryObject.MATCAT_ID, alias), true, DataRowVersion.Current);
                        obj.Category = RowFunctions.GetValueFromRowToString(MaterialCategory, MaterialCategoryObject.ConvertColumnToAlias(MaterialCategoryObject.CATEGORY, alias), false, DataRowVersion.Current);
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

        public static MaterialCategoryObjectCollection DataTableToCollection(DataTable MaterialCategorys)
        {
            MaterialCategoryObjectCollection objectsTotal;
            MaterialCategoryObjectCollection objects = new MaterialCategoryObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = MaterialCategorys.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MaterialCategoryRowToObject(current, MaterialCategoryObject.TABLE));
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

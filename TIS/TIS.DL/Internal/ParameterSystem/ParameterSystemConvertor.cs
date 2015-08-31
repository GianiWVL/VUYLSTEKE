using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.ParameterSystem
{
    public static class ParameterSystemConvertor
    {
        public static ParameterSystemObject ParameterSystemRowToObject(DataRow parameterSystem)
        {
            ParameterSystemObject obj = new ParameterSystemObject();
            try
            {
                if (parameterSystem != null)
                {
                    obj.ParID = RowFunctions.GetValueFromRowToGuid(parameterSystem, ParameterSystemObject.PAR_ID, true, DataRowVersion.Current);
                    obj.KeyName = RowFunctions.GetValueFromRowToString(parameterSystem, ParameterSystemObject.KEYNAME, true, DataRowVersion.Current);
                    obj.Value = RowFunctions.GetValueFromRowToString(parameterSystem, ParameterSystemObject.VALUE, true, DataRowVersion.Current);
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

        public static ParameterSystemObjectCollection DataTableToCollection(DataTable parameterSystems)
        {
            ParameterSystemObjectCollection objectsTotal;
            ParameterSystemObjectCollection objects = new ParameterSystemObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = parameterSystems.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(ParameterSystemRowToObject(current));
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

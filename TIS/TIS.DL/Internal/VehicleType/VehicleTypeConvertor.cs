using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Reflection;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.VehicleType
{
    public static class VehicleTypeConvertor
    {
        public static VehicleTypeObject VehicleTypeRowToObject(DataRow VehicleType)
        {
            VehicleTypeObject obj = new VehicleTypeObject();
            try
            {
                if (VehicleType != null)
                {
                    if (RowFunctions.GetValueFromRowToInt64(VehicleType, VehicleTypeObject.VEHTID, false, DataRowVersion.Current) != Constants.NullInt)
                    {
                        obj.VehtID = RowFunctions.GetValueFromRowToInteger(VehicleType, VehicleTypeObject.VEHTID, true, DataRowVersion.Current);
                        obj.Transc_VehicleType = RowFunctions.GetValueFromRowToInteger(VehicleType, VehicleTypeObject.TRANSC_VEHICLETYPE, false, DataRowVersion.Current);
                        obj.Type = RowFunctions.GetValueFromRowToString(VehicleType, VehicleTypeObject.TYPE, false, DataRowVersion.Current);
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

        public static VehicleTypeObjectCollection DataTableToCollection(DataTable VehicleTypes)
        {
            VehicleTypeObjectCollection objectsTotal;
            VehicleTypeObjectCollection objects = new VehicleTypeObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = VehicleTypes.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(VehicleTypeRowToObject(current));
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

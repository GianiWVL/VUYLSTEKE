using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Reflection;
using PROF_IT.Common.Data;

namespace TIS.DL.Internal.VehicleMileage
{
    public static class VehicleMileageConvertor
    {
        public static VehicleMileageObject VehicleMileageRowToObject(DataRow VehicleMileage)
        {
            VehicleMileageObject obj = new VehicleMileageObject();
            try
            {
                if (VehicleMileage != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(VehicleMileage, VehicleMileageObject.VEHM_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.VehmID = RowFunctions.GetValueFromRowToGuid(VehicleMileage, VehicleMileageObject.VEHM_ID, true, DataRowVersion.Current);
                        obj.Transi_TNR_mat = RowFunctions.GetValueFromRowToInteger(VehicleMileage, VehicleMileageObject.TRANSI_TNR_MAT, false, DataRowVersion.Current);
                        obj.Transi_NM_mat = RowFunctions.GetValueFromRowToString(VehicleMileage, VehicleMileageObject.TRANSI_NM_MAT, false, DataRowVersion.Current);
                        obj.Date = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(RowFunctions.GetValueFromRowToString(VehicleMileage, VehicleMileageObject.DATE, false, DataRowVersion.Current));
                        obj.Mileage = RowFunctions.GetValueFromRowToInteger(VehicleMileage, VehicleMileageObject.MILEAGE, false, DataRowVersion.Current);
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

        public static VehicleMileageObjectCollection DataTableToCollection(DataTable VehicleMileages)
        {
            VehicleMileageObjectCollection objectsTotal;
            VehicleMileageObjectCollection objects = new VehicleMileageObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = VehicleMileages.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(VehicleMileageRowToObject(current));
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

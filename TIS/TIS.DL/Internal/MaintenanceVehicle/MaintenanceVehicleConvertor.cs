using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Employee;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.MaintenanceVehicle
{
    public static class MaintenanceVehicleConvertor
    {
        public static MaintenanceVehicleObject MaintenanceVehicleRowToObject(DataRow MaintenanceVehicle)
        {
            MaintenanceVehicleObject obj = new MaintenanceVehicleObject();
            try
            {
                if (MaintenanceVehicle != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(MaintenanceVehicle, MaintenanceVehicleObject.MAINTVEH_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MaintVehID = RowFunctions.GetValueFromRowToGuid(MaintenanceVehicle, MaintenanceVehicleObject.MAINTVEH_ID, true, DataRowVersion.Current);
                        //obj.Vehicle = TIS.DL.Internal.Vehicle.VehicleConvertor.VehicleRowToObject(MaintenanceVehicle);
                        obj.Executor = EmployeeConvertor.EmployeeRowToObject(MaintenanceVehicle, "");
                        obj.StartMaintenance = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(RowFunctions.GetValueFromRowToString(MaintenanceVehicle, MaintenanceVehicleObject.START_MAINTENANCE, false, DataRowVersion.Current));
                        obj.Remark = RowFunctions.GetValueFromRowToString(MaintenanceVehicle, MaintenanceVehicleObject.REMARK, false, DataRowVersion.Current);
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

        public static MaintenanceVehicleObjectCollection DataTableToCollection(DataTable MaintenanceVehicles)
        {
            MaintenanceVehicleObjectCollection objectsTotal;
            MaintenanceVehicleObjectCollection objects = new MaintenanceVehicleObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = MaintenanceVehicles.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MaintenanceVehicleRowToObject(current));
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

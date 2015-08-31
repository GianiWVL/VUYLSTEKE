using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Reflection;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Material;
using TIS.DL.Internal.Employee;

namespace TIS.DL.Internal.Maintenance
{
    public static class MaintenanceConvertor
    {
        public static MaintenanceObject MaintenanceRowToObject(DataRow Maintenance)
        {
            MaintenanceObject obj = new MaintenanceObject();
            try
            {
                if (Maintenance != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Maintenance, MaintenanceObject.MAINT_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MaintID = RowFunctions.GetValueFromRowToGuid(Maintenance, MaintenanceObject.MAINT_ID, true, DataRowVersion.Current);
                        //obj.Material = MaterialConvertor.MaterialRowToObject(Maintenance);
                        //obj.MaintenanceVehicle = TIS.DL.Internal.MaintenanceVehicle.MaintenanceVehicleConvertor.MaintenanceVehicleRowToObject(Maintenance);
                        obj.Executor = EmployeeConvertor.EmployeeRowToObject(Maintenance,"");
                        obj.StartMaintenance = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(RowFunctions.GetValueFromRowToString(Maintenance, MaintenanceObject.START_MAINTENANCE, false, DataRowVersion.Current), false);
                        obj.Remark = RowFunctions.GetValueFromRowToString(Maintenance, MaintenanceObject.REMARK, false, DataRowVersion.Current);
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

        public static MaintenanceObjectCollection DataTableToCollection(DataTable Maintenances)
        {
            MaintenanceObjectCollection objectsTotal;
            MaintenanceObjectCollection objects = new MaintenanceObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = Maintenances.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MaintenanceRowToObject(current));
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

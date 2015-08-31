using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Reflection;
using PROF_IT.Common.Data;
using TIS.DL.Internal.VehicleTransicsLink;

namespace TIS.DL.Internal.Vehicle
{
    public static class VehicleConvertor
    {
        public static VehicleObject VehicleRowToObject(DataRow Vehicle)
        {
            VehicleObject obj = new VehicleObject();
            try
            {
                if (Vehicle != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Vehicle, VehicleObject.VEHID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.VehID = RowFunctions.GetValueFromRowToGuid(Vehicle, VehicleObject.VEHID, true, DataRowVersion.Current);
                        obj.Transc_VehicleID = RowFunctions.GetValueFromRowToInteger(Vehicle, VehicleObject.TRANSC_VEHICLE_ID, false, DataRowVersion.Current);
                        obj.Transc_VehicleType = RowFunctions.GetValueFromRowToInteger(Vehicle, VehicleObject.TRANSC_VEHICLE_TYPE, false, DataRowVersion.Current);
                        obj.Name = RowFunctions.GetValueFromRowToString(Vehicle, VehicleObject.NAME, false, DataRowVersion.Current);
                        obj.LicenseNumber = RowFunctions.GetValueFromRowToString(Vehicle, VehicleObject.LICENSE_NUMBER, false, DataRowVersion.Current);
                        obj.Euronorm = RowFunctions.GetValueFromRowToInteger(Vehicle, VehicleObject.EURONORM, false, DataRowVersion.Current);
                        obj.Chassis = RowFunctions.GetValueFromRowToString(Vehicle, VehicleObject.CHASSIS, false, DataRowVersion.Current);
                        obj.Brand = RowFunctions.GetValueFromRowToString(Vehicle, VehicleObject.BRAND, false, DataRowVersion.Current);
                        obj.Icon = RowFunctions.GetValueFromRowToString(Vehicle, VehicleObject.ICON, false, DataRowVersion.Current);
                        obj.VehicleType = RowFunctions.GetValueFromRowToString(Vehicle, VehicleObject.VEHICLETYPE, false, DataRowVersion.Current);
                        obj.VehicleTransicsLink = VehicleTransicsLinkConvertor.VehicleTransicsLinkRowToObject(Vehicle);
                        obj.ContactTransics = RowFunctions.GetValueFromRowToBoolean(Vehicle, VehicleObject.CONTACT_TRANSICS, false, DataRowVersion.Current);
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

        public static VehicleObjectCollection DataTableToCollection(DataTable Vehicles)
        {
            VehicleObjectCollection objectsTotal;
            VehicleObjectCollection objects = new VehicleObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = Vehicles.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(VehicleRowToObject(current));
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

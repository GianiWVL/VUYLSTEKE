using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.VehicleTransicsLink
{
    public static class VehicleTransicsLinkConvertor
    {
        public static VehicleTransicsLinkObject VehicleTransicsLinkRowToObject(DataRow VehicleTransicsLink)
        {
            VehicleTransicsLinkObject obj = new VehicleTransicsLinkObject();
            try
            {
                if (VehicleTransicsLink != null)
                {
                    if (RowFunctions.GetValueFromRowToInteger(VehicleTransicsLink, VehicleTransicsLinkObject.VEHTI_ID, false, DataRowVersion.Current) != 0)
                    {
                        obj.VehtiID = RowFunctions.GetValueFromRowToInteger(VehicleTransicsLink, VehicleTransicsLinkObject.VEHTI_ID, true, DataRowVersion.Current);
                        obj.Transi_TNR_mat = RowFunctions.GetValueFromRowToInteger(VehicleTransicsLink, VehicleTransicsLinkObject.TRANSI_TNR_MAT, false, DataRowVersion.Current);
                        obj.Transc_VehicleID = RowFunctions.GetValueFromRowToInteger(VehicleTransicsLink, VehicleTransicsLinkObject.TRANSC_VEHICLEID, false, DataRowVersion.Current);
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

        public static VehicleTransicsLinkObjectCollection DataTableToCollection(DataTable VehicleTransicsLinks)
        {
            VehicleTransicsLinkObjectCollection objectsTotal;
            VehicleTransicsLinkObjectCollection objects = new VehicleTransicsLinkObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = VehicleTransicsLinks.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(VehicleTransicsLinkRowToObject(current));
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

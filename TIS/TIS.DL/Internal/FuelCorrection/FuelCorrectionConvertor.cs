using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.FuelCorrection
{
    public static class FuelCorrectionConvertor
    {
        public static FuelCorrectionObject FuelRowToObject(DataRow Fuel)
        {
            FuelCorrectionObject obj = new FuelCorrectionObject();
            try
            {
                if (Fuel != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Fuel, FuelCorrectionObject.FUELCOR_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.FuelCorID = RowFunctions.GetValueFromRowToGuid(Fuel, FuelCorrectionObject.FUELCOR_ID, true, DataRowVersion.Current);
                        obj.DateFrom = RowFunctions.GetValueFromRowToString(Fuel, FuelCorrectionObject.DATE_FROM, false, DataRowVersion.Current);
                        obj.DateTo = RowFunctions.GetValueFromRowToString(Fuel, FuelCorrectionObject.DATE_TO, false, DataRowVersion.Current);
                        obj.Quantity = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelCorrectionObject.QUANTITY, false, DataRowVersion.Current);
                        obj.MaxQuantity = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelCorrectionObject.MAXQUANTITY, false, DataRowVersion.Current);
                        obj.VehiclesNotIncluded = RowFunctions.GetValueFromRowToString(Fuel, FuelCorrectionObject.VEHICLES_NOT_INCLUDED, false, DataRowVersion.Current);
                        obj.SuppliersIncluded = RowFunctions.GetValueFromRowToString(Fuel, FuelCorrectionObject.SUPPLIERS_INCLUDED, false, DataRowVersion.Current);
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

        public static FuelCorrectionObjectCollection DataTableToCollection(DataTable Fuels)
        {
            FuelCorrectionObjectCollection objectsTotal;
            FuelCorrectionObjectCollection objects = new FuelCorrectionObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = Fuels.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(FuelRowToObject(current));
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

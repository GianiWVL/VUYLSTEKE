using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Collections;
using System.Reflection;

namespace TIS.DL.Internal.Fuel
{
    public static class FuelConvertor
    {
        public static FuelObject FuelRowToObject(DataRow Fuel)
        {
            FuelObject obj = new FuelObject();
            try
            {
                if (Fuel != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Fuel, FuelObject.FUEL_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.FuelID = RowFunctions.GetValueFromRowToGuid(Fuel, FuelObject.FUEL_ID, true, DataRowVersion.Current);
                        obj.Transi_TNR_reg = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSI_TNR_REG, false, DataRowVersion.Current);
                        obj.Transi_TNR_person = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSI_TNR_PERSON, false, DataRowVersion.Current);
                        obj.Transi_TNR_mat = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSI_TNR_MAT, false, DataRowVersion.Current);
                        obj.Transi_TNR_pump = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSI_TNR_PUMP, false, DataRowVersion.Current);
                        obj.Transi_TNR_tank = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSI_TNR_TANK, false, DataRowVersion.Current);
                        obj.Transi_FuelType = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSI_FUELTYPE, false, DataRowVersion.Current);
                        obj.Transc_FuelId = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSC_FUELID, false, DataRowVersion.Current);
                        obj.Transc_NawID = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSC_NAWID, false, DataRowVersion.Current);
                        //obj.Transc_Date = RowFunctions.GetValueFromRowToInt64(Fuel, FuelObject.TRANSC_DATE, false, DataRowVersion.Current);
                        obj.Transc_PriveBedrijf = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.TRANSC_PRIVEBEDRIJF, false, DataRowVersion.Current);
                        obj.Transc_Product = RowFunctions.GetValueFromRowToString(Fuel, FuelObject.TRANSC_PRODUCT, false, DataRowVersion.Current);
                        obj.Date = RowFunctions.GetValueFromRowToDateTime(Fuel, FuelObject.DATE, false, DataRowVersion.Current);
                        obj.EmployeeName = RowFunctions.GetValueFromRowToString(Fuel, FuelObject.EMPLOYEE_NAME, false, DataRowVersion.Current).Trim();
                        obj.Employee = RowFunctions.GetValueFromRowToString(Fuel, FuelObject.EMPLOYEE, false, DataRowVersion.Current).Trim();
                        obj.VehicleLicensePlate = RowFunctions.GetValueFromRowToString(Fuel, FuelObject.VEHICLE_LICENSEPLATE, false, DataRowVersion.Current).Trim();
                        obj.VehicleKilometreCounter = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.VEHICLE_KILOMETRECOUNTER, false, DataRowVersion.Current);
                        obj.Quantity = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelObject.QUANTITY, false, DataRowVersion.Current);
                        obj.QuantityCorrection = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelObject.QUANTITY_CORRECTION, false, DataRowVersion.Current);
                        obj.FullTank = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelObject.FULLTANK, false, DataRowVersion.Current);
                        obj.UnityPrice = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelObject.UNITYPRICE, false, DataRowVersion.Current);
                        obj.TotalPrice = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelObject.TOTALPRICE, false, DataRowVersion.Current);
                        obj.Unit = RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.UNIT, false, DataRowVersion.Current);
                        obj.Supplier = RowFunctions.GetValueFromRowToString(Fuel, FuelObject.SUPPLIER, false, DataRowVersion.Current).Trim();
                        obj.Location = RowFunctions.GetValueFromRowToString(Fuel, FuelObject.LOCATION, false, DataRowVersion.Current);
                        obj.FuelType = (Framework.Common.Enumeration.Fuel.FuelType)RowFunctions.GetValueFromRowToInteger(Fuel, FuelObject.FUELTYPE, false, DataRowVersion.Current);
                        obj.Btw = RowFunctions.GetValueFromRowToDecimal(Fuel, FuelObject.BTW, false, DataRowVersion.Current);
                        obj.PrivateTanking = RowFunctions.GetValueFromRowToBoolean(Fuel, FuelObject.PRIVATE_TANKING, false, DataRowVersion.Current);
                        obj.CompanyTanking = RowFunctions.GetValueFromRowToBoolean(Fuel, FuelObject.COMPANY_TANKING, false, DataRowVersion.Current);
                        obj.InvoiceReceived = RowFunctions.GetValueFromRowToBoolean(Fuel, FuelObject.INVOICE_RECEIVED, false, DataRowVersion.Current);
                        obj.InvoiceOK = RowFunctions.GetValueFromRowToBoolean(Fuel, FuelObject.INVOICE_OK, false, DataRowVersion.Current);
                        obj.DateMailForbiddenFueling = PROF_IT.Common.Convert.DateFunctions.DBDateToDateTime( RowFunctions.GetValueFromRowToString(Fuel, FuelObject.DATEMAIL_FORBIDDENFUELING, false, DataRowVersion.Current),false);
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

        public static FuelObjectCollection DataTableToCollection(DataTable Fuels)
        {
            FuelObjectCollection objectsTotal;
            FuelObjectCollection objects = new FuelObjectCollection();
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

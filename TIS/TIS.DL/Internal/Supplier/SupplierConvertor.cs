using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Supplier
{
    public static class SupplierConvertor
    {
        public static SupplierObject SupplierRowToObject(DataRow supplier)
        {
            SupplierObject obj = null;
            try
            {
                if (supplier != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(supplier, SupplierObject.SUP_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj = new SupplierObject();
                        obj.SupID = RowFunctions.GetValueFromRowToGuid(supplier, SupplierObject.SUP_ID, true, DataRowVersion.Current);
                        obj.TranscID = RowFunctions.GetValueFromRowToInteger(supplier, SupplierObject.TRANSC_ID, false, DataRowVersion.Current);
                        obj.TasID = RowFunctions.GetValueFromRowToInteger(supplier, SupplierObject.TAS_ID, false, DataRowVersion.Current);
                        obj.Name = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.NAME, false, DataRowVersion.Current);
                        obj.Name2 = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.NAME2, false, DataRowVersion.Current);
                        obj.Street = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.STREET, false, DataRowVersion.Current);
                        obj.HouseNumber = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.HOUSE_NUMBER, false, DataRowVersion.Current);
                        obj.Zipcode = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.ZIPCODE, false, DataRowVersion.Current);
                        obj.Town = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.TOWN, false, DataRowVersion.Current);
                        obj.Country = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.COUNTRY, false, DataRowVersion.Current);
                        obj.Vat = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.VAT, false, DataRowVersion.Current);
                        obj.Phone = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.PHONE, false, DataRowVersion.Current);
                        obj.Language = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.LANGUAGE, false, DataRowVersion.Current);
                        obj.Currency = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.CURRENCY, false, DataRowVersion.Current);
                        obj.Email = RowFunctions.GetValueFromRowToString(supplier, SupplierObject.EMAIL, false, DataRowVersion.Current);
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

        public static SupplierObjectCollection DataTableToCollection(DataTable suppliers)
        {
            SupplierObjectCollection objectsTotal;
            SupplierObjectCollection objects = new SupplierObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = suppliers.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(SupplierRowToObject(current));
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

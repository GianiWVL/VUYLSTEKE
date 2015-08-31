using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Customer
{

    public static class CustomerConvertor
    {
        public static CustomerObject CustomerRowToObject(DataRow customer)
        {
            CustomerObject obj = new CustomerObject();
            try
            {
                if (customer != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(customer, CustomerObject.CUS_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.CusID = RowFunctions.GetValueFromRowToGuid(customer, CustomerObject.CUS_ID, true, DataRowVersion.Current);
                        obj.TasID = RowFunctions.GetValueFromRowToInteger(customer, CustomerObject.TAS_ID, true, DataRowVersion.Current);
                        obj.Name = RowFunctions.GetValueFromRowToString(customer, CustomerObject.NAME, true, DataRowVersion.Current);
                        obj.Name2 = RowFunctions.GetValueFromRowToString(customer, CustomerObject.NAME2, true, DataRowVersion.Current);
                        obj.Street = RowFunctions.GetValueFromRowToString(customer, CustomerObject.STREET, true, DataRowVersion.Current);
                        obj.HouseNumber = RowFunctions.GetValueFromRowToString(customer, CustomerObject.HOUSE_NUMBER, true, DataRowVersion.Current);
                        obj.Zipcode = RowFunctions.GetValueFromRowToString(customer, CustomerObject.ZIPCODE, true, DataRowVersion.Current);
                        obj.Town = RowFunctions.GetValueFromRowToString(customer, CustomerObject.TOWN, true, DataRowVersion.Current);
                        obj.Country = RowFunctions.GetValueFromRowToString(customer, CustomerObject.COUNTRY, true, DataRowVersion.Current);
                        obj.Vat = RowFunctions.GetValueFromRowToString(customer, CustomerObject.VAT, true, DataRowVersion.Current);
                        obj.Phone = RowFunctions.GetValueFromRowToString(customer, CustomerObject.PHONE, true, DataRowVersion.Current);
                        obj.Language = RowFunctions.GetValueFromRowToString(customer, CustomerObject.LANGUAGE, true, DataRowVersion.Current);
                        obj.Currency = RowFunctions.GetValueFromRowToString(customer, CustomerObject.CURRENCY, true, DataRowVersion.Current);
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

        public static CustomerObjectCollection DataTableToCollection(DataTable customers)
        {
            CustomerObjectCollection objectsTotal;
            CustomerObjectCollection objects = new CustomerObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = customers.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(CustomerRowToObject(current));
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

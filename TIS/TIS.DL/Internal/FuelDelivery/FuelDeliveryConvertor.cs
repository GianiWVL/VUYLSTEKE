using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Supplier;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.FuelDelivery
{
    public static class FuelDeliveryConvertor
    {
        public static FuelDeliveryObject FuelDeliveryRowToObject(DataRow FuelDelivery)
        {
            FuelDeliveryObject obj = new FuelDeliveryObject();
            try
            {
                if (FuelDelivery != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(FuelDelivery, FuelDeliveryObject.FUELDEL_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.FuelDeliveryID = RowFunctions.GetValueFromRowToGuid(FuelDelivery, FuelDeliveryObject.FUELDEL_ID, true, DataRowVersion.Current);
                        obj.Supplier = SupplierConvertor.SupplierRowToObject(FuelDelivery);
                        obj.DateDelivery = RowFunctions.GetValueFromRowToString(FuelDelivery, FuelDeliveryObject.DATE_DELIVERY, false, DataRowVersion.Current);
                        obj.DateInvoice = RowFunctions.GetValueFromRowToString(FuelDelivery, FuelDeliveryObject.DATE_INVOICE, false, DataRowVersion.Current);
                        obj.Quantity = RowFunctions.GetValueFromRowToDecimal(FuelDelivery, FuelDeliveryObject.QUANTITY, false, DataRowVersion.Current);
                        obj.UnityPrice = RowFunctions.GetValueFromRowToDecimal(FuelDelivery, FuelDeliveryObject.UNITY_PRICE, false, DataRowVersion.Current);
                        obj.Location = (Framework.Common.Enumeration.Fuel.Location)RowFunctions.GetValueFromRowToInteger(FuelDelivery, FuelDeliveryObject.LOCATION, false, DataRowVersion.Current);
                        obj.Remark = RowFunctions.GetValueFromRowToString(FuelDelivery, FuelDeliveryObject.REMARK, false, DataRowVersion.Current);

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

        public static FuelDeliveryObjectCollection DataTableToCollection(DataTable FuelDeliverys)
        {
            FuelDeliveryObjectCollection objectsTotal;
            FuelDeliveryObjectCollection objects = new FuelDeliveryObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = FuelDeliverys.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(FuelDeliveryRowToObject(current));
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

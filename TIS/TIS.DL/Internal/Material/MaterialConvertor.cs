using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Employee;
using TIS.DL.Internal.Vehicle;
using System.Reflection;
using System.Collections;
using TIS.DL.Internal.Supplier;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;

namespace TIS.DL.Internal.Material
{
    public static class MaterialConvertor
    {
        public static MaterialObject MaterialRowToObject(DataRow Material)
        {
            MaterialObject obj = new MaterialObject();
            try
            {
                if (Material != null)
                {
                    if (RowFunctions.GetValueFromRowToGuid(Material, MaterialObject.MAT_ID, false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.MatID = RowFunctions.GetValueFromRowToGuid(Material, MaterialObject.MAT_ID, true, DataRowVersion.Current);
                        obj.MaterialCategory = MaterialCategoryConvertor.MaterialCategoryRowToObject(Material, ""); 
                        obj.MaterialType = MaterialTypeConvertor.MaterialTypeRowToObject(Material, ""); 
                        obj.MaterialSubType = MaterialSubTypeConvertor.MaterialSubTypeRowToObject(Material, ""); 
                        obj.EmployeeCreator = EmployeeConvertor.EmployeeRowToObject(Material, "Creator");
                        obj.EmployeeResponsable = EmployeeConvertor.EmployeeRowToObject(Material, "Responsable");
                        obj.Vehicle = VehicleConvertor.VehicleRowToObject(Material);
                        obj.Supplier = SupplierConvertor.SupplierRowToObject(Material);
                        obj.Name = RowFunctions.GetValueFromRowToString(Material, MaterialObject.NAME, false, DataRowVersion.Current);
                        obj.Description = RowFunctions.GetValueFromRowToString(Material, MaterialObject.DESCRIPTION, false, DataRowVersion.Current);
                        obj.Type = (TIS.Framework.Common.Enumeration.Material.Type)RowFunctions.GetValueFromRowToInteger(Material, MaterialObject.TYPE, false, DataRowVersion.Current);
                        obj.SerieNumber = RowFunctions.GetValueFromRowToString(Material, MaterialObject.SERIE_NUMBER, false, DataRowVersion.Current);
                        obj.InternalNumber = RowFunctions.GetValueFromRowToString(Material, MaterialObject.INTERNAL_NUMBER, false, DataRowVersion.Current);
                        obj.PurchasedOn = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(RowFunctions.GetValueFromRowToString(Material, MaterialObject.PURCHASEDON, false, DataRowVersion.Current), false);
                        obj.Price = RowFunctions.GetValueFromRowToDecimal(Material, MaterialObject.PRICE, false, DataRowVersion.Current);
                        obj.NextMaintenance = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(RowFunctions.GetValueFromRowToString(Material, MaterialObject.NEXT_MAINTENANCE, false, DataRowVersion.Current), false);
                        obj.MaintenanceFrequency = RowFunctions.GetValueFromRowToInteger(Material, MaterialObject.MAINTENANCE_FREQUENCY, false, DataRowVersion.Current);
                        obj.Broken = RowFunctions.GetValueFromRowToBoolean(Material, MaterialObject.BROKEN, false, DataRowVersion.Current);
                        obj.Active = RowFunctions.GetValueFromRowToBoolean(Material, MaterialObject.ACTIVE, false, DataRowVersion.Current);
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

        public static MaterialObjectCollection DataTableToCollection(DataTable Materials)
        {
            MaterialObjectCollection objectsTotal;
            MaterialObjectCollection objects = new MaterialObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = Materials.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(MaterialRowToObject(current));
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

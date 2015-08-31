using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.Internal.Material;
using TIS.DL.Internal.Vehicle;
using TIS.DL.Internal.Employee;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Language;
using TIS.DL.Internal.VehicleTransicsLink;
using TIS.DL.Internal.Supplier;
using TIS.DL.Internal.MaterialCategory;
using TIS.DL.Internal.MaterialType;
using TIS.DL.Internal.MaterialSubType;

namespace TIS.DATA.Internal
{
    public class MaterialDataService : DataServiceBase
    {
        public MaterialDataService()
            : base()
        { }
        public MaterialDataService(IDbTransaction txn)
            : base(txn)
        { }

        public string BaseQuery(bool selectTop, int top)
        {
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                if (selectTop == true)
                    builder.SelectTop(top);
                else
                    builder.Select();
                builder.AppendColumn(MaterialObject.MATCAT_ID);
                builder.AppendColumn(MaterialObject.MATTYP_ID);
                builder.AppendColumn(MaterialObject.MATSTYP_ID);
                builder.AppendColumn(MaterialObject.EMP_ID_CREATOR);
                builder.AppendColumn(MaterialObject.EMP_ID_RESPONSABLE);
                builder.AppendColumn(MaterialObject.INTERNAL_NUMBER);
                builder.AppendColumn(MaterialObject.MAT_ID);
                builder.AppendColumn(MaterialObject.NAME);
                builder.AppendColumn(MaterialObject.NEXT_MAINTENANCE);
                builder.AppendColumn(MaterialObject.PRICE);
                builder.AppendColumn(MaterialObject.SERIE_NUMBER);
                builder.AppendColumn(MaterialObject.TYPE);
                builder.AppendColumn(MaterialObject.VEH_ID);
                builder.AppendColumn(MaterialObject.SUP_ID);
                builder.AppendColumn(MaterialObject.DESCRIPTION);
                builder.AppendColumn(MaterialObject.PURCHASEDON);
                builder.AppendColumn(MaterialObject.MAINTENANCE_FREQUENCY);
                builder.AppendColumn(MaterialObject.BROKEN);
                builder.AppendColumn(MaterialObject.ACTIVE);
                builder.AppendColumn(MaterialCategoryObject.MATCAT_ID);
                builder.AppendColumn(MaterialCategoryObject.CATEGORY);
                builder.AppendColumn(MaterialTypeObject.MATTYP_ID);
                builder.AppendColumn(MaterialTypeObject.MATCAT_ID);
                builder.AppendColumn(MaterialTypeObject.TYPE);
                builder.AppendColumn(MaterialSubTypeObject.MATSTYP_ID);
                builder.AppendColumn(MaterialSubTypeObject.MATTYP_ID);
                builder.AppendColumn(MaterialSubTypeObject.SUBTYPE);
                builder.AppendColumn(VehicleObject.BRAND);
                builder.AppendColumn(VehicleObject.CHASSIS);
                builder.AppendColumn(VehicleObject.EURONORM);
                builder.AppendColumn(VehicleObject.ICON);
                builder.AppendColumn(VehicleObject.LICENSE_NUMBER);
                builder.AppendColumn(VehicleObject.NAME);
                builder.AppendColumn(VehicleObject.TRANSC_VEHICLE_ID);
                builder.AppendColumn(VehicleObject.TRANSC_VEHICLE_TYPE);
                builder.AppendColumn(VehicleObject.VEHICLETYPE);
                builder.AppendColumn(VehicleObject.VEHID);
                builder.AppendColumn(VehicleObject.CONTACT_TRANSICS);
                builder.AppendColumn(SupplierObject.COUNTRY);
                builder.AppendColumn(SupplierObject.CURRENCY);
                builder.AppendColumn(SupplierObject.EMAIL);
                builder.AppendColumn(SupplierObject.HOUSE_NUMBER);
                builder.AppendColumn(SupplierObject.LANGUAGE);
                builder.AppendColumn(SupplierObject.NAME);
                builder.AppendColumn(SupplierObject.NAME2);
                builder.AppendColumn(SupplierObject.PHONE);
                builder.AppendColumn(SupplierObject.STREET);
                builder.AppendColumn(SupplierObject.SUP_ID);
                builder.AppendColumn(SupplierObject.TAS_ID);
                builder.AppendColumn(SupplierObject.TOWN);
                builder.AppendColumn(SupplierObject.TRANSC_ID);
                builder.AppendColumn(SupplierObject.VAT);
                builder.AppendColumn(SupplierObject.ZIPCODE);
                builder.AppendColumn(VehicleTransicsLinkObject.TRANSC_VEHICLEID);
                builder.AppendColumn(VehicleTransicsLinkObject.TRANSI_TNR_MAT);
                builder.AppendColumn(VehicleTransicsLinkObject.VEHTI_ID);
                builder.AppendColumn(EmployeeObject.ARCHIVE, "Creator");
                builder.AppendColumn(EmployeeObject.EMAIL, "Creator");
                builder.AppendColumn(EmployeeObject.EMP_ID, "Creator");
                builder.AppendColumn(EmployeeObject.LAN_ID, "Creator");
                builder.AppendColumn(EmployeeObject.NAME, "Creator");
                builder.AppendColumn(EmployeeObject.SURNAME, "Creator");
                builder.AppendColumn(EmployeeObject.TRANSC_ID, "Creator");
                builder.AppendColumn(EmployeeObject.TRANSC_LANGUAGE, "Creator");
                builder.AppendColumn(EmployeeObject.TRANSI_ID, "Creator");
                builder.AppendColumn(EmployeeObject.REPEAT_MAIL, "Creator");
                builder.AppendColumn(LanguageObject.LAN_ID, "CreatorLanguage");
                builder.AppendColumn(LanguageObject.LANGUAGE, "CreatorLanguage");
                builder.AppendColumn(LanguageObject.LANGUAGE_DUTCH, "CreatorLanguage");
                builder.AppendColumn(EmployeeObject.ARCHIVE, "Responsable");
                builder.AppendColumn(EmployeeObject.EMAIL, "Responsable");
                builder.AppendColumn(EmployeeObject.EMP_ID, "Responsable");
                builder.AppendColumn(EmployeeObject.LAN_ID, "Responsable");
                builder.AppendColumn(EmployeeObject.NAME, "Responsable");
                builder.AppendColumn(EmployeeObject.SURNAME, "Responsable");
                builder.AppendColumn(EmployeeObject.TRANSC_ID, "Responsable");
                builder.AppendColumn(EmployeeObject.TRANSC_LANGUAGE, "Responsable");
                builder.AppendColumn(EmployeeObject.TRANSI_ID, "Responsable");
                builder.AppendColumn(EmployeeObject.REPEAT_MAIL, "Responsable");
                builder.AppendColumn(LanguageObject.LAN_ID, "ResponsableLanguage");
                builder.AppendColumn(LanguageObject.LANGUAGE, "ResponsableLanguage");
                builder.AppendColumn(LanguageObject.LANGUAGE_DUTCH, "ResponsableLanguage");
                builder.AppendFromTable(MaterialObject.TABLE);
                builder.AppendLeftJoin(VehicleObject.TABLE, VehicleObject.VEHID, MaterialObject.VEH_ID);
                builder.AppendLeftJoin(VehicleTransicsLinkObject.TABLE, VehicleTransicsLinkObject.TRANSC_VEHICLEID, VehicleObject.TRANSC_VEHICLE_ID);
                builder.AppendLeftJoin(SupplierObject.TABLE, SupplierObject.SUP_ID, MaterialObject.SUP_ID);
                builder.AppendLeftJoin(EmployeeObject.TABLE, "Creator", EmployeeObject.EMP_ID, MaterialObject.EMP_ID_CREATOR);
                builder.AppendLeftJoin(LanguageObject.TABLE, "CreatorLanguage", LanguageObject.LAN_ID, EmployeeObject.ConvertColumnToAlias(EmployeeObject.LAN_ID,"Creator"));
                builder.AppendLeftJoin(EmployeeObject.TABLE, "Responsable", EmployeeObject.EMP_ID, MaterialObject.EMP_ID_RESPONSABLE);
                builder.AppendLeftJoin(LanguageObject.TABLE, "ResponsableLanguage", LanguageObject.LAN_ID, EmployeeObject.ConvertColumnToAlias(EmployeeObject.LAN_ID, "Responsable"));
                builder.AppendLeftJoin(MaterialCategoryObject.TABLE, MaterialCategoryObject.MATCAT_ID, MaterialObject.MATCAT_ID);
                builder.AppendLeftJoin(MaterialTypeObject.TABLE, MaterialTypeObject.MATTYP_ID, MaterialObject.MATTYP_ID);
                builder.AppendLeftJoin(MaterialSubTypeObject.TABLE, MaterialSubTypeObject.MATSTYP_ID, MaterialObject.MATSTYP_ID);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public MaterialObjectCollection GetAll()
        {
            MaterialObjectCollection materials = new MaterialObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(MaterialObject.NAME, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                materials = MaterialConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materials;
        }

        public MaterialObjectCollection GetByVehicle(VehicleObject vehicle)
        {
            MaterialObjectCollection materials = new MaterialObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString(MaterialObject.VEH_ID, vehicle.VehID.ToString(), QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                builder.Append("AND " + MaterialObject.VEH_ID + " is not null ");
                builder.AppendOrderBy(MaterialObject.NAME, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                materials = MaterialConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return materials;
        }

        public void Save(MaterialObject material)
        {
            string test = "";
            if (material.PurchasedOn == DateTime.MinValue)
                test = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(material.PurchasedOn);
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Material_SAVE",
                    CreateParameter("@matID", SqlDbType.UniqueIdentifier, material.MatID, ParameterDirection.InputOutput),
                    CreateParameter("@matcatID", SqlDbType.UniqueIdentifier, material.MaterialCategory == null ? Guid.Empty : material.MaterialCategory.MatcatID),
                    CreateParameter("@mattypID", SqlDbType.UniqueIdentifier, material.MaterialType == null ? Guid.Empty : material.MaterialType.MatTypID),
                    CreateParameter("@matstypID", SqlDbType.UniqueIdentifier, material.MaterialSubType == null ? Guid.Empty : material.MaterialSubType.MatStypID),
                    CreateParameter("@empIDCreator", SqlDbType.UniqueIdentifier, material.EmployeeCreator == null ? Guid.Empty : material.EmployeeCreator.EmpID),
                    CreateParameter("@empIDResponsable", SqlDbType.UniqueIdentifier, material.EmployeeResponsable == null ? Guid.Empty : material.EmployeeResponsable.EmpID),
                    CreateParameter("@vehID", SqlDbType.UniqueIdentifier, material.Vehicle == null ? Guid.Empty : material.Vehicle.VehID),
                    CreateParameter("@supID", SqlDbType.UniqueIdentifier, material.Supplier == null ? Guid.Empty : material.Supplier.SupID),
                    CreateParameter("@Name", SqlDbType.NChar, material.Name),
                    CreateParameter("@Description", SqlDbType.VarChar, material.Description),
                    CreateParameter("@Type", SqlDbType.Int, (int)material.Type),
                    CreateParameter("@SerieNumber", SqlDbType.NChar, material.SerieNumber),
                    CreateParameter("@InternalNumber", SqlDbType.NChar, material.InternalNumber),
                    CreateParameter("@PurchasedOn", SqlDbType.VarChar, material.PurchasedOn == DateTime.MinValue ? null : PROF_IT.Common.Convert.DateFunctions.DateToStrDate(material.PurchasedOn)),
                    CreateParameter("@Price", SqlDbType.Decimal, material.Price),
                    CreateParameter("@NextMaintenance", SqlDbType.VarChar, material.NextMaintenance == DateTime.MinValue ? null : PROF_IT.Common.Convert.DateFunctions.DateToStrDate(material.NextMaintenance)),
                    CreateParameter("@MaintenanceFrequency", SqlDbType.Int, material.MaintenanceFrequency),
                    CreateParameter("@Broken", SqlDbType.Bit, material.Broken),
                    CreateParameter("@Active", SqlDbType.Bit, material.Active)
                    );
                material.MatID = (Guid)cmd.Parameters["@matID"].Value;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }

        public bool Remove(MaterialObject material)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Material_DELETE",
                    CreateParameter("@matID", SqlDbType.UniqueIdentifier, material.MatID, ParameterDirection.Input)
                    );
                return true;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
            }
        }
    }
}

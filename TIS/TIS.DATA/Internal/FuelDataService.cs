using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Fuel;
using System.Data;
using PROF_IT.DLM.DATA.SqlServer;
using PROF_IT.DLM.DATA;
using System.Reflection;

namespace TIS.DATA.Internal
{
    public class FuelDataService : DataServiceBase
    {
        public FuelDataService()
            : base()
        { }
        public FuelDataService(IDbTransaction txn)
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
                builder.AppendColumn(FuelObject.FUEL_ID);
                builder.AppendColumn(FuelObject.TRANSI_TNR_REG);
                builder.AppendColumn(FuelObject.TRANSI_TNR_PERSON);
                builder.AppendColumn(FuelObject.TRANSI_TNR_MAT);
                builder.AppendColumn(FuelObject.TRANSI_TNR_PUMP);
                builder.AppendColumn(FuelObject.TRANSI_TNR_TANK);
                builder.AppendColumn(FuelObject.TRANSI_FUELTYPE);
                builder.AppendColumn(FuelObject.TRANSC_FUELID);
                builder.AppendColumn(FuelObject.TRANSC_NAWID);
                builder.AppendColumn(FuelObject.TRANSC_DATE);
                builder.AppendColumn(FuelObject.TRANSC_PRIVEBEDRIJF);
                builder.AppendColumn(FuelObject.TRANSC_PRODUCT);
                builder.AppendColumn(FuelObject.DATE);
                builder.AppendColumn(FuelObject.EMPLOYEE_NAME);
                builder.AppendColumn(FuelObject.EMPLOYEE);
                builder.AppendColumn(FuelObject.VEHICLE_LICENSEPLATE);
                builder.AppendColumn(FuelObject.VEHICLE_KILOMETRECOUNTER);
                builder.AppendColumn(FuelObject.QUANTITY);
                builder.AppendColumn(FuelObject.QUANTITY_CORRECTION);
                builder.AppendColumn(FuelObject.FULLTANK);
                builder.AppendColumn(FuelObject.UNITYPRICE);
                builder.AppendColumn(FuelObject.TOTALPRICE);
                builder.AppendColumn(FuelObject.UNIT);
                builder.AppendColumn(FuelObject.SUPPLIER);
                builder.AppendColumn(FuelObject.LOCATION);
                builder.AppendColumn(FuelObject.FUELTYPE);
                builder.AppendColumn(FuelObject.BTW);
                builder.AppendColumn(FuelObject.PRIVATE_TANKING);
                builder.AppendColumn(FuelObject.COMPANY_TANKING);
                builder.AppendColumn(FuelObject.INVOICE_RECEIVED);
                builder.AppendColumn(FuelObject.INVOICE_OK);
                builder.AppendColumn(FuelObject.DATEMAIL_FORBIDDENFUELING);
                builder.AppendFromTable(FuelObject.TABLE);
                return builder.Query;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public FuelObjectCollection GetAll()
        {
            FuelObjectCollection fuels = new FuelObjectCollection();
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendOrderBy(FuelObject.DATE, QueryBuilder.OrderByType.ASC, QueryBuilder.ParameterLocation.FIRST_LAST);
                fuels = FuelConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuels;
        }

        public string[] GetSuppliers()
        {
            
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append( " SELECT " + FuelObject.SUPPLIER + " FROM " + FuelObject.TABLE );
                builder.Append(" GROUP BY " + FuelObject.SUPPLIER);
                builder.Append(" ORDER BY " + FuelObject.SUPPLIER);
                DataTable dt = this.ExecuteDataSet(builder.Query, false).Tables[0];
                string[] suppliers = new string[dt.Rows.Count];
                int i = 0;

                foreach (DataRow row in dt.Rows)
                {
                    suppliers[i] = row[0].ToString().Trim();
                    i++;
                }

                return suppliers;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return null;
        }

        public string[] GetVehicles()
        {

            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(" SELECT " + FuelObject.VEHICLE_LICENSEPLATE + " FROM " + FuelObject.TABLE);
                builder.Append(" GROUP BY " + FuelObject.VEHICLE_LICENSEPLATE);
                builder.Append(" ORDER BY " + FuelObject.VEHICLE_LICENSEPLATE);
                DataTable dt = this.ExecuteDataSet(builder.Query, false).Tables[0];
                string[] vehicles = new string[dt.Rows.Count];
                int i = 0;

                foreach (DataRow row in dt.Rows)
                {
                    vehicles[i] = row[0].ToString().Trim();
                    i++;
                }

                return vehicles;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return null;
        }

        public string[] GetEmployees()
        {
           
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(" SELECT " + FuelObject.EMPLOYEE + " FROM " + FuelObject.TABLE);
                builder.Append(" GROUP BY " + FuelObject.EMPLOYEE);
                builder.Append(" ORDER BY " + FuelObject.EMPLOYEE);
                DataTable dt = this.ExecuteDataSet(builder.Query, false).Tables[0];
                string[] employees = new string[dt.Rows.Count];
                int i = 0;

                foreach (DataRow row in dt.Rows)
                {
                    employees[i] = row[0].ToString().Trim();
                    i++;
                }

                return employees;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return null;
        }

        public FuelObjectCollection GetFilter(string supplier, int fuelType, 
                                               string employee, string vehicle, DateTime dateFrom, DateTime dateTo)
        {
            FuelObjectCollection fuels;
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString("1", "1", QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                if (supplier != "" & supplier != null)
                    builder.AppendWhereString(FuelObject.SUPPLIER, supplier, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.MIDDLE);
                if (fuelType != -1)
                    builder.AppendWhereInteger(FuelObject.FUELTYPE, Convert.ToInt16(fuelType), QueryBuilder.ParameterLocation.MIDDLE);
                if (employee != "" & employee != null)
                    builder.AppendWhereString(FuelObject.EMPLOYEE, employee, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.MIDDLE);
                if (vehicle != "" & vehicle != null)
                    builder.AppendWhereString(FuelObject.VEHICLE_LICENSEPLATE, vehicle, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.MIDDLE);
                if (dateFrom != DateTime.MinValue)
                    builder.AppendWhereString(FuelObject.DATE, dateFrom.Year + "-" + dateFrom.Month + "-" + dateFrom.Day, QueryBuilder.ComparisonOperators.GreaterAndEqual, QueryBuilder.ParameterLocation.MIDDLE);
                if (dateTo != DateTime.MaxValue)
                {
                    dateTo = dateTo.AddDays(1);
                    builder.AppendWhereString(FuelObject.DATE, dateTo.Year + "-" + dateTo.Month + "-" + dateTo.Day, QueryBuilder.ComparisonOperators.SmallerAndEqual, QueryBuilder.ParameterLocation.MIDDLE);
                }

                builder.AppendOrderBy(FuelObject.DATE, QueryBuilder.OrderByType.DESC, QueryBuilder.ParameterLocation.FIRST_LAST);
                return fuels = FuelConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);

            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuels;
        }

        public FuelObjectCollection GetFilter(string supplier, int fuelType,
                                               string employee, string vehicle, DateTime dateFrom, DateTime dateTo,
                                                        Boolean privateFuel)
        {
            FuelObjectCollection fuels;
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString("1", "1", QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                if (supplier != "" & supplier != null)
                    builder.AppendWhereString(FuelObject.SUPPLIER, supplier, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.MIDDLE);
                if (fuelType != -1)
                    builder.AppendWhereInteger(FuelObject.FUELTYPE, Convert.ToInt16(fuelType), QueryBuilder.ParameterLocation.MIDDLE);
                if (employee != "" & employee != null)
                    builder.AppendWhereString(FuelObject.EMPLOYEE, employee, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.MIDDLE);
                if (vehicle != "" & vehicle != null)
                    builder.AppendWhereString(FuelObject.VEHICLE_LICENSEPLATE, vehicle, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.MIDDLE);
                if (dateFrom != DateTime.MinValue)
                    builder.AppendWhereString(FuelObject.DATE, dateFrom.Year + "-" + dateFrom.Month + "-" + dateFrom.Day, QueryBuilder.ComparisonOperators.GreaterAndEqual, QueryBuilder.ParameterLocation.MIDDLE);
                if (dateTo != DateTime.MaxValue)
                    builder.AppendWhereString(FuelObject.DATE, dateTo.Year + "-" + dateTo.Month + "-" + dateTo.Day, QueryBuilder.ComparisonOperators.SmallerAndEqual, QueryBuilder.ParameterLocation.MIDDLE);

                builder.AppendWhereBoolean(FuelObject.PRIVATE_TANKING, privateFuel, QueryBuilder.ParameterLocation.LAST);
                builder.AppendOrderBy(FuelObject.DATE, QueryBuilder.OrderByType.DESC, QueryBuilder.ParameterLocation.FIRST_LAST);
                return fuels = FuelConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);

            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuels;
        }

        public FuelObjectCollection GetForbiddenFuelNotSendMail(string supplier, int transc_NawID, DateTime dateFrom, DateTime dateTo)
        {
            FuelObjectCollection fuels;
            QueryBuilder builder;
            try
            {
                builder = new QueryBuilder();
                builder.Append(this.BaseQuery(false, 0));
                builder.AppendWhereString("1", "1", QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.FIRST);
                if (supplier != "" & supplier != null)
                    builder.AppendWhereString(FuelObject.SUPPLIER, supplier, QueryBuilder.ComparisonOperators.Equal, QueryBuilder.ParameterLocation.MIDDLE);
                if (transc_NawID != -1)
                    builder.AppendWhereInteger(FuelObject.TRANSC_NAWID, transc_NawID, QueryBuilder.ParameterLocation.MIDDLE);
                if (dateFrom != DateTime.MinValue)
                    builder.AppendWhereString(FuelObject.DATE, dateFrom.Year + "-" + dateFrom.Month + "-" + dateFrom.Day, QueryBuilder.ComparisonOperators.GreaterAndEqual, QueryBuilder.ParameterLocation.MIDDLE);
                if (dateTo != DateTime.MaxValue)
                    builder.AppendWhereString(FuelObject.DATE, dateTo.Year + "-" + dateTo.Month + "-" + dateTo.Day, QueryBuilder.ComparisonOperators.SmallerAndEqual, QueryBuilder.ParameterLocation.MIDDLE);
                
                builder.Append(" AND " + FuelObject.DATEMAIL_FORBIDDENFUELING + " IS NULL ");

                builder.AppendOrderBy(FuelObject.DATE, QueryBuilder.OrderByType.DESC, QueryBuilder.ParameterLocation.FIRST_LAST);
                return fuels = FuelConvertor.DataTableToCollection(this.ExecuteDataSet(builder.Query, false).Tables[0]);

            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return fuels;
        }

        public void Save(FuelObject fuel)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Fuel_SAVE",
                    CreateParameter("@fuelID", SqlDbType.UniqueIdentifier, fuel.FuelID, ParameterDirection.InputOutput),
                    CreateParameter("@transi_TNR_reg", SqlDbType.Int, fuel.Transi_TNR_reg),
                    CreateParameter("@transi_TNR_person", SqlDbType.Int, fuel.Transi_TNR_person),
                    CreateParameter("@transi_TNR_mat", SqlDbType.Int, fuel.Transi_TNR_mat),
                    CreateParameter("@transi_TNR_pump", SqlDbType.Int, fuel.Transi_TNR_pump),
                    CreateParameter("@transi_TNR_tank", SqlDbType.Int, fuel.Transi_TNR_tank),
                    CreateParameter("@transi_FuelType", SqlDbType.Int, fuel.Transi_FuelType),
                    CreateParameter("@transc_FuelId", SqlDbType.Int, fuel.Transc_FuelId),
                    CreateParameter("@transc_NawID", SqlDbType.Int, fuel.Transc_NawID),
                    CreateParameter("@transc_Date", SqlDbType.Float, fuel.Transc_Date),
                    CreateParameter("@transc_PriveBedrijf", SqlDbType.Int , fuel.Transc_PriveBedrijf),
                    CreateParameter("@transc_Product", SqlDbType.NChar, fuel.Transc_Product),
                    CreateParameter("@Date", SqlDbType.DateTime, fuel.Date),
                    CreateParameter("@EmployeeName", SqlDbType.NChar, fuel.EmployeeName),
                    CreateParameter("@Employee", SqlDbType.NChar, fuel.Employee),
                    CreateParameter("@VehicleLicensePlate", SqlDbType.NChar, fuel.VehicleLicensePlate),
                    CreateParameter("@VehicleKilometreCounter", SqlDbType.Int, fuel.VehicleKilometreCounter),
                    CreateParameter("@Quantity", SqlDbType.Decimal, fuel.Quantity),
                    CreateParameter("@QuantityCorrection", SqlDbType.Decimal, fuel.QuantityCorrection),
                    CreateParameter("@Fulltank", SqlDbType.Decimal, fuel.FullTank),
                    CreateParameter("@UnityPrice", SqlDbType.Decimal, fuel.UnityPrice),
                    CreateParameter("@TotalPrice", SqlDbType.Decimal, fuel.TotalPrice),
                    CreateParameter("@Unit", SqlDbType.Int, fuel.Unit),
                    CreateParameter("@Supplier", SqlDbType.NChar, fuel.Supplier),
                    CreateParameter("@Location", SqlDbType.NChar, fuel.Location),
                    CreateParameter("@Fueltype", SqlDbType.Int, (int)fuel.FuelType),
                    CreateParameter("@BTW", SqlDbType.Decimal, fuel.Btw),
                    CreateParameter("@PrivateTanking", SqlDbType.Bit, fuel.PrivateTanking),
                    CreateParameter("@CompanyTanking", SqlDbType.Bit, fuel.CompanyTanking),
                    CreateParameter("@InvoiceReceived", SqlDbType.Bit, fuel.InvoiceReceived),
                    CreateParameter("@InvoiceOK", SqlDbType.Bit, fuel.InvoiceReceived),
                    CreateParameter("@DateMailForbiddenFueling", SqlDbType.VarChar, PROF_IT.Common.Convert.DateFunctions.DateToLongStrDate(fuel.DateMailForbiddenFueling))
                    );
                fuel.FuelID = (Guid)cmd.Parameters["@fuelID"].Value;
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

        public bool Remove(FuelObject fuel)
        {
            SqlCommand cmd = null;
            try
            {
                ExecuteNonQuery(out cmd, false, "Fuel_DELETE",
                    CreateParameter("@fuelID", SqlDbType.UniqueIdentifier, fuel.FuelID, ParameterDirection.Input)
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

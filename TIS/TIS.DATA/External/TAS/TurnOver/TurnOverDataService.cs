using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.DLM.DATA.SqlServer;
using System.Data;
using PROF_IT.DLM.DATA;
using TIS.DL.External.TAS.TurnOver;
using System.Reflection;
using System.Data.SqlClient;
using TIS.DL.Internal.Customer;

namespace TIS.DATA.External.TAS.TurnOver
{
    public class TurnOverDataService: DataServiceBase
    {
        public TurnOverDataService()
            : base()
        { }
        public TurnOverDataService(IDbTransaction txn)
            : base(txn)
        { }

        public TurnOverObjectCollection GetByCustomer(CustomerObject customer)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByCustomer");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TNR_ID", customer.TasID));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOvers;
        }

        public TurnOverObjectCollection GetByCustomerByYear(CustomerObject customer, int year)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByCustomerByYear");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TNR_ID", customer.TasID));
                cmd.Parameters.Add(new SqlParameter("@YEAR", year));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return AddZeroTurnOvers(turnOvers);
        }

        public TurnOverObjectCollection GetByCustomerGreaterThanDate(CustomerObject customer, DateTime date)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByCustomerGreaterThanDate");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TNR_ID", customer.TasID));
                cmd.Parameters.Add(new SqlParameter("@DATE", date));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return AddZeroTurnOvers(turnOvers);
        }

        public TurnOverObjectCollection GetByMonth(int year, int month)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByMonth");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@YEAR", year));
                cmd.Parameters.Add(new SqlParameter("@MONTH", month));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOvers;
        }

        public TurnOverObjectCollection GetByYear(int year)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByYear");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@YEAR", year));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOvers;
        }

        public TurnOverObjectCollection GetByGreaterThanDate(DateTime date)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByGreaterThanDate");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DATE", date));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return AddZeroTurnOvers(turnOvers);
        }

        public Decimal GetAverageTurnOverMonthByYear(int year)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            Decimal turnOver = new Decimal();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByYear");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@YEAR", year));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);

                for (int i = 0; i < turnOvers.Count; i++)
                {
                    turnOver += turnOvers[i].TurnOver;
                }
                int months = 1;
                if (year != System.DateTime.Now.Year)
                    months = 12;
                else
                    months = System.DateTime.Now.Month;
                turnOver = turnOver / months;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOver;
        }

        public Decimal GetAverageTurnOverMonthByYearByCustomer(CustomerObject customer, int year)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            Decimal turnOver = new Decimal();
            try
            {
                if (customer == null) //Average All
                    return GetAverageTurnOverMonthByYear(year);
                else // Average Customer
                {
                    turnOvers = GetByCustomerByYear(customer, year);
                    for (int i = 0; i < turnOvers.Count; i++)
                    {
                        turnOver += turnOvers[i].TurnOver;
                    }
                    int months = 1;
                    if (year != System.DateTime.Now.Year)
                        months = 12;
                    else
                        months = System.DateTime.Now.Month;
                    turnOver = turnOver / months;
                }
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOver;
        }

        public Decimal GetTurnOverByYearByCustomer(CustomerObject customer, int year)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            Decimal turnOver = new Decimal();
            SqlCommand cmd = null;
            DataTable dt;
            try
            {
                string query = "SELECT SUM(Turnover) "
                                + " FROM [TIS].[dbo].[TurnOverCustomer]"
                                + " WHERE tas_TNR_ID = " + customer.TasID + " AND Date >= '" + year + "0101' AND Date <= '" + year + "1231'";



                cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@TNR_ID", customer.TasID));
                cmd.Parameters.Add(new SqlParameter("@YEAR", year));
                dt = this.ExecuteNonQuery(cmd, false).Tables[0];

                if (dt.Rows[0][0].ToString() == "")
                    turnOver = 0;
                else
                    turnOver = Convert.ToDecimal(dt.Rows[0][0].ToString());
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOver;
        }

        public TurnOverObjectCollection GetByVehicleByYear(int year, string vehicle)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByVehicleByYear");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@YEAR", year));
                cmd.Parameters.Add(new SqlParameter("@VEHICLE", vehicle));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return AddZeroTurnOvers(turnOvers);
        }

        public TurnOverObjectCollection GetByVehicleGreaterThanDate(DateTime date, string vehicle)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver_ByVehicleGreaterThanDate");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DATE", date));
                cmd.Parameters.Add(new SqlParameter("@VEHICLE", vehicle));
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return AddZeroTurnOvers(turnOvers);
        }

        public Decimal GetAverageTurnOverMonthByYearByVehicle(int year, string vehicle)
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            Decimal turnOver = new Decimal();
            try
            {
                turnOvers = GetByVehicleByYear(year, vehicle);
                for (int i = 0; i < turnOvers.Count; i++)
                {
                    turnOver += turnOvers[i].TurnOver;
                }
                int months = 1;
                if (year != System.DateTime.Now.Year)
                    months = 12;
                else
                    months = System.DateTime.Now.Month;
                turnOver = turnOver / months;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOver;
        }


        public TurnOverObjectCollection GetAll()
        {
            TurnOverObjectCollection turnOvers = new TurnOverObjectCollection();
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_TurnOver");
                cmd.CommandType = CommandType.StoredProcedure;
                turnOvers = TurnOverConvertor.DataTableToCollection(this.ExecuteNonQuery(cmd, false).Tables[0]);
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOvers;
        }

        public string[] GetVehicles()
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("TAS_Vehicles");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = this.ExecuteNonQuery(cmd, false).Tables[0];

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

        public TurnOverObjectCollection AddZeroTurnOvers(TurnOverObjectCollection turnOvers)
        {
            try
            {
                TurnOverObjectCollection newTurnOvers = new TurnOverObjectCollection();
                TurnOverObject newTurnOver;
                Boolean firstRow = true;
                int previousYear = 0;
                int previousMonth = 0;
                int month = 0;
                int year = 0;
                foreach (TurnOverObject turnOver in turnOvers)
                {
                    if (firstRow == false)
                    {
                        //Check Add zero TurnOver row
                        if (turnOver.Month != previousMonth + 1)
                        {
                            if (previousMonth != 12)
                            {
                                month = previousMonth + 1;
                                year = previousYear;
                            }
                            else
                            {
                                if (turnOver.Month != 1)
                                {
                                    month = 1;
                                    year = previousYear + 1;
                                }
                                else
                                {
                                    month = 0;
                                    year = 0;
                                }
                            }
                        }
                        else
                        {
                            month = 0;
                            year = 0;
                        }

                        //Add Zero TurnOver row
                        if (year != 0 & month != 0)
                        {
                            int i = 0;
                            do
                            {
                                
                                newTurnOver = new TurnOverObject();
                                newTurnOver.Month = month + i;
                                newTurnOver.Year = year;
                                newTurnOver.TnrID = turnOver.TnrID;
                                newTurnOver.Vehicle = turnOver.Vehicle;
                                newTurnOver.TurnOver = 0;
                                newTurnOvers.Add(newTurnOver);
                                i += 1;

                                if (month + i == 13)
                                {
                                    month = 1;
                                    year = year + 1;
                                    i = 0;
                                }
                            }
                            while (turnOver.Month != month + i);
                        }
                    }

                    //Add Normal Turnover
                    newTurnOver = new TurnOverObject();
                    newTurnOver.Month = turnOver.Month;
                    newTurnOver.Year = turnOver.Year;
                    newTurnOver.TnrID = turnOver.TnrID;
                    newTurnOver.Vehicle = turnOver.Vehicle;
                    newTurnOver.TurnOver = turnOver.TurnOver;
                    newTurnOver.Date = turnOver.Date;
                    newTurnOvers.Add(newTurnOver);

                    firstRow = false;
                    previousMonth = newTurnOver.Month;
                    previousYear = newTurnOver.Year;
                }

                return newTurnOvers;
            }
            catch (System.Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return turnOvers;
        }

    }
}

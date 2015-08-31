using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.Customer;
using TIS.DL.External.TAS.TurnOver;
using TIS.DATA.External.TAS.TurnOver;
using System.Reflection;

namespace TIS.BL.External.TAS.TurnOver
{
    public class TurnOver : PROF_IT.DLM.BL.SqlServer.BaseObject
    {

        #region Constructor
        public TurnOver()
            : base()
        {
            
        }
        #endregion

        #region Methods

        public TurnOverObjectCollection GetByMonth(int year, int month)
        {
            TurnOverObjectCollection turnOvers;
            try
            {
                turnOvers = new TurnOverDataService().GetByMonth(year, month);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOvers;
        }

        public TurnOverObjectCollection GetByYear(int year)
        {
            TurnOverObjectCollection turnOvers;
            try
            {
                turnOvers = new TurnOverDataService().GetByYear(year);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOvers;
        }

        public TurnOverObjectCollection GetByYear(int year, CustomerObject customer)
        {
            TurnOverObjectCollection turnOvers;
            try
            {
                if (customer == null)
                    turnOvers = new TurnOverDataService().GetByYear(year);
                else
                    turnOvers = new TurnOverDataService().GetByCustomerByYear(customer, year);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOvers;
        }

        public Decimal GetAverageTurnOverMonthByYear(int year)
        {
            Decimal turnOver;
            try
            {
                turnOver = new TurnOverDataService().GetAverageTurnOverMonthByYear(year);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOver;
        }

        public TurnOverObjectCollection GetByCustomer(CustomerObject customer)
        {
            TurnOverObjectCollection turnOvers;
            try
            {
                turnOvers = new TurnOverDataService().GetByCustomer(customer);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOvers;
        }

        public TurnOverObjectCollection GetByCustomerGreaterThanDate(DateTime date, CustomerObject customer)
        {
            TurnOverObjectCollection turnOvers;
            try
            {
                if (customer == null)
                    turnOvers = new TurnOverDataService().GetByGreaterThanDate(date);
                else
                    turnOvers = new TurnOverDataService().GetByCustomerGreaterThanDate(customer, date);
                    
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOvers;
        }

        public Decimal GetAverageTurnOverMonthByYearByCustomer(int year, CustomerObject customer)
        {
            Decimal turnOver;
            try
            {
                turnOver = new TurnOverDataService().GetAverageTurnOverMonthByYearByCustomer(customer, year);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOver;
        }

        public Decimal GetAverageTurnOverMonthGreaterThanDateByCustomer(DateTime date, CustomerObject customer)
        {
            TurnOverObjectCollection turnOvers;
            Decimal turnOver = 0;
            try
            {
                if (customer == null)
                    turnOvers = new TurnOverDataService().GetByGreaterThanDate(date);
                else
                    turnOvers = new TurnOverDataService().GetByCustomerGreaterThanDate(customer, date);
                    
                for (int i = 0; i < turnOvers.Count; i++)
                {
                    turnOver += turnOvers[i].TurnOver;
                }
                decimal months = Math.Round(Convert.ToDecimal(System.DateTime.Now.Subtract(date).TotalDays) / Convert.ToDecimal(30.5), 0);
                turnOver = turnOver / months;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOver;
        }

        public Decimal GetTurnOverByYearByCustomer(CustomerObject customer, int year)
        {
            Decimal turnOver = 0;
            try
            {
                if (customer != null)
                {
                    turnOver = new TurnOverDataService().GetTurnOverByYearByCustomer(customer, year);
                }
                
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOver;
        }

        public TurnOverObjectCollection GetByVehicleByYear(int year, string vehicle)
        {
            TurnOverObjectCollection turnOvers;
            try
            {
                turnOvers = new TurnOverDataService().GetByVehicleByYear(year, vehicle);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOvers;
        }

        public TurnOverObjectCollection GetByVehicleGreaterThanDate(DateTime date, string vehicle)
        {
            TurnOverObjectCollection turnOvers;
            try
            {
                turnOvers = new TurnOverDataService().GetByVehicleGreaterThanDate(date, vehicle);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOvers;
        }

        public Decimal GetAverageTurnOverMonthByYearByVehicle(int year, string vehicle)
        {
            Decimal turnOver;
            try
            {
                turnOver = new TurnOverDataService().GetAverageTurnOverMonthByYearByVehicle(year, vehicle);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOver;
        }

        public Decimal GetAverageTurnOverMonthGreaterThanDateByVehicle(DateTime date, string vehicle)
        {
            TurnOverObjectCollection turnOvers;
            Decimal turnOver = 0;
            try
            {
                turnOvers = new TurnOverDataService().GetByVehicleGreaterThanDate(date, vehicle);
                for (int i = 0; i < turnOvers.Count; i++)
                {
                    turnOver += turnOvers[i].TurnOver;
                }
                decimal months = Math.Round(Convert.ToDecimal(System.DateTime.Now.Subtract(date).TotalDays) / Convert.ToDecimal(30.5), 0);
                turnOver = turnOver / months;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return turnOver;
        }

        //public TurnOverObjectCollection GetByYear()
        //{
        //    TurnOverObjectCollection turnOvers;
        //    try
        //    {
        //        turnOvers = new TurnOverDataService().GetAll();
        //    }
        //    catch (System.Exception exception1)
        //    {
        //        System.Exception innerException = exception1;
        //        throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
        //    }
        //    return turnOvers;
        //}

        public string[] GetVehicles()
        {
            string[] vehicles;
            try
            {
                vehicles = new TurnOverDataService().GetVehicles();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicles;
        }

        #endregion
    }
}

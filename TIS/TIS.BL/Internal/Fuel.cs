using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TIS.DL.Internal.Fuel;
using System.Reflection;
using TIS.DATA.Internal;

namespace TIS.BL.Internal
{
    public class Fuel : PROF_IT.DLM.BL.SqlServer.BaseObject
    {
        private SqlTransaction _transaction;

        #region Constructor
        public Fuel()
            : base()
        {

        }
        public Fuel(SqlTransaction transaction)
            : base(transaction)
        {

        }
        #endregion

        #region Methods

        public FuelObjectCollection GetAll()
        {
            FuelObjectCollection Fuels;
            try
            {
                Fuels = new FuelDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return Fuels;
        }

        public FuelObjectCollection GetFilter(string supplier, int fuelType,
                                                        string employee, string vehicle, DateTime dateFrom, DateTime dateTo,
                                                        Boolean privateFuel)
        {
            FuelObjectCollection Fuels;
            try
            {
                Fuels = new FuelDataService().GetFilter(supplier, fuelType, employee,vehicle,dateFrom, dateTo, privateFuel);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return Fuels;
        }

        public FuelObjectCollection GetFilter(string supplier, int fuelType,
                                                        string employee, string vehicle, DateTime dateFrom, 
                                                        DateTime dateTo)
        {
            FuelObjectCollection Fuels;
            try
            {
                Fuels = new FuelDataService().GetFilter(supplier, fuelType, employee, vehicle, dateFrom, dateTo);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return Fuels;
        }

        public FuelObjectCollection GetForbiddenFuelNotSendMail(string supplier, int transc_NawID, DateTime dateFrom, DateTime dateTo)
        {
            FuelObjectCollection Fuels;
            try
            {
                Fuels = new FuelDataService().GetForbiddenFuelNotSendMail(supplier, transc_NawID, dateFrom, dateTo);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return Fuels;
        }

        public string[] GetSuppliers()
        {
            string[] suppliers;
            try
            {
                suppliers = new FuelDataService().GetSuppliers();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return suppliers;
        }

        public string[] GetVehicles()
        {
            string[] vehicles;
            try
            {
                vehicles = new FuelDataService().GetVehicles();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return vehicles;
        }

        public string[] GetEmployees()
        {
            string[] employees;
            try
            {
                employees = new FuelDataService().GetEmployees();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return employees;
        }

        public FuelObjectCollection GetFilter( DateTime dateFrom, DateTime dateTo,string vehiclesNotIncluded, string suppliersIncluded)
        {
            FuelObjectCollection FuelsFiltered;
            FuelObjectCollection Fuels;
            try
            {
                Fuels = new FuelDataService().GetFilter("",-1,"","",dateFrom,dateTo);
                FuelsFiltered = new FuelObjectCollection();

                foreach (FuelObject fuel in Fuels)
                {
                    if (!vehiclesNotIncluded.Contains(fuel.VehicleLicensePlate))
                    {
                        if (suppliersIncluded.Contains(fuel.Supplier))
                        {
                            FuelsFiltered.Add(fuel);
                        }
                    }
                    
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return FuelsFiltered;
        }

        public decimal GetTotalAmountOfLiters(FuelObjectCollection fuels)
        {
            decimal value = 0;
            try
            {
                foreach (FuelObject fuel in fuels)
                {
                    value += fuel.Quantity;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return value;
        }

        public void Save(FuelObject Fuel)
        {
            try
            {
                CheckTransaction();
                new FuelDataService(Transaction).Save(Fuel);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }

        public void Remove(FuelObject Fuel)
        {
            try
            {
                CheckTransaction();
                new FuelDataService(Transaction).Remove(Fuel);
                if (IsOwner) Transaction.Commit();
            }
            catch (Exception exception1)
            {
                if (IsOwner) Transaction.Rollback();
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                if (IsOwner) Connection.Close();
            }
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Reflection;
using TIS.Model.Internal;

namespace TIS.Model.BL
{
    public class CostBL
    {
        private UnitOfWork uow;

        public CostBL()
        {
            try
            {
                uow = new UnitOfWork();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public CostBL(UnitOfWork uow)
        {
            try
            {
                this.uow = uow;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public System.Linq.IQueryable<Object> Get(int year, Supplier supplier)
        {
            try
            {
                DateTime minValue = new DateTime(year, 1, 1);
                DateTime maxValue = new DateTime(year, 12, 31);
                //var cost = new XPCollection<Cost>(uow, Cost.Fields.tas_TNR_SUPPLIER == supplier
                //                                                            & Cost.Fields.Date >= minValue & Cost.Fields.Date <= maxValue)
                //                                                 .GroupBy(q => q.Date.Month).Select(q => q.K;

                var cost = from x in new XPQuery<Cost>(uow)
                                  where x.tas_TNR_SUPPLIER.tasID == supplier.tasID && x.Date >= minValue && x.Date <= maxValue
                                  group x by x.Date.Month into grp
                                  select new { PurchaseAmount = grp.Sum(sum => sum.PurchaseAmount), Month = grp.Key };

                return cost;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public decimal GetCost(int year, Supplier supplier)
        {
            try
            {
                DateTime minValue = new DateTime(year, 1, 1);
                DateTime maxValue = new DateTime(year, 12, 31);
                var cost = new XPCollection<Cost>(uow, Cost.Fields.tas_TNR_SUPPLIER == supplier
                                                                            & Cost.Fields.Date >= minValue & Cost.Fields.Date <= maxValue);

                return cost.Sum(q => q.PurchaseAmount);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public decimal GetAverageTurnOverMonthGreaterThanDateBySupplier(DateTime date, Supplier supplier)
        {
            Decimal cost = 0;
            try
            {
                XPCollection<Cost> costs = new XPCollection<Cost>(uow, Cost.Fields.tas_TNR_SUPPLIER == supplier
                                                                            & Cost.Fields.Date >= date);

                decimal months = Math.Round(Convert.ToDecimal(System.DateTime.Now.Subtract(date).TotalDays) / Convert.ToDecimal(30.5), 0);
                cost = costs.Sum(q => q.PurchaseAmount) / months;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return cost;
        }

        public System.Linq.IQueryable<Object> GetBySupplierGreaterThanDate(DateTime date, Supplier supplier)
        {
            try
            {
                var costs = from x in new XPQuery<Cost>(uow)
                           where x.tas_TNR_SUPPLIER.tasID == supplier.tasID && x.Date >= date 
                           group x by x.Date into grp
                           select new { PurchaseAmount = grp.Sum(sum => sum.PurchaseAmount), Date = grp.Key };


                return costs;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public decimal GetAverageTurnOverMonthByYearBySupplier(int year, Supplier supplier)
        {
            Decimal cost = 0;
            try
            {
                DateTime minValue = new DateTime(year, 1, 1);
                DateTime maxValue = new DateTime(year, 12, 31);
                XPCollection<Cost> costs = new XPCollection<Cost>(uow, Cost.Fields.tas_TNR_SUPPLIER == supplier
                                                                            & Cost.Fields.Date >= minValue & Cost.Fields.Date <= maxValue);

                decimal months = 1;
                if (minValue.Year == DateTime.Now.Year)
                    months = Math.Round(Convert.ToDecimal(System.DateTime.Now.Subtract(minValue).TotalDays) / Convert.ToDecimal(30.5), 0);
                else
                    months = 12;

                cost = costs.Sum(q => q.PurchaseAmount) / months;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return cost;
        }


    }
}

using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TIS.Model.Internal;

namespace TIS.Model.BL
{
    public class VacationBL
    {
        private UnitOfWork uow;

        public VacationBL()
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

        public VacationBL(UnitOfWork uow)
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

        public List<Vacation> GetAll()
        {
            try
            {
                List<Vacation> vacations = new XPCollection<Vacation>(uow).OrderBy(v => v.Date).ToList();

                return vacations;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public List<Vacation> GetByEmployee(Employee emp)
        {
            try
            {
                List<Vacation> vacations = new XPQuery<Vacation>(uow).Where(v => v.Employee.empID == emp.empID).OrderBy(e => e.Employee.DisplayName).ToList();

                return vacations;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public List<Vacation> GetByDispatcher(Employee disp)
        {
            try
            {
                List<Vacation> vacations = new XPQuery<Vacation>(uow).Where(v => v.Dispatcher.empID == disp.empID).OrderBy(e => e.Dispatcher.DisplayName).ToList();

                return vacations;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public List<Vacation> GetByDate(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                List<Vacation> vacations = new XPQuery<Vacation>(uow).Where(v => v.Date.Date >= dateFrom.Date && v.Date.Date <= dateTo.Date).OrderBy(v => v.Date).ToList();

                return vacations;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
    }
}

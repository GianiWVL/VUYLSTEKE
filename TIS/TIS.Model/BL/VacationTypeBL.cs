using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TIS.Model.Internal;

namespace TIS.Model.BL
{
    public class VacationTypeBL
    {
        private UnitOfWork uow;

        public VacationTypeBL()
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
        public VacationTypeBL(UnitOfWork uow)
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

        public List<VacationType> GetAll()
        {
            try
            {
                List<VacationType> vacationTypes = new XPCollection<VacationType>(uow).OrderBy(v => v.Name).ToList();

                return vacationTypes;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

    }
}

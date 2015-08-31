using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TIS.Model.Internal;

namespace TIS.Model.BL
{
    public class SupplierBL
    {
        private UnitOfWork uow;

        public SupplierBL()
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

        public SupplierBL(UnitOfWork uow)
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

        public List<Supplier> GetAll()
        {
            try
            {
                List<Supplier> suppliers = new XPCollection<Supplier>(uow).OrderBy(s => s.Name).ToList();
                return suppliers;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
    }
}

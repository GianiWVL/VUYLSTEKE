using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TIS.Model.Internal;

namespace TIS.Model.BL
{
    public class VehicleBL
    {
        private UnitOfWork uow;

        public VehicleBL()
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

        public VehicleBL(UnitOfWork uow)
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

        public List<Vehicle> GetAll()
        {
            try
            {
                List<Vehicle> vehicles = new XPCollection<Vehicle>(uow).OrderBy(s => s.Name).ToList();

                return vehicles;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
    }
}

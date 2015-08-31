using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TIS.Model.Internal;

namespace TIS.Model.BL
{
    public class BoardComputerBL
    {
        private UnitOfWork uow;

        public BoardComputerBL()
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

        public BoardComputerBL(UnitOfWork uow)
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

        public List<BoardComputer> GetAll()
        {
            try
            {
                List<BoardComputer> boardComputers = new XPCollection<BoardComputer>(uow).OrderBy(bc => bc.Id).ToList();

                return boardComputers;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
    }
}

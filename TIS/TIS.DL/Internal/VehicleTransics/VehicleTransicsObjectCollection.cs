using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using TIS.DL.Internal.VehicleTransicsLink;
using System.Reflection;

namespace TIS.DL.Internal.VehicleTransics
{
    public class VehicleTransicsObjectCollection: CollectionBase
    {

        #region Constructor
        public VehicleTransicsObjectCollection()
        {
        }
        #endregion

        #region Properties

        public VehicleTransicsObject this[int index]
        {
            get
            {
                return (VehicleTransicsObject)(List[index]);
            }
            set
            {
                List[index] = value;
            }
        }

        #endregion


        #region Methods
        public int Add(VehicleTransicsObject value)
        {
            try
            {
                return List.Add(value);
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion
    }
}

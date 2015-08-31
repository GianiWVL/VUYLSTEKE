using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using TIS.DL.Internal.Customer;
using System.Reflection;
using System.Collections;

namespace TIS.DL.External.TAS.TurnOver
{
    public static class TurnOverConvertor
    {
        public static TurnOverObject CustomerRowToObject(DataRow turnOvers)
        {
            TurnOverObject obj = new TurnOverObject();
            try
            {
                if (turnOvers != null)
                {
                    if (turnOvers.Table.Columns.Contains(TurnOverObject.TNR_ID))
                        obj.TnrID = RowFunctions.GetValueFromRowToInteger(turnOvers, TurnOverObject.TNR_ID, true, DataRowVersion.Current);

                    if (turnOvers.Table.Columns.Contains(TurnOverObject.YEAR))
                        obj.Year = RowFunctions.GetValueFromRowToInteger(turnOvers, TurnOverObject.YEAR, false, DataRowVersion.Current);

                    if (turnOvers.Table.Columns.Contains(TurnOverObject.MONTH))
                        obj.Month = RowFunctions.GetValueFromRowToInteger(turnOvers, TurnOverObject.MONTH, false, DataRowVersion.Current);

                    if (turnOvers.Table.Columns.Contains(TurnOverObject.DATE))
                        obj.Date = RowFunctions.GetValueFromRowToString(turnOvers, TurnOverObject.DATE, true, DataRowVersion.Current);

                    if (turnOvers.Table.Columns.Contains(TurnOverObject.VEHICLE))
                        obj.Vehicle = RowFunctions.GetValueFromRowToString(turnOvers, TurnOverObject.VEHICLE, true, DataRowVersion.Current);

                    if (turnOvers.Table.Columns.Contains(TurnOverObject.TURNOVER))
                        obj.TurnOver = RowFunctions.GetValueFromRowToDecimal(turnOvers, TurnOverObject.TURNOVER, true, DataRowVersion.Current);
                    return obj;
                }
                obj = null;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return obj;
        }

        public static TurnOverObjectCollection DataTableToCollection(DataTable turnOvers)
        {
            TurnOverObjectCollection objectsTotal;
            TurnOverObjectCollection objects = new TurnOverObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = turnOvers.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(CustomerRowToObject(current));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                objectsTotal = objects;
            }
            catch (System.Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return objectsTotal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.Popup
{
    public class PopupConvertor
    {
        public static PopupObject PopupRowToObject(DataRow popup)
        {
            PopupObject obj = new PopupObject();
            try
            {
                if (popup != null)
                {
                    obj.PopupID = RowFunctions.GetValueFromRowToGuid(popup, PopupObject.POPUP_ID, true, DataRowVersion.Current);
                    obj.Description = RowFunctions.GetValueFromRowToString(popup,PopupObject.DESCRIPTION,true,DataRowVersion.Current);
                    obj.Repeation = (Framework.Common.Enumeration.Frequency.TimeFrequency)RowFunctions.GetValueFromRowToInteger(popup, PopupObject.REPEAT, true, DataRowVersion.Current);
                    obj.Time = RowFunctions.GetValueFromRowToString(popup,PopupObject.TIME,true,DataRowVersion.Current);
                    obj.Active = RowFunctions.GetValueFromRowToBoolean(popup,PopupObject.ACTIVE,true,DataRowVersion.Current);
                    obj.CreationDate = RowFunctions.GetValueFromRowToString(popup,PopupObject.CREATIONDATE,true,DataRowVersion.Current);
                    obj.ShowDirect = RowFunctions.GetValueFromRowToBoolean(popup, PopupObject.SHOW_DIRECT, true, DataRowVersion.Current);
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
        public static PopupObjectCollection DataTableToCollection(DataTable popups)
        {
            PopupObjectCollection objectsTotal;
            PopupObjectCollection objects = new PopupObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = popups.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(PopupRowToObject(current));
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

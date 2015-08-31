using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections;

namespace TIS.DL.Internal.PopupUser
{
    public class PopupUserConverter
    {
        public static PopupUserObject TaskPeopleRowToObject(DataRow popupUser)
        {
            PopupUserObject obj = new PopupUserObject();
            try
            {
                if (popupUser != null)
                {
                    obj.User = User.UserConvertor.UserRowToObject(popupUser);
                    obj.Popup = Popup.PopupConvertor.PopupRowToObject(popupUser);
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

        public static PopupUserObjectCollection DataTableToCollection(DataTable taskPeoples)
        {
            PopupUserObjectCollection objectsTotal;
            PopupUserObjectCollection objects = new PopupUserObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = taskPeoples.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(TaskPeopleRowToObject(current));
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

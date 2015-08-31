using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Collections;
using System.Reflection;
using System.IO;
using TIS.DL.Internal.User;

namespace TIS.DL.Internal.UserSecurity
{
    public static class UserSecurityConvertor
    {
        public static UserSecurityObject UserSecurityRowToObject(DataRow user)
        {
            UserSecurityObject obj = new UserSecurityObject();
            try
            {
                if (user != null)
                {
                    obj = (UserSecurityObject)PROF_IT.Common.Convert.Byte.ByteArrayToObject(RowFunctions.GetValueFromRowToByteArray(user, UserObject.SECURITY, true, DataRowVersion.Current));
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

        public static UserSecurityObjectCollection DataTableToCollection(DataTable users)
        {
            UserSecurityObjectCollection objectsTotal;
            UserSecurityObjectCollection objects = new UserSecurityObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = users.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(UserSecurityRowToObject(current));
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

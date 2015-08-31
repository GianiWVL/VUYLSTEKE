using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PROF_IT.Common.Data;
using System.Reflection;
using System.Collections;
using TIS.DL.Internal.UserSecurity;

namespace TIS.DL.Internal.User
{
    public static class UserConvertor
    {
        public static UserObject UserRowToObject(DataRow user)
        {
            UserObject obj = new UserObject();
            try
            {
                if (user != null)
                {
                    obj.UsrID = RowFunctions.GetValueFromRowToGuid(user, UserObject.USR_ID, true, DataRowVersion.Current);
                    obj.Employee = Employee.EmployeeConvertor.EmployeeRowToObject(user, "");
                    obj.Surname = RowFunctions.GetValueFromRowToString(user, UserObject.SURNAME, false, DataRowVersion.Current);
                    obj.Name = RowFunctions.GetValueFromRowToString(user, UserObject.NAME, false, DataRowVersion.Current);
                    obj.Login = RowFunctions.GetValueFromRowToString(user, UserObject.LOGIN, true, DataRowVersion.Current);
                    obj.Password = RowFunctions.GetValueFromRowToString(user, UserObject.PASSWORD, true, DataRowVersion.Current);
                    obj.Active = RowFunctions.GetValueFromRowToBoolean(user, UserObject.ACTIVE, true, DataRowVersion.Current);
                    obj.HasPopups = RowFunctions.GetValueFromRowToBoolean(user, UserObject.HASPOPUPS, false, DataRowVersion.Current);
                    obj.Security = UserSecurityConvertor.UserSecurityRowToObject(user);
                    obj.SetInitialValues();
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

        public static UserObjectCollection DataTableToCollection(DataTable users)
        {
            UserObjectCollection objectsTotal;
            UserObjectCollection objects = new UserObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = users.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(UserRowToObject(current));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Common.Data;
using System.Data;
using System.Reflection;
using System.Collections;
using TIS.DL.Internal.Language;

namespace TIS.DL.Internal.Employee
{
    public static class EmployeeConvertor
    {
        public static EmployeeObject EmployeeRowToObject(DataRow employee, string alias)
        {
            EmployeeObject obj = new EmployeeObject();
            try
            {
                if (employee != null)
                {
                    string aliasLanguage = "";
                    if (alias != "")
                    {
                        aliasLanguage = alias + "Language";
                    }
                    string test = EmployeeObject.ConvertColumnToAlias(EmployeeObject.EMP_ID, alias);
                    if (RowFunctions.GetValueFromRowToGuid(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.EMP_ID, alias), false, DataRowVersion.Current) != Guid.Empty)
                    {
                        obj.EmpID = RowFunctions.GetValueFromRowToGuid(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.EMP_ID, alias), true, DataRowVersion.Current);
                        obj.TranscID = RowFunctions.GetValueFromRowToInteger(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.TRANSC_ID, alias), true, DataRowVersion.Current);
                        obj.TransiID = RowFunctions.GetValueFromRowToInteger(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.TRANSI_ID, alias), false, DataRowVersion.Current);
                        obj.Name = RowFunctions.GetValueFromRowToString(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.NAME, alias), false, DataRowVersion.Current);
                        obj.Surname = RowFunctions.GetValueFromRowToString(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.SURNAME, alias), false, DataRowVersion.Current);
                        obj.Email = RowFunctions.GetValueFromRowToString(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.EMAIL, alias), false, DataRowVersion.Current);
                        obj.Archive = RowFunctions.GetValueFromRowToBoolean(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.ARCHIVE, alias), false, DataRowVersion.Current);
                        obj.TranscLanguage = RowFunctions.GetValueFromRowToInteger(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.TRANSC_LANGUAGE, alias), false, DataRowVersion.Current);
                        obj.Language = LanguageConvertor.LanguageRowToObject(employee, aliasLanguage);
                        obj.RepeatMail = RowFunctions.GetValueFromRowToBoolean(employee, EmployeeObject.ConvertColumnToAlias(EmployeeObject.REPEAT_MAIL, alias), false, DataRowVersion.Current);
                    }
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

        public static EmployeeObjectCollection DataTableToCollection(DataTable employees, string alias)
        {
            EmployeeObjectCollection objectsTotal;
            EmployeeObjectCollection objects = new EmployeeObjectCollection();
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = employees.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        objects.Add(EmployeeRowToObject(current, alias));
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

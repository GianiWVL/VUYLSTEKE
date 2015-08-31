using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROF_IT.Exceptionhandling.DL.User;
using System.Reflection;
using TIS.Framework.Common;

namespace TIS.Framework.Security
{
    public class Functions
    {
        public Functions()
        {
        }

        public static bool AllowDelete(string authentication)
        {
            bool flag;
            try
            {
                if (authentication.Trim().Length == 3)
                {
                    return authentication.Substring(2, 1).Equals("1");
                }
                flag = false;
            }
            catch (Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return flag;
        }

        public static bool AllowDisplay(string authentication)
        {
            bool flag;
            try
            {
                if (authentication.Trim().Length == 3)
                {
                    return authentication.Substring(0, 1).Equals("1");
                }
                flag = false;
            }
            catch (Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return flag;
        }

        public static bool AllowMaintain(string authentication)
        {
            bool flag;
            try
            {
                if (authentication.Trim().Length == 3)
                {
                    return authentication.Substring(1, 1).Equals("1");
                }
                flag = false;
            }
            catch (Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return flag;
        }

        public static bool AllowGeneralDisplay(Enumeration.EnumViews.Application View)
        {
            bool flag;
            try
            {
                switch (((int)View))
                {
                    case 1:
                        if (!AllowDisplay(Context.User.Security.Application.AuthUser))
                            break;
                        return true;
                }
                return flag = false;
            }
            catch (Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
        }

        public static bool AllowGeneralMaintain(Enumeration.EnumViews.Application View)
        {
            bool flag;
            try
            {
                switch (((int)View))
                {
                    case 1:
                        if (!AllowMaintain(Context.User.Security.Application.AuthUser))
                            break;
                        return true;
                }
                return flag = false;
            }
            catch (Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
        }

        public static bool AllowGeneralDelete(Enumeration.EnumViews.Application view)
        {
            bool flag;
            try
            {
                switch (((int)view))
                {
                    case 1:
                        return AllowDelete(Context.User.Security.Application.AuthUser);

                }
                return flag = false;
            }
            catch (Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
        }

        public static string GetAuthentication(Enumeration.EnumViews.Application view, TIS.DL.Internal.User.UserObject user)
        {
            try
            {
                switch (((int)view))
                {
                    case 1:
                        return user.Security.Application.AuthUser;
                }
            }
            catch (Exception exception1)
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return "000";
        }
    }
}

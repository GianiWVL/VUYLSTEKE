using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using TIS.DATA.Internal;
using TIS.DL.Internal.User;
using PROF_IT.Common;

namespace TIS.BL.Internal
{
    public class User
    {
        public UserObjectCollection GetAll()
        {
            UserObjectCollection users;
            try
            {
                users = new UserDataService().GetAll();
            }
            catch (System.Exception exception1)
            {
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, exception1);
            }
            return users;
        }

        public UserObject GetUserByLogin(string login)
        {
            UserObject userByLogin;
            try
            {
                userByLogin = new UserDataService().GetUserByLogin(login);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return userByLogin;

        }

        public bool ValidUser(Enumerations.TypeForm type, UserObject user, ref string invalidMessage)
        {
            bool flag = false;
            try
            {
                invalidMessage = "";
                if (user.Surname.Trim().Length == 0)
                {
                    invalidMessage = "Surname cannot be empty.";
                    return false;
                }
                if (user.Login.Trim().Length == 0)
                {
                    invalidMessage = "Login cannot be empty.";
                    return false;
                }
                if (user.Password.Trim().Length == 0)
                {
                    invalidMessage = "Password cannot be empty.";
                    return false;
                }
                switch (((int)type))
                {
                    case 0:
                        if (this.GetUserBySurNameAndName(user.Surname, user.Name) == null)
                        {
                            if (GetUserByLogin(user.Login) == null)
                            {
                                return true;
                            }
                            else
                            {
                                invalidMessage = "User with this surname and name already exists.";
                                return false;
                            }
                        }
                        invalidMessage = "User with this surname and name already exists.";
                        return false;
                    case 1:
                        if ((user.SurNameChanged | user.NameChanged) && (GetUserBySurNameAndName(user.Surname, user.Name) == null))
                        {
                            if (user.LoginChanged && (GetUserByLogin(user.Login) == null))
                            {
                                invalidMessage = "user with this login already exists.";
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (!(user.SurNameChanged | user.NameChanged))
                            {
                                if (user.LoginChanged && (GetUserByLogin(user.Login) == null))
                                {
                                    return true;
                                }
                                else
                                {
                                    if (!user.LoginChanged)
                                        return true;
                                    else
                                    {
                                        invalidMessage = "User with this login already exists.";
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                invalidMessage = "User with this surname and name already exists.";
                                return false;
                            }
                        }
                    default:
                        return true;
                }
                if (this.GetUserByLogin(user.Login) != null)
                {
                    invalidMessage = "User with this login already exists.";
                    return false;
                }
                return flag;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public UserObject GetUserBySurNameAndName(string surName, string name)
        {
            UserObject user;
            try
            {
                user = new UserDataService().GetUserBySurNameAndName(surName, name);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            return user;
        }

        public void Save(UserObject user)
        {
            try
            {
                new UserDataService().Save(user);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void Remove(UserObject user)
        {
            try
            {
                new UserDataService().Remove(user);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public void SetUnknownSecurityParameters(UserObject user)
        {
            try
            {
                new UserDataService().SetUnknownSecurityParameters(user);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        public Boolean HasDependencies(UserObject user)
        {
            bool flag;
            try
            {
                flag = new UserDataService().HasDependencies(user);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }

            return flag;
        }
    }
}
                          
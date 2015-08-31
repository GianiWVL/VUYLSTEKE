using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIS.DL.Internal.User;

namespace TIS.Framework.Security
{
    public class Context
    {
        private static UserObject USER = null;

        public static UserObject User
        {
            get
            {
                return USER;
            }
            set
            {
                USER = value;
            }
        }
           
    }
}

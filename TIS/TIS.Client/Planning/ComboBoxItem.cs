using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIS.DL.Internal.User;

namespace TIS.Client.Planning
{
    class ComboBoxItem
    {
        public UserObject Value { get; set; }

        public override string ToString()
        {
            return Value.Login;
        }
    }
}

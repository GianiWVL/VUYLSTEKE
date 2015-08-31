using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using TIS.Model.Internal;

namespace TIS.Client
{
    static class Program
    {
        public static bool CLOSE = false;
        public static bool LOGIN = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string forcedConnectionString = PROF_IT.Application.Configuration.GetConnectionString("ConnectionStringData");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(forcedConnectionString, AutoCreateOption.DatabaseAndSchema);

            //The default session is used internally when objects of XPCollectioninstances are created without a session parameter.
            //This may result in a SessionMixingException
            XpoDefault.Session = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TIS.Client.General.Login());
            if (CLOSE == false)
                Application.Run(new TIS.Client.General.Main());
            if (LOGIN == true)
                Application.Restart();
        }
    }
}

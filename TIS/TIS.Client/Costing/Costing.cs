using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROF_IT.Exceptionhandling;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using TIS.DL.Internal.Task;
using TIS.DL.Internal.Customer;

namespace TIS.Client.Costing
{
    public partial class Costing : General.BaseChildForm
    {

        #region Fields
        #endregion

        #region Constructor
        public Costing()
        {
            try
            {
                InitializeComponent();
                FindAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        

        #region Properties
        #endregion 

        #region Events
        private void bbiTurnOverByYear_Click(object sender, EventArgs e)
        {
            try
            {
                Report.TurnOver chartVwr = new Report.TurnOver();
                chartVwr.Show();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void bbiTurnOverByVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                Report.TurnOverVehicle chartVwr = new Report.TurnOverVehicle();
                chartVwr.Show();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        private void FindAll()
        {
            try
            {
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        

        





        

 

       

        

       




    }
}

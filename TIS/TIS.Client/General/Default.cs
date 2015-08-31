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

namespace TIS.Client.Employee
{
    public partial class Default : General.BaseChildForm
    {

        #region Fields
        
        #endregion

        #region Constructor
        public Default()
        {
            try
            {
                InitializeComponent();
                
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

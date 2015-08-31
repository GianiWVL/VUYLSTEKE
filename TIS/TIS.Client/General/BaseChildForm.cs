using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.Xpo;

namespace TIS.Client.General
{
    public partial class BaseChildForm : DevExpress.XtraEditors.XtraUserControl
    {
        #region Fields
        private UnitOfWork _uow;
        #endregion

        public BaseChildForm()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
            this.Disposed += new EventHandler(Base_Disposed);
        }

        void Base_Disposed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #region Properties
        public UnitOfWork Uow
        {
            get { return _uow; }
            set { _uow = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}

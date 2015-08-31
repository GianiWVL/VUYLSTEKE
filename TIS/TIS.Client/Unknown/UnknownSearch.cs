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
using TIS.DL.Internal.Unknown;
using DevExpress.XtraGrid.Views.Base;

namespace TIS.Client.Unknown
{
    public partial class UnknownSearch : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private TIS.DL.Internal.Unknown.UnknownObject _unknown;
        private Boolean _saveRowToDatabase;
        private Boolean _newRow;
        #endregion

        #region Constructor
        public UnknownSearch()
        {
            try
            {
                InitializeComponent();
                _unknown = new UnknownObject();
                FindAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Methods
        public UnknownObject Unknown
        {
            get { return _unknown; }
            set { _unknown = value; }
        }
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvUnknown.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    Unknown = (UnknownObject)gdvUnknown.GetRow(gdvUnknown.FocusedRowHandle);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please select first a unknown!", "Attention", MessageBoxButtons.OK);
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void gdvUnknown_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (_saveRowToDatabase == true)
                {
                    if (gdvUnknown.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                    {
                        UnknownObject unknown = (UnknownObject)gdvUnknown.GetRow(gdvUnknown.FocusedRowHandle);
                        TIS.BL.Internal.Unknown blUnk = new TIS.BL.Internal.Unknown();
                        if (unknown != null)
                            blUnk.Save(unknown);
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvUnknown_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                ColumnView view = sender as ColumnView;
                if (!_newRow)
                {
                    if (MessageBox.Show("Do you want to save the current row?", "Confirm update",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        gdvUnknown.CancelUpdateCurrentRow();
                        _saveRowToDatabase = false;
                    }
                    else
                    {
                        _saveRowToDatabase = true;
                    }
                }
                else
                {
                    _saveRowToDatabase = true;
                    _newRow = false;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvUnknown_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            try
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
                e.WindowCaption = "Input error";
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove filter
                gdvUnknown.ClearColumnsFilter();
                // Get the handle of the source data row
                // the row will provide group column values for a new row
                int rowHandle = gdvUnknown.GetDataRowHandleByGroupRowHandle(gdvUnknown.FocusedRowHandle);
                //store group column values
                object[] groupValues = null;
                int groupColumnCount = gdvUnknown.GroupedColumns.Count;
                if (groupColumnCount > 0)
                {
                    groupValues = new object[groupColumnCount];
                    for (int i = 0; i < groupColumnCount; i++)
                    {
                        groupValues[i] = gdvUnknown.GetRowCellValue(rowHandle, gdvUnknown.GroupedColumns[i]);
                    }
                }
                //Add a new Row
                gdvUnknown.AddNewRow();
                //Get the handle of the new row
                int newRowHandle = gdvUnknown.FocusedRowHandle;
                object newRow = gdvUnknown.GetRow(newRowHandle);
                //Set cell values corresponding to group columns
                if (groupColumnCount > 0)
                {
                    for (int i = 0; i < groupColumnCount; i++)
                    {
                        gdvUnknown.SetRowCellValue(newRowHandle, gdvUnknown.GroupedColumns[i], groupValues[i]);
                    }
                }

                // Accept the new row
                _newRow = true;
                gdvUnknown.UpdateCurrentRow();
                // The row moves to a new position according to the current group settings
                // Locate the new row
                for (int n = 0; n < gdvUnknown.DataRowCount; n++)
                {
                    if (gdvUnknown.GetRow(n).Equals(newRow))
                    {
                        gdvUnknown.FocusedRowHandle = n;
                        break;
                    }
                }

            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new TIS.BL.Internal.Unknown().Remove((UnknownObject)gdvUnknown.GetRow(gdvUnknown.FocusedRowHandle));
                    UnknownObjectCollection carriers = (UnknownObjectCollection)gdcUnknown.DataSource;
                    carriers.Remove((UnknownObject)gdvUnknown.GetRow(gdvUnknown.FocusedRowHandle));
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Methods
        public void FindAll()
        {
            try
            {
                BL.Internal.Unknown blUnk = new BL.Internal.Unknown();
                gdcUnknown.DataSource = blUnk.GetAll();
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

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
using TIS.Framework.Common;
using TIS.DL.Internal.Fuel;
using TIS.Framework.Security;
using TIS.DL.Internal.FuelCorrection;
using TIS.DL.Internal.FuelDelivery;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace TIS.Client.Fuel
{
    public partial class Fuel : General.BaseChildForm
    {
        #region Fields
        private FuelCorrectionObject _fuelCorrection;
        private FuelObjectCollection _fuelCorrectionRows;
        private Boolean _saveEnable;
        #endregion

        #region Constructor
        public Fuel()
        {
            try
            {
                InitializeComponent();
                _fuelCorrection = new FuelCorrectionObject();
                _fuelCorrectionRows = new FuelObjectCollection();
                _saveEnable = true;
                FillControls();
                FillControlsCorrection();
                FillControlsDelivery();
                FillControlsFuelReport();
                SetPermissions();
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
      
        #region Fuel
        private void btnImportTotal_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    OpenFileDialog ofdImport = new OpenFileDialog();
                    ofdImport.Title = "Select file";
                    ofdImport.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet 2003(*.xls)|*.xls|All Files(*.*)|*.*";
                    ofdImport.FilterIndex = 1;
                    ofdImport.RestoreDirectory = true;

                    if (ofdImport.ShowDialog() != DialogResult.OK)
                        return;

                    string connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0;", ofdImport.FileName);
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Download factuur in Excel$]", connectionString);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);


                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (dr[18].ToString() == "" || dr[18].ToString().Trim() == "hoeveelheid") // Do not import header or empty rows from Excel
                            continue;

                        Enumeration.Fuel.FuelType fuelType;
                        switch(dr[17].ToString().ToLower())
                        {
                            case "adblue":
                                fuelType = Enumeration.Fuel.FuelType.Unknown ;
                                break;
                            case "diesel 10 ppm":
                                fuelType = Enumeration.Fuel.FuelType.Diesel ;
                                break;
                            case "excellium diesel":
                                fuelType = Enumeration.Fuel.FuelType.Diesel ;
                                break;
                            default:
                                fuelType = Enumeration.Fuel.FuelType.Unknown;
                                break;
                        }

                        string currency = dr[28].ToString().ToLower().Trim();
                        if (currency.ToLower() != "eur" && currency.ToLower() != "pln")
                        {
                            XtraMessageBox.Show("Wisselkoers niet gekend", "De wisselkoers " + currency + "is niet gekend!" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        if (fuelType == Enumeration.Fuel.FuelType.Diesel)
                        {
                            string licenseplate = "";
                            string employeename = "";
                            if (dr[12].ToString() != "")
                            {
                                int space1 = dr[12].ToString().IndexOf(' ');
                                licenseplate = dr[12].ToString().Substring(0, space1);
                                employeename = dr[12].ToString().Substring(space1 + 1);
                            }

                            TIS.DL.Internal.Fuel.FuelObject fuelObj = new FuelObject();
                            fuelObj.Btw = Convert.ToDecimal(dr[21].ToString());
                            fuelObj.CompanyTanking = false;
                            fuelObj.Date = Convert.ToDateTime(dr[15].ToString());
                            fuelObj.Employee = employeename;
                            fuelObj.EmployeeName = employeename;
                            fuelObj.FuelType = fuelType;
                            fuelObj.InvoiceOK = false;
                            fuelObj.InvoiceReceived = false;
                            fuelObj.Location = dr[26].ToString() + " -- " + dr[30].ToString();
                            fuelObj.PrivateTanking = false;
                            fuelObj.Quantity = Convert.ToDecimal(dr[18].ToString());
                            fuelObj.QuantityCorrection = 0;
                            fuelObj.Supplier = "TOTAL";
                            fuelObj.TotalPrice = Convert.ToDecimal(dr[20].ToString());
                            fuelObj.UnityPrice = Convert.ToDecimal(dr[20].ToString()) /  Convert.ToDecimal(dr[18].ToString());
                            fuelObj.VehicleKilometreCounter = Convert.ToInt32(Math.Round(Convert.ToDecimal(dr[31].ToString()),0));
                            fuelObj.VehicleLicensePlate = licenseplate;

                            if (currency == "pln")
                            {
                                decimal pln = Convert.ToDecimal(txtPLNCurrency.Text);
                                fuelObj.Btw = fuelObj.Btw / pln;
                                fuelObj.TotalPrice = fuelObj.TotalPrice / pln;
                                fuelObj.UnityPrice = fuelObj.UnityPrice / pln;
                            }

                            TIS.BL.Internal.Fuel fuelBL = new BL.Internal.Fuel();
                            fuelBL.Save(fuelObj);
                        }
                    }
                    XtraMessageBox.Show("Geïmporteerd", "Bestand is geïmporteerd.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Filter();
                }
                catch (System.Exception excepion1)
                {
                    System.Exception thisException = excepion1;
                    Management.ShowException(thisException);
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiAddFuel_Click(object sender, EventArgs e)
        {
            try
            {
                TIS.Client.Fuel.FuelDetail fuel = new TIS.Client.Fuel.FuelDetail(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (fuel.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiRemove_Click(object sender, EventArgs e)
        {
            try
            {

                if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Ben je zeker dat je de tanking wilt verwijderen?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    new BL.Internal.Fuel().Remove((FuelObject)gdvFuel.GetRow(this.gdvFuel.FocusedRowHandle));
                    Filter();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSearchFuel_Click(object sender, EventArgs e)
        {
            try
            {
                Filter();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "XLS|*.xls";
                saveDialog.Title = "Save to XLS File";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                    this.gdvFuel.ExportToXls(saveDialog.FileName);
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void gdvFuel_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                FuelObject fuel = (FuelObject)view.GetRow(view.FocusedRowHandle);
                TIS.Client.Fuel.FuelDetail fuelDetail = new FuelDetail(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, fuel);
                if (fuelDetail.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Filter();
                }
            }
            catch (System.Exception excepion1)
            {
                Cursor.Current = Cursors.Default;
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region FuelDelivery
        private void btnSearchFuelDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                FilterDelivery();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnExportToExcelFuelDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "XLS|*.xls";
                saveDialog.Title = "Save to XLS File";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                    this.gdvFuelDelivery.ExportToXls(saveDialog.FileName);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnNewFuelDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                TIS.Client.Fuel.FuelDeliveryDetail fuel = new TIS.Client.Fuel.FuelDeliveryDetail(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (fuel.ShowDialog() == DialogResult.OK)
                {
                    FilterDelivery();
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnRemoveFuelDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Ben je zeker dat je de levering wilt verwijderen?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    new BL.Internal.FuelDelivery().Remove((FuelDeliveryObject)this.gdvFuelDelivery.GetRow(this.gdvFuelDelivery.FocusedRowHandle));
                    FilterDelivery();
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvFuelDelivery_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                FuelDeliveryObject fuelDelivery = (FuelDeliveryObject)view.GetRow(view.FocusedRowHandle);
                TIS.Client.Fuel.FuelDeliveryDetail fuelDeliveryDetail = new FuelDeliveryDetail(PROF_IT.Common.Enumerations.TypeForm.PropertyForm, fuelDelivery);
                if (fuelDeliveryDetail.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.FilterDelivery();
                }
            }
            catch (System.Exception excepion1)
            {
                Cursor.Current = Cursors.Default;
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region FuelCorrection
        private void bbiRemoveFuelCorrection_Click(object sender, EventArgs e)
        {
            try
            {

                if (DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "Ben je zeker dat je de brandstof correctie wilt verwijderen?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    //********************
                    //    GetFuels
                    //********************
                    FuelCorrectionObject fuel = (FuelCorrectionObject)this.gdvFuelCorrection.GetRow(this.gdvFuelCorrection.FocusedRowHandle);
                    FuelObjectCollection fuels;
                    BL.Internal.Fuel fuelBL = new BL.Internal.Fuel();
                    fuels = fuelBL.GetFilter(PROF_IT.Common.Convert.DateFunctions.DBDateToDate(fuel.DateFrom),
                                                            PROF_IT.Common.Convert.DateFunctions.DBDateToDate(fuel.DateTo),
                                                            fuel.VehiclesNotIncluded, fuel.SuppliersIncluded);
                    if (fuels != null)
                    {
                        foreach (FuelObject fuelObj in fuels)
                        {
                            fuelObj.QuantityCorrection = fuelObj.Quantity;
                            new BL.Internal.Fuel().Save(fuelObj);
                        }
                    }

                    new BL.Internal.FuelCorrection().Remove(fuel);
                    FillControlsCorrection();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnAddFuelCorrection_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFuelCorrectionControls();

            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSaveCorrection_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFuelCorrection();
                SaveFuelCorrectionRows();
                ClearFuelCorrectionControls();
                FillControlsCorrection();

            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnCalculateCorrection_Click(object sender, EventArgs e)
        {
            try
            {
                if (dteDateFrom.Text == "" | dteDateTo.Text == "" | spinMaxQuantity.Value == 0 | spinQuantityCorrection.Value == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vul eerst de datum- en de hoeveelheids velden in !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CalculateFuelCorrectionRows();
                    if (_saveEnable)
                    {
                        this.btnSaveCorrection.Enabled = true;
                        this.btnCancelCorrection.Enabled = true;
                    }
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void btnCancelCorrection_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFuelCorrectionControls();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void gdvFuelCorrection_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                _fuelCorrection = (FuelCorrectionObject)view.GetRow(view.FocusedRowHandle);
                FillFuelCorrectionControls();
                _saveEnable = false;
                btnSaveCorrection.Enabled = false;
                btnCancelCorrection.Enabled = false;
                btnCalculateCorrection.Enabled = true;
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region FuelReport
        private void chartFuelDelivery_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                // Obtain hit information under the test point.
                ChartHitInfo hi = chartFuelDelivery.CalcHitInfo(e.X, e.Y);


                // Obtain the series point under the test point.
                SeriesPoint point = hi.SeriesPoint;

                // Check whether the series point was clicked or not.
                if (point != null)
                {
                    // Obtain the series point argument.
                    string argument = "Datum: " + point.Argument.ToString();

                    // Obtain series point values.

                    string values = "Eenheidsprijs: " + Math.Round(point.Values[0], 0).ToString() + " €";
                    if (point.Values.Length > 1)
                    {
                        for (int i = 1; i < point.Values.Length; i++)
                        {
                            values = values + ", " + point.Values[i].ToString();
                        }
                    }

                    // Show the tooltip.
                    toolTipController2.ShowHint(argument + "\n" + values, "Omzet " + hi.Series.LegendText);
                }
                else
                {
                    // Hide the tooltip.
                    toolTipController2.HideHint();
                }
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }

        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialogbrowse = new FolderBrowserDialog();
                SaveFileDialog dialogSave = new SaveFileDialog();
                dialogbrowse.RootFolder = Environment.SpecialFolder.Personal;
                dialogSave.DefaultExt = ".jpeg";
                dialogSave.Filter = "jpeg files (*.jpeg)|*.jpeg";

                dialogSave.InitialDirectory = dialogbrowse.SelectedPath;
                DialogResult result = dialogSave.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.chartFuelDelivery.ExportToImage(dialogSave.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialogbrowse = new FolderBrowserDialog();
                SaveFileDialog dialogSave = new SaveFileDialog();
                dialogbrowse.RootFolder = Environment.SpecialFolder.Personal;
                dialogSave.DefaultExt = ".pdf";
                dialogSave.Filter = "pdf files (*.pdf)|*.pdf";

                dialogSave.InitialDirectory = dialogbrowse.SelectedPath;
                DialogResult result = dialogSave.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.chartFuelDelivery.ExportToPdf(dialogSave.FileName);
                }
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btn3M_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 30));
                fuelDeliveryObjectCollectionBindingSource.DataSource = new BL.Internal.FuelDelivery().GetFilter(date, DateTime.Now);
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void btn6M_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(6 * 30));
                fuelDeliveryObjectCollectionBindingSource.DataSource = new BL.Internal.FuelDelivery().GetFilter(date, DateTime.Now);
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void btn1J_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(1 * 365));
                fuelDeliveryObjectCollectionBindingSource.DataSource = new BL.Internal.FuelDelivery().GetFilter(date, DateTime.Now);
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void btn3J_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 365));
                fuelDeliveryObjectCollectionBindingSource.DataSource = new BL.Internal.FuelDelivery().GetFilter(date, DateTime.Now);
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void btn5J_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(5 * 365));
                fuelDeliveryObjectCollectionBindingSource.DataSource = new BL.Internal.FuelDelivery().GetFilter(date, DateTime.Now);
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void btn10J_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(10 * 365));
                fuelDeliveryObjectCollectionBindingSource.DataSource = new BL.Internal.FuelDelivery().GetFilter(date, DateTime.Now);
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void cbxTurnOverByTimeFrameLabel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckEdit chkBox = (CheckEdit)sender;
                if (chkBox.Checked)
                    chartFuelDelivery.Series[0].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                else
                    chartFuelDelivery.Series[0].LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
                this.chartFuelDelivery.Refresh();
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion


        #endregion

        #region Methods
        #region Fuel
        private void Filter()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Int32 fuelType;

                if (cmbFuel.Text != "")
                    fuelType = Convert.ToInt32((Enumeration.Fuel.FuelType)Enum.Parse(typeof(Enumeration.Fuel.FuelType), cmbFuel.Text));
                else
                    fuelType = -1;
                if (cbxPrivate.Checked)
                {
                    this.gdcFuel.DataSource = new BL.Internal.Fuel().GetFilter(cmbSupplier.Text, fuelType,
                                            cmbEmployee.Text, cmbVehicle.Text, dteDateFrom.DateTime, dteDateTo.DateTime,
                                            cbxPrivate.Checked);
                }
                else
                {
                    this.gdcFuel.DataSource = new BL.Internal.Fuel().GetFilter(cmbSupplier.Text, fuelType,
                                            cmbEmployee.Text, cmbVehicle.Text, dteDateFrom.DateTime, dteDateTo.DateTime);
                }
                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void FillControls()
        {
            try
            {
                string[] suppliers = new BL.Internal.Fuel().GetSuppliers();
                foreach (string supplier in suppliers)
                {
                    this.cmbSupplier.Properties.Items.Add(supplier);
                    this.ccbxSuppliersIncluded.Properties.Items.Add(supplier);
                }

                string[] vehicles = new BL.Internal.Fuel().GetVehicles();
                foreach (string vehicle in vehicles)
                {
                    this.cmbVehicle.Properties.Items.Add(vehicle);
                    this.ccbxVehiclesNotIncluded.Properties.Items.Add(vehicle);
                }

                string[] employees = new BL.Internal.Fuel().GetEmployees();
                foreach (string employee in employees)
                {
                    this.cmbEmployee.Properties.Items.Add(employee);
                }

                foreach (string fuelType in Enum.GetNames(typeof(Framework.Common.Enumeration.Fuel.FuelType)))
                {
                    this.cmbFuel.Properties.Items.Add(fuelType);
                }


                dteDateFrom.DateTime = DateTime.Now.Subtract(TimeSpan.FromDays(1));
                dteDateTo.DateTime = DateTime.Now;

            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region FuelDelivery
        private void FilterDelivery()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (dteDateFromDelivery.Text != "" & dteDateToDelivery.Text != "")
                {
                    this.gdcFuelDelivery.DataSource = new BL.Internal.FuelDelivery().GetFilter(dteDateFromDelivery.DateTime, dteDateToDelivery.DateTime);

                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Datum van en datum tot moet ingevuld worden!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                
                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void FillControlsDelivery()
        {
            try
            {
                dteDateFromDelivery.DateTime = DateTime.Now.Subtract(TimeSpan.FromDays(180));
                dteDateToDelivery.DateTime = DateTime.Now;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region FuelCorrection
        private void FillControlsCorrection()
        {
            try
            {
                gdcFuelCorrection.DataSource = new BL.Internal.FuelCorrection().GetAll();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void ClearFuelCorrectionControls()
        {
            try
            {
                this.ccbxSuppliersIncluded.Properties.Items.Clear();
                string[] suppliers = new BL.Internal.Fuel().GetSuppliers();
                foreach (string supplier in suppliers)
                {
                    this.ccbxSuppliersIncluded.Properties.Items.Add(supplier);
                }

                this.ccbxVehiclesNotIncluded.Properties.Items.Clear();
                string[] vehicles = new BL.Internal.Fuel().GetVehicles();
                foreach (string vehicle in vehicles)
                {
                    this.ccbxVehiclesNotIncluded.Properties.Items.Add(vehicle);
                }

                dteDateFromCorrection.Text = "";
                dteDateToCorrection.Text = "";
                _fuelCorrection = new FuelCorrectionObject();

                this.gdcFuelCorrectionCalc.DataSource = null;
                _saveEnable = true;
                btnSaveCorrection.Enabled = false;
                btnCancelCorrection.Enabled = false;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }

            spinMaxQuantity.Value = 0;
            spinQuantityCorrection.Value = 0;
        }
        private void SaveFuelCorrection()
        {
            try
            {
                _fuelCorrection.DateFrom = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(dteDateFromCorrection.DateTime);
                _fuelCorrection.DateTo = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(dteDateToCorrection.DateTime);
                _fuelCorrection.Quantity = spinQuantityCorrection.Value;
                _fuelCorrection.MaxQuantity = spinMaxQuantity.Value;
                _fuelCorrection.VehiclesNotIncluded = "";
                for (int i = 0; i < this.ccbxVehiclesNotIncluded.Properties.GetItems().Count; i++)
                {
                    if (this.ccbxVehiclesNotIncluded.Properties.Items[i].CheckState == CheckState.Checked)
                    {
                        _fuelCorrection.VehiclesNotIncluded += (string)this.ccbxVehiclesNotIncluded.Properties.Items[i].Value + "/";
                    }
                }
                _fuelCorrection.SuppliersIncluded = "";
                for (int i = 0; i < this.ccbxSuppliersIncluded.Properties.GetItems().Count; i++)
                {
                    if (this.ccbxSuppliersIncluded.Properties.Items[i].CheckState == CheckState.Checked)
                    {
                        _fuelCorrection.SuppliersIncluded += (string)this.ccbxSuppliersIncluded.Properties.Items[i].Value + "/"; ;
                    }
                }

                new BL.Internal.FuelCorrection().Save(_fuelCorrection);
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void SaveFuelCorrectionRows()
        {
            try
            {
                foreach (FuelObject fuel in _fuelCorrectionRows)
                {
                    new BL.Internal.Fuel().Save(fuel);
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void CalculateFuelCorrectionRows()
        {
            try
            {
                //********************
                //    GetFuels
                //********************
                string vehiclesNotIncluded = "";
                for (int i = 0; i < this.ccbxVehiclesNotIncluded.Properties.GetItems().Count; i++)
                {
                    if (this.ccbxVehiclesNotIncluded.Properties.Items[i].CheckState == CheckState.Checked)
                    {
                        vehiclesNotIncluded += (string)this.ccbxVehiclesNotIncluded.Properties.Items[i].Value + "/";
                    }
                }
                string suppliersIncluded = "";
                for (int i = 0; i < this.ccbxSuppliersIncluded.Properties.GetItems().Count; i++)
                {
                    if (this.ccbxSuppliersIncluded.Properties.Items[i].CheckState == CheckState.Checked)
                    {
                        suppliersIncluded += (string)this.ccbxSuppliersIncluded.Properties.Items[i].Value + "/";
                    }
                }


                BL.Internal.Fuel fuelBL = new BL.Internal.Fuel();
                _fuelCorrectionRows = fuelBL.GetFilter(dteDateFromCorrection.DateTime, dteDateToCorrection.DateTime, vehiclesNotIncluded, suppliersIncluded);

                //********************
                //    Calculate
                //********************

                decimal totalAmountOfLiters = fuelBL.GetTotalAmountOfLiters(_fuelCorrectionRows);
                decimal stillToAdd = spinQuantityCorrection.Value;
                decimal averageToAdd = 0;
                string vehicle = "";
                int CountLoop = 0;

                do
                {
                    foreach (FuelObject fuel in _fuelCorrectionRows)
                    {
                        if (stillToAdd > 0)
                        {
                            averageToAdd = (fuel.Quantity / totalAmountOfLiters) * spinQuantityCorrection.Value;
                            if (vehicle != fuel.VehicleLicensePlate)
                            {
                                if (stillToAdd > averageToAdd)
                                {
                                    if (spinMaxQuantity.Value < fuel.Quantity + averageToAdd)
                                    {
                                        if (spinMaxQuantity.Value > fuel.Quantity)
                                        {
                                            fuel.QuantityCorrection = spinMaxQuantity.Value;
                                            stillToAdd -= spinMaxQuantity.Value - fuel.Quantity;
                                        }
                                        else
                                            fuel.QuantityCorrection = fuel.Quantity;
                                    }
                                    else
                                    {

                                        fuel.QuantityCorrection = fuel.Quantity + averageToAdd;
                                        stillToAdd -= averageToAdd;
                                    }
                                }
                                else
                                {
                                    if (spinMaxQuantity.Value < fuel.Quantity + stillToAdd)
                                    {
                                        if (spinMaxQuantity.Value > fuel.Quantity)
                                        {
                                            fuel.QuantityCorrection = spinMaxQuantity.Value;
                                            stillToAdd -= spinMaxQuantity.Value - fuel.Quantity;
                                        }
                                        else
                                            fuel.QuantityCorrection = fuel.Quantity;
                                    }
                                    else
                                    {

                                        fuel.QuantityCorrection = fuel.Quantity + stillToAdd;
                                        stillToAdd = 0;
                                    }
                                }

                                vehicle = fuel.VehicleLicensePlate;
                            }
                        }
                    }
                    CountLoop += 1;
                }
                while (stillToAdd > 0 & CountLoop < 1000);

                if (CountLoop >= 1000)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Niet mogelijk om de hoeveelheid te verdelen over de voertuigen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.gdcFuelCorrectionCalc.DataSource = _fuelCorrectionRows;
                }

            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void FillFuelCorrectionControls()
        {
            try
            {
                dteDateFromCorrection.DateTime = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(_fuelCorrection.DateFrom);
                dteDateToCorrection.DateTime = PROF_IT.Common.Convert.DateFunctions.DBDateToDate(_fuelCorrection.DateTo);
                spinMaxQuantity.Value = _fuelCorrection.MaxQuantity;
                spinQuantityCorrection.Value = _fuelCorrection.Quantity;

                for (int i = 0; i < this.ccbxVehiclesNotIncluded.Properties.GetItems().Count; i++)
                {
                    if (_fuelCorrection.VehiclesNotIncluded.Contains((string)this.ccbxVehiclesNotIncluded.Properties.Items[i].Value))
                    {
                        this.ccbxVehiclesNotIncluded.Properties.Items[i].CheckState = CheckState.Checked;
                    }
                    else
                        this.ccbxVehiclesNotIncluded.Properties.Items[i].CheckState = CheckState.Unchecked;
                }

                for (int i = 0; i < this.ccbxSuppliersIncluded.Properties.GetItems().Count; i++)
                {
                    if (_fuelCorrection.SuppliersIncluded.Contains((string)this.ccbxSuppliersIncluded.Properties.Items[i].Value))
                    {
                        this.ccbxSuppliersIncluded.Properties.Items[i].CheckState = CheckState.Checked;
                    }
                    else
                        this.ccbxSuppliersIncluded.Properties.Items[i].CheckState = CheckState.Unchecked;
                }

            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region FuelReport
        private void FillControlsFuelReport()
        {
            try
            {
                fuelDeliveryObjectCollectionBindingSource.DataSource = new BL.Internal.FuelDelivery().GetAllNotZero();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        private void SetPermissions()
        {
            try
            {
                if (!Functions.AllowDisplay(Context.User.Security.Costing.AuthFuel))
                    this.tabpageFuel.PageEnabled = false;
                if (!Functions.AllowDisplay(Context.User.Security.Costing.AuthFuelCorrection))
                {
                    this.tabpageCorrection.PageEnabled = false;
                    gdcoQuantity.Visible = false;
                    gdcoQuantityCorrection.Caption = "Hoeveelheid";
                }
                if (!Functions.AllowDisplay(Context.User.Security.Costing.AuthFuelDelivery))
                    this.tabpageDelivery.PageEnabled = false;


                if (!Functions.AllowMaintain(Context.User.Security.Costing.AuthFuel))
                    this.bbiAddFuel.Enabled = false;
                if (!Functions.AllowDelete(Context.User.Security.Costing.AuthFuel))
                    this.bbiRemove.Enabled = false;

                if (!Functions.AllowMaintain(Context.User.Security.Costing.AuthFuelDelivery))
                    this.btnNewFuelDelivery.Enabled = false;
                if (!Functions.AllowDelete(Context.User.Security.Costing.AuthFuelDelivery))
                    this.btnRemoveFuelDelivery.Enabled = false;

                if (!Functions.AllowMaintain(Context.User.Security.Costing.AuthFuelCorrection))
                {
                    this.btnAddFuelCorrection.Enabled = false;
                    this.btnSaveCorrection.Enabled = false;
                }
                if (!Functions.AllowDelete(Context.User.Security.Costing.AuthFuelCorrection))
                    this.bbiRemoveFuelCorrection.Enabled = false;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Reporting.WinForms;
using TIS.DL.External.TAS.TurnOver;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.Customer;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using DevExpress.XtraRichEdit.Internal;

namespace TIS.Client.Report
{
    public partial class TurnOver : DevExpress.XtraEditors.XtraForm
    {

        #region Fields
        private TIS.Framework.Common.Enumeration.Reports.TurnOver _report;
        private CustomerObject _customer;
        private DateTime _startDateByTimeFrame;
        private BL.External.TAS.TurnOver.TurnOver _blTurnover;
        #endregion

        #region Constructor
        public TurnOver()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                InitializeComponent();
                _blTurnover = new BL.External.TAS.TurnOver.TurnOver();
                FillControls();
                AddSerie(1, System.DateTime.Now.Year);
                //AddTrend(1, System.DateTime.Now.Year);
                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
                Cursor.Current = Cursors.Default;
            }
        }
        public TurnOver(CustomerObject customer)
        {
            try
            {

                InitializeComponent();
                _blTurnover = new BL.External.TAS.TurnOver.TurnOver();
                _customer = customer;
                FillControls();
                AddSerie(1, System.DateTime.Now.Year); 
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

        #region Private Methods
        #region By Year
        private void AddSerie(int tag, int year)
        {
            try
            {
                this.chartTurnOver.Series["Series " + tag.ToString()].Visible = true;
                this.chartTurnOver.Series["Series " + tag.ToString()].LegendText = year.ToString();

                switch (tag)
                {
                    case 1:
                        turnOverObjectCollectionBindingSource1.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 2:
                        turnOverObjectCollectionBindingSource2.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 3:
                        turnOverObjectCollectionBindingSource3.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 4:
                        turnOverObjectCollectionBindingSource4.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 5:
                        turnOverObjectCollectionBindingSource5.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 6:
                        turnOverObjectCollectionBindingSource6.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 7:
                        turnOverObjectCollectionBindingSource7.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 8:
                        turnOverObjectCollectionBindingSource8.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 9:
                        turnOverObjectCollectionBindingSource9.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 10:
                        turnOverObjectCollectionBindingSource10.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                    case 11:
                        turnOverObjectCollectionBindingSource11.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByYear(year, _customer);
                        break;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void RemoveSerie(int tag)
        {
            try
            {
                switch (tag)
                {
                    case 1:

                        this.chartTurnOver.Series["Series 1"].Visible = false;
                        turnOverObjectCollectionBindingSource1.Clear();
                        break;
                    case 2:
                        this.chartTurnOver.Series["Series 2"].Visible = false;
                        turnOverObjectCollectionBindingSource2.Clear();
                        break;
                    case 3:
                        this.chartTurnOver.Series["Series 3"].Visible = false;
                        turnOverObjectCollectionBindingSource3.Clear();
                        break;
                    case 4:
                        this.chartTurnOver.Series["Series 4"].Visible = false;
                        turnOverObjectCollectionBindingSource4.Clear();
                        break;
                    case 5:
                        this.chartTurnOver.Series["Series 5"].Visible = false;
                        turnOverObjectCollectionBindingSource5.Clear();
                        break;
                    case 6:
                        this.chartTurnOver.Series["Series 6"].Visible = false;
                        turnOverObjectCollectionBindingSource6.Clear();
                        break;
                    case 7:
                        this.chartTurnOver.Series["Series 7"].Visible = false;
                        turnOverObjectCollectionBindingSource7.Clear();
                        break;
                    case 8:
                        this.chartTurnOver.Series["Series 8"].Visible = false;
                        turnOverObjectCollectionBindingSource8.Clear();
                        break;
                    case 9:
                        this.chartTurnOver.Series["Series 9"].Visible = false;
                        turnOverObjectCollectionBindingSource9.Clear();
                        break;
                    case 10:
                        this.chartTurnOver.Series["Series 10"].Visible = false;
                        turnOverObjectCollectionBindingSource10.Clear();
                        break;
                    case 11:
                        this.chartTurnOver.Series["Series 11"].Visible = false;
                        turnOverObjectCollectionBindingSource11.Clear();
                        break;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void AddTrend(int tag, int year)
        {
            try
            {
                Decimal turnOver = new Decimal();

                this.chartTurnOver.Series["Trend " + tag.ToString()].Visible = true;
                this.chartTurnOver.Series["Trend " + tag.ToString()].LegendText = "Gem. " + year.ToString();
                turnOver = new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthByYearByCustomer(year, _customer);
                turnOver = Math.Round(turnOver, 0);
                this.chartTurnOver.Series["Trend " + tag.ToString()].Points.Add(new SeriesPoint(1, new object[] { turnOver }));
                this.chartTurnOver.Series["Trend " + tag.ToString()].Points.Add(new SeriesPoint(12, new object[] { turnOver }));

            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void RemoveTrend(int tag)
        {
            try
            {
                switch (tag)
                {
                    case 1:
                        this.chartTurnOver.Series["Trend 1"].Visible = false;
                        this.chartTurnOver.Series["Trend 1"].Points.Clear();
                        break;
                    case 2:
                        this.chartTurnOver.Series["Trend 2"].Visible = false;
                        this.chartTurnOver.Series["Trend 2"].Points.Clear();
                        break;
                    case 3:
                        this.chartTurnOver.Series["Trend 3"].Visible = false;
                        this.chartTurnOver.Series["Trend 3"].Points.Clear();
                        break;
                    case 4:
                        this.chartTurnOver.Series["Trend 4"].Visible = false;
                        this.chartTurnOver.Series["Trend 4"].Points.Clear();
                        break;
                    case 5:
                        this.chartTurnOver.Series["Trend 5"].Visible = false;
                        this.chartTurnOver.Series["Trend 5"].Points.Clear();
                        break;
                    case 6:
                        this.chartTurnOver.Series["Trend 6"].Visible = false;
                        this.chartTurnOver.Series["Trend 6"].Points.Clear();
                        break;
                    case 7:
                        this.chartTurnOver.Series["Trend 7"].Visible = false;
                        this.chartTurnOver.Series["Trend 7"].Points.Clear();
                        break;
                    case 8:
                        this.chartTurnOver.Series["Trend 8"].Visible = false;
                        this.chartTurnOver.Series["Trend 8"].Points.Clear();
                        break;
                    case 9:
                        this.chartTurnOver.Series["Trend 9"].Visible = false;
                        this.chartTurnOver.Series["Trend 9"].Points.Clear();
                        break;
                    case 10:
                        this.chartTurnOver.Series["Trend 10"].Visible = false;
                        this.chartTurnOver.Series["Trend 10"].Points.Clear();
                        break;
                    case 11:
                        this.chartTurnOver.Series["Trend 11"].Visible = false;
                        this.chartTurnOver.Series["Trend 11"].Points.Clear();
                        break;
                }
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
                int year = System.DateTime.Now.Year;
                btnYear11.Text = Convert.ToString(year);
                btnYear10.Text = Convert.ToString(year - 1);
                btnYear9.Text = Convert.ToString(year - 2);
                btnYear8.Text = Convert.ToString(year - 3);
                btnYear7.Text = Convert.ToString(year - 4);
                btnYear6.Text = Convert.ToString(year - 5);
                btnYear5.Text = Convert.ToString(year - 6);
                btnYear4.Text = Convert.ToString(year - 7);
                btnYear3.Text = Convert.ToString(year - 8);
                btnYear2.Text = Convert.ToString(year - 9);
                btnYear1.Text = Convert.ToString(year - 10);

                if (_customer != null)
                {
                    lblTurnByTimeFrameOverYear11.Text = Convert.ToString(year);
                    lblTurnByTimeFrameOverYear10.Text = Convert.ToString(year - 1);
                    lblTurnByTimeFrameOverYear9.Text = Convert.ToString(year - 2);
                    lblTurnByTimeFrameOverYear8.Text = Convert.ToString(year - 3);
                    lblTurnByTimeFrameOverYear7.Text = Convert.ToString(year - 4);
                    lblTurnByTimeFrameOverYear6.Text = Convert.ToString(year - 5);
                    lblTurnByTimeFrameOverYear5.Text = Convert.ToString(year - 6);
                    lblTurnByTimeFrameOverYear4.Text = Convert.ToString(year - 7);
                    lblTurnByTimeFrameOverYear3.Text = Convert.ToString(year - 8);
                    lblTurnByTimeFrameOverYear2.Text = Convert.ToString(year - 9);
                    lblTurnByTimeFrameOverYear1.Text = Convert.ToString(year - 10);

                    lblTurnOverYear11.Text = Convert.ToString(year);
                    lblTurnOverYear10.Text = Convert.ToString(year - 1);
                    lblTurnOverYear9.Text = Convert.ToString(year - 2);
                    lblTurnOverYear8.Text = Convert.ToString(year - 3);
                    lblTurnOverYear7.Text = Convert.ToString(year - 4);
                    lblTurnOverYear6.Text = Convert.ToString(year - 5);
                    lblTurnOverYear5.Text = Convert.ToString(year - 6);
                    lblTurnOverYear4.Text = Convert.ToString(year - 7);
                    lblTurnOverYear3.Text = Convert.ToString(year - 8);
                    lblTurnOverYear2.Text = Convert.ToString(year - 9);
                    lblTurnOverYear1.Text = Convert.ToString(year - 10);

                    txtTurnOverByTimeFrameYear11.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year).ToString();
                    txtTurnOverByTimeFrameYear10.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 1).ToString();
                    txtTurnOverByTimeFrameYear9.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 2).ToString();
                    txtTurnOverByTimeFrameYear8.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 3).ToString();
                    txtTurnOverByTimeFrameYear7.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 4).ToString();
                    txtTurnOverByTimeFrameYear6.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 5).ToString();
                    txtTurnOverByTimeFrameYear5.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 6).ToString();
                    txtTurnOverByTimeFrameYear4.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 7).ToString();
                    txtTurnOverByTimeFrameYear3.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 8).ToString();
                    txtTurnOverByTimeFrameYear2.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 9).ToString();
                    txtTurnOverByTimeFrameYear1.Text = _blTurnover.GetTurnOverByYearByCustomer(_customer, year - 10).ToString();

                    txtTurnOverYear11.Text = txtTurnOverByTimeFrameYear11.Text;
                    txtTurnOverYear10.Text = txtTurnOverByTimeFrameYear10.Text;
                    txtTurnOverYear9.Text = txtTurnOverByTimeFrameYear9.Text;
                    txtTurnOverYear8.Text = txtTurnOverByTimeFrameYear8.Text;
                    txtTurnOverYear7.Text = txtTurnOverByTimeFrameYear7.Text;
                    txtTurnOverYear6.Text = txtTurnOverByTimeFrameYear6.Text;
                    txtTurnOverYear5.Text = txtTurnOverByTimeFrameYear5.Text;
                    txtTurnOverYear4.Text = txtTurnOverByTimeFrameYear4.Text;
                    txtTurnOverYear3.Text = txtTurnOverByTimeFrameYear3.Text;
                    txtTurnOverYear2.Text = txtTurnOverByTimeFrameYear2.Text;
                    txtTurnOverYear1.Text = txtTurnOverByTimeFrameYear1.Text;
                }
                else
                {
                    lblTurnByTimeFrameOverYear11.Visible = false;
                    lblTurnByTimeFrameOverYear10.Visible = false;
                    lblTurnByTimeFrameOverYear9.Visible = false;
                    lblTurnByTimeFrameOverYear8.Visible = false;
                    lblTurnByTimeFrameOverYear7.Visible = false;
                    lblTurnByTimeFrameOverYear6.Visible = false;
                    lblTurnByTimeFrameOverYear5.Visible = false;
                    lblTurnByTimeFrameOverYear4.Visible = false;
                    lblTurnByTimeFrameOverYear3.Visible = false;
                    lblTurnByTimeFrameOverYear2.Visible = false;
                    lblTurnByTimeFrameOverYear1.Visible = false;

                    lblTurnOverYear11.Visible = false;
                    lblTurnOverYear10.Visible = false;
                    lblTurnOverYear9.Visible = false;
                    lblTurnOverYear8.Visible = false;
                    lblTurnOverYear7.Visible = false;
                    lblTurnOverYear6.Visible = false;
                    lblTurnOverYear5.Visible = false;
                    lblTurnOverYear4.Visible = false;
                    lblTurnOverYear3.Visible = false;
                    lblTurnOverYear2.Visible = false;
                    lblTurnOverYear1.Visible = false;

                    txtTurnOverByTimeFrameYear11.Visible = false;
                    txtTurnOverByTimeFrameYear10.Visible = false;
                    txtTurnOverByTimeFrameYear9.Visible = false;
                    txtTurnOverByTimeFrameYear8.Visible = false;
                    txtTurnOverByTimeFrameYear7.Visible = false;
                    txtTurnOverByTimeFrameYear6.Visible = false;
                    txtTurnOverByTimeFrameYear5.Visible = false;
                    txtTurnOverByTimeFrameYear4.Visible = false;
                    txtTurnOverByTimeFrameYear3.Visible = false;
                    txtTurnOverByTimeFrameYear2.Visible = false;
                    txtTurnOverByTimeFrameYear1.Visible = false;

                    txtTurnOverYear11.Visible = false;
                    txtTurnOverYear10.Visible = false;
                    txtTurnOverYear9.Visible = false;
                    txtTurnOverYear8.Visible = false;
                    txtTurnOverYear7.Visible = false;
                    txtTurnOverYear6.Visible = false;
                    txtTurnOverYear5.Visible = false;
                    txtTurnOverYear4.Visible = false;
                    txtTurnOverYear3.Visible = false;
                    txtTurnOverYear2.Visible = false;
                    txtTurnOverYear1.Visible = false;
                }

            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region By Timeframe
        private void InitializeSerieByTimeFrame(DateTime date, string tag)
        {
            try
            {
                this.chartTurnOverByTimeFrame.Series["Series 1"].LegendText = "Omzet " + tag.ToString();
                TurnOverObjectCollection turnOvers = new BL.External.TAS.TurnOver.TurnOver().GetByCustomerGreaterThanDate(date, _customer);
                this.turnOverObjectCollectionBindingSourceByTimeFrame.DataSource = turnOvers;
                _startDateByTimeFrame = turnOvers[0].YearMonth;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void AddTrendByTimeFrame(decimal turnover, DateTime startDate, string tag)
        {
            try
            {
                DateTime date;
                if (_startDateByTimeFrame.ToShortDateString() == System.DateTime.Now.ToShortDateString())
                    date = startDate;
                else
                    date = _startDateByTimeFrame;
                this.chartTurnOverByTimeFrame.Series["Trend 1"].Visible = true;
                this.chartTurnOverByTimeFrame.Series["Trend 1"].LegendText = "Gem. " + tag;
                this.chartTurnOverByTimeFrame.Series["Trend 1"].Points.RemoveRange(0, chartTurnOverByTimeFrame.Series["Trend 1"].Points.Count);
                this.chartTurnOverByTimeFrame.Series["Trend 1"].Points.Add(new SeriesPoint(date, new object[] { turnover }));
                this.chartTurnOverByTimeFrame.Series["Trend 1"].Points.Add(new SeriesPoint(System.DateTime.Now, new object[] { turnover }));
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #endregion

        #region Events
        #region By Year
        private void btnYear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DevExpress.XtraEditors.SimpleButton button = (SimpleButton)sender;
                if (button.LookAndFeel.SkinName == "Office 2010 Blue")
                    button.LookAndFeel.SkinName = "Black";
                else
                    button.LookAndFeel.SkinName = "Office 2010 Blue";

                if (button.LookAndFeel.SkinName == "Black")
                    AddSerie(Convert.ToInt16(button.Tag), Convert.ToInt16(button.Text));
                else
                    RemoveSerie(Convert.ToInt16(button.Tag));
                this.Cursor = Cursors.Default;

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTrend_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DevExpress.XtraEditors.SimpleButton button = (SimpleButton)sender;
                if (button.LookAndFeel.SkinName == "Office 2010 Blue")
                    button.LookAndFeel.SkinName = "Black";
                else
                    button.LookAndFeel.SkinName = "Office 2010 Blue";

                if (button.LookAndFeel.SkinName == "Black")
                    AddTrend(Convert.ToInt16(button.Tag), Convert.ToInt16(button.Text));
                else
                    RemoveTrend(Convert.ToInt16(button.Tag));
                this.Cursor = Cursors.Default;

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void chartControl1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                // Obtain hit information under the test point.
                ChartHitInfo hi = chartTurnOver.CalcHitInfo(e.X, e.Y);


                // Obtain the series point under the test point.
                SeriesPoint point = hi.SeriesPoint;

                // Check whether the series point was clicked or not.
                if (point != null)
                {
                    // Obtain the series point argument.
                    string argument = "Maand: " + point.Argument.ToString();

                    // Obtain series point values.

                    string values = "Omzet: " + Math.Round(point.Values[0], 0).ToString() + " €";
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
        private void cbxLabel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckEdit chkBox = (CheckEdit)sender;
                switch (Convert.ToInt16(chkBox.Tag))
                {
                    case 1:
                        this.chartTurnOver.Series["Series 1"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 1"].Label.Visible = chkBox.Checked;
                        break;
                    case 2:
                        this.chartTurnOver.Series["Series 2"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 2"].Label.Visible = chkBox.Checked;
                        break;
                    case 3:
                        this.chartTurnOver.Series["Series 3"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 3"].Label.Visible = chkBox.Checked;
                        break;
                    case 4:
                        this.chartTurnOver.Series["Series 4"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 4"].Label.Visible = chkBox.Checked;
                        break;
                    case 5:
                        this.chartTurnOver.Series["Series 5"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 5"].Label.Visible = chkBox.Checked;
                        break;
                    case 6:
                        this.chartTurnOver.Series["Series 6"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 6"].Label.Visible = chkBox.Checked;
                        break;
                    case 7:
                        this.chartTurnOver.Series["Series 7"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 7"].Label.Visible = chkBox.Checked;
                        break;
                    case 8:
                        this.chartTurnOver.Series["Series 8"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 8"].Label.Visible = chkBox.Checked;
                        break;
                    case 9:
                        this.chartTurnOver.Series["Series 9"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 9"].Label.Visible = chkBox.Checked;
                        break;
                    case 10:
                        this.chartTurnOver.Series["Series 10"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 10"].Label.Visible = chkBox.Checked;
                        break;
                    case 11:
                        this.chartTurnOver.Series["Series 11"].Label.Visible = chkBox.Checked;
                        this.chartTurnOver.Series["Trend 11"].Label.Visible = chkBox.Checked;
                        break;
                }
                this.chartTurnOver.Refresh();
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
                    this.chartTurnOver.ExportToPdf(dialogSave.FileName);
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
                    this.chartTurnOver.ExportToImage(dialogSave.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region By TimeFrame
        private void chartTurnOverByTimeFrame_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                // Obtain hit information under the test point.
                ChartHitInfo hi = this.chartTurnOverByTimeFrame.CalcHitInfo(e.X, e.Y);


                // Obtain the series point under the test point.
                SeriesPoint point = hi.SeriesPoint;

                // Check whether the series point was clicked or not.
                if (point != null)
                {
                    // Obtain the series point argument.
                    string argument = "Maand: " + point.Argument.ToString();

                    // Obtain series point values.

                    string values = "Omzet: " + Math.Round(point.Values[0], 0).ToString() + " €";
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
        private void cbxTurnOverByTimeFrameLabel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckEdit chkBox = (CheckEdit)sender;
                this.chartTurnOverByTimeFrame.Series[0].Label.Visible = chkBox.Checked;
                this.chartTurnOverByTimeFrame.Series[0].Label.Visible = chkBox.Checked;
                this.chartTurnOverByTimeFrame.Refresh();
            }
            catch (System.Exception exception1)
            {
                Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }

        private void btn10J_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(10 * 365));
                InitializeSerieByTimeFrame(date, "10J");
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
                InitializeSerieByTimeFrame(date, "5J");
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
                InitializeSerieByTimeFrame(date, "3J");
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
                InitializeSerieByTimeFrame(date, "1J");
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
                InitializeSerieByTimeFrame(date, "6M");
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void btn3M_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 30));
                InitializeSerieByTimeFrame(date, "3M");
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }

        private void btnTrend10J_Click(object sender, EventArgs e)
        {
            try
            {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(10 * 365));
                    AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByCustomer(date, _customer), date, "10J");
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTrend5J_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(5 * 365));
            AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByCustomer(date, _customer), date, "5J");

        }
        private void btnTrend3J_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 365));
            AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByCustomer(date, _customer), date, "3J");

        }
        private void btnTrend1J_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(1 * 365));
            AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByCustomer(date, _customer), date, "1J");

        }
        private void btnTrend6M_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(6 * 30));
            AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByCustomer(date, _customer), date, "6M");

        }
        private void btnTrend3M_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 30));
            AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByCustomer(date, _customer), date, "3M");

        }
        #endregion

        

        #endregion

       
       


    }
}

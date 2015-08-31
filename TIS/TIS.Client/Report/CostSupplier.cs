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
using DevExpress.Xpo;

namespace TIS.Client.Report
{
    public partial class CostSupplier : DevExpress.XtraEditors.XtraForm
    {

        #region Fields
        private TIS.Framework.Common.Enumeration.Reports.TurnOver _report;
        private Model.Internal.Supplier _supplier;
        private DateTime _startDateByTimeFrame;
        private TIS.Model.BL.CostBL _costBL;
        private UnitOfWork _uow;
        #endregion

        #region Constructor
        public CostSupplier(Model.Internal.Supplier supplier, UnitOfWork uow)
        {
            try
            {

                InitializeComponent();
                _supplier = supplier;
                _uow = uow;
                _costBL = new Model.BL.CostBL(_uow);
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
                var costs = _costBL.Get(year, _supplier);
                this.chartTurnOver.Series["Series " + tag.ToString()].Visible = true;
                this.chartTurnOver.Series["Series " + tag.ToString()].LegendText = year.ToString();
                if (costs.Count() != 0)
                {
                    this.chartTurnOver.Series["Series " + tag.ToString()].DataSource = _costBL.Get(year, _supplier);
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
                this.chartTurnOver.Series["Series " + tag.ToString()].Visible = false;
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
                Decimal cost = new Decimal();

                this.chartTurnOver.Series["Trend " + tag.ToString()].Visible = true;
                this.chartTurnOver.Series["Trend " + tag.ToString()].LegendText = "Gem. " + year.ToString();
                cost = _costBL.GetAverageTurnOverMonthByYearBySupplier(year, _supplier);

                cost = Math.Round(cost, 0);
                this.chartTurnOver.Series["Trend " + tag.ToString()].Points.Add(new SeriesPoint(1, new object[] { cost }));
                this.chartTurnOver.Series["Trend " + tag.ToString()].Points.Add(new SeriesPoint(12, new object[] { cost }));

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
                this.chartTurnOver.Series["Trend " + tag.ToString()].Visible = false;
                this.chartTurnOver.Series["Trend " + tag.ToString()].Points.Clear();
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
                btnTrend11.Text = Convert.ToString(year);
                btnTrend10.Text = Convert.ToString(year - 1);
                btnTrend9.Text = Convert.ToString(year - 2);
                btnTrend8.Text = Convert.ToString(year - 3);
                btnTrend7.Text = Convert.ToString(year - 4);
                btnTrend6.Text = Convert.ToString(year - 5);
                btnTrend5.Text = Convert.ToString(year - 6);
                btnTrend4.Text = Convert.ToString(year - 7);
                btnTrend3.Text = Convert.ToString(year - 8);
                btnTrend2.Text = Convert.ToString(year - 9);
                btnTrend1.Text = Convert.ToString(year - 10);
                

                if (_supplier != null)
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

                    txtTurnOverByTimeFrameYear11.Text = _costBL.GetCost(year, _supplier).ToString();
                    txtTurnOverByTimeFrameYear10.Text = _costBL.GetCost(year - 1, _supplier).ToString();
                    txtTurnOverByTimeFrameYear9.Text = _costBL.GetCost(year - 2, _supplier).ToString();
                    txtTurnOverByTimeFrameYear8.Text = _costBL.GetCost(year - 3, _supplier).ToString();
                    txtTurnOverByTimeFrameYear7.Text = _costBL.GetCost(year - 4, _supplier).ToString();
                    txtTurnOverByTimeFrameYear6.Text = _costBL.GetCost(year - 5, _supplier).ToString();
                    txtTurnOverByTimeFrameYear5.Text = _costBL.GetCost(year - 6, _supplier).ToString();
                    txtTurnOverByTimeFrameYear4.Text = _costBL.GetCost(year - 7, _supplier).ToString();
                    txtTurnOverByTimeFrameYear3.Text = _costBL.GetCost(year - 8, _supplier).ToString();
                    txtTurnOverByTimeFrameYear2.Text = _costBL.GetCost(year - 9, _supplier).ToString();
                    txtTurnOverByTimeFrameYear1.Text = _costBL.GetCost(year - 10, _supplier).ToString();

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
                var costs = _costBL.GetBySupplierGreaterThanDate(date, _supplier);
                if (costs.Count() != 0)
                    this.chartTurnOverByTimeFrame.Series["Series 1"].DataSource = costs;
                //_startDateByTimeFrame = costs.First();
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
                if (_startDateByTimeFrame == DateTime.MinValue)
                    date = startDate;
                else if (_startDateByTimeFrame.ToShortDateString() == System.DateTime.Now.ToShortDateString())
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
                this.chartTurnOver.Series["Series " + chkBox.Tag.ToString()].Label.Visible = chkBox.Checked;
                this.chartTurnOver.Series["Trend " + chkBox.Tag.ToString()].Label.Visible = chkBox.Checked;
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
                    AddTrendByTimeFrame(_costBL.GetAverageTurnOverMonthGreaterThanDateBySupplier(date, _supplier), date, "10J");
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
            AddTrendByTimeFrame(_costBL.GetAverageTurnOverMonthGreaterThanDateBySupplier(date, _supplier), date, "5J");

        }
        private void btnTrend3J_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 365));
            AddTrendByTimeFrame(_costBL.GetAverageTurnOverMonthGreaterThanDateBySupplier(date, _supplier), date, "3J");

        }
        private void btnTrend1J_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(1 * 365));
            AddTrendByTimeFrame(_costBL.GetAverageTurnOverMonthGreaterThanDateBySupplier(date, _supplier), date, "1J");

        }
        private void btnTrend6M_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(6 * 30));
            AddTrendByTimeFrame(_costBL.GetAverageTurnOverMonthGreaterThanDateBySupplier(date, _supplier), date, "6M");

        }
        private void btnTrend3M_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 30));
            AddTrendByTimeFrame(_costBL.GetAverageTurnOverMonthGreaterThanDateBySupplier(date, _supplier), date, "3M");
        }
        #endregion

        

        #endregion



    }
}

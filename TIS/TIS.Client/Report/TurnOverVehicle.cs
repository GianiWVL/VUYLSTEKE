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
    public partial class TurnOverVehicle : DevExpress.XtraEditors.XtraForm
    {

        #region Fields
        private DateTime _startDateByTimeFrame;
        #endregion

        #region Constructor
        public TurnOverVehicle()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                InitializeComponent();
                FillControls();
                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Properties
        #endregion

        #region Private Methods
        private void FillControls()
        {
            try
            {
                int year = System.DateTime.Now.Year;
                _startDateByTimeFrame = System.DateTime.Now;
                louVehicleByYear.Properties.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetVehicles();
                louVehicleByTimeFrame.Properties.DataSource = louVehicleByYear.Properties.DataSource;
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
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #region By Year
        private void AddSerie(int tag, int year)
        {
            try
            {
                this.chartTurnOverByYear.Series["Series " + tag.ToString()].Visible = true;
                this.chartTurnOverByYear.Series["Series " + tag.ToString()].LegendText = year.ToString();

                switch (tag)
                {
                    case 1:
                        turnOverObjectCollectionBindingSource1.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 2:
                        turnOverObjectCollectionBindingSource2.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 3:
                        turnOverObjectCollectionBindingSource3.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 4:
                        turnOverObjectCollectionBindingSource4.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 5:
                        turnOverObjectCollectionBindingSource5.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 6:
                        turnOverObjectCollectionBindingSource6.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 7:
                        turnOverObjectCollectionBindingSource7.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 8:
                        turnOverObjectCollectionBindingSource8.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 9:
                        turnOverObjectCollectionBindingSource9.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 10:
                        turnOverObjectCollectionBindingSource10.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
                        break;
                    case 11:
                        turnOverObjectCollectionBindingSource11.DataSource = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleByYear(year, louVehicleByYear.Text);
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

                        this.chartTurnOverByYear.Series["Series 1"].Visible = false;
                        turnOverObjectCollectionBindingSource1.Clear();
                        break;
                    case 2:
                        this.chartTurnOverByYear.Series["Series 2"].Visible = false;
                        turnOverObjectCollectionBindingSource2.Clear();
                        break;
                    case 3:
                        this.chartTurnOverByYear.Series["Series 3"].Visible = false;
                        turnOverObjectCollectionBindingSource3.Clear();
                        break;
                    case 4:
                        this.chartTurnOverByYear.Series["Series 4"].Visible = false;
                        turnOverObjectCollectionBindingSource4.Clear();
                        break;
                    case 5:
                        this.chartTurnOverByYear.Series["Series 5"].Visible = false;
                        turnOverObjectCollectionBindingSource5.Clear();
                        break;
                    case 6:
                        this.chartTurnOverByYear.Series["Series 6"].Visible = false;
                        turnOverObjectCollectionBindingSource6.Clear();
                        break;
                    case 7:
                        this.chartTurnOverByYear.Series["Series 7"].Visible = false;
                        turnOverObjectCollectionBindingSource7.Clear();
                        break;
                    case 8:
                        this.chartTurnOverByYear.Series["Series 8"].Visible = false;
                        turnOverObjectCollectionBindingSource8.Clear();
                        break;
                    case 9:
                        this.chartTurnOverByYear.Series["Series 9"].Visible = false;
                        turnOverObjectCollectionBindingSource9.Clear();
                        break;
                    case 10:
                        this.chartTurnOverByYear.Series["Series 10"].Visible = false;
                        turnOverObjectCollectionBindingSource10.Clear();
                        break;
                    case 11:
                        this.chartTurnOverByYear.Series["Series 11"].Visible = false;
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

                this.chartTurnOverByYear.Series["Trend " + tag.ToString()].Visible = true;
                this.chartTurnOverByYear.Series["Trend " + tag.ToString()].LegendText = "Gem. " + year.ToString();
                turnOver = new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthByYearByVehicle(year, louVehicleByYear.Text);
                turnOver = Math.Round(turnOver, 0);
                this.chartTurnOverByYear.Series["Trend " + tag.ToString()].Points.RemoveRange(0, chartTurnOverByYear.Series["Trend " + tag.ToString()].Points.Count);
                this.chartTurnOverByYear.Series["Trend " + tag.ToString()].Points.Add(new SeriesPoint(1, new object[] { turnOver }));
                this.chartTurnOverByYear.Series["Trend " + tag.ToString()].Points.Add(new SeriesPoint(12, new object[] { turnOver }));
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
                        this.chartTurnOverByYear.Series["Trend 1"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 1"].Points.Clear();
                        break;
                    case 2:
                        this.chartTurnOverByYear.Series["Trend 2"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 2"].Points.Clear();
                        break;
                    case 3:
                        this.chartTurnOverByYear.Series["Trend 3"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 3"].Points.Clear();
                        break;
                    case 4:
                        this.chartTurnOverByYear.Series["Trend 4"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 4"].Points.Clear();
                        break;
                    case 5:
                        this.chartTurnOverByYear.Series["Trend 5"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 5"].Points.Clear();
                        break;
                    case 6:
                        this.chartTurnOverByYear.Series["Trend 6"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 6"].Points.Clear();
                        break;
                    case 7:
                        this.chartTurnOverByYear.Series["Trend 7"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 7"].Points.Clear();
                        break;
                    case 8:
                        this.chartTurnOverByYear.Series["Trend 8"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 8"].Points.Clear();
                        break;
                    case 9:
                        this.chartTurnOverByYear.Series["Trend 9"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 9"].Points.Clear();
                        break;
                    case 10:
                        this.chartTurnOverByYear.Series["Trend 10"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 10"].Points.Clear();
                        break;
                    case 11:
                        this.chartTurnOverByYear.Series["Trend 11"].Visible = false;
                        this.chartTurnOverByYear.Series["Trend 11"].Points.Clear();
                        break;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
       
        #endregion

        #region By TimeFrame
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
                if (louVehicleByYear.Text != "")
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
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                if (louVehicleByYear.Text != "")
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
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                ChartHitInfo hi = chartTurnOverByYear.CalcHitInfo(e.X, e.Y);


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
                        this.chartTurnOverByYear.Series["Series 1"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 1"].Label.Visible = chkBox.Checked;
                        break;
                    case 2:
                        this.chartTurnOverByYear.Series["Series 2"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 2"].Label.Visible = chkBox.Checked;
                        break;
                    case 3:
                        this.chartTurnOverByYear.Series["Series 3"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 3"].Label.Visible = chkBox.Checked;
                        break;
                    case 4:
                        this.chartTurnOverByYear.Series["Series 4"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 4"].Label.Visible = chkBox.Checked;
                        break;
                    case 5:
                        this.chartTurnOverByYear.Series["Series 5"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 5"].Label.Visible = chkBox.Checked;
                        break;
                    case 6:
                        this.chartTurnOverByYear.Series["Series 6"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 6"].Label.Visible = chkBox.Checked;
                        break;
                    case 7:
                        this.chartTurnOverByYear.Series["Series 7"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 7"].Label.Visible = chkBox.Checked;
                        break;
                    case 8:
                        this.chartTurnOverByYear.Series["Series 8"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 8"].Label.Visible = chkBox.Checked;
                        break;
                    case 9:
                        this.chartTurnOverByYear.Series["Series 9"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 9"].Label.Visible = chkBox.Checked;
                        break;
                    case 10:
                        this.chartTurnOverByYear.Series["Series 10"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 10"].Label.Visible = chkBox.Checked;
                        break;
                    case 11:
                        this.chartTurnOverByYear.Series["Series 11"].Label.Visible = chkBox.Checked;
                        this.chartTurnOverByYear.Series["Trend 11"].Label.Visible = chkBox.Checked;
                        break;
                }
                this.chartTurnOverByYear.Refresh();
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
                    this.chartTurnOverByYear.ExportToPdf(dialogSave.FileName);
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
                    this.chartTurnOverByYear.ExportToImage(dialogSave.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
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
        private void chartVehicleByTimeFrame_MouseMove(object sender, MouseEventArgs e)
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

        private void btn10J_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(10 * 365));
                    TurnOverObjectCollection turnOvers = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleGreaterThanDate(date, louVehicleByTimeFrame.Text);
                    this.turnOverObjectCollectionByTimeFrameBindingSource1.DataSource = turnOvers;
                    _startDateByTimeFrame = turnOvers[0].YearMonth;
                    this.chartTurnOverByTimeFrame.Series["Series 1"].LegendText = "Omzet 10J";

                   
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btn5J_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(5 * 365));
                    TurnOverObjectCollection turnOvers = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleGreaterThanDate(date, louVehicleByTimeFrame.Text);
                    this.turnOverObjectCollectionByTimeFrameBindingSource1.DataSource = turnOvers;
                    _startDateByTimeFrame = turnOvers[0].YearMonth; 
                    this.chartTurnOverByTimeFrame.Series["Series 1"].LegendText = "Omzet 5J";
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btn1J_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(1 * 365));
                    TurnOverObjectCollection turnOvers = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleGreaterThanDate(date, louVehicleByTimeFrame.Text);
                    this.turnOverObjectCollectionByTimeFrameBindingSource1.DataSource = turnOvers;
                    _startDateByTimeFrame = turnOvers[0].YearMonth; 
                    this.chartTurnOverByTimeFrame.Series["Series 1"].LegendText = "Omzet 1J";
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btn3J_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 365));
                    TurnOverObjectCollection turnOvers = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleGreaterThanDate(date, louVehicleByTimeFrame.Text);
                    this.turnOverObjectCollectionByTimeFrameBindingSource1.DataSource = turnOvers;
                    _startDateByTimeFrame = turnOvers[0].YearMonth; 
                    this.chartTurnOverByTimeFrame.Series["Series 1"].LegendText = "Omzet 3J";
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btn6M_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(6 * 30.5));
                    TurnOverObjectCollection turnOvers = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleGreaterThanDate(date, louVehicleByTimeFrame.Text);
                    this.turnOverObjectCollectionByTimeFrameBindingSource1.DataSource = turnOvers;
                    _startDateByTimeFrame = turnOvers[0].YearMonth; 
                    this.chartTurnOverByTimeFrame.Series["Series 1"].LegendText = "Omzet 6M";
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btn3M_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 30.5));
                    TurnOverObjectCollection turnOvers = new BL.External.TAS.TurnOver.TurnOver().GetByVehicleGreaterThanDate(date, louVehicleByTimeFrame.Text);
                    this.turnOverObjectCollectionByTimeFrameBindingSource1.DataSource = turnOvers;
                    _startDateByTimeFrame = turnOvers[0].YearMonth; 
                    this.chartTurnOverByTimeFrame.Series["Series 1"].LegendText = "Omzet 3M";
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }

        private void btnTrend10J_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(10 * 365));
                    AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByVehicle(date, louVehicleByTimeFrame.Text), date, "10J");
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(5 * 365));
                    AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByVehicle(date, louVehicleByTimeFrame.Text), date, "5J");
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTrend3J_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 365));
                    AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByVehicle(date, louVehicleByTimeFrame.Text), date, "3J");
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTrend1J_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(1 * 365));
                    AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByVehicle(date, louVehicleByTimeFrame.Text), date, "1J");
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTrend6M_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(6 * 30.5));
                    AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByVehicle(date, louVehicleByTimeFrame.Text), date, "6M");
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTrend3M_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.louVehicleByTimeFrame.Text != "")
                {
                    DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(3 * 30.5));
                    AddTrendByTimeFrame(new BL.External.TAS.TurnOver.TurnOver().GetAverageTurnOverMonthGreaterThanDateByVehicle(date, louVehicleByTimeFrame.Text), date, "3M");
                }
                else
                    XtraMessageBox.Show("Selecteer eerst een voertuig!", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #endregion

        

    }
}

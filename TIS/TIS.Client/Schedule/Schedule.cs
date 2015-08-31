using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROF_IT.Exceptionhandling;
using TIS.DL.Internal.Schedule;
using System.Reflection;
using TIS.Framework.Common;
using TIS.DL.Internal.TaskSchedule;

namespace TIS.Client.Schedule
{
    public partial class Schedule : DevExpress.XtraEditors.XtraForm
    {
        #region Fields
        private PROF_IT.Common.Enumerations.TypeForm _typeForm;
        private TIS.DL.Internal.Schedule.ScheduleObject _schedule;
        private TIS.DL.Internal.Schedule.ScheduleObject _scheduleOriginal;
        #endregion

        #region Constructor
        public Schedule(PROF_IT.Common.Enumerations.TypeForm typeForm)
        {
            try
            {
                InitializeComponent();
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    Initialize();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public Schedule(PROF_IT.Common.Enumerations.TypeForm typeForm, TaskScheduleObject taskSchedule)
        {
            try
            {
                InitializeComponent();
                _scheduleOriginal = taskSchedule.Schedule.Clone();
                _schedule = taskSchedule.Schedule;
                _typeForm = typeForm;
                if (_typeForm == PROF_IT.Common.Enumerations.TypeForm.NewForm)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    InitializePropertyForm();
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Properties
        public ScheduleObject ScheduleMember
        {
            get { return _schedule; }
            set { _schedule = value; }
        }
        #endregion

        #region Events
        private void cmbFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Daily)
                {
                    cbxMonday.Checked = true;
                    cbxMonday.Visible = false;
                    cbxTuesday.Checked = true;
                    cbxTuesday.Visible = false;
                    cbxWednesday.Checked = true;
                    cbxWednesday.Visible = false;
                    cbxThursday.Checked = true;
                    cbxThursday.Visible = false;
                    cbxFriday.Checked = true;
                    cbxFriday.Visible = false;
                    cbxSaterday.Checked = true;
                    cbxSaterday.Visible = false;
                    cbxSunday.Checked = true;
                    cbxSunday.Visible = false;
                }
                else
                {
                    cbxMonday.Checked = false;
                    cbxMonday.Visible = true;
                    cbxTuesday.Checked = false;
                    cbxTuesday.Visible = true;
                    cbxWednesday.Checked = false;
                    cbxWednesday.Visible = true;
                    cbxThursday.Checked = false;
                    cbxThursday.Visible = true;
                    cbxFriday.Checked = false;
                    cbxFriday.Visible = true;
                    cbxSaterday.Checked = false;
                    cbxSaterday.Visible = true;
                    cbxSunday.Checked = false;
                    cbxSunday.Visible = true;
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ScheduleMember = _scheduleOriginal;
                this.Close();
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null & txtTimeOfDay.EditValue != null & datStartdate.EditValue != null)
                {
                    if (((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly) &
                                !CheckOnlyOneDaySelect())
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = System.Windows.Forms.DialogResult.None;
                    }
                    else
                    {
                        if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Daily)
                        {
                            cbxMonday.Checked = true;
                            cbxTuesday.Checked = true;
                            cbxWednesday.Checked = true;
                            cbxThursday.Checked = true;
                            cbxFriday.Checked = true;
                            cbxSaterday.Checked = true;
                            cbxSunday.Checked = true;
                        }
                        ScheduleMember.Monday = cbxMonday.Checked;
                        ScheduleMember.Tuesday = cbxTuesday.Checked;
                        ScheduleMember.Wednesday = cbxWednesday.Checked;
                        ScheduleMember.Thursday = cbxThursday.Checked;
                        ScheduleMember.Friday = cbxFriday.Checked;
                        ScheduleMember.Saterday = cbxSaterday.Checked;
                        ScheduleMember.Sunday = cbxSunday.Checked;
                        ScheduleMember.Frequency = (Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue;
                        if (txtTimeOfDay.Text.Length == 7)
                            ScheduleMember.Time = "0" + txtTimeOfDay.Text.Replace(":", "");
                        else
                            ScheduleMember.Time = txtTimeOfDay.Text.Replace(":", "");
                        ScheduleMember.StartDate = PROF_IT.Common.Convert.DateFunctions.DateToStrDate(datStartdate.DateTime);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                        DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "The fields frequency, time of day and startdate can not be empty!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = System.Windows.Forms.DialogResult.None;
                }

                
                    
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void cbxMonday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null)
                {
                    if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly)
                    {
                        if (!CheckOnlyOneDaySelect())
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cbxMonday.Checked = false;
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void cbxTuesday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null)
                {
                    if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly)
                    {
                        if (!CheckOnlyOneDaySelect())
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cbxTuesday.Checked = false;
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void cbxWednesday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null)
                {
                    if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly)
                    {
                        if (!CheckOnlyOneDaySelect())
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cbxWednesday.Checked = false;
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void cbxThursday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null)
                {
                    if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly)
                    {
                        if (!CheckOnlyOneDaySelect())
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cbxThursday.Checked = false;
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void cbxFriday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null)
                {
                    if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly)
                    {
                        if (!CheckOnlyOneDaySelect())
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cbxFriday.Checked = false;
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void cbxSaterday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null)
                {
                    if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly)
                    {
                        if (!CheckOnlyOneDaySelect())
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cbxSaterday.Checked = false;
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void cbxSunday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFrequency.EditValue != null)
                {
                    if ((TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.Monthly |
                            (TIS.Framework.Common.Enumeration.Frequency.TimeFrequency)cmbFrequency.EditValue == TIS.Framework.Common.Enumeration.Frequency.TimeFrequency.TwoWeekly)
                    {
                        if (!CheckOnlyOneDaySelect())
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(this.LookAndFeel, "You can only select one day with this Frequency!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cbxSunday.Checked = false;
                        }
                    }
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
        private void Initialize()
        {
            try
            {
                _schedule = new ScheduleObject();
                datStartdate.DateTime = System.DateTime.Now;
                cmbFrequency.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Frequency.TimeFrequency)));
                Random random = new Random();
                txtTimeOfDay.Text = random.Next(0, 23).ToString() + ":" + FormatTimeFrame(random.Next(0, 59).ToString()) + ":" + FormatTimeFrame(random.Next(0, 59).ToString());
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        public void InitializePropertyForm()
        {
            try
            {
                cmbFrequency.Properties.Items.AddRange(Enum.GetValues(typeof(Enumeration.Frequency.TimeFrequency)));
                cmbFrequency.SelectedIndex = (int)_schedule.Frequency;
                cbxMonday.Checked = _schedule.Monday;
                cbxTuesday.Checked = _schedule.Tuesday;
                cbxWednesday.Checked = _schedule.Wednesday;
                cbxThursday.Checked = _schedule.Thursday;
                cbxFriday.Checked = _schedule.Friday;
                cbxSaterday.Checked = _schedule.Saterday;
                cbxSunday.Checked = _schedule.Sunday;
                datStartdate.Text = PROF_IT.Common.Convert.DateFunctions.DBDateToStrDate(_schedule.StartDate);
                txtTimeOfDay.Text = _schedule.TimeDisplay;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private Boolean CheckOnlyOneDaySelect()
        {
            try
            {
                Int16 count = 0;
                if (cbxMonday.Checked)
                    count += 1;
                if (cbxTuesday.Checked)
                    count += 1;
                if (cbxWednesday.Checked)
                    count += 1;
                if (cbxThursday.Checked)
                    count += 1;
                if (cbxFriday.Checked)
                    count += 1;
                if (cbxSaterday.Checked)
                    count += 1;
                if (cbxSunday.Checked)
                    count += 1;

                if (count > 1)
                    return false;
                else
                    return true;
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private string FormatTimeFrame(string timeFrame)
        {
            try
            {
                if (timeFrame.Length == 1)
                {
                    return "0" + timeFrame;
                }
                else
                    return timeFrame;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PROF_IT.Exceptionhandling;
using TIS.Framework;
using System.Reflection;
using TIS.Framework.Security;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using PROF_IT.Common;
using TIS.Framework.Common;
using TIS.DL.Internal.User;
using TIS.DL.External.TAS.TurnOver;
using TIS.DL.Internal.Customer;
using System.Collections;
using System.Xml;
using System.Threading;

namespace TIS.Client.General
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Private Fields
        BaseChildForm mainMDI;
        private Thread _popupThread;
        private string _description;
        #endregion

        #region Constructor
        public Main()
        {
            try
            {
                InitializeComponent();
                SetPermissions();
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Events

        #region RibbonPageMain
        private void bbiLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                Program.CLOSE = false;
                Program.LOGIN = true;
                Context.User = null;
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
            finally
            {
                if (this != null)
                    this.Dispose();
            }
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                Application.Exit();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Task);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Customer);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Supplier);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiCosting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Costing);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Employee);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiVehicle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Vehicle);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiPump_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Fuel);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiMaterial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Material);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiBoardComputer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.BoardComputer);
            }
            catch (Exception ex)
            {
                Management.ShowException(ex);
            }
        }

        private void bbiPlanning_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Planning);
            }
            catch (Exception ex)
            {
                Management.ShowException(ex);
            }
        }

        private void bbiTAS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!OpenApplication(@"C:\TOP\TRB\Source\TRB.exe", @"-xroot=C:\TOP"))
                {
                    MessageBox.Show("Applicatie is niet geïnstalleerd op de PC", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception excepion1)
            {
                 System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiTLNPlanner_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!OpenApplication(@"C:\Program Files (x86)\PTV-AG\tln2011\mg.exe", @""))
                {
                    MessageBox.Show("Applicatie is niet geïnstalleerd op de PC", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception excepion1)
            {
                 System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiTOPAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!OpenApplication(@"C:\TOP\TAC\Source\topaccount.exe", @"-xroot=C:\TOP"))
                {
                    MessageBox.Show("Applicatie is niet geïnstalleerd op de PC", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception excepion1)
            {
                 System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiTimoCom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!OpenApplication(@"C:\tccargo\tccargo.exe", @""))
                {
                    MessageBox.Show("Applicatie is niet geïnstalleerd op de PC", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception excepion1)
            {
                 System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiAct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!OpenApplication(@"C:\Program Files (x86)\ACT\Act for Windows\ActSage.exe", @""))
                {
                    MessageBox.Show("Applicatie is niet geïnstalleerd op de PC", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception excepion1)
            {
                 System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiOutlook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (OpenApplication(@"C:\Program Files (x86)\Microsoft Office\Office12\Outlook.exe", @"")) {}
                else if (OpenApplication(@"C:\Program Files (x86)\Microsoft Office\Office14\Outlook.exe",@"")) {}
                else { MessageBox.Show("Applicatie is niet geïnstalleerd op de PC", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiTollCollect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"http://www.toll-collect.de/en/home.html");
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiProcedure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"\\192.168.2.20\data\Procedures");
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }

        

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bent u zeker dat je de applicatie wilt afsluiten?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            == System.Windows.Forms.DialogResult.No)
                {
                        e.Cancel = true;
                }
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }

        
        #endregion

        #region RibbonPageManagement
        private void bbiUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Users users = new Users();
                users.Show();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            User user = null;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                user = new User(PROF_IT.Common.Enumerations.TypeForm.NewForm);
                if (user.ShowDialog() == DialogResult.OK)
                {
                }
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
            finally
            {
                if (user != null)
                {
                    user.Dispose();
                }
                user = null;
                this.Cursor = Cursors.Default;
            }
        }
        private void bbiSettingsSystem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParameterSystem.Settings parameterSystem = null;
            try
            {
                parameterSystem = new ParameterSystem.Settings();
                parameterSystem.Show();
            }
            catch (System.Exception exception)
            {
                Exception thisException = exception;
                Management.ShowException(thisException);
            }
        }
        private void bbiMaterialCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.MaterialCategory);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void bbiPopup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Popup);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion

        #region Popup
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                _popupThread = new Thread(new ThreadStart(this.PopupThread));
                _popupThread.IsBackground = true;
                _popupThread.Start();
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void alertControl_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            try
            {
                //TODO uitwerken indien nodig.
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        private void alertControl_FormClosing(object sender, DevExpress.XtraBars.Alerter.AlertFormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason != DevExpress.XtraBars.Alerter.AlertFormCloseReason.UserClosing)
                    e.Cancel = true;
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }
        #endregion
        #endregion

        #region Methods
        private void LoadGrid(Enumeration.EnumViews.Main mainView)
        {
            this.SuspendLayout();
            bool noGrid = false;
            try
            {
                if (mainMDI != null)
                {
                    this.Controls.Remove(mainMDI);
                    mainMDI = null;
                }
                switch ((Enumeration.EnumViews.Main)mainView)
                {
                    case Enumeration.EnumViews.Main.Task:
                        mainMDI = new Task.Tasks();
                        break;
                    case Enumeration.EnumViews.Main.Customer:
                        mainMDI = new Customer.Customers();
                        break;
                    case Enumeration.EnumViews.Main.Supplier:
                        mainMDI = new Supplier.Suppliers();
                        break;
                    case Enumeration.EnumViews.Main.Costing:
                        mainMDI = new Costing.Costing();
                        break;
                    case Enumeration.EnumViews.Main.Employee:
                        mainMDI = new Employee.Employees();
                        break;
                    case Enumeration.EnumViews.Main.Vehicle:
                        mainMDI = new Vehicle.Vehicles();
                        break;
                    case Enumeration.EnumViews.Main.Fuel:
                        mainMDI = new Fuel.Fuel();
                        break;
                    case Enumeration.EnumViews.Main.Material:
                        mainMDI = new Material.Materials();
                        break;
                    case Enumeration.EnumViews.Main.MaterialCategory:
                        mainMDI = new Material.MaterialCategories();
                        break;
                    case Enumeration.EnumViews.Main.Popup:
                        mainMDI = new Popup.Popups();
                        break;
                    case Enumeration.EnumViews.Main.Document:
                        mainMDI = new Document.Document();
                        break;
                    case Enumeration.EnumViews.Main.BoardComputer:
                        mainMDI = new Vehicle.BoardComputers();
                        break;
                    case Enumeration.EnumViews.Main.Planning:
                        mainMDI = new Planning.Planning();
                        break;
                    default:
                        noGrid = true;
                        break;
                }
                if (noGrid == false)
                {
                    mainMDI.Tag = (Enumeration.EnumViews.Application)mainView;
                    mainMDI.Location = new System.Drawing.Point(2, 150);
                    mainMDI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
                    mainMDI.Size = new System.Drawing.Size(this.Size.Width - 15, this.Size.Height - 175);
                    this.Controls.Add(mainMDI);
                }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
            finally
            {
                this.ResumeLayout();
            }
        }
        private Boolean OpenApplication(string path, string arguments)
        {
            try
            {
                 if (System.IO.File.Exists(path))
                 {
                     System.Diagnostics.Process.Start(path, arguments);
                     return true;
                 }
                 else
                 {
                     return false;
                 }
            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void SetPermissions()
        {
            try
            {
                //-------------
                //   Ribbon
                //-------------

                if (!Functions.AllowDisplay(Context.User.Security.Application.AuthUser))
                    this.bbiUsers.Enabled = false;
                if (!Functions.AllowMaintain(Context.User.Security.Application.AuthUser))
                    this.bbiAddUser.Enabled = false;
                if (!Functions.AllowDisplay(Context.User.Security.Main.AuthTask))
                    this.bbiTask.Enabled = false;
                if (!Functions.AllowDisplay(Context.User.Security.Main.AuthCustomer))
                    this.bbiCustomer.Enabled = false;
                if (!Functions.AllowDisplay(Context.User.Security.Main.AuthEmployee))
                    this.bbiEmployee.Enabled = false;

                if (!Functions.AllowDisplay(Context.User.Security.Costing.AuthCosting))
                    this.bbiCosting.Enabled = false;
                if (!Functions.AllowDisplay(Context.User.Security.Costing.AuthFuel) &
                    !Functions.AllowDisplay(Context.User.Security.Costing.AuthFuelCorrection) &
                    !Functions.AllowDisplay(Context.User.Security.Costing.AuthFuelDelivery))
                    this.bbiFuel.Enabled = false; 

                if (!Functions.AllowDisplay(Context.User.Security.Vehicle.AuthVehicle))
                    this.bbiVehicle.Enabled = false;

                if (!Functions.AllowDisplay(Context.User.Security.Material.AuthMaterial))
                    this.bbiMaterial.Enabled = false; 

                if (!Functions.AllowMaintain(Context.User.Security.Application.AuthSettings))
                    this.bbiSettingsSystem.Enabled = false;
                
                if (!Functions.AllowDisplay(Context.User.Security.Material.AuthMaterialCategory))
                    this.bbiMaterialCategory.Enabled = false;

                if (!Functions.AllowDisplay(Context.User.Security.Planning.AuthPlanning))
                    this.bbiPlanning.Enabled = false;



            }
            catch (System.Exception exception1)
            {
                System.Exception innerException = exception1;
                throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }

        #region Popup
        private void PopupThread()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(30000);
                    //Execute the query if user!= null and user.HasPopups
                    Popup();
                }
                catch (Exception e)
                { }
            }
        }
        private void Popup()
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new MethodInvoker(Popup));
                }
                else
                {
                    if (Context.User != null && Context.User.HasPopups)
                    {
                        DL.Internal.Popup.PopupObjectCollection popups = new BL.Internal.Popup().GetallActivePopupsByUser(Context.User);
                        TimeSpan time;
                        foreach (DL.Internal.Popup.PopupObject popup in popups)
                        {
                            //Show popup directly?
                            if (popup.ShowDirect == true)
                            {
                                Alert(popup);
                                popup.ShowDirect = false;
                                new BL.Internal.Popup().Save(popup);
                            }

                            time = new TimeSpan(int.Parse(popup.Time.Substring(0, 2)), int.Parse(popup.Time.Substring(2, 2)), int.Parse(popup.Time.Substring(4, 2)));
                            switch (popup.Repeation)
                            {
                                case Enumeration.Frequency.TimeFrequency.Daily:
                                    DateTime compTime = DateTime.Now;
                                    if (time.CompareTo(DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 0, 15))) != time.CompareTo(DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 0, -15))))
                                        Alert(popup);
                                    break;
                                case Enumeration.Frequency.TimeFrequency.Monthly:
                                    if (PROF_IT.Common.Convert.DateFunctions.DBDateToDate(popup.CreationDate, false).Day == DateTime.Now.Day
                                        && time.CompareTo(DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 0, 15))) != time.CompareTo(DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 0, -15))))
                                        Alert(popup);
                                    break;
                                case Enumeration.Frequency.TimeFrequency.Weekly:
                                    if (PROF_IT.Common.Convert.DateFunctions.DBDateToDate(popup.CreationDate, false).DayOfWeek == DateTime.Now.DayOfWeek
                                        && time.CompareTo(DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 0, 15))) != time.CompareTo(DateTime.Now.TimeOfDay.Add(new TimeSpan(0, 0, -15))))
                                        Alert(popup);
                                    break;

                            }
                            
                        }
                    }
                }
            }
            catch (System.Exception exception1)
            {
                //System.Exception innerException = exception1;
                //throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void Alert(DL.Internal.Popup.PopupObject popup)
        {
            try
            {
                alertControl.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
                //TODO: verder info geven
                _description = popup.Description;
                alertControl.Show(this, "Popup", popup.Description);
            }
            catch (System.Exception exception1)
            {
                //System.Exception innerException = exception1;
                //throw new System.Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        private void bbiLink_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadGrid(Enumeration.EnumViews.Main.Document);
            }
            catch (System.Exception excepion1)
            {
                System.Exception thisException = excepion1;
                Management.ShowException(thisException);
            }
        }


        #endregion

    }
}

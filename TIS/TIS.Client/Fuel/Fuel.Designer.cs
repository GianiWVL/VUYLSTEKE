namespace TIS.Client.Fuel
{
    partial class Fuel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fuel));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineAreaSeriesView splineAreaSeriesView1 = new DevExpress.XtraCharts.SplineAreaSeriesView();
            DevExpress.XtraCharts.SplineAreaSeriesView splineAreaSeriesView2 = new DevExpress.XtraCharts.SplineAreaSeriesView();
            this.tabctrlFuel = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageFuel = new DevExpress.XtraTab.XtraTabPage();
            this.txtPLNCurrency = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.btnImportTotal = new DevExpress.XtraEditors.SimpleButton();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.btnExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.bbiRemove = new DevExpress.XtraEditors.SimpleButton();
            this.bbiAddFuel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchFuel = new DevExpress.XtraEditors.SimpleButton();
            this.gdcFuel = new DevExpress.XtraGrid.GridControl();
            this.gdvFuel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoInvoiceOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoInvoiceReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoPrivateTanking = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoVehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFuelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoVehicleKilometreCounter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoQuantityCorrection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoUnityPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxPrivate = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dteDateTo = new DevExpress.XtraEditors.DateEdit();
            this.dteDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbVehicle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEmployee = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbFuel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbSupplier = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tabpageDelivery = new DevExpress.XtraTab.XtraTabPage();
            this.btnExportToExcelFuelDelivery = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveFuelDelivery = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewFuelDelivery = new DevExpress.XtraEditors.SimpleButton();
            this.gdcFuelDelivery = new DevExpress.XtraGrid.GridControl();
            this.gdvFuelDelivery = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoFuelDeliverySupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFuelDeliveryDateDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFuelDeliveryDateInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFuelDeliveryLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcFuelDeliveryQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFuelDeliveryUnityPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearchFuelDelivery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dteDateToDelivery = new DevExpress.XtraEditors.DateEdit();
            this.dteDateFromDelivery = new DevExpress.XtraEditors.DateEdit();
            this.tabpageCorrection = new DevExpress.XtraTab.XtraTabPage();
            this.btnAddFuelCorrection = new DevExpress.XtraEditors.SimpleButton();
            this.bbiRemoveFuelCorrection = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gdcFuelCorrectionCalc = new DevExpress.XtraGrid.GridControl();
            this.gdvFuelCorrectionCalc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoDateFuelCorrectionCalc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoVehicleFuelCorrectionCalc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoQuantityFuelCorrectionCalc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoQuantityCorrectionFuelCorrectionCalc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteDateFromCorrection = new DevExpress.XtraEditors.DateEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.dteDateToCorrection = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.spinQuantityCorrection = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.spinMaxQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.ccbxVehiclesNotIncluded = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.ccbxSuppliersIncluded = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnSaveCorrection = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelCorrection = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnCalculateCorrection = new DevExpress.XtraEditors.SimpleButton();
            this.gdcFuelCorrection = new DevExpress.XtraGrid.GridControl();
            this.gdvFuelCorrection = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoFuelCorDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFuelCorDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFuelCorQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabpageFuelReport = new DevExpress.XtraTab.XtraTabPage();
            this.cbxTurnOverByTimeFrameLabel = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btn3J = new DevExpress.XtraEditors.SimpleButton();
            this.btn3M = new DevExpress.XtraEditors.SimpleButton();
            this.btn6M = new DevExpress.XtraEditors.SimpleButton();
            this.btn1J = new DevExpress.XtraEditors.SimpleButton();
            this.btn10J = new DevExpress.XtraEditors.SimpleButton();
            this.btn5J = new DevExpress.XtraEditors.SimpleButton();
            this.btnImage = new DevExpress.XtraEditors.SimpleButton();
            this.iclLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.btnPDF = new DevExpress.XtraEditors.SimpleButton();
            this.chartFuelDelivery = new DevExpress.XtraCharts.ChartControl();
            this.fuelDeliveryObjectCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipController2 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlFuel)).BeginInit();
            this.tabctrlFuel.SuspendLayout();
            this.tabpageFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLNCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPrivate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).BeginInit();
            this.tabpageDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuelDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuelDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToDelivery.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromDelivery.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromDelivery.Properties)).BeginInit();
            this.tabpageCorrection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuelCorrectionCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuelCorrectionCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromCorrection.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromCorrection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToCorrection.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToCorrection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantityCorrection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbxVehiclesNotIncluded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbxSuppliersIncluded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuelCorrection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuelCorrection)).BeginInit();
            this.tabpageFuelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTurnOverByTimeFrameLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuelDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelDeliveryObjectCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlFuel
            // 
            this.tabctrlFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlFuel.Location = new System.Drawing.Point(3, 4);
            this.tabctrlFuel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tabctrlFuel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabctrlFuel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabctrlFuel.Name = "tabctrlFuel";
            this.tabctrlFuel.SelectedTabPage = this.tabpageFuel;
            this.tabctrlFuel.Size = new System.Drawing.Size(1167, 703);
            this.tabctrlFuel.TabIndex = 0;
            this.tabctrlFuel.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageFuel,
            this.tabpageDelivery,
            this.tabpageCorrection,
            this.tabpageFuelReport});
            // 
            // tabpageFuel
            // 
            this.tabpageFuel.Controls.Add(this.txtPLNCurrency);
            this.tabpageFuel.Controls.Add(this.labelControl16);
            this.tabpageFuel.Controls.Add(this.btnImportTotal);
            this.tabpageFuel.Controls.Add(this.btnExportToExcel);
            this.tabpageFuel.Controls.Add(this.bbiRemove);
            this.tabpageFuel.Controls.Add(this.bbiAddFuel);
            this.tabpageFuel.Controls.Add(this.btnSearchFuel);
            this.tabpageFuel.Controls.Add(this.gdcFuel);
            this.tabpageFuel.Controls.Add(this.cbxPrivate);
            this.tabpageFuel.Controls.Add(this.labelControl6);
            this.tabpageFuel.Controls.Add(this.labelControl5);
            this.tabpageFuel.Controls.Add(this.dteDateTo);
            this.tabpageFuel.Controls.Add(this.dteDateFrom);
            this.tabpageFuel.Controls.Add(this.labelControl4);
            this.tabpageFuel.Controls.Add(this.cmbVehicle);
            this.tabpageFuel.Controls.Add(this.labelControl3);
            this.tabpageFuel.Controls.Add(this.labelControl2);
            this.tabpageFuel.Controls.Add(this.labelControl1);
            this.tabpageFuel.Controls.Add(this.cmbEmployee);
            this.tabpageFuel.Controls.Add(this.cmbFuel);
            this.tabpageFuel.Controls.Add(this.cmbSupplier);
            this.tabpageFuel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageFuel.Name = "tabpageFuel";
            this.tabpageFuel.Size = new System.Drawing.Size(1161, 672);
            this.tabpageFuel.Text = "Fuel";
            // 
            // txtPLNCurrency
            // 
            this.txtPLNCurrency.EditValue = "4.1556";
            this.txtPLNCurrency.Location = new System.Drawing.Point(1038, 58);
            this.txtPLNCurrency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPLNCurrency.Name = "txtPLNCurrency";
            this.txtPLNCurrency.Properties.Mask.EditMask = "n4";
            this.txtPLNCurrency.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPLNCurrency.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPLNCurrency.Size = new System.Drawing.Size(111, 22);
            this.txtPLNCurrency.TabIndex = 73;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(938, 62);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(97, 16);
            this.labelControl16.TabIndex = 72;
            this.labelControl16.Text = "PLN  Wisselkoers";
            // 
            // btnImportTotal
            // 
            this.btnImportTotal.ImageIndex = 15;
            this.btnImportTotal.ImageList = this.iclSmall;
            this.btnImportTotal.Location = new System.Drawing.Point(1038, 90);
            this.btnImportTotal.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnImportTotal.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnImportTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportTotal.Name = "btnImportTotal";
            this.btnImportTotal.Size = new System.Drawing.Size(111, 30);
            this.btnImportTotal.TabIndex = 70;
            this.btnImportTotal.Text = "Import Total";
            this.btnImportTotal.Click += new System.EventHandler(this.btnImportTotal_Click);
            // 
            // iclSmall
            // 
            this.iclSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("iclSmall.ImageStream")));
            this.iclSmall.Images.SetKeyName(0, "add_user_16.png");
            this.iclSmall.Images.SetKeyName(1, "arrow_left_16.png");
            this.iclSmall.Images.SetKeyName(2, "arrow_left_16_d.png");
            this.iclSmall.Images.SetKeyName(3, "arrow_left_16_h.png");
            this.iclSmall.Images.SetKeyName(4, "arrow_right_16.png");
            this.iclSmall.Images.SetKeyName(5, "arrow_right_16_d.png");
            this.iclSmall.Images.SetKeyName(6, "arrow_right_16_h.png");
            this.iclSmall.Images.SetKeyName(7, "copy_clipboard_16.png");
            this.iclSmall.Images.SetKeyName(8, "copy_clipboard_16_d.png");
            this.iclSmall.Images.SetKeyName(9, "copy_clipboard_16_h.png");
            this.iclSmall.Images.SetKeyName(10, "copy_clipboard_lined_16.png");
            this.iclSmall.Images.SetKeyName(11, "copy_clipboard_lined_16_d.png");
            this.iclSmall.Images.SetKeyName(12, "copy_clipboard_lined_16_h.png");
            this.iclSmall.Images.SetKeyName(13, "copy_to_folder_16.png");
            this.iclSmall.Images.SetKeyName(14, "copy_to_folder_16_d.png");
            this.iclSmall.Images.SetKeyName(15, "copy_to_folder_16_h.png");
            this.iclSmall.Images.SetKeyName(16, "cut_clipboard_16.png");
            this.iclSmall.Images.SetKeyName(17, "cut_clipboard_16_d.png");
            this.iclSmall.Images.SetKeyName(18, "cut_clipboard_16_h.png");
            this.iclSmall.Images.SetKeyName(19, "delete_16.png");
            this.iclSmall.Images.SetKeyName(20, "delete_16_d.png");
            this.iclSmall.Images.SetKeyName(21, "delete_16_h.png");
            this.iclSmall.Images.SetKeyName(22, "dollar_16.png");
            this.iclSmall.Images.SetKeyName(23, "equipment_16.png");
            this.iclSmall.Images.SetKeyName(24, "excel-16.png");
            this.iclSmall.Images.SetKeyName(25, "favorites_16.png");
            this.iclSmall.Images.SetKeyName(26, "favorites_16_d.png");
            this.iclSmall.Images.SetKeyName(27, "favorites_16_h.png");
            this.iclSmall.Images.SetKeyName(28, "folder_closed_16.png");
            this.iclSmall.Images.SetKeyName(29, "folder_closed_16_d.png");
            this.iclSmall.Images.SetKeyName(30, "folder_closed_16_h.png");
            this.iclSmall.Images.SetKeyName(31, "folder_open_16.png");
            this.iclSmall.Images.SetKeyName(32, "folder_open_16_d.png");
            this.iclSmall.Images.SetKeyName(33, "folder_open_16_h.png");
            this.iclSmall.Images.SetKeyName(34, "folder_options_16.png");
            this.iclSmall.Images.SetKeyName(35, "folder_options_16_d.png");
            this.iclSmall.Images.SetKeyName(36, "folder_options_16_h.png");
            this.iclSmall.Images.SetKeyName(37, "folder_options_b_16.png");
            this.iclSmall.Images.SetKeyName(38, "folder_options_b_16_d.png");
            this.iclSmall.Images.SetKeyName(39, "folder_options_b_16_h.png");
            this.iclSmall.Images.SetKeyName(40, "folders_16.png");
            this.iclSmall.Images.SetKeyName(41, "folders_16_d.png");
            this.iclSmall.Images.SetKeyName(42, "folders_16_h.png");
            this.iclSmall.Images.SetKeyName(43, "help-16.png");
            this.iclSmall.Images.SetKeyName(44, "history_1_16.png");
            this.iclSmall.Images.SetKeyName(45, "history_1_16_d.png");
            this.iclSmall.Images.SetKeyName(46, "history_1_16_h.png");
            this.iclSmall.Images.SetKeyName(47, "history_16.png");
            this.iclSmall.Images.SetKeyName(48, "history_16_d.png");
            this.iclSmall.Images.SetKeyName(49, "history_16_h.png");
            this.iclSmall.Images.SetKeyName(50, "history_b1_16.png");
            this.iclSmall.Images.SetKeyName(51, "history_b1_16_d.png");
            this.iclSmall.Images.SetKeyName(52, "history_b1_16_h.png");
            this.iclSmall.Images.SetKeyName(53, "history_b_16.png");
            this.iclSmall.Images.SetKeyName(54, "history_b_16_d.png");
            this.iclSmall.Images.SetKeyName(55, "history_b_16_h.png");
            this.iclSmall.Images.SetKeyName(56, "home_16.png");
            this.iclSmall.Images.SetKeyName(57, "home_16_d.png");
            this.iclSmall.Images.SetKeyName(58, "home_16_h.png");
            this.iclSmall.Images.SetKeyName(59, "info-16.png");
            this.iclSmall.Images.SetKeyName(60, "logout_16.png");
            this.iclSmall.Images.SetKeyName(61, "mail_16.png");
            this.iclSmall.Images.SetKeyName(62, "mail_16_d.png");
            this.iclSmall.Images.SetKeyName(63, "mail_16_h.png");
            this.iclSmall.Images.SetKeyName(64, "mail_b_16.png");
            this.iclSmall.Images.SetKeyName(65, "mail_b_16_d.png");
            this.iclSmall.Images.SetKeyName(66, "mail_b_16_h.png");
            this.iclSmall.Images.SetKeyName(67, "move_to_folder_16.png");
            this.iclSmall.Images.SetKeyName(68, "move_to_folder_16_d.png");
            this.iclSmall.Images.SetKeyName(69, "move_to_folder_16_h.png");
            this.iclSmall.Images.SetKeyName(70, "new_document_16.png");
            this.iclSmall.Images.SetKeyName(71, "new_document_16_d.png");
            this.iclSmall.Images.SetKeyName(72, "new_document_16_h.png");
            this.iclSmall.Images.SetKeyName(73, "new_document_lined_16.png");
            this.iclSmall.Images.SetKeyName(74, "new_document_lined_16_d.png");
            this.iclSmall.Images.SetKeyName(75, "new_document_lined_16_h.png");
            this.iclSmall.Images.SetKeyName(76, "ok_16.png");
            this.iclSmall.Images.SetKeyName(77, "open_document_16.png");
            this.iclSmall.Images.SetKeyName(78, "open_document_16_d.png");
            this.iclSmall.Images.SetKeyName(79, "open_document_16_h.png");
            this.iclSmall.Images.SetKeyName(80, "paste_clipboard_16.png");
            this.iclSmall.Images.SetKeyName(81, "paste_clipboard_16_d.png");
            this.iclSmall.Images.SetKeyName(82, "paste_clipboard_16_h.png");
            this.iclSmall.Images.SetKeyName(83, "paste_clipboard_lined_16.png");
            this.iclSmall.Images.SetKeyName(84, "paste_clipboard_lined_16_d.png");
            this.iclSmall.Images.SetKeyName(85, "paste_clipboard_lined_16_h.png");
            this.iclSmall.Images.SetKeyName(86, "print_16.png");
            this.iclSmall.Images.SetKeyName(87, "print_16_d.png");
            this.iclSmall.Images.SetKeyName(88, "print_16_h.png");
            this.iclSmall.Images.SetKeyName(89, "print_preview_16.png");
            this.iclSmall.Images.SetKeyName(90, "print_preview_16_d.png");
            this.iclSmall.Images.SetKeyName(91, "print_preview_16_h.png");
            this.iclSmall.Images.SetKeyName(92, "print_preview_lined_16.png");
            this.iclSmall.Images.SetKeyName(93, "print_preview_lined_16_d.png");
            this.iclSmall.Images.SetKeyName(94, "print_preview_lined_16_h.png");
            this.iclSmall.Images.SetKeyName(95, "properties_document_16.png");
            this.iclSmall.Images.SetKeyName(96, "properties_document_16_d.png");
            this.iclSmall.Images.SetKeyName(97, "properties_document_16_h.png");
            this.iclSmall.Images.SetKeyName(98, "properties_document_b_16.png");
            this.iclSmall.Images.SetKeyName(99, "properties_document_b_16_d.png");
            this.iclSmall.Images.SetKeyName(100, "properties_document_b_16_h.png");
            this.iclSmall.Images.SetKeyName(101, "properties_document_b_lined_16.png");
            this.iclSmall.Images.SetKeyName(102, "properties_document_b_lined_16_d.png");
            this.iclSmall.Images.SetKeyName(103, "properties_document_b_lined_16_h.png");
            this.iclSmall.Images.SetKeyName(104, "properties_document_lined_16.png");
            this.iclSmall.Images.SetKeyName(105, "properties_document_lined_16_d.png");
            this.iclSmall.Images.SetKeyName(106, "properties_document_lined_16_h.png");
            this.iclSmall.Images.SetKeyName(107, "redo_16.png");
            this.iclSmall.Images.SetKeyName(108, "redo_16_d.png");
            this.iclSmall.Images.SetKeyName(109, "redo_16_h.png");
            this.iclSmall.Images.SetKeyName(110, "redo_square_16.png");
            this.iclSmall.Images.SetKeyName(111, "redo_square_16_d.png");
            this.iclSmall.Images.SetKeyName(112, "redo_square_16_h.png");
            this.iclSmall.Images.SetKeyName(113, "refresh_document_16.png");
            this.iclSmall.Images.SetKeyName(114, "refresh_document_16_d.png");
            this.iclSmall.Images.SetKeyName(115, "refresh_document_16_h.png");
            this.iclSmall.Images.SetKeyName(116, "run_16.png");
            this.iclSmall.Images.SetKeyName(117, "save_16.png");
            this.iclSmall.Images.SetKeyName(118, "save_16_d.png");
            this.iclSmall.Images.SetKeyName(119, "save_16_h.png");
            this.iclSmall.Images.SetKeyName(120, "search_16.png");
            this.iclSmall.Images.SetKeyName(121, "search_16_d.png");
            this.iclSmall.Images.SetKeyName(122, "search_16_h.png");
            this.iclSmall.Images.SetKeyName(123, "stop_16.png");
            this.iclSmall.Images.SetKeyName(124, "stop_16_d.png");
            this.iclSmall.Images.SetKeyName(125, "stop_16_h.png");
            this.iclSmall.Images.SetKeyName(126, "undo_16.png");
            this.iclSmall.Images.SetKeyName(127, "undo_16_d.png");
            this.iclSmall.Images.SetKeyName(128, "undo_16_h.png");
            this.iclSmall.Images.SetKeyName(129, "undo_square_16.png");
            this.iclSmall.Images.SetKeyName(130, "undo_square_16_d.png");
            this.iclSmall.Images.SetKeyName(131, "undo_square_16_h.png");
            this.iclSmall.Images.SetKeyName(132, "up_folder_16.png");
            this.iclSmall.Images.SetKeyName(133, "up_folder_16_d.png");
            this.iclSmall.Images.SetKeyName(134, "up_folder_16_h.png");
            this.iclSmall.Images.SetKeyName(135, "user_16.png");
            this.iclSmall.Images.SetKeyName(136, "users_16.png");
            this.iclSmall.Images.SetKeyName(137, "view_16.png");
            this.iclSmall.Images.SetKeyName(138, "view_16_d.png");
            this.iclSmall.Images.SetKeyName(139, "view_16_h.png");
            this.iclSmall.Images.SetKeyName(140, "label_16.png");
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportToExcel.ImageIndex = 24;
            this.btnExportToExcel.ImageList = this.iclSmall;
            this.btnExportToExcel.Location = new System.Drawing.Point(1128, 130);
            this.btnExportToExcel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnExportToExcel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(28, 30);
            this.btnExportToExcel.TabIndex = 69;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // bbiRemove
            // 
            this.bbiRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bbiRemove.ImageIndex = 21;
            this.bbiRemove.ImageList = this.iclSmall;
            this.bbiRemove.Location = new System.Drawing.Point(1128, 202);
            this.bbiRemove.LookAndFeel.SkinName = "Office 2010 Blue";
            this.bbiRemove.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bbiRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bbiRemove.Name = "bbiRemove";
            this.bbiRemove.Size = new System.Drawing.Size(28, 30);
            this.bbiRemove.TabIndex = 68;
            this.bbiRemove.Click += new System.EventHandler(this.bbiRemove_Click);
            // 
            // bbiAddFuel
            // 
            this.bbiAddFuel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bbiAddFuel.ImageIndex = 27;
            this.bbiAddFuel.ImageList = this.iclSmall;
            this.bbiAddFuel.Location = new System.Drawing.Point(1128, 165);
            this.bbiAddFuel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.bbiAddFuel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bbiAddFuel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bbiAddFuel.Name = "bbiAddFuel";
            this.bbiAddFuel.Size = new System.Drawing.Size(28, 30);
            this.bbiAddFuel.TabIndex = 67;
            this.bbiAddFuel.Click += new System.EventHandler(this.bbiAddFuel_Click);
            // 
            // btnSearchFuel
            // 
            this.btnSearchFuel.ImageIndex = 122;
            this.btnSearchFuel.ImageList = this.iclSmall;
            this.btnSearchFuel.Location = new System.Drawing.Point(1038, 20);
            this.btnSearchFuel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnSearchFuel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSearchFuel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchFuel.Name = "btnSearchFuel";
            this.btnSearchFuel.Size = new System.Drawing.Size(111, 30);
            this.btnSearchFuel.TabIndex = 66;
            this.btnSearchFuel.Text = "Zoeken";
            this.btnSearchFuel.Click += new System.EventHandler(this.btnSearchFuel_Click);
            // 
            // gdcFuel
            // 
            this.gdcFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcFuel.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuel.Location = new System.Drawing.Point(3, 130);
            this.gdcFuel.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcFuel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcFuel.MainView = this.gdvFuel;
            this.gdcFuel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuel.Name = "gdcFuel";
            this.gdcFuel.Size = new System.Drawing.Size(1118, 542);
            this.gdcFuel.TabIndex = 65;
            this.gdcFuel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvFuel});
            // 
            // gdvFuel
            // 
            this.gdvFuel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoInvoiceOK,
            this.gdcoInvoiceReceived,
            this.gdcoPrivateTanking,
            this.gdcoDate,
            this.gdcoEmployee,
            this.gdcoVehicle,
            this.gdcoFuelType,
            this.gdcoLocation,
            this.gdcoVehicleKilometreCounter,
            this.gdcoSupplier,
            this.gdcoQuantity,
            this.gdcoQuantityCorrection,
            this.gdcoUnityPrice,
            this.gdcoTotalPrice});
            this.gdvFuel.GridControl = this.gdcFuel;
            this.gdvFuel.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", null, "(Som = {0:c2})")});
            this.gdvFuel.Name = "gdvFuel";
            this.gdvFuel.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvFuel.OptionsFind.AlwaysVisible = true;
            this.gdvFuel.OptionsView.ShowAutoFilterRow = true;
            this.gdvFuel.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gdvFuel.OptionsView.ShowFooter = true;
            this.gdvFuel.DoubleClick += new System.EventHandler(this.gdvFuel_DoubleClick);
            // 
            // gdcoInvoiceOK
            // 
            this.gdcoInvoiceOK.Caption = "F OK";
            this.gdcoInvoiceOK.FieldName = "InvoiceOK";
            this.gdcoInvoiceOK.Name = "gdcoInvoiceOK";
            this.gdcoInvoiceOK.OptionsColumn.AllowEdit = false;
            this.gdcoInvoiceOK.Visible = true;
            this.gdcoInvoiceOK.VisibleIndex = 0;
            this.gdcoInvoiceOK.Width = 38;
            // 
            // gdcoInvoiceReceived
            // 
            this.gdcoInvoiceReceived.Caption = "F Ontv";
            this.gdcoInvoiceReceived.FieldName = "InvoiceReceived";
            this.gdcoInvoiceReceived.Name = "gdcoInvoiceReceived";
            this.gdcoInvoiceReceived.OptionsColumn.AllowEdit = false;
            this.gdcoInvoiceReceived.Visible = true;
            this.gdcoInvoiceReceived.VisibleIndex = 1;
            this.gdcoInvoiceReceived.Width = 47;
            // 
            // gdcoPrivateTanking
            // 
            this.gdcoPrivateTanking.Caption = "Privé";
            this.gdcoPrivateTanking.FieldName = "PrivateTanking";
            this.gdcoPrivateTanking.Name = "gdcoPrivateTanking";
            this.gdcoPrivateTanking.OptionsColumn.AllowEdit = false;
            this.gdcoPrivateTanking.Visible = true;
            this.gdcoPrivateTanking.VisibleIndex = 2;
            this.gdcoPrivateTanking.Width = 37;
            // 
            // gdcoDate
            // 
            this.gdcoDate.Caption = "Datum";
            this.gdcoDate.DisplayFormat.FormatString = "g";
            this.gdcoDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gdcoDate.FieldName = "Date";
            this.gdcoDate.Name = "gdcoDate";
            this.gdcoDate.OptionsColumn.AllowEdit = false;
            this.gdcoDate.Visible = true;
            this.gdcoDate.VisibleIndex = 3;
            this.gdcoDate.Width = 100;
            // 
            // gdcoEmployee
            // 
            this.gdcoEmployee.Caption = "Naam";
            this.gdcoEmployee.FieldName = "Employee";
            this.gdcoEmployee.Name = "gdcoEmployee";
            this.gdcoEmployee.OptionsColumn.AllowEdit = false;
            this.gdcoEmployee.Visible = true;
            this.gdcoEmployee.VisibleIndex = 4;
            this.gdcoEmployee.Width = 72;
            // 
            // gdcoVehicle
            // 
            this.gdcoVehicle.Caption = "Voertuig";
            this.gdcoVehicle.FieldName = "VehicleLicensePlate";
            this.gdcoVehicle.Name = "gdcoVehicle";
            this.gdcoVehicle.OptionsColumn.AllowEdit = false;
            this.gdcoVehicle.Visible = true;
            this.gdcoVehicle.VisibleIndex = 5;
            this.gdcoVehicle.Width = 72;
            // 
            // gdcoFuelType
            // 
            this.gdcoFuelType.AppearanceCell.Options.UseTextOptions = true;
            this.gdcoFuelType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gdcoFuelType.Caption = "Brandstof";
            this.gdcoFuelType.FieldName = "FuelType";
            this.gdcoFuelType.Name = "gdcoFuelType";
            this.gdcoFuelType.OptionsColumn.AllowEdit = false;
            this.gdcoFuelType.Visible = true;
            this.gdcoFuelType.VisibleIndex = 6;
            this.gdcoFuelType.Width = 72;
            // 
            // gdcoLocation
            // 
            this.gdcoLocation.Caption = "Locatie";
            this.gdcoLocation.FieldName = "Location";
            this.gdcoLocation.Name = "gdcoLocation";
            this.gdcoLocation.OptionsColumn.AllowEdit = false;
            this.gdcoLocation.Visible = true;
            this.gdcoLocation.VisibleIndex = 7;
            this.gdcoLocation.Width = 72;
            // 
            // gdcoVehicleKilometreCounter
            // 
            this.gdcoVehicleKilometreCounter.Caption = "Kilometerstand";
            this.gdcoVehicleKilometreCounter.FieldName = "VehicleKilometreCounter";
            this.gdcoVehicleKilometreCounter.Name = "gdcoVehicleKilometreCounter";
            this.gdcoVehicleKilometreCounter.OptionsColumn.AllowEdit = false;
            this.gdcoVehicleKilometreCounter.Visible = true;
            this.gdcoVehicleKilometreCounter.VisibleIndex = 8;
            this.gdcoVehicleKilometreCounter.Width = 72;
            // 
            // gdcoSupplier
            // 
            this.gdcoSupplier.Caption = "Leverancier";
            this.gdcoSupplier.FieldName = "Supplier";
            this.gdcoSupplier.Name = "gdcoSupplier";
            this.gdcoSupplier.OptionsColumn.AllowEdit = false;
            this.gdcoSupplier.Visible = true;
            this.gdcoSupplier.VisibleIndex = 9;
            this.gdcoSupplier.Width = 72;
            // 
            // gdcoQuantity
            // 
            this.gdcoQuantity.Caption = "Hoeveelheid";
            this.gdcoQuantity.DisplayFormat.FormatString = "N0";
            this.gdcoQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gdcoQuantity.FieldName = "Quantity";
            this.gdcoQuantity.Name = "gdcoQuantity";
            this.gdcoQuantity.OptionsColumn.AllowEdit = false;
            this.gdcoQuantity.Visible = true;
            this.gdcoQuantity.VisibleIndex = 10;
            this.gdcoQuantity.Width = 72;
            // 
            // gdcoQuantityCorrection
            // 
            this.gdcoQuantityCorrection.Caption = "H. Correctie";
            this.gdcoQuantityCorrection.DisplayFormat.FormatString = "N2";
            this.gdcoQuantityCorrection.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gdcoQuantityCorrection.FieldName = "QuantityCorrection";
            this.gdcoQuantityCorrection.Name = "gdcoQuantityCorrection";
            this.gdcoQuantityCorrection.Visible = true;
            this.gdcoQuantityCorrection.VisibleIndex = 11;
            this.gdcoQuantityCorrection.Width = 68;
            // 
            // gdcoUnityPrice
            // 
            this.gdcoUnityPrice.Caption = "Eenheidsprijs";
            this.gdcoUnityPrice.FieldName = "UnityPrice";
            this.gdcoUnityPrice.Name = "gdcoUnityPrice";
            this.gdcoUnityPrice.OptionsColumn.AllowEdit = false;
            this.gdcoUnityPrice.Visible = true;
            this.gdcoUnityPrice.VisibleIndex = 12;
            this.gdcoUnityPrice.Width = 72;
            // 
            // gdcoTotalPrice
            // 
            this.gdcoTotalPrice.Caption = "Netto";
            this.gdcoTotalPrice.FieldName = "TotalPrice";
            this.gdcoTotalPrice.Name = "gdcoTotalPrice";
            this.gdcoTotalPrice.OptionsColumn.AllowEdit = false;
            this.gdcoTotalPrice.Visible = true;
            this.gdcoTotalPrice.VisibleIndex = 13;
            this.gdcoTotalPrice.Width = 71;
            // 
            // cbxPrivate
            // 
            this.cbxPrivate.Location = new System.Drawing.Point(936, 16);
            this.cbxPrivate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPrivate.Name = "cbxPrivate";
            this.cbxPrivate.Properties.Caption = "Prive";
            this.cbxPrivate.Size = new System.Drawing.Size(87, 20);
            this.cbxPrivate.TabIndex = 63;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 52);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Datum tot";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 20);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Datum van";
            // 
            // dteDateTo
            // 
            this.dteDateTo.EditValue = null;
            this.dteDateTo.Location = new System.Drawing.Point(140, 48);
            this.dteDateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDateTo.Name = "dteDateTo";
            this.dteDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDateTo.Size = new System.Drawing.Size(140, 22);
            this.dteDateTo.TabIndex = 9;
            // 
            // dteDateFrom
            // 
            this.dteDateFrom.EditValue = null;
            this.dteDateFrom.Location = new System.Drawing.Point(140, 16);
            this.dteDateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDateFrom.Name = "dteDateFrom";
            this.dteDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDateFrom.Size = new System.Drawing.Size(140, 22);
            this.dteDateFrom.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(644, 52);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Voertuig";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.Location = new System.Drawing.Point(752, 48);
            this.cmbVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVehicle.Size = new System.Drawing.Size(142, 22);
            this.cmbVehicle.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(644, 20);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Chauffeur";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(324, 52);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Brandstof";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(324, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Leverancier";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Location = new System.Drawing.Point(752, 16);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmployee.Size = new System.Drawing.Size(142, 22);
            this.cmbEmployee.TabIndex = 2;
            // 
            // cmbFuel
            // 
            this.cmbFuel.Location = new System.Drawing.Point(448, 48);
            this.cmbFuel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFuel.Size = new System.Drawing.Size(141, 22);
            this.cmbFuel.TabIndex = 1;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Location = new System.Drawing.Point(448, 16);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplier.Size = new System.Drawing.Size(141, 22);
            this.cmbSupplier.TabIndex = 0;
            // 
            // tabpageDelivery
            // 
            this.tabpageDelivery.Controls.Add(this.btnExportToExcelFuelDelivery);
            this.tabpageDelivery.Controls.Add(this.btnRemoveFuelDelivery);
            this.tabpageDelivery.Controls.Add(this.btnNewFuelDelivery);
            this.tabpageDelivery.Controls.Add(this.gdcFuelDelivery);
            this.tabpageDelivery.Controls.Add(this.btnSearchFuelDelivery);
            this.tabpageDelivery.Controls.Add(this.labelControl7);
            this.tabpageDelivery.Controls.Add(this.labelControl8);
            this.tabpageDelivery.Controls.Add(this.dteDateToDelivery);
            this.tabpageDelivery.Controls.Add(this.dteDateFromDelivery);
            this.tabpageDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageDelivery.Name = "tabpageDelivery";
            this.tabpageDelivery.Size = new System.Drawing.Size(1161, 672);
            this.tabpageDelivery.Text = "Levering";
            // 
            // btnExportToExcelFuelDelivery
            // 
            this.btnExportToExcelFuelDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportToExcelFuelDelivery.ImageIndex = 24;
            this.btnExportToExcelFuelDelivery.ImageList = this.iclSmall;
            this.btnExportToExcelFuelDelivery.Location = new System.Drawing.Point(1128, 95);
            this.btnExportToExcelFuelDelivery.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnExportToExcelFuelDelivery.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExportToExcelFuelDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToExcelFuelDelivery.Name = "btnExportToExcelFuelDelivery";
            this.btnExportToExcelFuelDelivery.Size = new System.Drawing.Size(28, 30);
            this.btnExportToExcelFuelDelivery.TabIndex = 72;
            this.btnExportToExcelFuelDelivery.Click += new System.EventHandler(this.btnExportToExcelFuelDelivery_Click);
            // 
            // btnRemoveFuelDelivery
            // 
            this.btnRemoveFuelDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveFuelDelivery.ImageIndex = 21;
            this.btnRemoveFuelDelivery.ImageList = this.iclSmall;
            this.btnRemoveFuelDelivery.Location = new System.Drawing.Point(1128, 166);
            this.btnRemoveFuelDelivery.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnRemoveFuelDelivery.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRemoveFuelDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveFuelDelivery.Name = "btnRemoveFuelDelivery";
            this.btnRemoveFuelDelivery.Size = new System.Drawing.Size(28, 30);
            this.btnRemoveFuelDelivery.TabIndex = 71;
            this.btnRemoveFuelDelivery.Click += new System.EventHandler(this.btnRemoveFuelDelivery_Click);
            // 
            // btnNewFuelDelivery
            // 
            this.btnNewFuelDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewFuelDelivery.ImageIndex = 27;
            this.btnNewFuelDelivery.ImageList = this.iclSmall;
            this.btnNewFuelDelivery.Location = new System.Drawing.Point(1128, 129);
            this.btnNewFuelDelivery.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnNewFuelDelivery.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNewFuelDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewFuelDelivery.Name = "btnNewFuelDelivery";
            this.btnNewFuelDelivery.Size = new System.Drawing.Size(28, 30);
            this.btnNewFuelDelivery.TabIndex = 70;
            this.btnNewFuelDelivery.Click += new System.EventHandler(this.btnNewFuelDelivery_Click);
            // 
            // gdcFuelDelivery
            // 
            this.gdcFuelDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcFuelDelivery.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuelDelivery.Location = new System.Drawing.Point(3, 95);
            this.gdcFuelDelivery.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcFuelDelivery.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcFuelDelivery.MainView = this.gdvFuelDelivery;
            this.gdcFuelDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuelDelivery.Name = "gdcFuelDelivery";
            this.gdcFuelDelivery.Size = new System.Drawing.Size(1118, 577);
            this.gdcFuelDelivery.TabIndex = 68;
            this.gdcFuelDelivery.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvFuelDelivery});
            // 
            // gdvFuelDelivery
            // 
            this.gdvFuelDelivery.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoFuelDeliverySupplier,
            this.gdcoFuelDeliveryDateDelivery,
            this.gdcoFuelDeliveryDateInvoice,
            this.gdcoFuelDeliveryLocation,
            this.gdcFuelDeliveryQuantity,
            this.gdcoFuelDeliveryUnityPrice});
            this.gdvFuelDelivery.GridControl = this.gdcFuelDelivery;
            this.gdvFuelDelivery.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", null, "(Som = {0:c2})")});
            this.gdvFuelDelivery.Name = "gdvFuelDelivery";
            this.gdvFuelDelivery.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvFuelDelivery.OptionsFind.AlwaysVisible = true;
            this.gdvFuelDelivery.OptionsView.ShowAutoFilterRow = true;
            this.gdvFuelDelivery.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gdvFuelDelivery.OptionsView.ShowFooter = true;
            this.gdvFuelDelivery.DoubleClick += new System.EventHandler(this.gdvFuelDelivery_DoubleClick);
            // 
            // gdcoFuelDeliverySupplier
            // 
            this.gdcoFuelDeliverySupplier.Caption = "Leverancier";
            this.gdcoFuelDeliverySupplier.FieldName = "Supplier.Name";
            this.gdcoFuelDeliverySupplier.Name = "gdcoFuelDeliverySupplier";
            this.gdcoFuelDeliverySupplier.OptionsColumn.AllowEdit = false;
            this.gdcoFuelDeliverySupplier.Visible = true;
            this.gdcoFuelDeliverySupplier.VisibleIndex = 0;
            // 
            // gdcoFuelDeliveryDateDelivery
            // 
            this.gdcoFuelDeliveryDateDelivery.Caption = "Leveringsdatum";
            this.gdcoFuelDeliveryDateDelivery.FieldName = "DateDeliveryDisplay";
            this.gdcoFuelDeliveryDateDelivery.Name = "gdcoFuelDeliveryDateDelivery";
            this.gdcoFuelDeliveryDateDelivery.OptionsColumn.AllowEdit = false;
            this.gdcoFuelDeliveryDateDelivery.Visible = true;
            this.gdcoFuelDeliveryDateDelivery.VisibleIndex = 1;
            // 
            // gdcoFuelDeliveryDateInvoice
            // 
            this.gdcoFuelDeliveryDateInvoice.Caption = "Factuurdatum";
            this.gdcoFuelDeliveryDateInvoice.FieldName = "DateInvoiceDisplay";
            this.gdcoFuelDeliveryDateInvoice.Name = "gdcoFuelDeliveryDateInvoice";
            this.gdcoFuelDeliveryDateInvoice.OptionsColumn.AllowEdit = false;
            this.gdcoFuelDeliveryDateInvoice.Visible = true;
            this.gdcoFuelDeliveryDateInvoice.VisibleIndex = 2;
            // 
            // gdcoFuelDeliveryLocation
            // 
            this.gdcoFuelDeliveryLocation.Caption = "Locatie";
            this.gdcoFuelDeliveryLocation.FieldName = "Location";
            this.gdcoFuelDeliveryLocation.Name = "gdcoFuelDeliveryLocation";
            this.gdcoFuelDeliveryLocation.OptionsColumn.AllowEdit = false;
            this.gdcoFuelDeliveryLocation.Visible = true;
            this.gdcoFuelDeliveryLocation.VisibleIndex = 3;
            // 
            // gdcFuelDeliveryQuantity
            // 
            this.gdcFuelDeliveryQuantity.Caption = "Hoeveelheid";
            this.gdcFuelDeliveryQuantity.FieldName = "Quantity";
            this.gdcFuelDeliveryQuantity.Name = "gdcFuelDeliveryQuantity";
            this.gdcFuelDeliveryQuantity.OptionsColumn.AllowEdit = false;
            this.gdcFuelDeliveryQuantity.Visible = true;
            this.gdcFuelDeliveryQuantity.VisibleIndex = 4;
            // 
            // gdcoFuelDeliveryUnityPrice
            // 
            this.gdcoFuelDeliveryUnityPrice.Caption = "Eenheidsprijs";
            this.gdcoFuelDeliveryUnityPrice.FieldName = "UnityPrice";
            this.gdcoFuelDeliveryUnityPrice.Name = "gdcoFuelDeliveryUnityPrice";
            this.gdcoFuelDeliveryUnityPrice.OptionsColumn.AllowEdit = false;
            this.gdcoFuelDeliveryUnityPrice.Visible = true;
            this.gdcoFuelDeliveryUnityPrice.VisibleIndex = 5;
            // 
            // btnSearchFuelDelivery
            // 
            this.btnSearchFuelDelivery.ImageIndex = 122;
            this.btnSearchFuelDelivery.ImageList = this.iclSmall;
            this.btnSearchFuelDelivery.Location = new System.Drawing.Point(1013, 42);
            this.btnSearchFuelDelivery.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnSearchFuelDelivery.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSearchFuelDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchFuelDelivery.Name = "btnSearchFuelDelivery";
            this.btnSearchFuelDelivery.Size = new System.Drawing.Size(83, 30);
            this.btnSearchFuelDelivery.TabIndex = 67;
            this.btnSearchFuelDelivery.Text = "Zoeken";
            this.btnSearchFuelDelivery.Click += new System.EventHandler(this.btnSearchFuelDelivery_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 55);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(105, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Datum levering tot";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 23);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 16);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Datum levering van";
            // 
            // dteDateToDelivery
            // 
            this.dteDateToDelivery.EditValue = null;
            this.dteDateToDelivery.Location = new System.Drawing.Point(138, 52);
            this.dteDateToDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDateToDelivery.Name = "dteDateToDelivery";
            this.dteDateToDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateToDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDateToDelivery.Size = new System.Drawing.Size(140, 22);
            this.dteDateToDelivery.TabIndex = 13;
            // 
            // dteDateFromDelivery
            // 
            this.dteDateFromDelivery.EditValue = null;
            this.dteDateFromDelivery.Location = new System.Drawing.Point(138, 20);
            this.dteDateFromDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDateFromDelivery.Name = "dteDateFromDelivery";
            this.dteDateFromDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateFromDelivery.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDateFromDelivery.Size = new System.Drawing.Size(140, 22);
            this.dteDateFromDelivery.TabIndex = 12;
            // 
            // tabpageCorrection
            // 
            this.tabpageCorrection.Controls.Add(this.btnAddFuelCorrection);
            this.tabpageCorrection.Controls.Add(this.bbiRemoveFuelCorrection);
            this.tabpageCorrection.Controls.Add(this.panelControl1);
            this.tabpageCorrection.Controls.Add(this.gdcFuelCorrection);
            this.tabpageCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageCorrection.Name = "tabpageCorrection";
            this.tabpageCorrection.Size = new System.Drawing.Size(1161, 672);
            this.tabpageCorrection.Text = "Correction";
            // 
            // btnAddFuelCorrection
            // 
            this.btnAddFuelCorrection.ImageIndex = 27;
            this.btnAddFuelCorrection.ImageList = this.iclSmall;
            this.btnAddFuelCorrection.Location = new System.Drawing.Point(318, 57);
            this.btnAddFuelCorrection.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnAddFuelCorrection.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAddFuelCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFuelCorrection.Name = "btnAddFuelCorrection";
            this.btnAddFuelCorrection.Size = new System.Drawing.Size(28, 30);
            this.btnAddFuelCorrection.TabIndex = 88;
            this.btnAddFuelCorrection.Click += new System.EventHandler(this.btnAddFuelCorrection_Click);
            // 
            // bbiRemoveFuelCorrection
            // 
            this.bbiRemoveFuelCorrection.ImageIndex = 21;
            this.bbiRemoveFuelCorrection.ImageList = this.iclSmall;
            this.bbiRemoveFuelCorrection.Location = new System.Drawing.Point(318, 20);
            this.bbiRemoveFuelCorrection.LookAndFeel.SkinName = "Office 2010 Blue";
            this.bbiRemoveFuelCorrection.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bbiRemoveFuelCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bbiRemoveFuelCorrection.Name = "bbiRemoveFuelCorrection";
            this.bbiRemoveFuelCorrection.Size = new System.Drawing.Size(28, 30);
            this.bbiRemoveFuelCorrection.TabIndex = 87;
            this.bbiRemoveFuelCorrection.Click += new System.EventHandler(this.bbiRemoveFuelCorrection_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gdcFuelCorrectionCalc);
            this.panelControl1.Controls.Add(this.dteDateFromCorrection);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.dteDateToCorrection);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.spinQuantityCorrection);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.spinMaxQuantity);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.ccbxVehiclesNotIncluded);
            this.panelControl1.Controls.Add(this.ccbxSuppliersIncluded);
            this.panelControl1.Controls.Add(this.btnSaveCorrection);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.btnCancelCorrection);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.btnCalculateCorrection);
            this.panelControl1.Location = new System.Drawing.Point(353, 20);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(796, 640);
            this.panelControl1.TabIndex = 86;
            // 
            // gdcFuelCorrectionCalc
            // 
            this.gdcFuelCorrectionCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcFuelCorrectionCalc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuelCorrectionCalc.Location = new System.Drawing.Point(23, 146);
            this.gdcFuelCorrectionCalc.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcFuelCorrectionCalc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcFuelCorrectionCalc.MainView = this.gdvFuelCorrectionCalc;
            this.gdcFuelCorrectionCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuelCorrectionCalc.Name = "gdcFuelCorrectionCalc";
            this.gdcFuelCorrectionCalc.Size = new System.Drawing.Size(754, 474);
            this.gdcFuelCorrectionCalc.TabIndex = 86;
            this.gdcFuelCorrectionCalc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvFuelCorrectionCalc});
            // 
            // gdvFuelCorrectionCalc
            // 
            this.gdvFuelCorrectionCalc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoDateFuelCorrectionCalc,
            this.gdcoVehicleFuelCorrectionCalc,
            this.gdcoQuantityFuelCorrectionCalc,
            this.gdcoQuantityCorrectionFuelCorrectionCalc});
            this.gdvFuelCorrectionCalc.GridControl = this.gdcFuelCorrectionCalc;
            this.gdvFuelCorrectionCalc.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", null, "(Som = {0:c2})")});
            this.gdvFuelCorrectionCalc.Name = "gdvFuelCorrectionCalc";
            this.gdvFuelCorrectionCalc.OptionsView.ShowAutoFilterRow = true;
            this.gdvFuelCorrectionCalc.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gdvFuelCorrectionCalc.OptionsView.ShowFooter = true;
            this.gdvFuelCorrectionCalc.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoDateFuelCorrectionCalc
            // 
            this.gdcoDateFuelCorrectionCalc.Caption = "Datum";
            this.gdcoDateFuelCorrectionCalc.FieldName = "Date";
            this.gdcoDateFuelCorrectionCalc.Name = "gdcoDateFuelCorrectionCalc";
            this.gdcoDateFuelCorrectionCalc.OptionsColumn.AllowEdit = false;
            this.gdcoDateFuelCorrectionCalc.Visible = true;
            this.gdcoDateFuelCorrectionCalc.VisibleIndex = 0;
            // 
            // gdcoVehicleFuelCorrectionCalc
            // 
            this.gdcoVehicleFuelCorrectionCalc.Caption = "Voertuig";
            this.gdcoVehicleFuelCorrectionCalc.FieldName = "VehicleLicensePlate";
            this.gdcoVehicleFuelCorrectionCalc.Name = "gdcoVehicleFuelCorrectionCalc";
            this.gdcoVehicleFuelCorrectionCalc.OptionsColumn.AllowEdit = false;
            this.gdcoVehicleFuelCorrectionCalc.Visible = true;
            this.gdcoVehicleFuelCorrectionCalc.VisibleIndex = 1;
            // 
            // gdcoQuantityFuelCorrectionCalc
            // 
            this.gdcoQuantityFuelCorrectionCalc.Caption = "Liters";
            this.gdcoQuantityFuelCorrectionCalc.FieldName = "Quantity";
            this.gdcoQuantityFuelCorrectionCalc.Name = "gdcoQuantityFuelCorrectionCalc";
            this.gdcoQuantityFuelCorrectionCalc.OptionsColumn.AllowEdit = false;
            this.gdcoQuantityFuelCorrectionCalc.Visible = true;
            this.gdcoQuantityFuelCorrectionCalc.VisibleIndex = 2;
            // 
            // gdcoQuantityCorrectionFuelCorrectionCalc
            // 
            this.gdcoQuantityCorrectionFuelCorrectionCalc.Caption = "Correctie";
            this.gdcoQuantityCorrectionFuelCorrectionCalc.DisplayFormat.FormatString = "N2";
            this.gdcoQuantityCorrectionFuelCorrectionCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gdcoQuantityCorrectionFuelCorrectionCalc.FieldName = "QuantityCorrection";
            this.gdcoQuantityCorrectionFuelCorrectionCalc.Name = "gdcoQuantityCorrectionFuelCorrectionCalc";
            this.gdcoQuantityCorrectionFuelCorrectionCalc.Visible = true;
            this.gdcoQuantityCorrectionFuelCorrectionCalc.VisibleIndex = 3;
            // 
            // dteDateFromCorrection
            // 
            this.dteDateFromCorrection.EditValue = null;
            this.dteDateFromCorrection.Location = new System.Drawing.Point(63, 20);
            this.dteDateFromCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDateFromCorrection.Name = "dteDateFromCorrection";
            this.dteDateFromCorrection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateFromCorrection.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDateFromCorrection.Size = new System.Drawing.Size(127, 22);
            this.dteDateFromCorrection.TabIndex = 70;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(483, 55);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(72, 16);
            this.labelControl14.TabIndex = 85;
            this.labelControl14.Text = "Leveranciers";
            // 
            // dteDateToCorrection
            // 
            this.dteDateToCorrection.EditValue = null;
            this.dteDateToCorrection.Location = new System.Drawing.Point(63, 52);
            this.dteDateToCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDateToCorrection.Name = "dteDateToCorrection";
            this.dteDateToCorrection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateToCorrection.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDateToCorrection.Size = new System.Drawing.Size(127, 22);
            this.dteDateToCorrection.TabIndex = 71;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(483, 23);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(92, 16);
            this.labelControl13.TabIndex = 84;
            this.labelControl13.Text = "Excl. Voertuigen";
            // 
            // spinQuantityCorrection
            // 
            this.spinQuantityCorrection.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinQuantityCorrection.Location = new System.Drawing.Point(325, 20);
            this.spinQuantityCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinQuantityCorrection.Name = "spinQuantityCorrection";
            this.spinQuantityCorrection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinQuantityCorrection.Size = new System.Drawing.Size(134, 22);
            this.spinQuantityCorrection.TabIndex = 72;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(218, 55);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(100, 16);
            this.labelControl12.TabIndex = 83;
            this.labelControl12.Text = "Max. Hoeveelheid";
            // 
            // spinMaxQuantity
            // 
            this.spinMaxQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMaxQuantity.Location = new System.Drawing.Point(325, 52);
            this.spinMaxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinMaxQuantity.Name = "spinMaxQuantity";
            this.spinMaxQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMaxQuantity.Size = new System.Drawing.Size(134, 22);
            this.spinMaxQuantity.TabIndex = 73;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(218, 23);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(69, 16);
            this.labelControl11.TabIndex = 82;
            this.labelControl11.Text = "Hoeveelheid";
            // 
            // ccbxVehiclesNotIncluded
            // 
            this.ccbxVehiclesNotIncluded.Location = new System.Drawing.Point(591, 20);
            this.ccbxVehiclesNotIncluded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccbxVehiclesNotIncluded.Name = "ccbxVehiclesNotIncluded";
            this.ccbxVehiclesNotIncluded.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbxVehiclesNotIncluded.Size = new System.Drawing.Size(166, 22);
            this.ccbxVehiclesNotIncluded.TabIndex = 74;
            // 
            // ccbxSuppliersIncluded
            // 
            this.ccbxSuppliersIncluded.Location = new System.Drawing.Point(591, 52);
            this.ccbxSuppliersIncluded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccbxSuppliersIncluded.Name = "ccbxSuppliersIncluded";
            this.ccbxSuppliersIncluded.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbxSuppliersIncluded.Size = new System.Drawing.Size(166, 22);
            this.ccbxSuppliersIncluded.TabIndex = 81;
            // 
            // btnSaveCorrection
            // 
            this.btnSaveCorrection.Enabled = false;
            this.btnSaveCorrection.ImageIndex = 76;
            this.btnSaveCorrection.ImageList = this.iclSmall;
            this.btnSaveCorrection.Location = new System.Drawing.Point(653, 97);
            this.btnSaveCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveCorrection.Name = "btnSaveCorrection";
            this.btnSaveCorrection.Size = new System.Drawing.Size(101, 28);
            this.btnSaveCorrection.TabIndex = 76;
            this.btnSaveCorrection.Text = "Opslaan";
            this.btnSaveCorrection.Click += new System.EventHandler(this.btnSaveCorrection_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(23, 55);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(19, 16);
            this.labelControl10.TabIndex = 80;
            this.labelControl10.Text = "Tot";
            // 
            // btnCancelCorrection
            // 
            this.btnCancelCorrection.Enabled = false;
            this.btnCancelCorrection.ImageIndex = 123;
            this.btnCancelCorrection.ImageList = this.iclSmall;
            this.btnCancelCorrection.Location = new System.Drawing.Point(548, 97);
            this.btnCancelCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelCorrection.Name = "btnCancelCorrection";
            this.btnCancelCorrection.Size = new System.Drawing.Size(101, 28);
            this.btnCancelCorrection.TabIndex = 77;
            this.btnCancelCorrection.Text = "Annuleren";
            this.btnCancelCorrection.Click += new System.EventHandler(this.btnCancelCorrection_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(23, 23);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(22, 16);
            this.labelControl9.TabIndex = 79;
            this.labelControl9.Text = "Van";
            // 
            // btnCalculateCorrection
            // 
            this.btnCalculateCorrection.ImageIndex = 116;
            this.btnCalculateCorrection.ImageList = this.iclSmall;
            this.btnCalculateCorrection.Location = new System.Drawing.Point(440, 97);
            this.btnCalculateCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculateCorrection.Name = "btnCalculateCorrection";
            this.btnCalculateCorrection.Size = new System.Drawing.Size(101, 28);
            this.btnCalculateCorrection.TabIndex = 78;
            this.btnCalculateCorrection.Text = "Berekenen";
            this.btnCalculateCorrection.Click += new System.EventHandler(this.btnCalculateCorrection_Click);
            // 
            // gdcFuelCorrection
            // 
            this.gdcFuelCorrection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gdcFuelCorrection.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuelCorrection.Location = new System.Drawing.Point(15, 20);
            this.gdcFuelCorrection.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcFuelCorrection.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcFuelCorrection.MainView = this.gdvFuelCorrection;
            this.gdcFuelCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcFuelCorrection.Name = "gdcFuelCorrection";
            this.gdcFuelCorrection.Size = new System.Drawing.Size(296, 640);
            this.gdcFuelCorrection.TabIndex = 69;
            this.gdcFuelCorrection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvFuelCorrection});
            // 
            // gdvFuelCorrection
            // 
            this.gdvFuelCorrection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoFuelCorDateFrom,
            this.gdcoFuelCorDateTo,
            this.gdcoFuelCorQuantity});
            this.gdvFuelCorrection.GridControl = this.gdcFuelCorrection;
            this.gdvFuelCorrection.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", null, "(Som = {0:c2})")});
            this.gdvFuelCorrection.Name = "gdvFuelCorrection";
            this.gdvFuelCorrection.OptionsView.ShowAutoFilterRow = true;
            this.gdvFuelCorrection.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gdvFuelCorrection.OptionsView.ShowFooter = true;
            this.gdvFuelCorrection.OptionsView.ShowGroupPanel = false;
            this.gdvFuelCorrection.DoubleClick += new System.EventHandler(this.gdvFuelCorrection_DoubleClick);
            // 
            // gdcoFuelCorDateFrom
            // 
            this.gdcoFuelCorDateFrom.Caption = "Van";
            this.gdcoFuelCorDateFrom.FieldName = "DateFromDisplay";
            this.gdcoFuelCorDateFrom.Name = "gdcoFuelCorDateFrom";
            this.gdcoFuelCorDateFrom.OptionsColumn.AllowEdit = false;
            this.gdcoFuelCorDateFrom.Visible = true;
            this.gdcoFuelCorDateFrom.VisibleIndex = 0;
            // 
            // gdcoFuelCorDateTo
            // 
            this.gdcoFuelCorDateTo.Caption = "Tot";
            this.gdcoFuelCorDateTo.FieldName = "DateToDisplay";
            this.gdcoFuelCorDateTo.Name = "gdcoFuelCorDateTo";
            this.gdcoFuelCorDateTo.OptionsColumn.AllowEdit = false;
            this.gdcoFuelCorDateTo.Visible = true;
            this.gdcoFuelCorDateTo.VisibleIndex = 1;
            // 
            // gdcoFuelCorQuantity
            // 
            this.gdcoFuelCorQuantity.Caption = "Liters";
            this.gdcoFuelCorQuantity.FieldName = "Quantity";
            this.gdcoFuelCorQuantity.Name = "gdcoFuelCorQuantity";
            this.gdcoFuelCorQuantity.OptionsColumn.AllowEdit = false;
            this.gdcoFuelCorQuantity.Visible = true;
            this.gdcoFuelCorQuantity.VisibleIndex = 2;
            // 
            // tabpageFuelReport
            // 
            this.tabpageFuelReport.Controls.Add(this.cbxTurnOverByTimeFrameLabel);
            this.tabpageFuelReport.Controls.Add(this.labelControl15);
            this.tabpageFuelReport.Controls.Add(this.btn3J);
            this.tabpageFuelReport.Controls.Add(this.btn3M);
            this.tabpageFuelReport.Controls.Add(this.btn6M);
            this.tabpageFuelReport.Controls.Add(this.btn1J);
            this.tabpageFuelReport.Controls.Add(this.btn10J);
            this.tabpageFuelReport.Controls.Add(this.btn5J);
            this.tabpageFuelReport.Controls.Add(this.btnImage);
            this.tabpageFuelReport.Controls.Add(this.btnPDF);
            this.tabpageFuelReport.Controls.Add(this.chartFuelDelivery);
            this.tabpageFuelReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageFuelReport.Name = "tabpageFuelReport";
            this.tabpageFuelReport.Size = new System.Drawing.Size(1161, 672);
            this.tabpageFuelReport.Text = "Grafiek";
            // 
            // cbxTurnOverByTimeFrameLabel
            // 
            this.cbxTurnOverByTimeFrameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxTurnOverByTimeFrameLabel.Location = new System.Drawing.Point(149, 620);
            this.cbxTurnOverByTimeFrameLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTurnOverByTimeFrameLabel.Name = "cbxTurnOverByTimeFrameLabel";
            this.cbxTurnOverByTimeFrameLabel.Properties.Caption = "";
            this.cbxTurnOverByTimeFrameLabel.Size = new System.Drawing.Size(34, 19);
            this.cbxTurnOverByTimeFrameLabel.TabIndex = 107;
            this.cbxTurnOverByTimeFrameLabel.Tag = "11";
            this.cbxTurnOverByTimeFrameLabel.CheckedChanged += new System.EventHandler(this.cbxTurnOverByTimeFrameLabel_CheckedChanged);
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl15.Location = new System.Drawing.Point(49, 624);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(83, 16);
            this.labelControl15.TabIndex = 106;
            this.labelControl15.Text = "Toon waarden";
            // 
            // btn3J
            // 
            this.btn3J.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3J.Location = new System.Drawing.Point(492, 615);
            this.btn3J.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btn3J.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn3J.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3J.Name = "btn3J";
            this.btn3J.Size = new System.Drawing.Size(47, 28);
            this.btn3J.TabIndex = 105;
            this.btn3J.Tag = "9";
            this.btn3J.Text = "3J";
            this.btn3J.Click += new System.EventHandler(this.btn3J_Click);
            // 
            // btn3M
            // 
            this.btn3M.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3M.Location = new System.Drawing.Point(331, 615);
            this.btn3M.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btn3M.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn3M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3M.Name = "btn3M";
            this.btn3M.Size = new System.Drawing.Size(47, 28);
            this.btn3M.TabIndex = 104;
            this.btn3M.Tag = "11";
            this.btn3M.Text = "3M";
            this.btn3M.Click += new System.EventHandler(this.btn3M_Click);
            // 
            // btn6M
            // 
            this.btn6M.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn6M.Location = new System.Drawing.Point(385, 615);
            this.btn6M.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btn6M.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn6M.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn6M.Name = "btn6M";
            this.btn6M.Size = new System.Drawing.Size(47, 28);
            this.btn6M.TabIndex = 103;
            this.btn6M.Tag = "10";
            this.btn6M.Text = "6M";
            this.btn6M.Click += new System.EventHandler(this.btn6M_Click);
            // 
            // btn1J
            // 
            this.btn1J.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn1J.Location = new System.Drawing.Point(439, 615);
            this.btn1J.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btn1J.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn1J.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1J.Name = "btn1J";
            this.btn1J.Size = new System.Drawing.Size(47, 28);
            this.btn1J.TabIndex = 102;
            this.btn1J.Tag = "9";
            this.btn1J.Text = "1J";
            this.btn1J.Click += new System.EventHandler(this.btn1J_Click);
            // 
            // btn10J
            // 
            this.btn10J.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn10J.Location = new System.Drawing.Point(600, 615);
            this.btn10J.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btn10J.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn10J.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn10J.Name = "btn10J";
            this.btn10J.Size = new System.Drawing.Size(47, 28);
            this.btn10J.TabIndex = 101;
            this.btn10J.Tag = "7";
            this.btn10J.Text = "10J";
            this.btn10J.Click += new System.EventHandler(this.btn10J_Click);
            // 
            // btn5J
            // 
            this.btn5J.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn5J.Location = new System.Drawing.Point(546, 615);
            this.btn5J.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btn5J.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn5J.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5J.Name = "btn5J";
            this.btn5J.Size = new System.Drawing.Size(47, 28);
            this.btn5J.TabIndex = 100;
            this.btn5J.Tag = "8";
            this.btn5J.Text = "5J";
            this.btn5J.Click += new System.EventHandler(this.btn5J_Click);
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.ImageIndex = 144;
            this.btnImage.ImageList = this.iclLarge;
            this.btnImage.Location = new System.Drawing.Point(1043, 601);
            this.btnImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(47, 49);
            this.btnImage.TabIndex = 80;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // iclLarge
            // 
            this.iclLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.iclLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("iclLarge.ImageStream")));
            this.iclLarge.Images.SetKeyName(0, "add_user_32.png");
            this.iclLarge.Images.SetKeyName(1, "arrow_left_32.png");
            this.iclLarge.Images.SetKeyName(2, "arrow_left_32_d.png");
            this.iclLarge.Images.SetKeyName(3, "arrow_left_32_h.png");
            this.iclLarge.Images.SetKeyName(4, "arrow_right_32.png");
            this.iclLarge.Images.SetKeyName(5, "arrow_right_32_d.png");
            this.iclLarge.Images.SetKeyName(6, "arrow_right_32_h.png");
            this.iclLarge.Images.SetKeyName(7, "copy_clipboard_32.png");
            this.iclLarge.Images.SetKeyName(8, "copy_clipboard_32_d.png");
            this.iclLarge.Images.SetKeyName(9, "copy_clipboard_32_h.png");
            this.iclLarge.Images.SetKeyName(10, "copy_clipboard_lined_32.png");
            this.iclLarge.Images.SetKeyName(11, "copy_clipboard_lined_32_d.png");
            this.iclLarge.Images.SetKeyName(12, "copy_clipboard_lined_32_h.png");
            this.iclLarge.Images.SetKeyName(13, "copy_to_folder_32.png");
            this.iclLarge.Images.SetKeyName(14, "copy_to_folder_32_d.png");
            this.iclLarge.Images.SetKeyName(15, "copy_to_folder_32_h.png");
            this.iclLarge.Images.SetKeyName(16, "cut_clipboard_32.png");
            this.iclLarge.Images.SetKeyName(17, "cut_clipboard_32_d.png");
            this.iclLarge.Images.SetKeyName(18, "cut_clipboard_32_h.png");
            this.iclLarge.Images.SetKeyName(19, "delete_32.png");
            this.iclLarge.Images.SetKeyName(20, "delete_32_d.png");
            this.iclLarge.Images.SetKeyName(21, "delete_32_h.png");
            this.iclLarge.Images.SetKeyName(22, "dollar_32.png");
            this.iclLarge.Images.SetKeyName(23, "equipment_32.png");
            this.iclLarge.Images.SetKeyName(24, "excel-32.png");
            this.iclLarge.Images.SetKeyName(25, "favorites_32.png");
            this.iclLarge.Images.SetKeyName(26, "favorites_32_d.png");
            this.iclLarge.Images.SetKeyName(27, "favorites_32_h.png");
            this.iclLarge.Images.SetKeyName(28, "folder_closed_32.png");
            this.iclLarge.Images.SetKeyName(29, "folder_closed_32_d.png");
            this.iclLarge.Images.SetKeyName(30, "folder_closed_32_h.png");
            this.iclLarge.Images.SetKeyName(31, "folder_open_32.png");
            this.iclLarge.Images.SetKeyName(32, "folder_open_32_d.png");
            this.iclLarge.Images.SetKeyName(33, "folder_open_32_h.png");
            this.iclLarge.Images.SetKeyName(34, "folder_options_32.png");
            this.iclLarge.Images.SetKeyName(35, "folder_options_32_d.png");
            this.iclLarge.Images.SetKeyName(36, "folder_options_32_h.png");
            this.iclLarge.Images.SetKeyName(37, "folder_options_b_32.png");
            this.iclLarge.Images.SetKeyName(38, "folder_options_b_32_d.png");
            this.iclLarge.Images.SetKeyName(39, "folder_options_b_32_h.png");
            this.iclLarge.Images.SetKeyName(40, "folders_32.png");
            this.iclLarge.Images.SetKeyName(41, "folders_32_d.png");
            this.iclLarge.Images.SetKeyName(42, "folders_32_h.png");
            this.iclLarge.Images.SetKeyName(43, "help-32.png");
            this.iclLarge.Images.SetKeyName(44, "history_1_32.png");
            this.iclLarge.Images.SetKeyName(45, "history_1_32_d.png");
            this.iclLarge.Images.SetKeyName(46, "history_1_32_h.png");
            this.iclLarge.Images.SetKeyName(47, "history_32.png");
            this.iclLarge.Images.SetKeyName(48, "history_32_d.png");
            this.iclLarge.Images.SetKeyName(49, "history_32_h.png");
            this.iclLarge.Images.SetKeyName(50, "history_b1_32.png");
            this.iclLarge.Images.SetKeyName(51, "history_b1_32_d.png");
            this.iclLarge.Images.SetKeyName(52, "history_b1_32_h.png");
            this.iclLarge.Images.SetKeyName(53, "history_b_32.png");
            this.iclLarge.Images.SetKeyName(54, "history_b_32_d.png");
            this.iclLarge.Images.SetKeyName(55, "history_b_32_h.png");
            this.iclLarge.Images.SetKeyName(56, "home_32.png");
            this.iclLarge.Images.SetKeyName(57, "home_32_d.png");
            this.iclLarge.Images.SetKeyName(58, "home_32_h.png");
            this.iclLarge.Images.SetKeyName(59, "info-32.png");
            this.iclLarge.Images.SetKeyName(60, "logout_32.png");
            this.iclLarge.Images.SetKeyName(61, "mail_32.png");
            this.iclLarge.Images.SetKeyName(62, "mail_32_d.png");
            this.iclLarge.Images.SetKeyName(63, "mail_32_h.png");
            this.iclLarge.Images.SetKeyName(64, "mail_b_32.png");
            this.iclLarge.Images.SetKeyName(65, "mail_b_32_d.png");
            this.iclLarge.Images.SetKeyName(66, "mail_b_32_h.png");
            this.iclLarge.Images.SetKeyName(67, "move_to_folder_32.png");
            this.iclLarge.Images.SetKeyName(68, "move_to_folder_32_d.png");
            this.iclLarge.Images.SetKeyName(69, "move_to_folder_32_h.png");
            this.iclLarge.Images.SetKeyName(70, "new_document_32.png");
            this.iclLarge.Images.SetKeyName(71, "new_document_32_d.png");
            this.iclLarge.Images.SetKeyName(72, "new_document_32_h.png");
            this.iclLarge.Images.SetKeyName(73, "new_document_lined_32.png");
            this.iclLarge.Images.SetKeyName(74, "new_document_lined_32_d.png");
            this.iclLarge.Images.SetKeyName(75, "new_document_lined_32_h.png");
            this.iclLarge.Images.SetKeyName(76, "ok_32.png");
            this.iclLarge.Images.SetKeyName(77, "open_document_32.png");
            this.iclLarge.Images.SetKeyName(78, "open_document_32_d.png");
            this.iclLarge.Images.SetKeyName(79, "open_document_32_h.png");
            this.iclLarge.Images.SetKeyName(80, "paste_clipboard_32.png");
            this.iclLarge.Images.SetKeyName(81, "paste_clipboard_32_d.png");
            this.iclLarge.Images.SetKeyName(82, "paste_clipboard_32_h.png");
            this.iclLarge.Images.SetKeyName(83, "paste_clipboard_lined_32.png");
            this.iclLarge.Images.SetKeyName(84, "paste_clipboard_lined_32_d.png");
            this.iclLarge.Images.SetKeyName(85, "paste_clipboard_lined_32_h.png");
            this.iclLarge.Images.SetKeyName(86, "print_32.png");
            this.iclLarge.Images.SetKeyName(87, "print_32_d.png");
            this.iclLarge.Images.SetKeyName(88, "print_32_h.png");
            this.iclLarge.Images.SetKeyName(89, "print_preview_32.png");
            this.iclLarge.Images.SetKeyName(90, "print_preview_32_d.png");
            this.iclLarge.Images.SetKeyName(91, "print_preview_32_h.png");
            this.iclLarge.Images.SetKeyName(92, "print_preview_lined_32.png");
            this.iclLarge.Images.SetKeyName(93, "print_preview_lined_32_d.png");
            this.iclLarge.Images.SetKeyName(94, "print_preview_lined_32_h.png");
            this.iclLarge.Images.SetKeyName(95, "properties_document_32.png");
            this.iclLarge.Images.SetKeyName(96, "properties_document_32_d.png");
            this.iclLarge.Images.SetKeyName(97, "properties_document_32_h.png");
            this.iclLarge.Images.SetKeyName(98, "properties_document_b_32.png");
            this.iclLarge.Images.SetKeyName(99, "properties_document_b_32_d.png");
            this.iclLarge.Images.SetKeyName(100, "properties_document_b_32_h.png");
            this.iclLarge.Images.SetKeyName(101, "properties_document_b_lined_32.png");
            this.iclLarge.Images.SetKeyName(102, "properties_document_b_lined_32_d.png");
            this.iclLarge.Images.SetKeyName(103, "properties_document_b_lined_32_h.png");
            this.iclLarge.Images.SetKeyName(104, "properties_document_lined_32.png");
            this.iclLarge.Images.SetKeyName(105, "properties_document_lined_32_d.png");
            this.iclLarge.Images.SetKeyName(106, "properties_document_lined_32_h.png");
            this.iclLarge.Images.SetKeyName(107, "redo_32.png");
            this.iclLarge.Images.SetKeyName(108, "redo_32_d.png");
            this.iclLarge.Images.SetKeyName(109, "redo_32_h.png");
            this.iclLarge.Images.SetKeyName(110, "redo_square_32.png");
            this.iclLarge.Images.SetKeyName(111, "redo_square_32_d.png");
            this.iclLarge.Images.SetKeyName(112, "redo_square_32_h.png");
            this.iclLarge.Images.SetKeyName(113, "refresh_document_32.png");
            this.iclLarge.Images.SetKeyName(114, "refresh_document_32_d.png");
            this.iclLarge.Images.SetKeyName(115, "refresh_document_32_h.png");
            this.iclLarge.Images.SetKeyName(116, "run_32.png");
            this.iclLarge.Images.SetKeyName(117, "save_32.png");
            this.iclLarge.Images.SetKeyName(118, "save_32_d.png");
            this.iclLarge.Images.SetKeyName(119, "save_32_h.png");
            this.iclLarge.Images.SetKeyName(120, "search_32.png");
            this.iclLarge.Images.SetKeyName(121, "search_32_d.png");
            this.iclLarge.Images.SetKeyName(122, "search_32_h.png");
            this.iclLarge.Images.SetKeyName(123, "stop_32.png");
            this.iclLarge.Images.SetKeyName(124, "stop_32_d.png");
            this.iclLarge.Images.SetKeyName(125, "stop_32_h.png");
            this.iclLarge.Images.SetKeyName(126, "undo_32.png");
            this.iclLarge.Images.SetKeyName(127, "undo_32_d.png");
            this.iclLarge.Images.SetKeyName(128, "undo_32_h.png");
            this.iclLarge.Images.SetKeyName(129, "undo_square_32.png");
            this.iclLarge.Images.SetKeyName(130, "undo_square_32_d.png");
            this.iclLarge.Images.SetKeyName(131, "undo_square_32_h.png");
            this.iclLarge.Images.SetKeyName(132, "up_folder_32.png");
            this.iclLarge.Images.SetKeyName(133, "up_folder_32_d.png");
            this.iclLarge.Images.SetKeyName(134, "up_folder_32_h.png");
            this.iclLarge.Images.SetKeyName(135, "user_32.png");
            this.iclLarge.Images.SetKeyName(136, "users_32.png");
            this.iclLarge.Images.SetKeyName(137, "view_32.png");
            this.iclLarge.Images.SetKeyName(138, "view_32_d.png");
            this.iclLarge.Images.SetKeyName(139, "view_32_h.png");
            this.iclLarge.Images.SetKeyName(140, "label_32.png");
            this.iclLarge.Images.SetKeyName(141, "Truck.png");
            this.iclLarge.Images.SetKeyName(142, "Pump_32.png");
            this.iclLarge.Images.SetKeyName(143, "PDF.jpg");
            this.iclLarge.Images.SetKeyName(144, "image.png");
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.ImageIndex = 143;
            this.btnPDF.ImageList = this.iclLarge;
            this.btnPDF.Location = new System.Drawing.Point(1097, 601);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(47, 49);
            this.btnPDF.TabIndex = 79;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // chartFuelDelivery
            // 
            this.chartFuelDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartFuelDelivery.DataSource = this.fuelDeliveryObjectCollectionBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "55";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "20";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "55";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "20";
            this.chartFuelDelivery.Diagram = xyDiagram1;
            this.chartFuelDelivery.Location = new System.Drawing.Point(3, 4);
            this.chartFuelDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartFuelDelivery.Name = "chartFuelDelivery";
            this.chartFuelDelivery.PaletteName = "Module";
            series1.ArgumentDataMember = "DateDeliveryDisplay";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            pointSeriesLabel1.TextPattern = "{V:C0}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "UnityPriceBEF";
            series1.View = splineAreaSeriesView1;
            this.chartFuelDelivery.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartFuelDelivery.SeriesTemplate.View = splineAreaSeriesView2;
            this.chartFuelDelivery.Size = new System.Drawing.Size(1153, 590);
            this.chartFuelDelivery.TabIndex = 41;
            this.chartFuelDelivery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartFuelDelivery_MouseMove);
            // 
            // fuelDeliveryObjectCollectionBindingSource
            // 
            this.fuelDeliveryObjectCollectionBindingSource.DataSource = typeof(TIS.DL.Internal.FuelDelivery.FuelDeliveryObjectCollection);
            // 
            // Fuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlFuel);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Fuel";
            this.Size = new System.Drawing.Size(1174, 710);
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlFuel)).EndInit();
            this.tabctrlFuel.ResumeLayout(false);
            this.tabpageFuel.ResumeLayout(false);
            this.tabpageFuel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPLNCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPrivate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).EndInit();
            this.tabpageDelivery.ResumeLayout(false);
            this.tabpageDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuelDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuelDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToDelivery.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromDelivery.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromDelivery.Properties)).EndInit();
            this.tabpageCorrection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuelCorrectionCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuelCorrectionCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromCorrection.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFromCorrection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToCorrection.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateToCorrection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantityCorrection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbxVehiclesNotIncluded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbxSuppliersIncluded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcFuelCorrection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFuelCorrection)).EndInit();
            this.tabpageFuelReport.ResumeLayout(false);
            this.tabpageFuelReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTurnOverByTimeFrameLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuelDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelDeliveryObjectCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlFuel;
        private DevExpress.XtraTab.XtraTabPage tabpageFuel;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEmployee;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFuel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dteDateTo;
        private DevExpress.XtraEditors.DateEdit dteDateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVehicle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit cbxPrivate;
        private DevExpress.XtraGrid.GridControl gdcFuel;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvFuel;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVehicle;
        private DevExpress.XtraEditors.SimpleButton btnSearchFuel;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelType;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVehicleKilometreCounter;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPrivateTanking;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoUnityPrice;
        private DevExpress.XtraEditors.SimpleButton bbiAddFuel;
        private DevExpress.XtraEditors.SimpleButton bbiRemove;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoLocation;
        private DevExpress.XtraEditors.SimpleButton btnExportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoInvoiceOK;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoInvoiceReceived;
        private DevExpress.XtraTab.XtraTabPage tabpageDelivery;
        private DevExpress.XtraEditors.SimpleButton btnExportToExcelFuelDelivery;
        private DevExpress.XtraEditors.SimpleButton btnRemoveFuelDelivery;
        private DevExpress.XtraEditors.SimpleButton btnNewFuelDelivery;
        private DevExpress.XtraGrid.GridControl gdcFuelDelivery;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvFuelDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelDeliverySupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelDeliveryDateDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelDeliveryDateInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn gdcFuelDeliveryQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelDeliveryUnityPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelDeliveryLocation;
        private DevExpress.XtraEditors.SimpleButton btnSearchFuelDelivery;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dteDateToDelivery;
        private DevExpress.XtraEditors.DateEdit dteDateFromDelivery;
        private DevExpress.XtraTab.XtraTabPage tabpageCorrection;
        private DevExpress.XtraGrid.GridControl gdcFuelCorrection;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvFuelCorrection;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelCorDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelCorDateTo;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFuelCorQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbxSuppliersIncluded;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnCalculateCorrection;
        private DevExpress.XtraEditors.SimpleButton btnCancelCorrection;
        private DevExpress.XtraEditors.SimpleButton btnSaveCorrection;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbxVehiclesNotIncluded;
        private DevExpress.XtraEditors.SpinEdit spinMaxQuantity;
        private DevExpress.XtraEditors.SpinEdit spinQuantityCorrection;
        private DevExpress.XtraEditors.DateEdit dteDateToCorrection;
        private DevExpress.XtraEditors.DateEdit dteDateFromCorrection;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gdcFuelCorrectionCalc;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvFuelCorrectionCalc;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDateFuelCorrectionCalc;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVehicleFuelCorrectionCalc;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoQuantityFuelCorrectionCalc;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoQuantityCorrectionFuelCorrectionCalc;
        private DevExpress.XtraEditors.SimpleButton bbiRemoveFuelCorrection;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoQuantityCorrection;
        private DevExpress.XtraEditors.SimpleButton btnAddFuelCorrection;
        private DevExpress.XtraTab.XtraTabPage tabpageFuelReport;
        private DevExpress.XtraCharts.ChartControl chartFuelDelivery;
        private DevExpress.XtraEditors.SimpleButton btnImage;
        private DevExpress.XtraEditors.SimpleButton btnPDF;
        private DevExpress.Utils.ImageCollection iclLarge;
        private DevExpress.Utils.ToolTipController toolTipController2;
        private System.Windows.Forms.BindingSource fuelDeliveryObjectCollectionBindingSource;
        private DevExpress.XtraEditors.CheckEdit cbxTurnOverByTimeFrameLabel;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SimpleButton btn3J;
        private DevExpress.XtraEditors.SimpleButton btn3M;
        private DevExpress.XtraEditors.SimpleButton btn6M;
        private DevExpress.XtraEditors.SimpleButton btn1J;
        private DevExpress.XtraEditors.SimpleButton btn10J;
        private DevExpress.XtraEditors.SimpleButton btn5J;
        private DevExpress.XtraEditors.SimpleButton btnImportTotal;
        private DevExpress.XtraEditors.TextEdit txtPLNCurrency;
        private DevExpress.XtraEditors.LabelControl labelControl16;
    }
}
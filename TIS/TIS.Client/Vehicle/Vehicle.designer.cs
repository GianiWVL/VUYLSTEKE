namespace TIS.Client.Vehicle
{
    partial class Vehicle
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle));
            this.gdvMemo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcMaterial = new DevExpress.XtraGrid.GridControl();
            this.gdvMaintenance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoStartMaintenance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoPurchasedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.tabctrlMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.cbxContactTransics = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtBrand = new DevExpress.XtraEditors.TextEdit();
            this.txtChassis = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.tabpageMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.btnRemoveMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.tabpageVehiclesMileages = new DevExpress.XtraTab.XtraTabPage();
            this.gdcVehicleMileage = new DevExpress.XtraGrid.GridControl();
            this.gdvVehicleMileage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoMileage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabpageTransicsLink = new DevExpress.XtraTab.XtraTabPage();
            this.louVehiclesTransics = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.iclMedium = new DevExpress.Utils.ImageCollection(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlMain)).BeginInit();
            this.tabctrlMain.SuspendLayout();
            this.tabpageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxContactTransics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChassis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.tabpageMaterial.SuspendLayout();
            this.tabpageVehiclesMileages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcVehicleMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVehicleMileage)).BeginInit();
            this.tabpageTransicsLink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.louVehiclesTransics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvMemo
            // 
            this.gdvMemo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoDateTime,
            this.gdcoMemo});
            this.gdvMemo.GridControl = this.gdcMaterial;
            this.gdvMemo.Name = "gdvMemo";
            this.gdvMemo.OptionsBehavior.Editable = false;
            this.gdvMemo.OptionsView.ColumnAutoWidth = false;
            this.gdvMemo.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoDateTime
            // 
            this.gdcoDateTime.Caption = "Datum";
            this.gdcoDateTime.FieldName = "DateTime";
            this.gdcoDateTime.Name = "gdcoDateTime";
            this.gdcoDateTime.Visible = true;
            this.gdcoDateTime.VisibleIndex = 0;
            this.gdcoDateTime.Width = 100;
            // 
            // gdcoMemo
            // 
            this.gdcoMemo.Caption = "Opmerking";
            this.gdcoMemo.FieldName = "Memo";
            this.gdcoMemo.Name = "gdcoMemo";
            this.gdcoMemo.Visible = true;
            this.gdcoMemo.VisibleIndex = 1;
            this.gdcoMemo.Width = 350;
            // 
            // gdcMaterial
            // 
            this.gdcMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcMaterial.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.LevelTemplate = this.gdvMemo;
            gridLevelNode1.RelationName = "Memos";
            gridLevelNode2.LevelTemplate = this.gdvMaintenance;
            gridLevelNode2.RelationName = "Maintenances";
            this.gdcMaterial.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gdcMaterial.Location = new System.Drawing.Point(50, 15);
            this.gdcMaterial.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcMaterial.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcMaterial.MainView = this.gdvMaterial;
            this.gdcMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcMaterial.Name = "gdcMaterial";
            this.gdcMaterial.Size = new System.Drawing.Size(812, 450);
            this.gdcMaterial.TabIndex = 23;
            this.gdcMaterial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvMaintenance,
            this.gdvMaterial,
            this.gridView1,
            this.gdvMemo});
            // 
            // gdvMaintenance
            // 
            this.gdvMaintenance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoStartMaintenance,
            this.gdcoRemark});
            this.gdvMaintenance.GridControl = this.gdcMaterial;
            this.gdvMaintenance.Name = "gdvMaintenance";
            this.gdvMaintenance.OptionsBehavior.Editable = false;
            this.gdvMaintenance.OptionsView.ColumnAutoWidth = false;
            this.gdvMaintenance.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoStartMaintenance
            // 
            this.gdcoStartMaintenance.Caption = "Onderhoud";
            this.gdcoStartMaintenance.FieldName = "StartMaintenance";
            this.gdcoStartMaintenance.Name = "gdcoStartMaintenance";
            this.gdcoStartMaintenance.Visible = true;
            this.gdcoStartMaintenance.VisibleIndex = 0;
            this.gdcoStartMaintenance.Width = 100;
            // 
            // gdcoRemark
            // 
            this.gdcoRemark.Caption = "Opmerking";
            this.gdcoRemark.FieldName = "Remark";
            this.gdcoRemark.Name = "gdcoRemark";
            this.gdcoRemark.Visible = true;
            this.gdcoRemark.VisibleIndex = 1;
            this.gdcoRemark.Width = 350;
            // 
            // gdvMaterial
            // 
            this.gdvMaterial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoType,
            this.gdcoName,
            this.gdcoResponsable,
            this.gdcoPurchasedOn,
            this.gdcoSupplier});
            this.gdvMaterial.GridControl = this.gdcMaterial;
            this.gdvMaterial.Name = "gdvMaterial";
            this.gdvMaterial.OptionsBehavior.Editable = false;
            this.gdvMaterial.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvMaterial.OptionsView.ColumnAutoWidth = false;
            this.gdvMaterial.OptionsView.ShowAutoFilterRow = true;
            this.gdvMaterial.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.gdvMaterial_MasterRowExpanding);
            this.gdvMaterial.DoubleClick += new System.EventHandler(this.gdvMaterial_DoubleClick);
            // 
            // gdcoType
            // 
            this.gdcoType.Caption = "Type";
            this.gdcoType.FieldName = "Type";
            this.gdcoType.Name = "gdcoType";
            this.gdcoType.Visible = true;
            this.gdcoType.VisibleIndex = 0;
            this.gdcoType.Width = 100;
            // 
            // gdcoName
            // 
            this.gdcoName.Caption = "Naam";
            this.gdcoName.FieldName = "Name";
            this.gdcoName.Name = "gdcoName";
            this.gdcoName.Visible = true;
            this.gdcoName.VisibleIndex = 1;
            this.gdcoName.Width = 100;
            // 
            // gdcoResponsable
            // 
            this.gdcoResponsable.Caption = "Gebruiker";
            this.gdcoResponsable.FieldName = "EmployeeResponsable.Name";
            this.gdcoResponsable.Name = "gdcoResponsable";
            this.gdcoResponsable.Visible = true;
            this.gdcoResponsable.VisibleIndex = 2;
            this.gdcoResponsable.Width = 100;
            // 
            // gdcoPurchasedOn
            // 
            this.gdcoPurchasedOn.Caption = "Aangekocht op";
            this.gdcoPurchasedOn.FieldName = "PurchasedOn";
            this.gdcoPurchasedOn.Name = "gdcoPurchasedOn";
            this.gdcoPurchasedOn.Visible = true;
            this.gdcoPurchasedOn.VisibleIndex = 4;
            this.gdcoPurchasedOn.Width = 100;
            // 
            // gdcoSupplier
            // 
            this.gdcoSupplier.Caption = "Leverancier";
            this.gdcoSupplier.FieldName = "Supplier.Name";
            this.gdcoSupplier.Name = "gdcoSupplier";
            this.gdcoSupplier.Visible = true;
            this.gdcoSupplier.VisibleIndex = 3;
            this.gdcoSupplier.Width = 175;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdcMaterial;
            this.gridView1.Name = "gridView1";
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
            // tabctrlMain
            // 
            this.tabctrlMain.Location = new System.Drawing.Point(14, 15);
            this.tabctrlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabctrlMain.Name = "tabctrlMain";
            this.tabctrlMain.SelectedTabPage = this.tabpageCustomer;
            this.tabctrlMain.Size = new System.Drawing.Size(880, 508);
            this.tabctrlMain.TabIndex = 0;
            this.tabctrlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageCustomer,
            this.tabpageMaterial,
            this.tabpageVehiclesMileages,
            this.tabpageTransicsLink});
            // 
            // tabpageCustomer
            // 
            this.tabpageCustomer.Controls.Add(this.cbxContactTransics);
            this.tabpageCustomer.Controls.Add(this.labelControl5);
            this.tabpageCustomer.Controls.Add(this.labelControl4);
            this.tabpageCustomer.Controls.Add(this.labelControl3);
            this.tabpageCustomer.Controls.Add(this.labelControl2);
            this.tabpageCustomer.Controls.Add(this.labelControl1);
            this.tabpageCustomer.Controls.Add(this.txtType);
            this.tabpageCustomer.Controls.Add(this.txtLicenseNumber);
            this.tabpageCustomer.Controls.Add(this.txtBrand);
            this.tabpageCustomer.Controls.Add(this.txtChassis);
            this.tabpageCustomer.Controls.Add(this.txtName);
            this.tabpageCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageCustomer.Name = "tabpageCustomer";
            this.tabpageCustomer.Size = new System.Drawing.Size(874, 477);
            this.tabpageCustomer.Text = "Algemeen";
            // 
            // cbxContactTransics
            // 
            this.cbxContactTransics.Location = new System.Drawing.Point(510, 23);
            this.cbxContactTransics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxContactTransics.Name = "cbxContactTransics";
            this.cbxContactTransics.Properties.Caption = "Link Transics Boordcomputer";
            this.cbxContactTransics.Size = new System.Drawing.Size(216, 20);
            this.cbxContactTransics.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 155);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Type:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 123);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Merk:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 91);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Chassis:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 59);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Nummerplaat:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Naam:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 151);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Properties.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(213, 22);
            this.txtType.TabIndex = 4;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(120, 55);
            this.txtLicenseNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Properties.ReadOnly = true;
            this.txtLicenseNumber.Size = new System.Drawing.Size(213, 22);
            this.txtLicenseNumber.TabIndex = 3;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(120, 119);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Properties.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(213, 22);
            this.txtBrand.TabIndex = 2;
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(120, 87);
            this.txtChassis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Properties.ReadOnly = true;
            this.txtChassis.Size = new System.Drawing.Size(213, 22);
            this.txtChassis.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(213, 22);
            this.txtName.TabIndex = 0;
            // 
            // tabpageMaterial
            // 
            this.tabpageMaterial.Controls.Add(this.btnRemoveMaterial);
            this.tabpageMaterial.Controls.Add(this.btnAddMaterial);
            this.tabpageMaterial.Controls.Add(this.gdcMaterial);
            this.tabpageMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageMaterial.Name = "tabpageMaterial";
            this.tabpageMaterial.Size = new System.Drawing.Size(874, 477);
            this.tabpageMaterial.Text = "Materiaal";
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.ImageIndex = 21;
            this.btnRemoveMaterial.ImageList = this.iclSmall;
            this.btnRemoveMaterial.Location = new System.Drawing.Point(9, 58);
            this.btnRemoveMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(28, 30);
            this.btnRemoveMaterial.TabIndex = 25;
            this.btnRemoveMaterial.Visible = false;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.ImageIndex = 27;
            this.btnAddMaterial.ImageList = this.iclSmall;
            this.btnAddMaterial.Location = new System.Drawing.Point(9, 21);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(28, 30);
            this.btnAddMaterial.TabIndex = 24;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // tabpageVehiclesMileages
            // 
            this.tabpageVehiclesMileages.Controls.Add(this.gdcVehicleMileage);
            this.tabpageVehiclesMileages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageVehiclesMileages.Name = "tabpageVehiclesMileages";
            this.tabpageVehiclesMileages.Size = new System.Drawing.Size(874, 477);
            this.tabpageVehiclesMileages.Text = "Kilometerstanden";
            // 
            // gdcVehicleMileage
            // 
            this.gdcVehicleMileage.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcVehicleMileage.Location = new System.Drawing.Point(3, 4);
            this.gdcVehicleMileage.MainView = this.gdvVehicleMileage;
            this.gdcVehicleMileage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcVehicleMileage.Name = "gdcVehicleMileage";
            this.gdcVehicleMileage.Size = new System.Drawing.Size(870, 474);
            this.gdcVehicleMileage.TabIndex = 0;
            this.gdcVehicleMileage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvVehicleMileage});
            // 
            // gdvVehicleMileage
            // 
            this.gdvVehicleMileage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoDate,
            this.gdcoMileage});
            this.gdvVehicleMileage.GridControl = this.gdcVehicleMileage;
            this.gdvVehicleMileage.Name = "gdvVehicleMileage";
            this.gdvVehicleMileage.OptionsView.ColumnAutoWidth = false;
            this.gdvVehicleMileage.OptionsView.ShowAutoFilterRow = true;
            this.gdvVehicleMileage.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gdvVehicleMileage.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoDate
            // 
            this.gdcoDate.Caption = "Datum";
            this.gdcoDate.FieldName = "Date";
            this.gdcoDate.Name = "gdcoDate";
            this.gdcoDate.Visible = true;
            this.gdcoDate.VisibleIndex = 0;
            this.gdcoDate.Width = 150;
            // 
            // gdcoMileage
            // 
            this.gdcoMileage.Caption = "Kilometerstand";
            this.gdcoMileage.FieldName = "Mileage";
            this.gdcoMileage.Name = "gdcoMileage";
            this.gdcoMileage.Visible = true;
            this.gdcoMileage.VisibleIndex = 1;
            this.gdcoMileage.Width = 150;
            // 
            // tabpageTransicsLink
            // 
            this.tabpageTransicsLink.Controls.Add(this.louVehiclesTransics);
            this.tabpageTransicsLink.Controls.Add(this.labelControl6);
            this.tabpageTransicsLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageTransicsLink.Name = "tabpageTransicsLink";
            this.tabpageTransicsLink.Size = new System.Drawing.Size(874, 477);
            this.tabpageTransicsLink.Text = "Transics Link";
            // 
            // louVehiclesTransics
            // 
            this.louVehiclesTransics.Location = new System.Drawing.Point(65, 28);
            this.louVehiclesTransics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.louVehiclesTransics.Name = "louVehiclesTransics";
            this.louVehiclesTransics.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.louVehiclesTransics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.louVehiclesTransics.Properties.DisplayMember = "Transi_NM_mat";
            this.louVehiclesTransics.Properties.NullText = "";
            this.louVehiclesTransics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.louVehiclesTransics.Properties.ValueMember = "Transi_TNR_mat";
            this.louVehiclesTransics.Size = new System.Drawing.Size(146, 22);
            this.louVehiclesTransics.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(21, 32);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 16);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Link:";
            // 
            // iclMedium
            // 
            this.iclMedium.ImageSize = new System.Drawing.Size(24, 24);
            this.iclMedium.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("iclMedium.ImageStream")));
            this.iclMedium.Images.SetKeyName(0, "add_user_24.png");
            this.iclMedium.Images.SetKeyName(1, "arrow_left_24.png");
            this.iclMedium.Images.SetKeyName(2, "arrow_left_24_d.png");
            this.iclMedium.Images.SetKeyName(3, "arrow_left_24_h.png");
            this.iclMedium.Images.SetKeyName(4, "arrow_right_24.png");
            this.iclMedium.Images.SetKeyName(5, "arrow_right_24_d.png");
            this.iclMedium.Images.SetKeyName(6, "arrow_right_24_h.png");
            this.iclMedium.Images.SetKeyName(7, "copy_clipboard_24.png");
            this.iclMedium.Images.SetKeyName(8, "copy_clipboard_24_d.png");
            this.iclMedium.Images.SetKeyName(9, "copy_clipboard_24_h.png");
            this.iclMedium.Images.SetKeyName(10, "copy_clipboard_lined_24.png");
            this.iclMedium.Images.SetKeyName(11, "copy_clipboard_lined_24_d.png");
            this.iclMedium.Images.SetKeyName(12, "copy_clipboard_lined_24_h.png");
            this.iclMedium.Images.SetKeyName(13, "copy_to_folder_24.png");
            this.iclMedium.Images.SetKeyName(14, "copy_to_folder_24_d.png");
            this.iclMedium.Images.SetKeyName(15, "copy_to_folder_24_h.png");
            this.iclMedium.Images.SetKeyName(16, "cut_clipboard_24.png");
            this.iclMedium.Images.SetKeyName(17, "cut_clipboard_24_d.png");
            this.iclMedium.Images.SetKeyName(18, "cut_clipboard_24_h.png");
            this.iclMedium.Images.SetKeyName(19, "delete_24.png");
            this.iclMedium.Images.SetKeyName(20, "delete_24_d.png");
            this.iclMedium.Images.SetKeyName(21, "delete_24_h.png");
            this.iclMedium.Images.SetKeyName(22, "equipment_24.png");
            this.iclMedium.Images.SetKeyName(23, "excel-24.png");
            this.iclMedium.Images.SetKeyName(24, "favorites_24.png");
            this.iclMedium.Images.SetKeyName(25, "favorites_24_d.png");
            this.iclMedium.Images.SetKeyName(26, "favorites_24_h.png");
            this.iclMedium.Images.SetKeyName(27, "folder_closed_24.png");
            this.iclMedium.Images.SetKeyName(28, "folder_closed_24_d.png");
            this.iclMedium.Images.SetKeyName(29, "folder_closed_24_h.png");
            this.iclMedium.Images.SetKeyName(30, "folder_open_24.png");
            this.iclMedium.Images.SetKeyName(31, "folder_open_24_d.png");
            this.iclMedium.Images.SetKeyName(32, "folder_open_24_h.png");
            this.iclMedium.Images.SetKeyName(33, "folder_options_24.png");
            this.iclMedium.Images.SetKeyName(34, "folder_options_24_d.png");
            this.iclMedium.Images.SetKeyName(35, "folder_options_24_h.png");
            this.iclMedium.Images.SetKeyName(36, "folder_options_b_24.png");
            this.iclMedium.Images.SetKeyName(37, "folder_options_b_24_d.png");
            this.iclMedium.Images.SetKeyName(38, "folder_options_b_24_h.png");
            this.iclMedium.Images.SetKeyName(39, "folders_24.png");
            this.iclMedium.Images.SetKeyName(40, "folders_24_d.png");
            this.iclMedium.Images.SetKeyName(41, "folders_24_h.png");
            this.iclMedium.Images.SetKeyName(42, "help-24.png");
            this.iclMedium.Images.SetKeyName(43, "history_1_24.png");
            this.iclMedium.Images.SetKeyName(44, "history_1_24_d.png");
            this.iclMedium.Images.SetKeyName(45, "history_1_24_h.png");
            this.iclMedium.Images.SetKeyName(46, "history_24.png");
            this.iclMedium.Images.SetKeyName(47, "history_24_d.png");
            this.iclMedium.Images.SetKeyName(48, "history_24_h.png");
            this.iclMedium.Images.SetKeyName(49, "history_b1_24.png");
            this.iclMedium.Images.SetKeyName(50, "history_b1_24_d.png");
            this.iclMedium.Images.SetKeyName(51, "history_b1_24_h.png");
            this.iclMedium.Images.SetKeyName(52, "history_b_24.png");
            this.iclMedium.Images.SetKeyName(53, "history_b_24_d.png");
            this.iclMedium.Images.SetKeyName(54, "history_b_24_h.png");
            this.iclMedium.Images.SetKeyName(55, "home_24.png");
            this.iclMedium.Images.SetKeyName(56, "home_24_d.png");
            this.iclMedium.Images.SetKeyName(57, "home_24_h.png");
            this.iclMedium.Images.SetKeyName(58, "info-24.png");
            this.iclMedium.Images.SetKeyName(59, "logo-24.png");
            this.iclMedium.Images.SetKeyName(60, "mail_24.png");
            this.iclMedium.Images.SetKeyName(61, "mail_24_d.png");
            this.iclMedium.Images.SetKeyName(62, "mail_24_h.png");
            this.iclMedium.Images.SetKeyName(63, "mail_b_24.png");
            this.iclMedium.Images.SetKeyName(64, "mail_b_24_d.png");
            this.iclMedium.Images.SetKeyName(65, "mail_b_24_h.png");
            this.iclMedium.Images.SetKeyName(66, "move_to_folder_24.png");
            this.iclMedium.Images.SetKeyName(67, "move_to_folder_24_d.png");
            this.iclMedium.Images.SetKeyName(68, "move_to_folder_24_h.png");
            this.iclMedium.Images.SetKeyName(69, "new_document_24.png");
            this.iclMedium.Images.SetKeyName(70, "new_document_24_d.png");
            this.iclMedium.Images.SetKeyName(71, "new_document_24_h.png");
            this.iclMedium.Images.SetKeyName(72, "new_document_lined_24.png");
            this.iclMedium.Images.SetKeyName(73, "new_document_lined_24_d.png");
            this.iclMedium.Images.SetKeyName(74, "new_document_lined_24_h.png");
            this.iclMedium.Images.SetKeyName(75, "open_document_24.png");
            this.iclMedium.Images.SetKeyName(76, "open_document_24_d.png");
            this.iclMedium.Images.SetKeyName(77, "open_document_24_h.png");
            this.iclMedium.Images.SetKeyName(78, "paste_clipboard_24.png");
            this.iclMedium.Images.SetKeyName(79, "paste_clipboard_24_d.png");
            this.iclMedium.Images.SetKeyName(80, "paste_clipboard_24_h.png");
            this.iclMedium.Images.SetKeyName(81, "paste_clipboard_lined_24.png");
            this.iclMedium.Images.SetKeyName(82, "paste_clipboard_lined_24_d.png");
            this.iclMedium.Images.SetKeyName(83, "paste_clipboard_lined_24_h.png");
            this.iclMedium.Images.SetKeyName(84, "print_24.png");
            this.iclMedium.Images.SetKeyName(85, "print_24_d.png");
            this.iclMedium.Images.SetKeyName(86, "print_24_h.png");
            this.iclMedium.Images.SetKeyName(87, "print_preview_24.png");
            this.iclMedium.Images.SetKeyName(88, "print_preview_24_d.png");
            this.iclMedium.Images.SetKeyName(89, "print_preview_24_h.png");
            this.iclMedium.Images.SetKeyName(90, "print_preview_lined_24.png");
            this.iclMedium.Images.SetKeyName(91, "print_preview_lined_24_d.png");
            this.iclMedium.Images.SetKeyName(92, "print_preview_lined_24_h.png");
            this.iclMedium.Images.SetKeyName(93, "properties_document_24.png");
            this.iclMedium.Images.SetKeyName(94, "properties_document_24_d.png");
            this.iclMedium.Images.SetKeyName(95, "properties_document_24_h.png");
            this.iclMedium.Images.SetKeyName(96, "properties_document_b_24.png");
            this.iclMedium.Images.SetKeyName(97, "properties_document_b_24_d.png");
            this.iclMedium.Images.SetKeyName(98, "properties_document_b_24_h.png");
            this.iclMedium.Images.SetKeyName(99, "properties_document_b_lined_24.png");
            this.iclMedium.Images.SetKeyName(100, "properties_document_b_lined_24_d.png");
            this.iclMedium.Images.SetKeyName(101, "properties_document_b_lined_24_h.png");
            this.iclMedium.Images.SetKeyName(102, "properties_document_lined_24.png");
            this.iclMedium.Images.SetKeyName(103, "properties_document_lined_24_d.png");
            this.iclMedium.Images.SetKeyName(104, "properties_document_lined_24_h.png");
            this.iclMedium.Images.SetKeyName(105, "redo_24.png");
            this.iclMedium.Images.SetKeyName(106, "redo_24_d.png");
            this.iclMedium.Images.SetKeyName(107, "redo_24_h.png");
            this.iclMedium.Images.SetKeyName(108, "redo_square_24.png");
            this.iclMedium.Images.SetKeyName(109, "redo_square_24_d.png");
            this.iclMedium.Images.SetKeyName(110, "redo_square_24_h.png");
            this.iclMedium.Images.SetKeyName(111, "refresh_document_24.png");
            this.iclMedium.Images.SetKeyName(112, "refresh_document_24_d.png");
            this.iclMedium.Images.SetKeyName(113, "refresh_document_24_h.png");
            this.iclMedium.Images.SetKeyName(114, "save_24.png");
            this.iclMedium.Images.SetKeyName(115, "save_24_d.png");
            this.iclMedium.Images.SetKeyName(116, "save_24_h.png");
            this.iclMedium.Images.SetKeyName(117, "search_24.png");
            this.iclMedium.Images.SetKeyName(118, "search_24_d.png");
            this.iclMedium.Images.SetKeyName(119, "search_24_h.png");
            this.iclMedium.Images.SetKeyName(120, "stop_24.png");
            this.iclMedium.Images.SetKeyName(121, "stop_24_d.png");
            this.iclMedium.Images.SetKeyName(122, "stop_24_h.png");
            this.iclMedium.Images.SetKeyName(123, "undo_24.png");
            this.iclMedium.Images.SetKeyName(124, "undo_24_d.png");
            this.iclMedium.Images.SetKeyName(125, "undo_24_h.png");
            this.iclMedium.Images.SetKeyName(126, "undo_square_24.png");
            this.iclMedium.Images.SetKeyName(127, "undo_square_24_d.png");
            this.iclMedium.Images.SetKeyName(128, "undo_square_24_h.png");
            this.iclMedium.Images.SetKeyName(129, "up_folder_24.png");
            this.iclMedium.Images.SetKeyName(130, "up_folder_24_d.png");
            this.iclMedium.Images.SetKeyName(131, "up_folder_24_h.png");
            this.iclMedium.Images.SetKeyName(132, "users_24.png");
            this.iclMedium.Images.SetKeyName(133, "view_24.png");
            this.iclMedium.Images.SetKeyName(134, "view_24_d.png");
            this.iclMedium.Images.SetKeyName(135, "view_24_h.png");
            this.iclMedium.Images.SetKeyName(136, "ok_24.png");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageIndex = 120;
            this.btnCancel.ImageList = this.iclMedium;
            this.btnCancel.Location = new System.Drawing.Point(786, 530);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ImageIndex = 114;
            this.btnSave.ImageList = this.iclMedium;
            this.btnSave.Location = new System.Drawing.Point(692, 530);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Opslaan";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 585);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabctrlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voertuig";
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlMain)).EndInit();
            this.tabctrlMain.ResumeLayout(false);
            this.tabpageCustomer.ResumeLayout(false);
            this.tabpageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxContactTransics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChassis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.tabpageMaterial.ResumeLayout(false);
            this.tabpageVehiclesMileages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcVehicleMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVehicleMileage)).EndInit();
            this.tabpageTransicsLink.ResumeLayout(false);
            this.tabpageTransicsLink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.louVehiclesTransics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraTab.XtraTabControl tabctrlMain;
        private DevExpress.XtraTab.XtraTabPage tabpageCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.TextEdit txtBrand;
        private DevExpress.XtraEditors.TextEdit txtChassis;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.Utils.ImageCollection iclMedium;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraTab.XtraTabPage tabpageTransicsLink;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit louVehiclesTransics;
        private DevExpress.XtraTab.XtraTabPage tabpageVehiclesMileages;
        private DevExpress.XtraGrid.GridControl gdcVehicleMileage;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvVehicleMileage;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoMileage;
        private DevExpress.XtraTab.XtraTabPage tabpageMaterial;
        private DevExpress.XtraEditors.SimpleButton btnRemoveMaterial;
        private DevExpress.XtraEditors.SimpleButton btnAddMaterial;
        private DevExpress.XtraGrid.GridControl gdcMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMemo;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoMemo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStartMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoRemark;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoType;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPurchasedOn;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckEdit cbxContactTransics;
    }
}
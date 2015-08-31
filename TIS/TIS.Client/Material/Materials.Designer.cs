namespace TIS.Client.Material
{
    partial class Materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
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
            this.tabctrlMaterial = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageMaterials = new DevExpress.XtraTab.XtraTabPage();
            this.btnRemoveMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.btnAddMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchMaterials = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlMaterial)).BeginInit();
            this.tabctrlMaterial.SuspendLayout();
            this.tabpageMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
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
            gridLevelNode1.LevelTemplate = this.gdvMemo;
            gridLevelNode1.RelationName = "Memos";
            gridLevelNode2.LevelTemplate = this.gdvMaintenance;
            gridLevelNode2.RelationName = "Maintenances";
            this.gdcMaterial.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gdcMaterial.Location = new System.Drawing.Point(43, 47);
            this.gdcMaterial.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcMaterial.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcMaterial.MainView = this.gdvMaterial;
            this.gdcMaterial.Name = "gdcMaterial";
            this.gdcMaterial.Size = new System.Drawing.Size(943, 481);
            this.gdcMaterial.TabIndex = 0;
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
            this.gdcoType.Caption = "Categorie";
            this.gdcoType.FieldName = "MaterialCategory.Category";
            this.gdcoType.Name = "gdcoType";
            this.gdcoType.Visible = true;
            this.gdcoType.VisibleIndex = 0;
            this.gdcoType.Width = 175;
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
            // tabctrlMaterial
            // 
            this.tabctrlMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlMaterial.Location = new System.Drawing.Point(3, 3);
            this.tabctrlMaterial.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tabctrlMaterial.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabctrlMaterial.Name = "tabctrlMaterial";
            this.tabctrlMaterial.SelectedTabPage = this.tabpageMaterials;
            this.tabctrlMaterial.Size = new System.Drawing.Size(1000, 571);
            this.tabctrlMaterial.TabIndex = 0;
            this.tabctrlMaterial.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageMaterials});
            // 
            // tabpageMaterials
            // 
            this.tabpageMaterials.Controls.Add(this.btnRemoveMaterial);
            this.tabpageMaterials.Controls.Add(this.btnAddMaterial);
            this.tabpageMaterials.Controls.Add(this.btnSearchMaterials);
            this.tabpageMaterials.Controls.Add(this.gdcMaterial);
            this.tabpageMaterials.Name = "tabpageMaterials";
            this.tabpageMaterials.Size = new System.Drawing.Size(994, 543);
            this.tabpageMaterials.Text = "Materialen";
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.ImageIndex = 21;
            this.btnRemoveMaterial.ImageList = this.iclSmall;
            this.btnRemoveMaterial.Location = new System.Drawing.Point(8, 82);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveMaterial.TabIndex = 22;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
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
            // btnAddMaterial
            // 
            this.btnAddMaterial.ImageIndex = 27;
            this.btnAddMaterial.ImageList = this.iclSmall;
            this.btnAddMaterial.Location = new System.Drawing.Point(8, 52);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(24, 24);
            this.btnAddMaterial.TabIndex = 21;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnSearchMaterials
            // 
            this.btnSearchMaterials.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchMaterials.ImageIndex = 120;
            this.btnSearchMaterials.ImageList = this.iclSmall;
            this.btnSearchMaterials.Location = new System.Drawing.Point(896, 12);
            this.btnSearchMaterials.Name = "btnSearchMaterials";
            this.btnSearchMaterials.Size = new System.Drawing.Size(90, 25);
            this.btnSearchMaterials.TabIndex = 9;
            this.btnSearchMaterials.Text = "Opzoeken";
            this.btnSearchMaterials.Click += new System.EventHandler(this.btnSearchMaterials_Click);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlMaterial);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Materials";
            this.Size = new System.Drawing.Size(1006, 577);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlMaterial)).EndInit();
            this.tabctrlMaterial.ResumeLayout(false);
            this.tabpageMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlMaterial;
        private DevExpress.XtraTab.XtraTabPage tabpageMaterials;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraGrid.GridControl gdcMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoType;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPurchasedOn;
        private DevExpress.XtraEditors.SimpleButton btnSearchMaterials;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMemo;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoMemo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStartMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoRemark;
        private DevExpress.XtraEditors.SimpleButton btnRemoveMaterial;
        private DevExpress.XtraEditors.SimpleButton btnAddMaterial;
    }
}
namespace TIS.Client.Material
{
    partial class MaterialCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialCategories));
            this.gdvType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcMaterialCategory = new DevExpress.XtraGrid.GridControl();
            this.gdvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvCategoryRevisions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoStartMaintenance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvSubTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoSubType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabctrlMaterial = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageMaterialCategory = new DevExpress.XtraTab.XtraTabPage();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdvType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMaterialCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCategoryRevisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSubTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlMaterial)).BeginInit();
            this.tabctrlMaterial.SuspendLayout();
            this.tabpageMaterialCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvType
            // 
            this.gdvType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoType});
            this.gdvType.GridControl = this.gdcMaterialCategory;
            this.gdvType.Name = "gdvType";
            this.gdvType.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gdvType.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gdvType.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvType.OptionsView.ColumnAutoWidth = false;
            this.gdvType.OptionsView.ShowColumnHeaders = false;
            this.gdvType.OptionsView.ShowGroupPanel = false;
            this.gdvType.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gdvType_InitNewRow);
            this.gdvType.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gdvType_RowUpdated);
            this.gdvType.DoubleClick += new System.EventHandler(this.gdvType_DoubleClick);
            // 
            // gdcoType
            // 
            this.gdcoType.Caption = "Type";
            this.gdcoType.FieldName = "Type";
            this.gdcoType.Name = "gdcoType";
            this.gdcoType.Visible = true;
            this.gdcoType.VisibleIndex = 0;
            this.gdcoType.Width = 250;
            // 
            // gdcMaterialCategory
            // 
            this.gdcMaterialCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcMaterialCategory.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gdcMaterial_EmbeddedNavigator_ButtonClick);
            gridLevelNode1.LevelTemplate = this.gdvType;
            gridLevelNode2.LevelTemplate = this.gdvSubTypes;
            gridLevelNode2.RelationName = "SubTypes";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "Types";
            this.gdcMaterialCategory.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gdcMaterialCategory.Location = new System.Drawing.Point(16, 17);
            this.gdcMaterialCategory.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcMaterialCategory.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcMaterialCategory.MainView = this.gdvCategory;
            this.gdcMaterialCategory.Name = "gdcMaterialCategory";
            this.gdcMaterialCategory.ShowOnlyPredefinedDetails = true;
            this.gdcMaterialCategory.Size = new System.Drawing.Size(970, 514);
            this.gdcMaterialCategory.TabIndex = 0;
            this.gdcMaterialCategory.UseEmbeddedNavigator = true;
            this.gdcMaterialCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvCategory,
            this.gdvCategoryRevisions,
            this.gdvSubTypes,
            this.gdvType});
            // 
            // gdvCategory
            // 
            this.gdvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoCategory});
            this.gdvCategory.GridControl = this.gdcMaterialCategory;
            this.gdvCategory.Name = "gdvCategory";
            this.gdvCategory.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gdvCategory.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gdvCategory.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvCategory.OptionsView.ColumnAutoWidth = false;
            this.gdvCategory.OptionsView.ShowAutoFilterRow = true;
            this.gdvCategory.OptionsView.ShowColumnHeaders = false;
            this.gdvCategory.OptionsView.ShowGroupPanel = false;
            this.gdvCategory.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gdvCategory_InitNewRow);
            this.gdvCategory.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gdvCategory_RowUpdated);
            this.gdvCategory.DoubleClick += new System.EventHandler(this.gdvCategory_DoubleClick);
            // 
            // gdcoCategory
            // 
            this.gdcoCategory.Caption = "Categorie";
            this.gdcoCategory.FieldName = "Category";
            this.gdcoCategory.Name = "gdcoCategory";
            this.gdcoCategory.Visible = true;
            this.gdcoCategory.VisibleIndex = 0;
            this.gdcoCategory.Width = 250;
            // 
            // gdvCategoryRevisions
            // 
            this.gdvCategoryRevisions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoStartMaintenance,
            this.gdcoRemark});
            this.gdvCategoryRevisions.GridControl = this.gdcMaterialCategory;
            this.gdvCategoryRevisions.Name = "gdvCategoryRevisions";
            this.gdvCategoryRevisions.OptionsBehavior.Editable = false;
            this.gdvCategoryRevisions.OptionsView.ColumnAutoWidth = false;
            this.gdvCategoryRevisions.OptionsView.ShowGroupPanel = false;
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
            // gdvSubTypes
            // 
            this.gdvSubTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoSubType});
            this.gdvSubTypes.GridControl = this.gdcMaterialCategory;
            this.gdvSubTypes.Name = "gdvSubTypes";
            this.gdvSubTypes.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gdvSubTypes.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gdvSubTypes.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvSubTypes.OptionsView.ColumnAutoWidth = false;
            this.gdvSubTypes.OptionsView.ShowColumnHeaders = false;
            this.gdvSubTypes.OptionsView.ShowGroupPanel = false;
            this.gdvSubTypes.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gdvSubTypes_InitNewRow);
            this.gdvSubTypes.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gdvSubTypes_RowUpdated);
            this.gdvSubTypes.DoubleClick += new System.EventHandler(this.gdvSubTypes_DoubleClick);
            // 
            // gdcoSubType
            // 
            this.gdcoSubType.Caption = "Sub type";
            this.gdcoSubType.FieldName = "SubType";
            this.gdcoSubType.Name = "gdcoSubType";
            this.gdcoSubType.Visible = true;
            this.gdcoSubType.VisibleIndex = 0;
            this.gdcoSubType.Width = 250;
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
            this.tabctrlMaterial.SelectedTabPage = this.tabpageMaterialCategory;
            this.tabctrlMaterial.Size = new System.Drawing.Size(1000, 571);
            this.tabctrlMaterial.TabIndex = 0;
            this.tabctrlMaterial.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageMaterialCategory});
            // 
            // tabpageMaterialCategory
            // 
            this.tabpageMaterialCategory.Controls.Add(this.gdcMaterialCategory);
            this.tabpageMaterialCategory.Name = "tabpageMaterialCategory";
            this.tabpageMaterialCategory.Size = new System.Drawing.Size(994, 543);
            this.tabpageMaterialCategory.Text = "Materialen categories";
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
            // MaterialCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlMaterial);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MaterialCategories";
            this.Size = new System.Drawing.Size(1006, 577);
            ((System.ComponentModel.ISupportInitialize)(this.gdvType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMaterialCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCategoryRevisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSubTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlMaterial)).EndInit();
            this.tabctrlMaterial.ResumeLayout(false);
            this.tabpageMaterialCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlMaterial;
        private DevExpress.XtraTab.XtraTabPage tabpageMaterialCategory;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraGrid.GridControl gdcMaterialCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSubTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvType;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoType;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvCategoryRevisions;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStartMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoRemark;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSubType;
    }
}
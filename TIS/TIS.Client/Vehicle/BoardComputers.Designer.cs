namespace TIS.Client.Vehicle
{
    partial class BoardComputers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardComputers));
            this.gdcBoardComputer = new DevExpress.XtraGrid.GridControl();
            this.gdvBoardComputer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoVehicleBuildIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDateBuildIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabctrlBoardComputer = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageBoardComputers = new DevExpress.XtraTab.XtraTabPage();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.btnAddBoardComputer = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchBoardComputers = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoardComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoardComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlBoardComputer)).BeginInit();
            this.tabctrlBoardComputer.SuspendLayout();
            this.tabpageBoardComputers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcBoardComputer
            // 
            this.gdcBoardComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcBoardComputer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Memos";
            gridLevelNode2.RelationName = "Maintenances";
            this.gdcBoardComputer.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gdcBoardComputer.Location = new System.Drawing.Point(50, 58);
            this.gdcBoardComputer.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcBoardComputer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcBoardComputer.MainView = this.gdvBoardComputer;
            this.gdcBoardComputer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcBoardComputer.Name = "gdcBoardComputer";
            this.gdcBoardComputer.Size = new System.Drawing.Size(1099, 469);
            this.gdcBoardComputer.TabIndex = 0;
            this.gdcBoardComputer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBoardComputer,
            this.gridView1});
            // 
            // gdvBoardComputer
            // 
            this.gdvBoardComputer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoBrand,
            this.gdcoSerialNumber,
            this.gdcoVehicleBuildIn,
            this.gdcoDateBuildIn,
            this.gdcoSupplier});
            this.gdvBoardComputer.GridControl = this.gdcBoardComputer;
            this.gdvBoardComputer.Name = "gdvBoardComputer";
            this.gdvBoardComputer.OptionsBehavior.Editable = false;
            this.gdvBoardComputer.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvBoardComputer.OptionsView.ColumnAutoWidth = false;
            this.gdvBoardComputer.OptionsView.ShowAutoFilterRow = true;
            this.gdvBoardComputer.DoubleClick += new System.EventHandler(this.gdvBoardComputer_DoubleClick);
            // 
            // gdcoBrand
            // 
            this.gdcoBrand.Caption = "Merk";
            this.gdcoBrand.FieldName = "Brand";
            this.gdcoBrand.Name = "gdcoBrand";
            this.gdcoBrand.Visible = true;
            this.gdcoBrand.VisibleIndex = 0;
            this.gdcoBrand.Width = 175;
            // 
            // gdcoSerialNumber
            // 
            this.gdcoSerialNumber.Caption = "Serienummer";
            this.gdcoSerialNumber.FieldName = "SerialNumber";
            this.gdcoSerialNumber.Name = "gdcoSerialNumber";
            this.gdcoSerialNumber.Visible = true;
            this.gdcoSerialNumber.VisibleIndex = 1;
            this.gdcoSerialNumber.Width = 100;
            // 
            // gdcoVehicleBuildIn
            // 
            this.gdcoVehicleBuildIn.Caption = "Ingebouwd in";
            this.gdcoVehicleBuildIn.FieldName = "VehicleBuildIn.Name";
            this.gdcoVehicleBuildIn.Name = "gdcoVehicleBuildIn";
            this.gdcoVehicleBuildIn.Visible = true;
            this.gdcoVehicleBuildIn.VisibleIndex = 3;
            this.gdcoVehicleBuildIn.Width = 100;
            // 
            // gdcoDateBuildIn
            // 
            this.gdcoDateBuildIn.Caption = "Ingebouwd op";
            this.gdcoDateBuildIn.FieldName = "DateBuildIn";
            this.gdcoDateBuildIn.Name = "gdcoDateBuildIn";
            this.gdcoDateBuildIn.Visible = true;
            this.gdcoDateBuildIn.VisibleIndex = 4;
            this.gdcoDateBuildIn.Width = 100;
            // 
            // gdcoSupplier
            // 
            this.gdcoSupplier.Caption = "Leverancier";
            this.gdcoSupplier.FieldName = "Supplier.Name";
            this.gdcoSupplier.Name = "gdcoSupplier";
            this.gdcoSupplier.Visible = true;
            this.gdcoSupplier.VisibleIndex = 2;
            this.gdcoSupplier.Width = 175;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdcBoardComputer;
            this.gridView1.Name = "gridView1";
            // 
            // tabctrlBoardComputer
            // 
            this.tabctrlBoardComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlBoardComputer.Location = new System.Drawing.Point(3, 4);
            this.tabctrlBoardComputer.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tabctrlBoardComputer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabctrlBoardComputer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabctrlBoardComputer.Name = "tabctrlBoardComputer";
            this.tabctrlBoardComputer.SelectedTabPage = this.tabpageBoardComputers;
            this.tabctrlBoardComputer.Size = new System.Drawing.Size(1165, 580);
            this.tabctrlBoardComputer.TabIndex = 1;
            this.tabctrlBoardComputer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageBoardComputers});
            // 
            // tabpageBoardComputers
            // 
            this.tabpageBoardComputers.Controls.Add(this.btnRemove);
            this.tabpageBoardComputers.Controls.Add(this.btnAddBoardComputer);
            this.tabpageBoardComputers.Controls.Add(this.btnSearchBoardComputers);
            this.tabpageBoardComputers.Controls.Add(this.gdcBoardComputer);
            this.tabpageBoardComputers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpageBoardComputers.Name = "tabpageBoardComputers";
            this.tabpageBoardComputers.Size = new System.Drawing.Size(1159, 549);
            this.tabpageBoardComputers.Text = "Boordcomputers";
            // 
            // btnRemove
            // 
            this.btnRemove.ImageIndex = 21;
            this.btnRemove.ImageList = this.iclSmall;
            this.btnRemove.Location = new System.Drawing.Point(9, 101);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 30);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            // btnAddBoardComputer
            // 
            this.btnAddBoardComputer.ImageIndex = 27;
            this.btnAddBoardComputer.ImageList = this.iclSmall;
            this.btnAddBoardComputer.Location = new System.Drawing.Point(9, 64);
            this.btnAddBoardComputer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBoardComputer.Name = "btnAddBoardComputer";
            this.btnAddBoardComputer.Size = new System.Drawing.Size(28, 30);
            this.btnAddBoardComputer.TabIndex = 21;
            this.btnAddBoardComputer.Click += new System.EventHandler(this.btnAddBoardComputer_Click);
            // 
            // btnSearchBoardComputers
            // 
            this.btnSearchBoardComputers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchBoardComputers.ImageIndex = 120;
            this.btnSearchBoardComputers.Location = new System.Drawing.Point(1045, 15);
            this.btnSearchBoardComputers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBoardComputers.Name = "btnSearchBoardComputers";
            this.btnSearchBoardComputers.Size = new System.Drawing.Size(105, 31);
            this.btnSearchBoardComputers.TabIndex = 9;
            this.btnSearchBoardComputers.Text = "Opzoeken";
            this.btnSearchBoardComputers.Click += new System.EventHandler(this.btnSearchBoardComputers_Click_1);
            // 
            // BoardComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlBoardComputer);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BoardComputers";
            this.Size = new System.Drawing.Size(1172, 587);
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoardComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoardComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlBoardComputer)).EndInit();
            this.tabctrlBoardComputer.ResumeLayout(false);
            this.tabpageBoardComputers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlBoardComputer;
        private DevExpress.XtraTab.XtraTabPage tabpageBoardComputers;
        private DevExpress.XtraEditors.SimpleButton btnAddBoardComputer;
        private DevExpress.XtraEditors.SimpleButton btnSearchBoardComputers;
        private DevExpress.XtraGrid.GridControl gdcBoardComputer;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBoardComputer;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoBrand;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVehicleBuildIn;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDateBuildIn;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraEditors.SimpleButton btnRemove;

    }
}

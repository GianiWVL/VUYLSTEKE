namespace TIS.Client.Supplier
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.gdcSupplier = new DevExpress.XtraGrid.GridControl();
            this.gdvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoHouseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoZipcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoTown = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDueDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.tabctrlSupplier = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageSuppliers = new DevExpress.XtraTab.XtraTabPage();
            this.gpbActions = new System.Windows.Forms.GroupBox();
            this.btnSearchSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdcSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlSupplier)).BeginInit();
            this.tabctrlSupplier.SuspendLayout();
            this.tabpageSuppliers.SuspendLayout();
            this.gpbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcSupplier
            // 
            this.gdcSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcSupplier.Location = new System.Drawing.Point(3, 69);
            this.gdcSupplier.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcSupplier.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcSupplier.MainView = this.gdvSupplier;
            this.gdcSupplier.Name = "gdcSupplier";
            this.gdcSupplier.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDueDate});
            this.gdcSupplier.Size = new System.Drawing.Size(992, 477);
            this.gdcSupplier.TabIndex = 0;
            this.gdcSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSupplier});
            // 
            // gdvSupplier
            // 
            this.gdvSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoName,
            this.gdcoName2,
            this.gdcoStreet,
            this.gdcoHouseNumber,
            this.gdcoZipcode,
            this.gdcoTown,
            this.gdcoVAT});
            this.gdvSupplier.GridControl = this.gdcSupplier;
            this.gdvSupplier.Name = "gdvSupplier";
            this.gdvSupplier.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvSupplier.OptionsView.ShowAutoFilterRow = true;
            this.gdvSupplier.DoubleClick += new System.EventHandler(this.gdvSupplier_DoubleClick);
            // 
            // gdcoName
            // 
            this.gdcoName.Caption = "Name";
            this.gdcoName.FieldName = "Name";
            this.gdcoName.Name = "gdcoName";
            this.gdcoName.OptionsColumn.AllowEdit = false;
            this.gdcoName.Visible = true;
            this.gdcoName.VisibleIndex = 0;
            // 
            // gdcoName2
            // 
            this.gdcoName2.Caption = "Name2";
            this.gdcoName2.FieldName = "Name2";
            this.gdcoName2.Name = "gdcoName2";
            this.gdcoName2.OptionsColumn.AllowEdit = false;
            this.gdcoName2.Visible = true;
            this.gdcoName2.VisibleIndex = 1;
            // 
            // gdcoStreet
            // 
            this.gdcoStreet.Caption = "Street";
            this.gdcoStreet.FieldName = "Street";
            this.gdcoStreet.Name = "gdcoStreet";
            this.gdcoStreet.OptionsColumn.AllowEdit = false;
            this.gdcoStreet.Visible = true;
            this.gdcoStreet.VisibleIndex = 2;
            // 
            // gdcoHouseNumber
            // 
            this.gdcoHouseNumber.Caption = "House number";
            this.gdcoHouseNumber.FieldName = "HouseNumber";
            this.gdcoHouseNumber.Name = "gdcoHouseNumber";
            this.gdcoHouseNumber.OptionsColumn.AllowEdit = false;
            this.gdcoHouseNumber.Visible = true;
            this.gdcoHouseNumber.VisibleIndex = 3;
            // 
            // gdcoZipcode
            // 
            this.gdcoZipcode.Caption = "Zipcode";
            this.gdcoZipcode.FieldName = "Zipcode";
            this.gdcoZipcode.Name = "gdcoZipcode";
            this.gdcoZipcode.OptionsColumn.AllowEdit = false;
            this.gdcoZipcode.Visible = true;
            this.gdcoZipcode.VisibleIndex = 4;
            // 
            // gdcoTown
            // 
            this.gdcoTown.Caption = "Town";
            this.gdcoTown.FieldName = "Town";
            this.gdcoTown.Name = "gdcoTown";
            this.gdcoTown.OptionsColumn.AllowEdit = false;
            this.gdcoTown.Visible = true;
            this.gdcoTown.VisibleIndex = 5;
            // 
            // gdcoVAT
            // 
            this.gdcoVAT.Caption = "VAT";
            this.gdcoVAT.FieldName = "Vat";
            this.gdcoVAT.Name = "gdcoVAT";
            this.gdcoVAT.OptionsColumn.AllowEdit = false;
            this.gdcoVAT.Visible = true;
            this.gdcoVAT.VisibleIndex = 6;
            // 
            // repositoryItemDateEditDueDate
            // 
            this.repositoryItemDateEditDueDate.AutoHeight = false;
            this.repositoryItemDateEditDueDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDueDate.Name = "repositoryItemDateEditDueDate";
            this.repositoryItemDateEditDueDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // tabctrlSupplier
            // 
            this.tabctrlSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlSupplier.Location = new System.Drawing.Point(3, 3);
            this.tabctrlSupplier.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tabctrlSupplier.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabctrlSupplier.Name = "tabctrlSupplier";
            this.tabctrlSupplier.SelectedTabPage = this.tabpageSuppliers;
            this.tabctrlSupplier.Size = new System.Drawing.Size(1000, 571);
            this.tabctrlSupplier.TabIndex = 0;
            this.tabctrlSupplier.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageSuppliers});
            // 
            // tabpageSuppliers
            // 
            this.tabpageSuppliers.Controls.Add(this.gpbActions);
            this.tabpageSuppliers.Controls.Add(this.gdcSupplier);
            this.tabpageSuppliers.Name = "tabpageSuppliers";
            this.tabpageSuppliers.Size = new System.Drawing.Size(994, 543);
            this.tabpageSuppliers.Text = "Suppliers";
            // 
            // gpbActions
            // 
            this.gpbActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbActions.Controls.Add(this.btnSearchSupplier);
            this.gpbActions.Location = new System.Drawing.Point(3, 3);
            this.gpbActions.Name = "gpbActions";
            this.gpbActions.Size = new System.Drawing.Size(992, 60);
            this.gpbActions.TabIndex = 5;
            this.gpbActions.TabStop = false;
            this.gpbActions.Text = "Actions";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.ImageIndex = 122;
            this.btnSearchSupplier.ImageList = this.iclSmall;
            this.btnSearchSupplier.Location = new System.Drawing.Point(6, 20);
            this.btnSearchSupplier.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnSearchSupplier.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(77, 24);
            this.btnSearchSupplier.TabIndex = 9;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
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
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlSupplier);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Suppliers";
            this.Size = new System.Drawing.Size(1006, 577);
            ((System.ComponentModel.ISupportInitialize)(this.gdcSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlSupplier)).EndInit();
            this.tabctrlSupplier.ResumeLayout(false);
            this.tabpageSuppliers.ResumeLayout(false);
            this.gpbActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlSupplier;
        private DevExpress.XtraTab.XtraTabPage tabpageSuppliers;
        private DevExpress.XtraGrid.GridControl gdcSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSupplier;
        private System.Windows.Forms.GroupBox gpbActions;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraEditors.SimpleButton btnSearchSupplier;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoName2;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStreet;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoHouseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoZipcode;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTown;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVAT;
    }
}
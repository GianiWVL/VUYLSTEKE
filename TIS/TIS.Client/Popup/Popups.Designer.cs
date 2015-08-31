namespace TIS.Client.Popup
{
    partial class Popups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popups));
            this.gdvPopupUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcPopups = new DevExpress.XtraGrid.GridControl();
            this.gdvPopups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoPopupActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoPopupDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoPopupRepeation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoPopupCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoPopupTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.btnRemovePopup = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPoup = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPopupUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPopups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPopups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvPopupUsers
            // 
            this.gdvPopupUsers.GridControl = this.gdcPopups;
            this.gdvPopupUsers.Name = "gdvPopupUsers";
            this.gdvPopupUsers.OptionsView.ColumnAutoWidth = false;
            // 
            // gdcPopups
            // 
            this.gdcPopups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcPopups.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.LevelTemplate = this.gdvPopupUsers;
            gridLevelNode1.RelationName = "Users";
            this.gdcPopups.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gdcPopups.Location = new System.Drawing.Point(44, 17);
            this.gdcPopups.MainView = this.gdvPopups;
            this.gdcPopups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcPopups.Name = "gdcPopups";
            this.gdcPopups.ShowOnlyPredefinedDetails = true;
            this.gdcPopups.Size = new System.Drawing.Size(877, 639);
            this.gdcPopups.TabIndex = 0;
            this.gdcPopups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvPopups,
            this.gdvPopupUsers});
            // 
            // gdvPopups
            // 
            this.gdvPopups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoPopupActive,
            this.gdcoPopupDescription,
            this.gdcoPopupRepeation,
            this.gdcoPopupCreationDate,
            this.gdcoPopupTime});
            this.gdvPopups.GridControl = this.gdcPopups;
            this.gdvPopups.Name = "gdvPopups";
            this.gdvPopups.OptionsBehavior.Editable = false;
            this.gdvPopups.OptionsBehavior.ReadOnly = true;
            this.gdvPopups.OptionsView.ShowGroupPanel = false;
            this.gdvPopups.DoubleClick += new System.EventHandler(this.gdvPopups_DoubleClick);
            // 
            // gdcoPopupActive
            // 
            this.gdcoPopupActive.Caption = "Actief";
            this.gdcoPopupActive.FieldName = "Active";
            this.gdcoPopupActive.Name = "gdcoPopupActive";
            this.gdcoPopupActive.Visible = true;
            this.gdcoPopupActive.VisibleIndex = 0;
            this.gdcoPopupActive.Width = 45;
            // 
            // gdcoPopupDescription
            // 
            this.gdcoPopupDescription.Caption = "Omschrijving";
            this.gdcoPopupDescription.FieldName = "Description";
            this.gdcoPopupDescription.Name = "gdcoPopupDescription";
            this.gdcoPopupDescription.Visible = true;
            this.gdcoPopupDescription.VisibleIndex = 1;
            this.gdcoPopupDescription.Width = 450;
            // 
            // gdcoPopupRepeation
            // 
            this.gdcoPopupRepeation.Caption = "Wanneer";
            this.gdcoPopupRepeation.FieldName = "Repeation";
            this.gdcoPopupRepeation.Name = "gdcoPopupRepeation";
            this.gdcoPopupRepeation.Visible = true;
            this.gdcoPopupRepeation.VisibleIndex = 2;
            this.gdcoPopupRepeation.Width = 82;
            // 
            // gdcoPopupCreationDate
            // 
            this.gdcoPopupCreationDate.Caption = "Datum";
            this.gdcoPopupCreationDate.FieldName = "CreationDateDisplay";
            this.gdcoPopupCreationDate.Name = "gdcoPopupCreationDate";
            this.gdcoPopupCreationDate.Visible = true;
            this.gdcoPopupCreationDate.VisibleIndex = 3;
            this.gdcoPopupCreationDate.Width = 77;
            // 
            // gdcoPopupTime
            // 
            this.gdcoPopupTime.Caption = "Uur";
            this.gdcoPopupTime.FieldName = "TimeDisplay";
            this.gdcoPopupTime.Name = "gdcoPopupTime";
            this.gdcoPopupTime.Visible = true;
            this.gdcoPopupTime.VisibleIndex = 4;
            this.gdcoPopupTime.Width = 80;
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
            // btnRemovePopup
            // 
            this.btnRemovePopup.ImageIndex = 21;
            this.btnRemovePopup.ImageList = this.iclSmall;
            this.btnRemovePopup.Location = new System.Drawing.Point(9, 54);
            this.btnRemovePopup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemovePopup.Name = "btnRemovePopup";
            this.btnRemovePopup.Size = new System.Drawing.Size(28, 30);
            this.btnRemovePopup.TabIndex = 24;
            this.btnRemovePopup.Click += new System.EventHandler(this.btnRemovePopup_Click);
            // 
            // btnAddPoup
            // 
            this.btnAddPoup.ImageIndex = 27;
            this.btnAddPoup.ImageList = this.iclSmall;
            this.btnAddPoup.Location = new System.Drawing.Point(9, 17);
            this.btnAddPoup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPoup.Name = "btnAddPoup";
            this.btnAddPoup.Size = new System.Drawing.Size(28, 30);
            this.btnAddPoup.TabIndex = 23;
            this.btnAddPoup.Click += new System.EventHandler(this.btnAddPoup_Click);
            // 
            // Popups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemovePopup);
            this.Controls.Add(this.btnAddPoup);
            this.Controls.Add(this.gdcPopups);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Popups";
            this.Size = new System.Drawing.Size(941, 679);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPopupUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPopups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPopups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcPopups;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvPopups;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvPopupUsers;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPopupDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPopupRepeation;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPopupActive;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPopupCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPopupTime;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraEditors.SimpleButton btnRemovePopup;
        private DevExpress.XtraEditors.SimpleButton btnAddPoup;
    }
}

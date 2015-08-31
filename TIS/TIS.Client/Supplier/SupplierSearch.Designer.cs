namespace TIS.Client.Supplier
{
    partial class SupplierSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierSearch));
            this.tabctrlSupplier = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageMain = new DevExpress.XtraTab.XtraTabPage();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gdcSupplier = new DevExpress.XtraGrid.GridControl();
            this.gdvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoTransID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iclMedium = new DevExpress.Utils.ImageCollection(this.components);
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlSupplier)).BeginInit();
            this.tabctrlSupplier.SuspendLayout();
            this.tabpageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlSupplier
            // 
            this.tabctrlSupplier.Location = new System.Drawing.Point(12, 12);
            this.tabctrlSupplier.Name = "tabctrlSupplier";
            this.tabctrlSupplier.SelectedTabPage = this.tabpageMain;
            this.tabctrlSupplier.Size = new System.Drawing.Size(517, 355);
            this.tabctrlSupplier.TabIndex = 0;
            this.tabctrlSupplier.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageMain});
            // 
            // tabpageMain
            // 
            this.tabpageMain.Controls.Add(this.pictureEdit1);
            this.tabpageMain.Controls.Add(this.labelControl1);
            this.tabpageMain.Controls.Add(this.gdcSupplier);
            this.tabpageMain.Name = "tabpageMain";
            this.tabpageMain.Size = new System.Drawing.Size(515, 333);
            this.tabpageMain.Text = "Main";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(26, 23);
            this.pictureEdit1.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(274, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Alleen leveranciers met een emailadres zijn selecteerbaar";
            // 
            // gdcSupplier
            // 
            this.gdcSupplier.Location = new System.Drawing.Point(3, 28);
            this.gdcSupplier.MainView = this.gdvSupplier;
            this.gdcSupplier.Name = "gdcSupplier";
            this.gdcSupplier.Size = new System.Drawing.Size(509, 302);
            this.gdcSupplier.TabIndex = 0;
            this.gdcSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSupplier});
            // 
            // gdvSupplier
            // 
            this.gdvSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoTransID,
            this.gdcoEmail});
            this.gdvSupplier.GridControl = this.gdcSupplier;
            this.gdvSupplier.Name = "gdvSupplier";
            this.gdvSupplier.OptionsView.ShowAutoFilterRow = true;
            this.gdvSupplier.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoTransID
            // 
            this.gdcoTransID.Caption = "TransID";
            this.gdcoTransID.FieldName = "TranscID";
            this.gdcoTransID.Name = "gdcoTransID";
            this.gdcoTransID.OptionsColumn.AllowEdit = false;
            this.gdcoTransID.Visible = true;
            this.gdcoTransID.VisibleIndex = 0;
            this.gdcoTransID.Width = 100;
            // 
            // gdcoEmail
            // 
            this.gdcoEmail.Caption = "Email";
            this.gdcoEmail.FieldName = "Email";
            this.gdcoEmail.Name = "gdcoEmail";
            this.gdcoEmail.OptionsColumn.AllowEdit = false;
            this.gdcoEmail.Visible = true;
            this.gdcoEmail.VisibleIndex = 1;
            this.gdcoEmail.Width = 388;
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
            // btnOk
            // 
            this.btnOk.ImageIndex = 136;
            this.btnOk.ImageList = this.iclMedium;
            this.btnOk.Location = new System.Drawing.Point(369, 373);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageIndex = 120;
            this.btnCancel.ImageList = this.iclMedium;
            this.btnCancel.Location = new System.Drawing.Point(450, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SupplierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 414);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabctrlSupplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlSupplier)).EndInit();
            this.tabctrlSupplier.ResumeLayout(false);
            this.tabpageMain.ResumeLayout(false);
            this.tabpageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlSupplier;
        private DevExpress.XtraTab.XtraTabPage tabpageMain;
        private DevExpress.Utils.ImageCollection iclMedium;
        private DevExpress.XtraGrid.GridControl gdcSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSupplier;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTransID;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoEmail;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
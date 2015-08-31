namespace TIS.Client.Vehicle
{
    partial class Vehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicles));
            this.tabctrlVehicle = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageVehicles = new DevExpress.XtraTab.XtraTabPage();
            this.gdcVehicle = new DevExpress.XtraGrid.GridControl();
            this.gdvVehicle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoChassis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoVehicleType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.btnSearchTransicsVehicle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlVehicle)).BeginInit();
            this.tabctrlVehicle.SuspendLayout();
            this.tabpageVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlVehicle
            // 
            this.tabctrlVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlVehicle.Location = new System.Drawing.Point(3, 45);
            this.tabctrlVehicle.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tabctrlVehicle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabctrlVehicle.Name = "tabctrlVehicle";
            this.tabctrlVehicle.SelectedTabPage = this.tabpageVehicles;
            this.tabctrlVehicle.Size = new System.Drawing.Size(1000, 529);
            this.tabctrlVehicle.TabIndex = 0;
            this.tabctrlVehicle.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageVehicles});
            // 
            // tabpageVehicles
            // 
            this.tabpageVehicles.Controls.Add(this.gdcVehicle);
            this.tabpageVehicles.Name = "tabpageVehicles";
            this.tabpageVehicles.Size = new System.Drawing.Size(998, 507);
            this.tabpageVehicles.Text = "Vehicles";
            // 
            // gdcVehicle
            // 
            this.gdcVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcVehicle.Location = new System.Drawing.Point(0, 3);
            this.gdcVehicle.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcVehicle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcVehicle.MainView = this.gdvVehicle;
            this.gdcVehicle.Name = "gdcVehicle";
            this.gdcVehicle.Size = new System.Drawing.Size(998, 501);
            this.gdcVehicle.TabIndex = 0;
            this.gdcVehicle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvVehicle,
            this.gridView1});
            // 
            // gdvVehicle
            // 
            this.gdvVehicle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoName,
            this.gdcoLicenseNumber,
            this.gdcoChassis,
            this.gdcoBrand,
            this.gdcoVehicleType});
            this.gdvVehicle.GridControl = this.gdcVehicle;
            this.gdvVehicle.Name = "gdvVehicle";
            this.gdvVehicle.OptionsBehavior.Editable = false;
            this.gdvVehicle.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvVehicle.OptionsView.ShowAutoFilterRow = true;
            this.gdvVehicle.DoubleClick += new System.EventHandler(this.gdvVehicle_DoubleClick);
            // 
            // gdcoName
            // 
            this.gdcoName.Caption = "Naam";
            this.gdcoName.FieldName = "Name";
            this.gdcoName.Name = "gdcoName";
            this.gdcoName.Visible = true;
            this.gdcoName.VisibleIndex = 0;
            // 
            // gdcoLicenseNumber
            // 
            this.gdcoLicenseNumber.Caption = "Nummerplaat";
            this.gdcoLicenseNumber.FieldName = "LicenseNumber";
            this.gdcoLicenseNumber.Name = "gdcoLicenseNumber";
            this.gdcoLicenseNumber.Visible = true;
            this.gdcoLicenseNumber.VisibleIndex = 1;
            // 
            // gdcoChassis
            // 
            this.gdcoChassis.Caption = "Chassis";
            this.gdcoChassis.FieldName = "Chassis";
            this.gdcoChassis.Name = "gdcoChassis";
            this.gdcoChassis.Visible = true;
            this.gdcoChassis.VisibleIndex = 2;
            // 
            // gdcoBrand
            // 
            this.gdcoBrand.Caption = "Merk";
            this.gdcoBrand.FieldName = "Brand";
            this.gdcoBrand.Name = "gdcoBrand";
            this.gdcoBrand.Visible = true;
            this.gdcoBrand.VisibleIndex = 3;
            // 
            // gdcoVehicleType
            // 
            this.gdcoVehicleType.Caption = "Voertuig Type";
            this.gdcoVehicleType.FieldName = "VehicleType";
            this.gdcoVehicleType.Name = "gdcoVehicleType";
            this.gdcoVehicleType.Visible = true;
            this.gdcoVehicleType.VisibleIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdcVehicle;
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
            // btnSearchTransicsVehicle
            // 
            this.btnSearchTransicsVehicle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchTransicsVehicle.ImageIndex = 120;
            this.btnSearchTransicsVehicle.ImageList = this.iclSmall;
            this.btnSearchTransicsVehicle.Location = new System.Drawing.Point(903, 14);
            this.btnSearchTransicsVehicle.Name = "btnSearchTransicsVehicle";
            this.btnSearchTransicsVehicle.Size = new System.Drawing.Size(90, 25);
            this.btnSearchTransicsVehicle.TabIndex = 9;
            this.btnSearchTransicsVehicle.Text = "Opzoeken";
            this.btnSearchTransicsVehicle.Click += new System.EventHandler(this.btnSearchTransicsVehicle_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchTransicsVehicle);
            this.Controls.Add(this.tabctrlVehicle);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Vehicles";
            this.Size = new System.Drawing.Size(1006, 577);
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlVehicle)).EndInit();
            this.tabctrlVehicle.ResumeLayout(false);
            this.tabpageVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlVehicle;
        private DevExpress.XtraTab.XtraTabPage tabpageVehicles;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraGrid.GridControl gdcVehicle;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoLicenseNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoChassis;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoBrand;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVehicleType;
        private DevExpress.XtraEditors.SimpleButton btnSearchTransicsVehicle;
    }
}
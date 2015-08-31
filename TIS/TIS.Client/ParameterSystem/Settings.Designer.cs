namespace TIS.Client.ParameterSystem
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabctrlParameterSystem = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageSystem = new DevExpress.XtraTab.XtraTabPage();
            this.txtSMTP_Vuylsteke = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.iclMedium = new DevExpress.Utils.ImageCollection(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetUknownSecurityParameters = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlParameterSystem)).BeginInit();
            this.tabctrlParameterSystem.SuspendLayout();
            this.tabpageSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTP_Vuylsteke.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlParameterSystem
            // 
            this.tabctrlParameterSystem.Location = new System.Drawing.Point(12, 12);
            this.tabctrlParameterSystem.Name = "tabctrlParameterSystem";
            this.tabctrlParameterSystem.SelectedTabPage = this.tabpageSystem;
            this.tabctrlParameterSystem.Size = new System.Drawing.Size(450, 197);
            this.tabctrlParameterSystem.TabIndex = 0;
            this.tabctrlParameterSystem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageSystem});
            // 
            // tabpageSystem
            // 
            this.tabpageSystem.Controls.Add(this.labelControl3);
            this.tabpageSystem.Controls.Add(this.labelControl2);
            this.tabpageSystem.Controls.Add(this.btnSetUknownSecurityParameters);
            this.tabpageSystem.Controls.Add(this.txtSMTP_Vuylsteke);
            this.tabpageSystem.Controls.Add(this.labelControl1);
            this.tabpageSystem.Name = "tabpageSystem";
            this.tabpageSystem.Size = new System.Drawing.Size(448, 175);
            this.tabpageSystem.Text = "System";
            // 
            // txtSMTP_Vuylsteke
            // 
            this.txtSMTP_Vuylsteke.Location = new System.Drawing.Point(85, 39);
            this.txtSMTP_Vuylsteke.Name = "txtSMTP_Vuylsteke";
            this.txtSMTP_Vuylsteke.Size = new System.Drawing.Size(316, 20);
            this.txtSMTP_Vuylsteke.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SMTP:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ImageIndex = 136;
            this.btnSave.ImageList = this.iclMedium;
            this.btnSave.Location = new System.Drawing.Point(305, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(386, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSetUknownSecurityParameters
            // 
            this.btnSetUknownSecurityParameters.ImageList = this.iclMedium;
            this.btnSetUknownSecurityParameters.Location = new System.Drawing.Point(22, 122);
            this.btnSetUknownSecurityParameters.Name = "btnSetUknownSecurityParameters";
            this.btnSetUknownSecurityParameters.Size = new System.Drawing.Size(208, 23);
            this.btnSetUknownSecurityParameters.TabIndex = 2;
            this.btnSetUknownSecurityParameters.Text = "Set unknwon security parameters";
            this.btnSetUknownSecurityParameters.Click += new System.EventHandler(this.btnSetUknownSecurityParameters_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(21, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Parameters General";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(21, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "User Security";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 263);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabctrlParameterSystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlParameterSystem)).EndInit();
            this.tabctrlParameterSystem.ResumeLayout(false);
            this.tabpageSystem.ResumeLayout(false);
            this.tabpageSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTP_Vuylsteke.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlParameterSystem;
        private DevExpress.XtraTab.XtraTabPage tabpageSystem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.Utils.ImageCollection iclMedium;
        private DevExpress.XtraEditors.TextEdit txtSMTP_Vuylsteke;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSetUknownSecurityParameters;
    }
}
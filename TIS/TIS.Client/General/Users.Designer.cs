namespace TIS.Client.General
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.sbtnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.iclMedium = new DevExpress.Utils.ImageCollection(this.components);
            this.sbtnDetailUser = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnRemoveUser = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gdcUsers = new DevExpress.XtraGrid.GridControl();
            this.gdvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnAddUser
            // 
            this.sbtnAddUser.ImageIndex = 0;
            this.sbtnAddUser.ImageList = this.iclMedium;
            this.sbtnAddUser.Location = new System.Drawing.Point(404, 12);
            this.sbtnAddUser.Name = "sbtnAddUser";
            this.sbtnAddUser.Size = new System.Drawing.Size(117, 32);
            this.sbtnAddUser.TabIndex = 1;
            this.sbtnAddUser.Text = "Add User";
            this.sbtnAddUser.Click += new System.EventHandler(this.sbtnAddUser_Click);
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
            // sbtnDetailUser
            // 
            this.sbtnDetailUser.ImageIndex = 10;
            this.sbtnDetailUser.ImageList = this.iclMedium;
            this.sbtnDetailUser.Location = new System.Drawing.Point(404, 50);
            this.sbtnDetailUser.Name = "sbtnDetailUser";
            this.sbtnDetailUser.Size = new System.Drawing.Size(117, 32);
            this.sbtnDetailUser.TabIndex = 2;
            this.sbtnDetailUser.Text = "Detail User";
            this.sbtnDetailUser.Click += new System.EventHandler(this.sbtnDetailUser_Click);
            // 
            // sbtnRemoveUser
            // 
            this.sbtnRemoveUser.ImageIndex = 19;
            this.sbtnRemoveUser.ImageList = this.iclMedium;
            this.sbtnRemoveUser.Location = new System.Drawing.Point(404, 88);
            this.sbtnRemoveUser.Name = "sbtnRemoveUser";
            this.sbtnRemoveUser.Size = new System.Drawing.Size(117, 32);
            this.sbtnRemoveUser.TabIndex = 3;
            this.sbtnRemoveUser.Text = "Remove User";
            this.sbtnRemoveUser.Click += new System.EventHandler(this.sbtnRemoveUser_Click);
            // 
            // sbtnClose
            // 
            this.sbtnClose.ImageList = this.iclMedium;
            this.sbtnClose.Location = new System.Drawing.Point(404, 375);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(117, 32);
            this.sbtnClose.TabIndex = 4;
            this.sbtnClose.Text = "Close";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // gdcUsers
            // 
            this.gdcUsers.Location = new System.Drawing.Point(12, 12);
            this.gdcUsers.MainView = this.gdvUsers;
            this.gdcUsers.Name = "gdcUsers";
            this.gdcUsers.Size = new System.Drawing.Size(386, 395);
            this.gdcUsers.TabIndex = 5;
            this.gdcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsers});
            // 
            // gdvUsers
            // 
            this.gdvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoActive,
            this.gdcoSurname,
            this.gdcoName,
            this.gdcoLogin});
            this.gdvUsers.GridControl = this.gdcUsers;
            this.gdvUsers.Name = "gdvUsers";
            this.gdvUsers.OptionsBehavior.Editable = false;
            this.gdvUsers.OptionsBehavior.ReadOnly = true;
            this.gdvUsers.OptionsCustomization.AllowGroup = false;
            this.gdvUsers.OptionsView.ShowAutoFilterRow = true;
            this.gdvUsers.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoActive
            // 
            this.gdcoActive.Caption = "Active";
            this.gdcoActive.FieldName = "Active";
            this.gdcoActive.MaxWidth = 50;
            this.gdcoActive.Name = "gdcoActive";
            this.gdcoActive.Visible = true;
            this.gdcoActive.VisibleIndex = 0;
            this.gdcoActive.Width = 50;
            // 
            // gdcoSurname
            // 
            this.gdcoSurname.Caption = "Surname";
            this.gdcoSurname.FieldName = "Surname";
            this.gdcoSurname.Name = "gdcoSurname";
            this.gdcoSurname.Visible = true;
            this.gdcoSurname.VisibleIndex = 1;
            // 
            // gdcoName
            // 
            this.gdcoName.Caption = "Name";
            this.gdcoName.FieldName = "Name";
            this.gdcoName.Name = "gdcoName";
            this.gdcoName.Visible = true;
            this.gdcoName.VisibleIndex = 2;
            // 
            // gdcoLogin
            // 
            this.gdcoLogin.Caption = "Login";
            this.gdcoLogin.FieldName = "Login";
            this.gdcoLogin.Name = "gdcoLogin";
            this.gdcoLogin.Visible = true;
            this.gdcoLogin.VisibleIndex = 3;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 419);
            this.Controls.Add(this.gdcUsers);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.sbtnRemoveUser);
            this.Controls.Add(this.sbtnDetailUser);
            this.Controls.Add(this.sbtnAddUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnAddUser;
        private DevExpress.XtraEditors.SimpleButton sbtnDetailUser;
        private DevExpress.XtraEditors.SimpleButton sbtnRemoveUser;
        private DevExpress.XtraEditors.SimpleButton sbtnClose;
        private DevExpress.XtraGrid.GridControl gdcUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvUsers;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoLogin;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoActive;
        private DevExpress.Utils.ImageCollection iclMedium;
    }
}
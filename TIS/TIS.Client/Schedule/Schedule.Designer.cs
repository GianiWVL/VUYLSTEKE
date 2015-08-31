namespace TIS.Client.Schedule
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.tabctrlSchedule = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageMain = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.datStartdate = new DevExpress.XtraEditors.DateEdit();
            this.txtTimeOfDay = new DevExpress.XtraEditors.TextEdit();
            this.cmbFrequency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSunday = new DevExpress.XtraEditors.CheckEdit();
            this.cbxSaterday = new DevExpress.XtraEditors.CheckEdit();
            this.cbxFriday = new DevExpress.XtraEditors.CheckEdit();
            this.cbxThursday = new DevExpress.XtraEditors.CheckEdit();
            this.cbxWednesday = new DevExpress.XtraEditors.CheckEdit();
            this.cbxTuesday = new DevExpress.XtraEditors.CheckEdit();
            this.cbxMonday = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.iclMedium = new DevExpress.Utils.ImageCollection(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlSchedule)).BeginInit();
            this.tabctrlSchedule.SuspendLayout();
            this.tabpageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datStartdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStartdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeOfDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFrequency.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSunday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSaterday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFriday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxThursday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxWednesday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTuesday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMonday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlSchedule
            // 
            this.tabctrlSchedule.Location = new System.Drawing.Point(12, 12);
            this.tabctrlSchedule.Name = "tabctrlSchedule";
            this.tabctrlSchedule.SelectedTabPage = this.tabpageMain;
            this.tabctrlSchedule.Size = new System.Drawing.Size(268, 275);
            this.tabctrlSchedule.TabIndex = 0;
            this.tabctrlSchedule.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageMain});
            // 
            // tabpageMain
            // 
            this.tabpageMain.Controls.Add(this.labelControl3);
            this.tabpageMain.Controls.Add(this.datStartdate);
            this.tabpageMain.Controls.Add(this.txtTimeOfDay);
            this.tabpageMain.Controls.Add(this.cmbFrequency);
            this.tabpageMain.Controls.Add(this.labelControl2);
            this.tabpageMain.Controls.Add(this.groupBox1);
            this.tabpageMain.Controls.Add(this.labelControl1);
            this.tabpageMain.Name = "tabpageMain";
            this.tabpageMain.Size = new System.Drawing.Size(262, 247);
            this.tabpageMain.Text = "Main";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Start date:";
            // 
            // datStartdate
            // 
            this.datStartdate.EditValue = null;
            this.datStartdate.Location = new System.Drawing.Point(100, 14);
            this.datStartdate.Name = "datStartdate";
            this.datStartdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datStartdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datStartdate.Size = new System.Drawing.Size(146, 20);
            this.datStartdate.TabIndex = 5;
            // 
            // txtTimeOfDay
            // 
            this.txtTimeOfDay.Location = new System.Drawing.Point(100, 217);
            this.txtTimeOfDay.Name = "txtTimeOfDay";
            this.txtTimeOfDay.Properties.DisplayFormat.FormatString = "T";
            this.txtTimeOfDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTimeOfDay.Properties.EditFormat.FormatString = "T";
            this.txtTimeOfDay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTimeOfDay.Properties.Mask.EditMask = "T";
            this.txtTimeOfDay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtTimeOfDay.Size = new System.Drawing.Size(146, 20);
            this.txtTimeOfDay.TabIndex = 4;
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.Location = new System.Drawing.Point(100, 40);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFrequency.Size = new System.Drawing.Size(146, 20);
            this.cmbFrequency.TabIndex = 3;
            this.cmbFrequency.SelectedIndexChanged += new System.EventHandler(this.cmbFrequency_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 220);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Time of day:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSunday);
            this.groupBox1.Controls.Add(this.cbxSaterday);
            this.groupBox1.Controls.Add(this.cbxFriday);
            this.groupBox1.Controls.Add(this.cbxThursday);
            this.groupBox1.Controls.Add(this.cbxWednesday);
            this.groupBox1.Controls.Add(this.cbxTuesday);
            this.groupBox1.Controls.Add(this.cbxMonday);
            this.groupBox1.Location = new System.Drawing.Point(23, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time of week";
            // 
            // cbxSunday
            // 
            this.cbxSunday.Location = new System.Drawing.Point(16, 95);
            this.cbxSunday.Name = "cbxSunday";
            this.cbxSunday.Properties.Caption = "Sunday";
            this.cbxSunday.Size = new System.Drawing.Size(75, 19);
            this.cbxSunday.TabIndex = 6;
            this.cbxSunday.CheckedChanged += new System.EventHandler(this.cbxSunday_CheckedChanged);
            // 
            // cbxSaterday
            // 
            this.cbxSaterday.Location = new System.Drawing.Point(121, 70);
            this.cbxSaterday.Name = "cbxSaterday";
            this.cbxSaterday.Properties.Caption = "Saterday";
            this.cbxSaterday.Size = new System.Drawing.Size(75, 19);
            this.cbxSaterday.TabIndex = 5;
            this.cbxSaterday.CheckedChanged += new System.EventHandler(this.cbxSaterday_CheckedChanged);
            // 
            // cbxFriday
            // 
            this.cbxFriday.Location = new System.Drawing.Point(16, 70);
            this.cbxFriday.Name = "cbxFriday";
            this.cbxFriday.Properties.Caption = "Friday";
            this.cbxFriday.Size = new System.Drawing.Size(75, 19);
            this.cbxFriday.TabIndex = 4;
            this.cbxFriday.CheckedChanged += new System.EventHandler(this.cbxFriday_CheckedChanged);
            // 
            // cbxThursday
            // 
            this.cbxThursday.Location = new System.Drawing.Point(121, 45);
            this.cbxThursday.Name = "cbxThursday";
            this.cbxThursday.Properties.Caption = "Thursday";
            this.cbxThursday.Size = new System.Drawing.Size(75, 19);
            this.cbxThursday.TabIndex = 3;
            this.cbxThursday.CheckedChanged += new System.EventHandler(this.cbxThursday_CheckedChanged);
            // 
            // cbxWednesday
            // 
            this.cbxWednesday.Location = new System.Drawing.Point(16, 45);
            this.cbxWednesday.Name = "cbxWednesday";
            this.cbxWednesday.Properties.Caption = "Wednesday";
            this.cbxWednesday.Size = new System.Drawing.Size(84, 19);
            this.cbxWednesday.TabIndex = 2;
            this.cbxWednesday.CheckedChanged += new System.EventHandler(this.cbxWednesday_CheckedChanged);
            // 
            // cbxTuesday
            // 
            this.cbxTuesday.Location = new System.Drawing.Point(121, 20);
            this.cbxTuesday.Name = "cbxTuesday";
            this.cbxTuesday.Properties.Caption = "Tuesday";
            this.cbxTuesday.Size = new System.Drawing.Size(75, 19);
            this.cbxTuesday.TabIndex = 1;
            this.cbxTuesday.CheckedChanged += new System.EventHandler(this.cbxTuesday_CheckedChanged);
            // 
            // cbxMonday
            // 
            this.cbxMonday.Location = new System.Drawing.Point(16, 20);
            this.cbxMonday.Name = "cbxMonday";
            this.cbxMonday.Properties.Caption = "Monday";
            this.cbxMonday.Size = new System.Drawing.Size(75, 19);
            this.cbxMonday.TabIndex = 0;
            this.cbxMonday.CheckedChanged += new System.EventHandler(this.cbxMonday_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Frequency: ";
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 136;
            this.btnSave.ImageList = this.iclMedium;
            this.btnSave.Location = new System.Drawing.Point(124, 295);
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
            this.btnCancel.Location = new System.Drawing.Point(205, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 339);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabctrlSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlSchedule)).EndInit();
            this.tabctrlSchedule.ResumeLayout(false);
            this.tabpageMain.ResumeLayout(false);
            this.tabpageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datStartdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datStartdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeOfDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFrequency.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxSunday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSaterday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFriday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxThursday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxWednesday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTuesday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMonday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlSchedule;
        private DevExpress.XtraTab.XtraTabPage tabpageMain;
        private DevExpress.XtraEditors.TextEdit txtTimeOfDay;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFrequency;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckEdit cbxSunday;
        private DevExpress.XtraEditors.CheckEdit cbxSaterday;
        private DevExpress.XtraEditors.CheckEdit cbxFriday;
        private DevExpress.XtraEditors.CheckEdit cbxThursday;
        private DevExpress.XtraEditors.CheckEdit cbxWednesday;
        private DevExpress.XtraEditors.CheckEdit cbxTuesday;
        private DevExpress.XtraEditors.CheckEdit cbxMonday;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.Utils.ImageCollection iclMedium;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit datStartdate;
    }
}
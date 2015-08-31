namespace TIS.Client.Employee
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.tabctrlEmployee = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageEmployees = new DevExpress.XtraTab.XtraTabPage();
            this.gdcEmployee = new DevExpress.XtraGrid.GridControl();
            this.gdvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabpageVacation = new DevExpress.XtraTab.XtraTabPage();
            this.gpbReport = new System.Windows.Forms.GroupBox();
            this.btnReportDate = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportDispatcher = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportChronological = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportAlphabetical = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dteReportTo = new DevExpress.XtraEditors.DateEdit();
            this.dteReportFrom = new DevExpress.XtraEditors.DateEdit();
            this.glouReportDispatcher = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glouReportEmployee = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.employeeObjectCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlEmployee)).BeginInit();
            this.tabctrlEmployee.SuspendLayout();
            this.tabpageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabpageVacation.SuspendLayout();
            this.gpbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouReportDispatcher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouReportEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeObjectCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlEmployee
            // 
            this.tabctrlEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlEmployee.Location = new System.Drawing.Point(3, 3);
            this.tabctrlEmployee.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tabctrlEmployee.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabctrlEmployee.Name = "tabctrlEmployee";
            this.tabctrlEmployee.SelectedTabPage = this.tabpageEmployees;
            this.tabctrlEmployee.Size = new System.Drawing.Size(1000, 571);
            this.tabctrlEmployee.TabIndex = 0;
            this.tabctrlEmployee.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageEmployees,
            this.tabpageVacation});
            // 
            // tabpageEmployees
            // 
            this.tabpageEmployees.Controls.Add(this.gdcEmployee);
            this.tabpageEmployees.Name = "tabpageEmployees";
            this.tabpageEmployees.Size = new System.Drawing.Size(994, 543);
            this.tabpageEmployees.Text = "Werknemers";
            // 
            // gdcEmployee
            // 
            this.gdcEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcEmployee.Location = new System.Drawing.Point(3, 3);
            this.gdcEmployee.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcEmployee.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcEmployee.MainView = this.gdvEmployee;
            this.gdcEmployee.Name = "gdcEmployee";
            this.gdcEmployee.Size = new System.Drawing.Size(988, 537);
            this.gdcEmployee.TabIndex = 0;
            this.gdcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvEmployee,
            this.gridView1});
            // 
            // gdvEmployee
            // 
            this.gdvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoSurname,
            this.gdcoName,
            this.gdcoEmail});
            this.gdvEmployee.GridControl = this.gdcEmployee;
            this.gdvEmployee.Name = "gdvEmployee";
            this.gdvEmployee.OptionsBehavior.Editable = false;
            this.gdvEmployee.OptionsBehavior.ReadOnly = true;
            this.gdvEmployee.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvEmployee.OptionsView.ColumnAutoWidth = false;
            this.gdvEmployee.OptionsView.ShowAutoFilterRow = true;
            this.gdvEmployee.OptionsView.ShowGroupPanel = false;
            this.gdvEmployee.DoubleClick += new System.EventHandler(this.gdvEmployee_DoubleClick);
            // 
            // gdcoSurname
            // 
            this.gdcoSurname.Caption = "Achternaam";
            this.gdcoSurname.FieldName = "Surname";
            this.gdcoSurname.Name = "gdcoSurname";
            this.gdcoSurname.Visible = true;
            this.gdcoSurname.VisibleIndex = 0;
            this.gdcoSurname.Width = 150;
            // 
            // gdcoName
            // 
            this.gdcoName.Caption = "Voornaam";
            this.gdcoName.FieldName = "Name";
            this.gdcoName.Name = "gdcoName";
            this.gdcoName.Visible = true;
            this.gdcoName.VisibleIndex = 1;
            this.gdcoName.Width = 150;
            // 
            // gdcoEmail
            // 
            this.gdcoEmail.Caption = "Email";
            this.gdcoEmail.FieldName = "Email";
            this.gdcoEmail.Name = "gdcoEmail";
            this.gdcoEmail.Visible = true;
            this.gdcoEmail.VisibleIndex = 2;
            this.gdcoEmail.Width = 150;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdcEmployee;
            this.gridView1.Name = "gridView1";
            // 
            // tabpageVacation
            // 
            this.tabpageVacation.Controls.Add(this.gpbReport);
            this.tabpageVacation.Name = "tabpageVacation";
            this.tabpageVacation.Size = new System.Drawing.Size(994, 543);
            this.tabpageVacation.Text = "Verlof";
            // 
            // gpbReport
            // 
            this.gpbReport.Controls.Add(this.btnReportDate);
            this.gpbReport.Controls.Add(this.btnReportDispatcher);
            this.gpbReport.Controls.Add(this.btnReportChronological);
            this.gpbReport.Controls.Add(this.btnReportAlphabetical);
            this.gpbReport.Controls.Add(this.btnReportEmployee);
            this.gpbReport.Controls.Add(this.labelControl4);
            this.gpbReport.Controls.Add(this.dteReportTo);
            this.gpbReport.Controls.Add(this.dteReportFrom);
            this.gpbReport.Controls.Add(this.glouReportDispatcher);
            this.gpbReport.Controls.Add(this.glouReportEmployee);
            this.gpbReport.Controls.Add(this.labelControl3);
            this.gpbReport.Controls.Add(this.labelControl2);
            this.gpbReport.Controls.Add(this.labelControl1);
            this.gpbReport.Location = new System.Drawing.Point(3, 3);
            this.gpbReport.Name = "gpbReport";
            this.gpbReport.Size = new System.Drawing.Size(463, 243);
            this.gpbReport.TabIndex = 13;
            this.gpbReport.TabStop = false;
            this.gpbReport.Text = "Rapporten";
            // 
            // btnReportDate
            // 
            this.btnReportDate.Location = new System.Drawing.Point(325, 75);
            this.btnReportDate.Name = "btnReportDate";
            this.btnReportDate.Size = new System.Drawing.Size(100, 20);
            this.btnReportDate.TabIndex = 21;
            this.btnReportDate.Text = "Rapport";
            this.btnReportDate.Click += new System.EventHandler(this.btnReportDate_Click);
            // 
            // btnReportDispatcher
            // 
            this.btnReportDispatcher.Location = new System.Drawing.Point(325, 49);
            this.btnReportDispatcher.Name = "btnReportDispatcher";
            this.btnReportDispatcher.Size = new System.Drawing.Size(100, 20);
            this.btnReportDispatcher.TabIndex = 20;
            this.btnReportDispatcher.Text = "Rapport";
            this.btnReportDispatcher.Click += new System.EventHandler(this.btnReportDispatcher_Click);
            // 
            // btnReportChronological
            // 
            this.btnReportChronological.Location = new System.Drawing.Point(21, 190);
            this.btnReportChronological.Name = "btnReportChronological";
            this.btnReportChronological.Size = new System.Drawing.Size(298, 20);
            this.btnReportChronological.TabIndex = 19;
            this.btnReportChronological.Text = "Alle verloven per chronologisch";
            this.btnReportChronological.Click += new System.EventHandler(this.btnReportChronological_Click);
            // 
            // btnReportAlphabetical
            // 
            this.btnReportAlphabetical.Location = new System.Drawing.Point(21, 164);
            this.btnReportAlphabetical.Name = "btnReportAlphabetical";
            this.btnReportAlphabetical.Size = new System.Drawing.Size(298, 20);
            this.btnReportAlphabetical.TabIndex = 18;
            this.btnReportAlphabetical.Text = "Alle verloven alfabetisch";
            this.btnReportAlphabetical.Click += new System.EventHandler(this.btnReportAlphabetical_Click);
            // 
            // btnReportEmployee
            // 
            this.btnReportEmployee.Location = new System.Drawing.Point(325, 23);
            this.btnReportEmployee.Name = "btnReportEmployee";
            this.btnReportEmployee.Size = new System.Drawing.Size(100, 20);
            this.btnReportEmployee.TabIndex = 14;
            this.btnReportEmployee.Text = "Rapport";
            this.btnReportEmployee.Click += new System.EventHandler(this.btnReportEmployee_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(205, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "tot";
            // 
            // dteReportTo
            // 
            this.dteReportTo.EditValue = null;
            this.dteReportTo.Location = new System.Drawing.Point(225, 75);
            this.dteReportTo.Name = "dteReportTo";
            this.dteReportTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteReportTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteReportTo.Size = new System.Drawing.Size(94, 20);
            this.dteReportTo.TabIndex = 16;
            // 
            // dteReportFrom
            // 
            this.dteReportFrom.EditValue = null;
            this.dteReportFrom.Location = new System.Drawing.Point(105, 75);
            this.dteReportFrom.Name = "dteReportFrom";
            this.dteReportFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteReportFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteReportFrom.Size = new System.Drawing.Size(94, 20);
            this.dteReportFrom.TabIndex = 14;
            // 
            // glouReportDispatcher
            // 
            this.glouReportDispatcher.Location = new System.Drawing.Point(105, 49);
            this.glouReportDispatcher.Name = "glouReportDispatcher";
            this.glouReportDispatcher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glouReportDispatcher.Properties.NullText = "";
            this.glouReportDispatcher.Properties.View = this.gridView4;
            this.glouReportDispatcher.Size = new System.Drawing.Size(214, 20);
            this.glouReportDispatcher.TabIndex = 15;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Naam";
            this.gridColumn2.FieldName = "DisplayName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // glouReportEmployee
            // 
            this.glouReportEmployee.Location = new System.Drawing.Point(105, 23);
            this.glouReportEmployee.Name = "glouReportEmployee";
            this.glouReportEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glouReportEmployee.Properties.NullText = "";
            this.glouReportEmployee.Properties.View = this.gridView3;
            this.glouReportEmployee.Size = new System.Drawing.Size(214, 20);
            this.glouReportEmployee.TabIndex = 14;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Naam";
            this.gridColumn1.FieldName = "DisplayName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Verlof van";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Per dispatcher:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Per werknemer:";
            // 
            // employeeObjectCollectionBindingSource
            // 
            this.employeeObjectCollectionBindingSource.DataSource = typeof(TIS.DL.Internal.Employee.EmployeeObjectCollection);
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
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlEmployee);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(1006, 577);
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlEmployee)).EndInit();
            this.tabctrlEmployee.ResumeLayout(false);
            this.tabpageEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabpageVacation.ResumeLayout(false);
            this.gpbReport.ResumeLayout(false);
            this.gpbReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteReportFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouReportDispatcher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouReportEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeObjectCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlEmployee;
        private DevExpress.XtraTab.XtraTabPage tabpageEmployees;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraGrid.GridControl gdcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoEmail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage tabpageVacation;
        private System.Windows.Forms.BindingSource employeeObjectCollectionBindingSource;
        private System.Windows.Forms.GroupBox gpbReport;
        private DevExpress.XtraEditors.SimpleButton btnReportChronological;
        private DevExpress.XtraEditors.SimpleButton btnReportAlphabetical;
        private DevExpress.XtraEditors.SimpleButton btnReportEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dteReportTo;
        private DevExpress.XtraEditors.DateEdit dteReportFrom;
        private DevExpress.XtraEditors.GridLookUpEdit glouReportDispatcher;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GridLookUpEdit glouReportEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReportDate;
        private DevExpress.XtraEditors.SimpleButton btnReportDispatcher;
    }
}
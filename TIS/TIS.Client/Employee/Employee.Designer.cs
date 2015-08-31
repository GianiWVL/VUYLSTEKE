namespace TIS.Client.Employee
{
    partial class Employee
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.gdvReporters = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoReporterEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcTask = new DevExpress.XtraGrid.GridControl();
            this.gdvAssigneeEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoEmployeeEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvAssigneeSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoSupplierEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvAssigneeUnknown = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoUnknownEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvSubscriptions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoFrequency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoMonday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoTuesday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoWednesday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoThursday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoFriday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoSaterday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoSunday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoStartdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoTag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDueDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gdcoStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoEffort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iclMedium = new DevExpress.Utils.ImageCollection(this.components);
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tabctrlEmployee = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageVacation = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.teTimeTo = new DevExpress.XtraEditors.TimeEdit();
            this.teTimeFrom = new DevExpress.XtraEditors.TimeEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnRemoveVacation = new DevExpress.XtraEditors.SimpleButton();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.glouVacationType = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gdvVacationType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoVacationTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddVacation = new DevExpress.XtraEditors.SimpleButton();
            this.dteDateTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.dteDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.lblDispatcher = new DevExpress.XtraEditors.LabelControl();
            this.glouDispatcher = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoVacationDispatcherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcVacation = new DevExpress.XtraGrid.GridControl();
            this.gdvVacation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoDispatcher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoVacationType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gdcoTimeFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoTimeTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabpageTasks = new DevExpress.XtraTab.XtraTabPage();
            this.cbxRepeatMail = new DevExpress.XtraEditors.CheckEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRemoveTask = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTask = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReporters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeUnknown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlEmployee)).BeginInit();
            this.tabctrlEmployee.SuspendLayout();
            this.tabpageVacation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTimeTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTimeFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouVacationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVacationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouDispatcher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.tabpageTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRepeatMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvReporters
            // 
            this.gdvReporters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoReporterEmail});
            this.gdvReporters.GridControl = this.gdcTask;
            this.gdvReporters.Name = "gdvReporters";
            this.gdvReporters.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gdvReporters.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoReporterEmail
            // 
            this.gdcoReporterEmail.Caption = "Email";
            this.gdcoReporterEmail.FieldName = "Employee.Email";
            this.gdcoReporterEmail.Name = "gdcoReporterEmail";
            this.gdcoReporterEmail.OptionsColumn.AllowEdit = false;
            this.gdcoReporterEmail.Visible = true;
            this.gdcoReporterEmail.VisibleIndex = 0;
            // 
            // gdcTask
            // 
            this.gdcTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.LevelTemplate = this.gdvReporters;
            gridLevelNode1.RelationName = "Reporters";
            gridLevelNode2.LevelTemplate = this.gdvAssigneeEmployee;
            gridLevelNode2.RelationName = "AssigneesEmployee";
            gridLevelNode3.LevelTemplate = this.gdvAssigneeSupplier;
            gridLevelNode3.RelationName = "AssigneesSupplier";
            gridLevelNode4.LevelTemplate = this.gdvAssigneeUnknown;
            gridLevelNode4.RelationName = "AssigneesUnknown";
            gridLevelNode5.LevelTemplate = this.gdvSubscriptions;
            gridLevelNode5.RelationName = "Subscriptions";
            this.gdcTask.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3,
            gridLevelNode4,
            gridLevelNode5});
            this.gdcTask.Location = new System.Drawing.Point(39, 61);
            this.gdcTask.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcTask.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcTask.MainView = this.gdvTask;
            this.gdcTask.Name = "gdcTask";
            this.gdcTask.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDueDate});
            this.gdcTask.Size = new System.Drawing.Size(878, 321);
            this.gdcTask.TabIndex = 2;
            this.gdcTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvAssigneeEmployee,
            this.gdvAssigneeSupplier,
            this.gdvAssigneeUnknown,
            this.gdvSubscriptions,
            this.gdvTask,
            this.gdvReporters});
            // 
            // gdvAssigneeEmployee
            // 
            this.gdvAssigneeEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoEmployeeEmail});
            this.gdvAssigneeEmployee.GridControl = this.gdcTask;
            this.gdvAssigneeEmployee.Name = "gdvAssigneeEmployee";
            this.gdvAssigneeEmployee.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gdvAssigneeEmployee.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoEmployeeEmail
            // 
            this.gdcoEmployeeEmail.Caption = "Email";
            this.gdcoEmployeeEmail.FieldName = "Employee.Email";
            this.gdcoEmployeeEmail.Name = "gdcoEmployeeEmail";
            this.gdcoEmployeeEmail.OptionsColumn.AllowEdit = false;
            this.gdcoEmployeeEmail.Visible = true;
            this.gdcoEmployeeEmail.VisibleIndex = 0;
            // 
            // gdvAssigneeSupplier
            // 
            this.gdvAssigneeSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoSupplierEmail});
            this.gdvAssigneeSupplier.GridControl = this.gdcTask;
            this.gdvAssigneeSupplier.Name = "gdvAssigneeSupplier";
            this.gdvAssigneeSupplier.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gdvAssigneeSupplier.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoSupplierEmail
            // 
            this.gdcoSupplierEmail.Caption = "Email";
            this.gdcoSupplierEmail.FieldName = "Supplier.Email";
            this.gdcoSupplierEmail.Name = "gdcoSupplierEmail";
            this.gdcoSupplierEmail.OptionsColumn.AllowEdit = false;
            this.gdcoSupplierEmail.Visible = true;
            this.gdcoSupplierEmail.VisibleIndex = 0;
            // 
            // gdvAssigneeUnknown
            // 
            this.gdvAssigneeUnknown.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoUnknownEmail});
            this.gdvAssigneeUnknown.GridControl = this.gdcTask;
            this.gdvAssigneeUnknown.Name = "gdvAssigneeUnknown";
            this.gdvAssigneeUnknown.OptionsDetail.AllowExpandEmptyDetails = true;
            // 
            // gdcoUnknownEmail
            // 
            this.gdcoUnknownEmail.Caption = "Email";
            this.gdcoUnknownEmail.FieldName = "Unknown.Email";
            this.gdcoUnknownEmail.Name = "gdcoUnknownEmail";
            this.gdcoUnknownEmail.OptionsColumn.AllowEdit = false;
            this.gdcoUnknownEmail.Visible = true;
            this.gdcoUnknownEmail.VisibleIndex = 0;
            // 
            // gdvSubscriptions
            // 
            this.gdvSubscriptions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoFrequency,
            this.gdcoMonday,
            this.gdcoTuesday,
            this.gdcoWednesday,
            this.gdcoThursday,
            this.gdcoFriday,
            this.gdcoSaterday,
            this.gdcoSunday,
            this.gdcoStartdate,
            this.gdcoTime});
            this.gdvSubscriptions.GridControl = this.gdcTask;
            this.gdvSubscriptions.Name = "gdvSubscriptions";
            this.gdvSubscriptions.OptionsDetail.AllowExpandEmptyDetails = true;
            // 
            // gdcoFrequency
            // 
            this.gdcoFrequency.Caption = "Frequency";
            this.gdcoFrequency.FieldName = "Schedule.Frequency";
            this.gdcoFrequency.Name = "gdcoFrequency";
            this.gdcoFrequency.OptionsColumn.AllowEdit = false;
            this.gdcoFrequency.Visible = true;
            this.gdcoFrequency.VisibleIndex = 0;
            // 
            // gdcoMonday
            // 
            this.gdcoMonday.Caption = "Monday";
            this.gdcoMonday.FieldName = "Schedule.Monday";
            this.gdcoMonday.Name = "gdcoMonday";
            this.gdcoMonday.OptionsColumn.AllowEdit = false;
            this.gdcoMonday.Visible = true;
            this.gdcoMonday.VisibleIndex = 1;
            // 
            // gdcoTuesday
            // 
            this.gdcoTuesday.Caption = "Tuesday";
            this.gdcoTuesday.FieldName = "Schedule.Tuesday";
            this.gdcoTuesday.Name = "gdcoTuesday";
            this.gdcoTuesday.OptionsColumn.AllowEdit = false;
            this.gdcoTuesday.Visible = true;
            this.gdcoTuesday.VisibleIndex = 2;
            // 
            // gdcoWednesday
            // 
            this.gdcoWednesday.Caption = "Wednesday";
            this.gdcoWednesday.FieldName = "Schedule.Wednesday";
            this.gdcoWednesday.Name = "gdcoWednesday";
            this.gdcoWednesday.OptionsColumn.AllowEdit = false;
            this.gdcoWednesday.Visible = true;
            this.gdcoWednesday.VisibleIndex = 3;
            // 
            // gdcoThursday
            // 
            this.gdcoThursday.Caption = "Thursday";
            this.gdcoThursday.FieldName = "Schedule.Thursday";
            this.gdcoThursday.Name = "gdcoThursday";
            this.gdcoThursday.OptionsColumn.AllowEdit = false;
            this.gdcoThursday.Visible = true;
            this.gdcoThursday.VisibleIndex = 4;
            // 
            // gdcoFriday
            // 
            this.gdcoFriday.Caption = "Friday";
            this.gdcoFriday.FieldName = "Schedule.Friday";
            this.gdcoFriday.Name = "gdcoFriday";
            this.gdcoFriday.OptionsColumn.AllowEdit = false;
            this.gdcoFriday.Visible = true;
            this.gdcoFriday.VisibleIndex = 5;
            // 
            // gdcoSaterday
            // 
            this.gdcoSaterday.Caption = "Saterday";
            this.gdcoSaterday.FieldName = "Schedule.Saterday";
            this.gdcoSaterday.Name = "gdcoSaterday";
            this.gdcoSaterday.OptionsColumn.AllowEdit = false;
            this.gdcoSaterday.Visible = true;
            this.gdcoSaterday.VisibleIndex = 6;
            // 
            // gdcoSunday
            // 
            this.gdcoSunday.Caption = "Sunday";
            this.gdcoSunday.FieldName = "Schedule.Sunday";
            this.gdcoSunday.Name = "gdcoSunday";
            this.gdcoSunday.OptionsColumn.AllowEdit = false;
            this.gdcoSunday.Visible = true;
            this.gdcoSunday.VisibleIndex = 7;
            // 
            // gdcoStartdate
            // 
            this.gdcoStartdate.Caption = "Startdate";
            this.gdcoStartdate.FieldName = "Schedule.StartDateDisplay";
            this.gdcoStartdate.Name = "gdcoStartdate";
            this.gdcoStartdate.OptionsColumn.AllowEdit = false;
            this.gdcoStartdate.Visible = true;
            this.gdcoStartdate.VisibleIndex = 8;
            // 
            // gdcoTime
            // 
            this.gdcoTime.Caption = "Time";
            this.gdcoTime.FieldName = "Schedule.TimeDisplay";
            this.gdcoTime.Name = "gdcoTime";
            this.gdcoTime.OptionsColumn.AllowEdit = false;
            this.gdcoTime.Visible = true;
            this.gdcoTime.VisibleIndex = 9;
            // 
            // gdvTask
            // 
            this.gdvTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoTag,
            this.gdcoCreationDate,
            this.gdcoDueDate,
            this.gdcoStatus,
            this.gdcoPriority,
            this.gdcoEffort});
            this.gdvTask.GridControl = this.gdcTask;
            this.gdvTask.Name = "gdvTask";
            this.gdvTask.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gdvTask.OptionsView.ShowAutoFilterRow = true;
            this.gdvTask.OptionsView.ShowGroupPanel = false;
            this.gdvTask.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.gdvTask_MasterRowExpanding);
            this.gdvTask.DoubleClick += new System.EventHandler(this.gdvTask_DoubleClick);
            // 
            // gdcoTag
            // 
            this.gdcoTag.Caption = "Task ID";
            this.gdcoTag.FieldName = "Tag";
            this.gdcoTag.Name = "gdcoTag";
            this.gdcoTag.OptionsColumn.AllowEdit = false;
            this.gdcoTag.Visible = true;
            this.gdcoTag.VisibleIndex = 0;
            // 
            // gdcoCreationDate
            // 
            this.gdcoCreationDate.Caption = "Creation Date";
            this.gdcoCreationDate.FieldName = "CreationDateDisplay";
            this.gdcoCreationDate.Name = "gdcoCreationDate";
            this.gdcoCreationDate.OptionsColumn.AllowEdit = false;
            this.gdcoCreationDate.Visible = true;
            this.gdcoCreationDate.VisibleIndex = 1;
            // 
            // gdcoDueDate
            // 
            this.gdcoDueDate.Caption = "Due Date";
            this.gdcoDueDate.ColumnEdit = this.repositoryItemDateEditDueDate;
            this.gdcoDueDate.FieldName = "DueDateDisplay";
            this.gdcoDueDate.Name = "gdcoDueDate";
            this.gdcoDueDate.OptionsColumn.AllowEdit = false;
            this.gdcoDueDate.Visible = true;
            this.gdcoDueDate.VisibleIndex = 2;
            // 
            // repositoryItemDateEditDueDate
            // 
            this.repositoryItemDateEditDueDate.AutoHeight = false;
            this.repositoryItemDateEditDueDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDueDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEditDueDate.Name = "repositoryItemDateEditDueDate";
            // 
            // gdcoStatus
            // 
            this.gdcoStatus.Caption = "Status";
            this.gdcoStatus.FieldName = "Status";
            this.gdcoStatus.Name = "gdcoStatus";
            this.gdcoStatus.OptionsColumn.AllowEdit = false;
            this.gdcoStatus.Visible = true;
            this.gdcoStatus.VisibleIndex = 3;
            // 
            // gdcoPriority
            // 
            this.gdcoPriority.Caption = "Priority";
            this.gdcoPriority.FieldName = "Priority";
            this.gdcoPriority.Name = "gdcoPriority";
            this.gdcoPriority.OptionsColumn.AllowEdit = false;
            this.gdcoPriority.Visible = true;
            this.gdcoPriority.VisibleIndex = 4;
            // 
            // gdcoEffort
            // 
            this.gdcoEffort.Caption = "Effort";
            this.gdcoEffort.FieldName = "Effort";
            this.gdcoEffort.Name = "gdcoEffort";
            this.gdcoEffort.OptionsColumn.AllowEdit = false;
            this.gdcoEffort.Visible = true;
            this.gdcoEffort.VisibleIndex = 5;
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
            this.btnOk.Location = new System.Drawing.Point(791, 444);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Save";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageIndex = 120;
            this.btnCancel.ImageList = this.iclMedium;
            this.btnCancel.Location = new System.Drawing.Point(872, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabctrlEmployee
            // 
            this.tabctrlEmployee.Location = new System.Drawing.Point(12, 12);
            this.tabctrlEmployee.Name = "tabctrlEmployee";
            this.tabctrlEmployee.SelectedTabPage = this.tabpageVacation;
            this.tabctrlEmployee.Size = new System.Drawing.Size(940, 426);
            this.tabctrlEmployee.TabIndex = 10;
            this.tabctrlEmployee.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageVacation,
            this.tabpageTasks});
            // 
            // tabpageVacation
            // 
            this.tabpageVacation.Controls.Add(this.labelControl8);
            this.tabpageVacation.Controls.Add(this.labelControl7);
            this.tabpageVacation.Controls.Add(this.teTimeTo);
            this.tabpageVacation.Controls.Add(this.teTimeFrom);
            this.tabpageVacation.Controls.Add(this.txtDescription);
            this.tabpageVacation.Controls.Add(this.labelControl6);
            this.tabpageVacation.Controls.Add(this.btnRemoveVacation);
            this.tabpageVacation.Controls.Add(this.labelControl4);
            this.tabpageVacation.Controls.Add(this.glouVacationType);
            this.tabpageVacation.Controls.Add(this.btnAddVacation);
            this.tabpageVacation.Controls.Add(this.dteDateTo);
            this.tabpageVacation.Controls.Add(this.labelControl5);
            this.tabpageVacation.Controls.Add(this.lblDate);
            this.tabpageVacation.Controls.Add(this.dteDateFrom);
            this.tabpageVacation.Controls.Add(this.lblDispatcher);
            this.tabpageVacation.Controls.Add(this.glouDispatcher);
            this.tabpageVacation.Controls.Add(this.gdcVacation);
            this.tabpageVacation.Name = "tabpageVacation";
            this.tabpageVacation.Size = new System.Drawing.Size(934, 398);
            this.tabpageVacation.Text = "Verlof";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 113);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 13);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "Nieuw uur / Van";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(207, 113);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(16, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Tot";
            // 
            // teTimeTo
            // 
            this.teTimeTo.EditValue = new System.DateTime(2014, 9, 5, 0, 0, 0, 0);
            this.teTimeTo.Location = new System.Drawing.Point(226, 110);
            this.teTimeTo.Name = "teTimeTo";
            this.teTimeTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teTimeTo.Properties.Mask.EditMask = "t";
            this.teTimeTo.Size = new System.Drawing.Size(73, 20);
            this.teTimeTo.TabIndex = 29;
            // 
            // teTimeFrom
            // 
            this.teTimeFrom.EditValue = new System.DateTime(2014, 9, 5, 0, 0, 0, 0);
            this.teTimeFrom.Location = new System.Drawing.Point(129, 110);
            this.teTimeFrom.Name = "teTimeFrom";
            this.teTimeFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teTimeFrom.Properties.Mask.EditMask = "t";
            this.teTimeFrom.Size = new System.Drawing.Size(73, 20);
            this.teTimeFrom.TabIndex = 28;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(129, 135);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 20);
            this.txtDescription.TabIndex = 27;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 138);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 13);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Omschrijving";
            // 
            // btnRemoveVacation
            // 
            this.btnRemoveVacation.ImageIndex = 21;
            this.btnRemoveVacation.ImageList = this.iclSmall;
            this.btnRemoveVacation.Location = new System.Drawing.Point(16, 161);
            this.btnRemoveVacation.Name = "btnRemoveVacation";
            this.btnRemoveVacation.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveVacation.TabIndex = 25;
            this.btnRemoveVacation.Click += new System.EventHandler(this.btnRemoveVacation_Click);
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Type";
            // 
            // glouVacationType
            // 
            this.glouVacationType.EditValue = "";
            this.glouVacationType.Location = new System.Drawing.Point(129, 57);
            this.glouVacationType.Name = "glouVacationType";
            this.glouVacationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glouVacationType.Properties.NullText = "";
            this.glouVacationType.Properties.View = this.gdvVacationType;
            this.glouVacationType.Size = new System.Drawing.Size(170, 20);
            this.glouVacationType.TabIndex = 1;
            // 
            // gdvVacationType
            // 
            this.gdvVacationType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoVacationTypeName});
            this.gdvVacationType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gdvVacationType.Name = "gdvVacationType";
            this.gdvVacationType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvVacationType.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoVacationTypeName
            // 
            this.gdcoVacationTypeName.Caption = "Naam";
            this.gdcoVacationTypeName.FieldName = "Name";
            this.gdcoVacationTypeName.Name = "gdcoVacationTypeName";
            this.gdcoVacationTypeName.Visible = true;
            this.gdcoVacationTypeName.VisibleIndex = 0;
            // 
            // btnAddVacation
            // 
            this.btnAddVacation.Location = new System.Drawing.Point(402, 135);
            this.btnAddVacation.Name = "btnAddVacation";
            this.btnAddVacation.Size = new System.Drawing.Size(79, 20);
            this.btnAddVacation.TabIndex = 4;
            this.btnAddVacation.Text = "Toevoegen";
            this.btnAddVacation.Click += new System.EventHandler(this.btnAddVacation_Click);
            // 
            // dteDateTo
            // 
            this.dteDateTo.EditValue = null;
            this.dteDateTo.Location = new System.Drawing.Point(327, 83);
            this.dteDateTo.Name = "dteDateTo";
            this.dteDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateTo.Size = new System.Drawing.Size(170, 20);
            this.dteDateTo.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(305, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(16, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Tot";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(16, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 13);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Nieuwe datum / Van";
            // 
            // dteDateFrom
            // 
            this.dteDateFrom.EditValue = null;
            this.dteDateFrom.Location = new System.Drawing.Point(129, 83);
            this.dteDateFrom.Name = "dteDateFrom";
            this.dteDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateFrom.Size = new System.Drawing.Size(170, 20);
            this.dteDateFrom.TabIndex = 2;
            this.dteDateFrom.EditValueChanged += new System.EventHandler(this.dteDateFrom_EditValueChanged);
            // 
            // lblDispatcher
            // 
            this.lblDispatcher.Location = new System.Drawing.Point(16, 34);
            this.lblDispatcher.Name = "lblDispatcher";
            this.lblDispatcher.Size = new System.Drawing.Size(51, 13);
            this.lblDispatcher.TabIndex = 17;
            this.lblDispatcher.Text = "Dispatcher";
            // 
            // glouDispatcher
            // 
            this.glouDispatcher.EditValue = "";
            this.glouDispatcher.Location = new System.Drawing.Point(129, 31);
            this.glouDispatcher.Name = "glouDispatcher";
            this.glouDispatcher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glouDispatcher.Properties.NullText = "";
            this.glouDispatcher.Properties.View = this.gridView2;
            this.glouDispatcher.Size = new System.Drawing.Size(170, 20);
            this.glouDispatcher.TabIndex = 0;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoVacationDispatcherName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoVacationDispatcherName
            // 
            this.gdcoVacationDispatcherName.Caption = "Naam";
            this.gdcoVacationDispatcherName.FieldName = "DisplayName";
            this.gdcoVacationDispatcherName.Name = "gdcoVacationDispatcherName";
            this.gdcoVacationDispatcherName.Visible = true;
            this.gdcoVacationDispatcherName.VisibleIndex = 0;
            // 
            // gdcVacation
            // 
            this.gdcVacation.Location = new System.Drawing.Point(47, 161);
            this.gdcVacation.MainView = this.gdvVacation;
            this.gdcVacation.Name = "gdcVacation";
            this.gdcVacation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gdcVacation.Size = new System.Drawing.Size(870, 222);
            this.gdcVacation.TabIndex = 12;
            this.gdcVacation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvVacation});
            // 
            // gdvVacation
            // 
            this.gdvVacation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoDispatcher,
            this.gdcoVacationType,
            this.gdcoDateFrom,
            this.gdcoDateTo,
            this.gdcoTimeFrom,
            this.gdcoTimeTo,
            this.gdcoDescription});
            this.gdvVacation.GridControl = this.gdcVacation;
            this.gdvVacation.Name = "gdvVacation";
            this.gdvVacation.OptionsBehavior.Editable = false;
            this.gdvVacation.OptionsBehavior.ReadOnly = true;
            this.gdvVacation.OptionsCustomization.AllowColumnMoving = false;
            this.gdvVacation.OptionsCustomization.AllowGroup = false;
            this.gdvVacation.OptionsFind.AllowFindPanel = false;
            this.gdvVacation.OptionsView.ColumnAutoWidth = false;
            this.gdvVacation.OptionsView.ShowAutoFilterRow = true;
            this.gdvVacation.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoDispatcher
            // 
            this.gdcoDispatcher.Caption = "Dispatcher";
            this.gdcoDispatcher.FieldName = "Dispatcher.Name";
            this.gdcoDispatcher.Name = "gdcoDispatcher";
            this.gdcoDispatcher.Visible = true;
            this.gdcoDispatcher.VisibleIndex = 0;
            this.gdcoDispatcher.Width = 150;
            // 
            // gdcoVacationType
            // 
            this.gdcoVacationType.Caption = "Type";
            this.gdcoVacationType.FieldName = "VacationType.Name";
            this.gdcoVacationType.Name = "gdcoVacationType";
            this.gdcoVacationType.Visible = true;
            this.gdcoVacationType.VisibleIndex = 1;
            this.gdcoVacationType.Width = 150;
            // 
            // gdcoDateFrom
            // 
            this.gdcoDateFrom.Caption = "Datum Van";
            this.gdcoDateFrom.FieldName = "DateFrom";
            this.gdcoDateFrom.Name = "gdcoDateFrom";
            this.gdcoDateFrom.Visible = true;
            this.gdcoDateFrom.VisibleIndex = 2;
            this.gdcoDateFrom.Width = 100;
            // 
            // gdcoDateTo
            // 
            this.gdcoDateTo.Caption = "Datum Tot";
            this.gdcoDateTo.FieldName = "DateTo";
            this.gdcoDateTo.Name = "gdcoDateTo";
            this.gdcoDateTo.Visible = true;
            this.gdcoDateTo.VisibleIndex = 3;
            this.gdcoDateTo.Width = 100;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.NullDate = new System.DateTime(((long)(0)));
            // 
            // gdcoTimeFrom
            // 
            this.gdcoTimeFrom.Caption = "Tijdstip Van";
            this.gdcoTimeFrom.ColumnEdit = this.repositoryItemDateEdit1;
            this.gdcoTimeFrom.DisplayFormat.FormatString = "t";
            this.gdcoTimeFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gdcoTimeFrom.FieldName = "TimeFrom";
            this.gdcoTimeFrom.Name = "gdcoTimeFrom";
            this.gdcoTimeFrom.Visible = true;
            this.gdcoTimeFrom.VisibleIndex = 4;
            this.gdcoTimeFrom.Width = 100;
            // 
            // gdcoTimeTo
            // 
            this.gdcoTimeTo.Caption = "Tijdstip Tot";
            this.gdcoTimeTo.DisplayFormat.FormatString = "t";
            this.gdcoTimeTo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gdcoTimeTo.FieldName = "TimeTo";
            this.gdcoTimeTo.Name = "gdcoTimeTo";
            this.gdcoTimeTo.Visible = true;
            this.gdcoTimeTo.VisibleIndex = 5;
            this.gdcoTimeTo.Width = 100;
            // 
            // gdcoDescription
            // 
            this.gdcoDescription.Caption = "Omschrijving";
            this.gdcoDescription.FieldName = "Description";
            this.gdcoDescription.Name = "gdcoDescription";
            this.gdcoDescription.Visible = true;
            this.gdcoDescription.VisibleIndex = 6;
            this.gdcoDescription.Width = 250;
            // 
            // tabpageTasks
            // 
            this.tabpageTasks.Controls.Add(this.cbxRepeatMail);
            this.tabpageTasks.Controls.Add(this.txtEmail);
            this.tabpageTasks.Controls.Add(this.labelControl3);
            this.tabpageTasks.Controls.Add(this.labelControl2);
            this.tabpageTasks.Controls.Add(this.txtSurname);
            this.tabpageTasks.Controls.Add(this.txtName);
            this.tabpageTasks.Controls.Add(this.labelControl1);
            this.tabpageTasks.Controls.Add(this.btnRemoveTask);
            this.tabpageTasks.Controls.Add(this.btnAddTask);
            this.tabpageTasks.Controls.Add(this.gdcTask);
            this.tabpageTasks.Name = "tabpageTasks";
            this.tabpageTasks.Size = new System.Drawing.Size(934, 398);
            this.tabpageTasks.Text = "Taken";
            // 
            // cbxRepeatMail
            // 
            this.cbxRepeatMail.Location = new System.Drawing.Point(838, 20);
            this.cbxRepeatMail.Name = "cbxRepeatMail";
            this.cbxRepeatMail.Properties.Caption = "Repeat Mail";
            this.cbxRepeatMail.Size = new System.Drawing.Size(79, 19);
            this.cbxRepeatMail.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(543, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(509, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Email:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(254, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Achternaam:";
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(322, 20);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(158, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(76, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Naam:";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.ImageIndex = 21;
            this.btnRemoveTask.ImageList = this.iclSmall;
            this.btnRemoveTask.Location = new System.Drawing.Point(9, 91);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveTask.TabIndex = 4;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.ImageIndex = 27;
            this.btnAddTask.ImageList = this.iclSmall;
            this.btnAddTask.Location = new System.Drawing.Point(9, 61);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(24, 24);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 488);
            this.Controls.Add(this.tabctrlEmployee);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Werknemer";
            ((System.ComponentModel.ISupportInitialize)(this.gdvReporters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeUnknown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlEmployee)).EndInit();
            this.tabctrlEmployee.ResumeLayout(false);
            this.tabpageVacation.ResumeLayout(false);
            this.tabpageVacation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTimeTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTimeFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouVacationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVacationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glouDispatcher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.tabpageTasks.ResumeLayout(false);
            this.tabpageTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRepeatMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection iclMedium;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraTab.XtraTabControl tabctrlEmployee;
        private DevExpress.XtraTab.XtraTabPage tabpageTasks;
        private DevExpress.XtraGrid.GridControl gdcTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvReporters;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoReporterEmail;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvAssigneeEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoEmployeeEmail;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvAssigneeSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSupplierEmail;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvAssigneeUnknown;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoUnknownEmail;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSubscriptions;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFrequency;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoMonday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTuesday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoWednesday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoThursday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFriday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSaterday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSunday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStartdate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvTask;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTag;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDueDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPriority;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoEffort;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraEditors.SimpleButton btnRemoveTask;
        private DevExpress.XtraEditors.SimpleButton btnAddTask;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit cbxRepeatMail;
        private DevExpress.XtraTab.XtraTabPage tabpageVacation;
        private DevExpress.XtraGrid.GridControl gdcVacation;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvVacation;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVacationType;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDateTo;
        private DevExpress.XtraEditors.DateEdit dteDateTo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.DateEdit dteDateFrom;
        private DevExpress.XtraEditors.LabelControl lblDispatcher;
        private DevExpress.XtraEditors.GridLookUpEdit glouDispatcher;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVacationDispatcherName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDispatcher;
        private DevExpress.XtraEditors.SimpleButton btnAddVacation;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit glouVacationType;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvVacationType;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoVacationTypeName;
        private DevExpress.XtraEditors.SimpleButton btnRemoveVacation;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDescription;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TimeEdit teTimeTo;
        private DevExpress.XtraEditors.TimeEdit teTimeFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTimeFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTimeTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}
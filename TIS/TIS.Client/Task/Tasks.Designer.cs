namespace TIS.Client.Task
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
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
            this.tabctrlTask = new DevExpress.XtraTab.XtraTabControl();
            this.tabpageTasks = new DevExpress.XtraTab.XtraTabPage();
            this.gpbActions = new System.Windows.Forms.GroupBox();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchTask = new DevExpress.XtraEditors.SimpleButton();
            this.iclSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.dteCreationDateTo = new DevExpress.XtraEditors.DateEdit();
            this.dteCreationDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlTask)).BeginInit();
            this.tabctrlTask.SuspendLayout();
            this.tabpageTasks.SuspendLayout();
            this.gpbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateFrom.Properties)).BeginInit();
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
            this.gdcTask.Location = new System.Drawing.Point(3, 127);
            this.gdcTask.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gdcTask.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gdcTask.MainView = this.gdvTask;
            this.gdcTask.Name = "gdcTask";
            this.gdcTask.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDueDate});
            this.gdcTask.Size = new System.Drawing.Size(992, 419);
            this.gdcTask.TabIndex = 0;
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
            this.repositoryItemDateEditDueDate.Name = "repositoryItemDateEditDueDate";
            this.repositoryItemDateEditDueDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            // tabctrlTask
            // 
            this.tabctrlTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlTask.Location = new System.Drawing.Point(3, 3);
            this.tabctrlTask.LookAndFeel.SkinName = "Office 2010 Blue";
            this.tabctrlTask.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabctrlTask.Name = "tabctrlTask";
            this.tabctrlTask.SelectedTabPage = this.tabpageTasks;
            this.tabctrlTask.Size = new System.Drawing.Size(1000, 571);
            this.tabctrlTask.TabIndex = 0;
            this.tabctrlTask.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpageTasks});
            // 
            // tabpageTasks
            // 
            this.tabpageTasks.Controls.Add(this.gpbActions);
            this.tabpageTasks.Controls.Add(this.gdcTask);
            this.tabpageTasks.Name = "tabpageTasks";
            this.tabpageTasks.Size = new System.Drawing.Size(998, 549);
            this.tabpageTasks.Text = "Tasks";
            // 
            // gpbActions
            // 
            this.gpbActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbActions.Controls.Add(this.txtDescription);
            this.gpbActions.Controls.Add(this.labelControl3);
            this.gpbActions.Controls.Add(this.btnSearchTask);
            this.gpbActions.Controls.Add(this.dteCreationDateTo);
            this.gpbActions.Controls.Add(this.dteCreationDateFrom);
            this.gpbActions.Controls.Add(this.labelControl2);
            this.gpbActions.Controls.Add(this.labelControl1);
            this.gpbActions.Controls.Add(this.btnRemoveTask);
            this.gpbActions.Controls.Add(this.btnAddTask);
            this.gpbActions.Location = new System.Drawing.Point(3, 3);
            this.gpbActions.Name = "gpbActions";
            this.gpbActions.Size = new System.Drawing.Size(992, 118);
            this.gpbActions.TabIndex = 5;
            this.gpbActions.TabStop = false;
            this.gpbActions.Text = "Actions";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(137, 80);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Description:";
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.ImageIndex = 122;
            this.btnSearchTask.ImageList = this.iclSmall;
            this.btnSearchTask.Location = new System.Drawing.Point(909, 80);
            this.btnSearchTask.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnSearchTask.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(77, 24);
            this.btnSearchTask.TabIndex = 9;
            this.btnSearchTask.Text = "Search";
            this.btnSearchTask.Click += new System.EventHandler(this.btnSearchTask_Click);
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
            // dteCreationDateTo
            // 
            this.dteCreationDateTo.EditValue = null;
            this.dteCreationDateTo.Location = new System.Drawing.Point(137, 54);
            this.dteCreationDateTo.Name = "dteCreationDateTo";
            this.dteCreationDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteCreationDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteCreationDateTo.Size = new System.Drawing.Size(169, 20);
            this.dteCreationDateTo.TabIndex = 8;
            // 
            // dteCreationDateFrom
            // 
            this.dteCreationDateFrom.EditValue = null;
            this.dteCreationDateFrom.Location = new System.Drawing.Point(137, 28);
            this.dteCreationDateFrom.Name = "dteCreationDateFrom";
            this.dteCreationDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteCreationDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteCreationDateFrom.Size = new System.Drawing.Size(169, 20);
            this.dteCreationDateFrom.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Creation date to:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Creation date from:";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.ImageIndex = 21;
            this.btnRemoveTask.ImageList = this.iclSmall;
            this.btnRemoveTask.Location = new System.Drawing.Point(909, 50);
            this.btnRemoveTask.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnRemoveTask.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(77, 24);
            this.btnRemoveTask.TabIndex = 4;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.ImageIndex = 27;
            this.btnAddTask.ImageList = this.iclSmall;
            this.btnAddTask.Location = new System.Drawing.Point(909, 20);
            this.btnAddTask.LookAndFeel.SkinName = "Office 2010 Blue";
            this.btnAddTask.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(77, 24);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlTask);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Tasks";
            this.Size = new System.Drawing.Size(1006, 577);
            ((System.ComponentModel.ISupportInitialize)(this.gdvReporters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAssigneeUnknown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlTask)).EndInit();
            this.tabctrlTask.ResumeLayout(false);
            this.tabpageTasks.ResumeLayout(false);
            this.gpbActions.ResumeLayout(false);
            this.gpbActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iclSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteCreationDateFrom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlTask;
        private DevExpress.XtraTab.XtraTabPage tabpageTasks;
        private DevExpress.XtraGrid.GridControl gdcTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvTask;
        private DevExpress.XtraEditors.SimpleButton btnRemoveTask;
        private DevExpress.XtraEditors.SimpleButton btnAddTask;
        private System.Windows.Forms.GroupBox gpbActions;
        private DevExpress.Utils.ImageCollection iclSmall;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dteCreationDateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearchTask;
        private DevExpress.XtraEditors.DateEdit dteCreationDateTo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvReporters;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoReporterEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTag;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoPriority;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoEffort;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvAssigneeSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSupplierEmail;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvAssigneeEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoEmployeeEmail;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSubscriptions;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFrequency;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoMonday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTuesday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoWednesday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoThursday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoFriday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSaterday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoSunday;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDueDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvAssigneeUnknown;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoUnknownEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoStartdate;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
namespace TIS.Client.Planning
{
    partial class Planning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planning));
            this.tabctrlPlanning = new DevExpress.XtraTab.XtraTabControl();
            this.tabpagePlanning = new DevExpress.XtraTab.XtraTabPage();
            this.btnEditJob = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveJob = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewJob = new DevExpress.XtraEditors.SimpleButton();
            this.gridctrlPlanning = new DevExpress.XtraGrid.GridControl();
            this.gridviewPlanning = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridcoTRuck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCoDriver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCoLoad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCoComm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCoFileOk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCoNotified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabpageAfwezig = new DevExpress.XtraTab.XtraTabPage();
            this.btnEditAbsence = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveAbsence = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewAbsent = new DevExpress.XtraEditors.SimpleButton();
            this.gridCoAbsent = new DevExpress.XtraGrid.GridControl();
            this.gridvAbsent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCoDriverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCoReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabpageSamenvatting = new DevExpress.XtraTab.XtraTabPage();
            this.tabpageMemo = new DevExpress.XtraTab.XtraTabPage();
            this.btnEditMemo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteMemo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewMemo = new DevExpress.XtraEditors.SimpleButton();
            this.gridctrlMemo = new DevExpress.XtraGrid.GridControl();
            this.gridvMemo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridcoComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabpageTransics = new DevExpress.XtraTab.XtraTabPage();
            this.btnReplacement = new DevExpress.XtraEditors.SimpleButton();
            this.dateDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblDispatcher = new DevExpress.XtraEditors.LabelControl();
            this.cboDispatcher = new System.Windows.Forms.ComboBox();
            this.btnAssigningVehicles = new System.Windows.Forms.Button();
            this.btnAssignDrivers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlPlanning)).BeginInit();
            this.tabctrlPlanning.SuspendLayout();
            this.tabpagePlanning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlPlanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPlanning)).BeginInit();
            this.tabpageAfwezig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvAbsent)).BeginInit();
            this.tabpageMemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlPlanning
            // 
            this.tabctrlPlanning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctrlPlanning.Location = new System.Drawing.Point(3, 49);
            this.tabctrlPlanning.Name = "tabctrlPlanning";
            this.tabctrlPlanning.SelectedTabPage = this.tabpagePlanning;
            this.tabctrlPlanning.Size = new System.Drawing.Size(775, 500);
            this.tabctrlPlanning.TabIndex = 0;
            this.tabctrlPlanning.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpagePlanning,
            this.tabpageAfwezig,
            this.tabpageSamenvatting,
            this.tabpageMemo,
            this.tabpageTransics});
            // 
            // tabpagePlanning
            // 
            this.tabpagePlanning.Controls.Add(this.btnEditJob);
            this.tabpagePlanning.Controls.Add(this.btnRemoveJob);
            this.tabpagePlanning.Controls.Add(this.btnNewJob);
            this.tabpagePlanning.Controls.Add(this.gridctrlPlanning);
            this.tabpagePlanning.Name = "tabpagePlanning";
            this.tabpagePlanning.Size = new System.Drawing.Size(769, 469);
            this.tabpagePlanning.Text = "Planning";
            // 
            // btnEditJob
            // 
            this.btnEditJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditJob.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditJob.Image = ((System.Drawing.Image)(resources.GetObject("btnEditJob.Image")));
            this.btnEditJob.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditJob.Location = new System.Drawing.Point(723, 47);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(40, 38);
            this.btnEditJob.TabIndex = 3;
            this.btnEditJob.ToolTip = "Edit Job";
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveJob.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnRemoveJob.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveJob.Image")));
            this.btnRemoveJob.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRemoveJob.Location = new System.Drawing.Point(723, 91);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(40, 38);
            this.btnRemoveJob.TabIndex = 2;
            this.btnRemoveJob.ToolTip = "Remove Job";
            this.btnRemoveJob.Click += new System.EventHandler(this.btnRemoveJob_Click);
            // 
            // btnNewJob
            // 
            this.btnNewJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewJob.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewJob.Image = ((System.Drawing.Image)(resources.GetObject("btnNewJob.Image")));
            this.btnNewJob.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNewJob.Location = new System.Drawing.Point(723, 3);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(40, 38);
            this.btnNewJob.TabIndex = 1;
            this.btnNewJob.ToolTip = "New Job";
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // gridctrlPlanning
            // 
            this.gridctrlPlanning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridctrlPlanning.Location = new System.Drawing.Point(0, 0);
            this.gridctrlPlanning.MainView = this.gridviewPlanning;
            this.gridctrlPlanning.Name = "gridctrlPlanning";
            this.gridctrlPlanning.Size = new System.Drawing.Size(717, 469);
            this.gridctrlPlanning.TabIndex = 0;
            this.gridctrlPlanning.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewPlanning});
            // 
            // gridviewPlanning
            // 
            this.gridviewPlanning.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridcoTRuck,
            this.gridCoDriver,
            this.gridCoLoad,
            this.gridCoComm,
            this.gridCoFileOk,
            this.gridCoNotified});
            this.gridviewPlanning.GridControl = this.gridctrlPlanning;
            this.gridviewPlanning.Name = "gridviewPlanning";
            this.gridviewPlanning.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridviewPlanning.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridviewPlanning.OptionsBehavior.Editable = false;
            this.gridviewPlanning.DoubleClick += new System.EventHandler(this.gridviewPlanning_DoubleClick);
            // 
            // gridcoTRuck
            // 
            this.gridcoTRuck.Caption = "Trekker";
            this.gridcoTRuck.FieldName = "Truck";
            this.gridcoTRuck.Name = "gridcoTRuck";
            this.gridcoTRuck.Visible = true;
            this.gridcoTRuck.VisibleIndex = 0;
            // 
            // gridCoDriver
            // 
            this.gridCoDriver.Caption = "Chauffeur";
            this.gridCoDriver.FieldName = "Driver";
            this.gridCoDriver.Name = "gridCoDriver";
            this.gridCoDriver.Visible = true;
            this.gridCoDriver.VisibleIndex = 1;
            // 
            // gridCoLoad
            // 
            this.gridCoLoad.Caption = "Lading";
            this.gridCoLoad.FieldName = "Load";
            this.gridCoLoad.Name = "gridCoLoad";
            this.gridCoLoad.Visible = true;
            this.gridCoLoad.VisibleIndex = 2;
            // 
            // gridCoComm
            // 
            this.gridCoComm.Caption = "Comment";
            this.gridCoComm.FieldName = "Comment";
            this.gridCoComm.Name = "gridCoComm";
            this.gridCoComm.Visible = true;
            this.gridCoComm.VisibleIndex = 3;
            // 
            // gridCoFileOk
            // 
            this.gridCoFileOk.Caption = "Dossier OK?";
            this.gridCoFileOk.FieldName = "FileOk";
            this.gridCoFileOk.Name = "gridCoFileOk";
            this.gridCoFileOk.Visible = true;
            this.gridCoFileOk.VisibleIndex = 4;
            // 
            // gridCoNotified
            // 
            this.gridCoNotified.Caption = "Op De Hoogte?";
            this.gridCoNotified.FieldName = "Notified";
            this.gridCoNotified.Name = "gridCoNotified";
            this.gridCoNotified.Visible = true;
            this.gridCoNotified.VisibleIndex = 5;
            // 
            // tabpageAfwezig
            // 
            this.tabpageAfwezig.Controls.Add(this.btnEditAbsence);
            this.tabpageAfwezig.Controls.Add(this.btnRemoveAbsence);
            this.tabpageAfwezig.Controls.Add(this.btnNewAbsent);
            this.tabpageAfwezig.Controls.Add(this.gridCoAbsent);
            this.tabpageAfwezig.Name = "tabpageAfwezig";
            this.tabpageAfwezig.Size = new System.Drawing.Size(769, 469);
            this.tabpageAfwezig.Text = "Afwezig";
            // 
            // btnEditAbsence
            // 
            this.btnEditAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAbsence.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditAbsence.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAbsence.Image")));
            this.btnEditAbsence.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditAbsence.Location = new System.Drawing.Point(723, 47);
            this.btnEditAbsence.Name = "btnEditAbsence";
            this.btnEditAbsence.Size = new System.Drawing.Size(40, 38);
            this.btnEditAbsence.TabIndex = 6;
            this.btnEditAbsence.ToolTip = "Edit Job";
            this.btnEditAbsence.Click += new System.EventHandler(this.btnEditAbsence_Click);
            // 
            // btnRemoveAbsence
            // 
            this.btnRemoveAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAbsence.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnRemoveAbsence.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAbsence.Image")));
            this.btnRemoveAbsence.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRemoveAbsence.Location = new System.Drawing.Point(723, 91);
            this.btnRemoveAbsence.Name = "btnRemoveAbsence";
            this.btnRemoveAbsence.Size = new System.Drawing.Size(40, 38);
            this.btnRemoveAbsence.TabIndex = 5;
            this.btnRemoveAbsence.ToolTip = "Remove Job";
            this.btnRemoveAbsence.Click += new System.EventHandler(this.btnRemoveAbsence_Click);
            // 
            // btnNewAbsent
            // 
            this.btnNewAbsent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewAbsent.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewAbsent.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAbsent.Image")));
            this.btnNewAbsent.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNewAbsent.Location = new System.Drawing.Point(723, 3);
            this.btnNewAbsent.Name = "btnNewAbsent";
            this.btnNewAbsent.Size = new System.Drawing.Size(40, 38);
            this.btnNewAbsent.TabIndex = 4;
            this.btnNewAbsent.ToolTip = "New Job";
            this.btnNewAbsent.Click += new System.EventHandler(this.btnNewAbsent_Click);
            // 
            // gridCoAbsent
            // 
            this.gridCoAbsent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCoAbsent.Location = new System.Drawing.Point(0, 0);
            this.gridCoAbsent.MainView = this.gridvAbsent;
            this.gridCoAbsent.Name = "gridCoAbsent";
            this.gridCoAbsent.Size = new System.Drawing.Size(717, 469);
            this.gridCoAbsent.TabIndex = 1;
            this.gridCoAbsent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvAbsent});
            // 
            // gridvAbsent
            // 
            this.gridvAbsent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCoDriverName,
            this.gridCoReason});
            this.gridvAbsent.GridControl = this.gridCoAbsent;
            this.gridvAbsent.Name = "gridvAbsent";
            this.gridvAbsent.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvAbsent.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvAbsent.OptionsBehavior.Editable = false;
            this.gridvAbsent.DoubleClick += new System.EventHandler(this.gridvAbsent_DoubleClick);
            // 
            // gridCoDriverName
            // 
            this.gridCoDriverName.Caption = "Chauffeur";
            this.gridCoDriverName.FieldName = "DriverName";
            this.gridCoDriverName.Name = "gridCoDriverName";
            this.gridCoDriverName.Visible = true;
            this.gridCoDriverName.VisibleIndex = 0;
            // 
            // gridCoReason
            // 
            this.gridCoReason.Caption = "Reden";
            this.gridCoReason.FieldName = "Reason";
            this.gridCoReason.Name = "gridCoReason";
            this.gridCoReason.Visible = true;
            this.gridCoReason.VisibleIndex = 1;
            // 
            // tabpageSamenvatting
            // 
            this.tabpageSamenvatting.Name = "tabpageSamenvatting";
            this.tabpageSamenvatting.Size = new System.Drawing.Size(769, 469);
            this.tabpageSamenvatting.Text = "Samenvatting";
            // 
            // tabpageMemo
            // 
            this.tabpageMemo.Controls.Add(this.btnEditMemo);
            this.tabpageMemo.Controls.Add(this.btnDeleteMemo);
            this.tabpageMemo.Controls.Add(this.btnNewMemo);
            this.tabpageMemo.Controls.Add(this.gridctrlMemo);
            this.tabpageMemo.Name = "tabpageMemo";
            this.tabpageMemo.Size = new System.Drawing.Size(769, 469);
            this.tabpageMemo.Text = "Memo";
            // 
            // btnEditMemo
            // 
            this.btnEditMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMemo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditMemo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMemo.Image")));
            this.btnEditMemo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEditMemo.Location = new System.Drawing.Point(726, 47);
            this.btnEditMemo.Name = "btnEditMemo";
            this.btnEditMemo.Size = new System.Drawing.Size(40, 38);
            this.btnEditMemo.TabIndex = 6;
            this.btnEditMemo.ToolTip = "Edit Memo";
            this.btnEditMemo.Click += new System.EventHandler(this.btnEditMemo_Click);
            // 
            // btnDeleteMemo
            // 
            this.btnDeleteMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMemo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDeleteMemo.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMemo.Image")));
            this.btnDeleteMemo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDeleteMemo.Location = new System.Drawing.Point(726, 91);
            this.btnDeleteMemo.Name = "btnDeleteMemo";
            this.btnDeleteMemo.Size = new System.Drawing.Size(40, 38);
            this.btnDeleteMemo.TabIndex = 5;
            this.btnDeleteMemo.ToolTip = "Remove Memo";
            this.btnDeleteMemo.Click += new System.EventHandler(this.btnDeleteMemo_Click);
            // 
            // btnNewMemo
            // 
            this.btnNewMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMemo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewMemo.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMemo.Image")));
            this.btnNewMemo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNewMemo.Location = new System.Drawing.Point(726, 3);
            this.btnNewMemo.Name = "btnNewMemo";
            this.btnNewMemo.Size = new System.Drawing.Size(40, 38);
            this.btnNewMemo.TabIndex = 4;
            this.btnNewMemo.ToolTip = "Add Memo";
            this.btnNewMemo.Click += new System.EventHandler(this.btnNewMemo_Click);
            // 
            // gridctrlMemo
            // 
            this.gridctrlMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridctrlMemo.Location = new System.Drawing.Point(0, 0);
            this.gridctrlMemo.MainView = this.gridvMemo;
            this.gridctrlMemo.Name = "gridctrlMemo";
            this.gridctrlMemo.Size = new System.Drawing.Size(717, 469);
            this.gridctrlMemo.TabIndex = 2;
            this.gridctrlMemo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvMemo});
            // 
            // gridvMemo
            // 
            this.gridvMemo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridcoComment});
            this.gridvMemo.GridControl = this.gridctrlMemo;
            this.gridvMemo.Name = "gridvMemo";
            this.gridvMemo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvMemo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvMemo.OptionsBehavior.Editable = false;
            this.gridvMemo.DoubleClick += new System.EventHandler(this.gridvMemo_DoubleClick);
            // 
            // gridcoComment
            // 
            this.gridcoComment.Caption = "Memo";
            this.gridcoComment.FieldName = "PlanningMemoComment";
            this.gridcoComment.Name = "gridcoComment";
            this.gridcoComment.Visible = true;
            this.gridcoComment.VisibleIndex = 0;
            // 
            // tabpageTransics
            // 
            this.tabpageTransics.Name = "tabpageTransics";
            this.tabpageTransics.Size = new System.Drawing.Size(769, 469);
            this.tabpageTransics.Text = "Transics";
            // 
            // btnReplacement
            // 
            this.btnReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplacement.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnReplacement.Image = ((System.Drawing.Image)(resources.GetObject("btnReplacement.Image")));
            this.btnReplacement.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnReplacement.Location = new System.Drawing.Point(566, 18);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Size = new System.Drawing.Size(51, 51);
            this.btnReplacement.TabIndex = 4;
            this.btnReplacement.ToolTip = "Add Replacement";
            this.btnReplacement.Click += new System.EventHandler(this.btnReplacement_Click);
            // 
            // dateDate
            // 
            this.dateDate.EditValue = null;
            this.dateDate.Location = new System.Drawing.Point(65, 21);
            this.dateDate.Name = "dateDate";
            this.dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDate.Size = new System.Drawing.Size(100, 22);
            this.dateDate.TabIndex = 1;
            this.dateDate.EditValueChanged += new System.EventHandler(this.dateDate_EditValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(17, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Datum:";
            // 
            // lblDispatcher
            // 
            this.lblDispatcher.Location = new System.Drawing.Point(220, 21);
            this.lblDispatcher.Name = "lblDispatcher";
            this.lblDispatcher.Size = new System.Drawing.Size(65, 16);
            this.lblDispatcher.TabIndex = 3;
            this.lblDispatcher.Text = "Dispatcher:";
            // 
            // cboDispatcher
            // 
            this.cboDispatcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDispatcher.FormattingEnabled = true;
            this.cboDispatcher.Location = new System.Drawing.Point(291, 18);
            this.cboDispatcher.Name = "cboDispatcher";
            this.cboDispatcher.Size = new System.Drawing.Size(158, 24);
            this.cboDispatcher.TabIndex = 4;
            this.cboDispatcher.SelectedIndexChanged += new System.EventHandler(this.cboDispatcher_SelectedIndexChanged);
            // 
            // btnAssigningVehicles
            // 
            this.btnAssigningVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssigningVehicles.Location = new System.Drawing.Point(623, 18);
            this.btnAssigningVehicles.Name = "btnAssigningVehicles";
            this.btnAssigningVehicles.Size = new System.Drawing.Size(150, 25);
            this.btnAssigningVehicles.TabIndex = 5;
            this.btnAssigningVehicles.Text = "Toewijzen Voertuigen";
            this.btnAssigningVehicles.UseVisualStyleBackColor = true;
            this.btnAssigningVehicles.Click += new System.EventHandler(this.btnAssigningVehicles_Click);
            // 
            // btnAssignDrivers
            // 
            this.btnAssignDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignDrivers.Location = new System.Drawing.Point(623, 44);
            this.btnAssignDrivers.Name = "btnAssignDrivers";
            this.btnAssignDrivers.Size = new System.Drawing.Size(150, 25);
            this.btnAssignDrivers.TabIndex = 6;
            this.btnAssignDrivers.Text = "Toewijzen Chauffeurs";
            this.btnAssignDrivers.UseVisualStyleBackColor = true;
            this.btnAssignDrivers.Click += new System.EventHandler(this.btnAssignDrivers_Click);
            // 
            // Planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.Controls.Add(this.btnAssignDrivers);
            this.Controls.Add(this.btnReplacement);
            this.Controls.Add(this.btnAssigningVehicles);
            this.Controls.Add(this.cboDispatcher);
            this.Controls.Add(this.lblDispatcher);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.tabctrlPlanning);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Planning";
            this.Size = new System.Drawing.Size(781, 552);
            this.Load += new System.EventHandler(this.Planning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabctrlPlanning)).EndInit();
            this.tabctrlPlanning.ResumeLayout(false);
            this.tabpagePlanning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlPlanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPlanning)).EndInit();
            this.tabpageAfwezig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCoAbsent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvAbsent)).EndInit();
            this.tabpageMemo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabctrlPlanning;
        private DevExpress.XtraTab.XtraTabPage tabpagePlanning;
        private DevExpress.XtraTab.XtraTabPage tabpageAfwezig;
        private DevExpress.XtraTab.XtraTabPage tabpageSamenvatting;
        private DevExpress.XtraTab.XtraTabPage tabpageMemo;
        private DevExpress.XtraTab.XtraTabPage tabpageTransics;
        private DevExpress.XtraEditors.DateEdit dateDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraGrid.GridControl gridctrlPlanning;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewPlanning;
        private DevExpress.XtraEditors.SimpleButton btnNewJob;
        private DevExpress.XtraEditors.SimpleButton btnEditJob;
        private DevExpress.XtraEditors.SimpleButton btnRemoveJob;
        private DevExpress.XtraGrid.GridControl gridCoAbsent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvAbsent;
        private DevExpress.XtraEditors.SimpleButton btnEditMemo;
        private DevExpress.XtraEditors.SimpleButton btnDeleteMemo;
        private DevExpress.XtraEditors.SimpleButton btnNewMemo;
        private DevExpress.XtraGrid.GridControl gridctrlMemo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvMemo;
        private DevExpress.XtraGrid.Columns.GridColumn gridcoComment;
        private DevExpress.XtraGrid.Columns.GridColumn gridcoTRuck;
        private DevExpress.XtraGrid.Columns.GridColumn gridCoDriver;
        private DevExpress.XtraGrid.Columns.GridColumn gridCoLoad;
        private DevExpress.XtraGrid.Columns.GridColumn gridCoComm;
        private DevExpress.XtraGrid.Columns.GridColumn gridCoFileOk;
        private DevExpress.XtraGrid.Columns.GridColumn gridCoNotified;
        private DevExpress.XtraEditors.LabelControl lblDispatcher;
        private System.Windows.Forms.ComboBox cboDispatcher;
        private System.Windows.Forms.Button btnAssigningVehicles;
        private DevExpress.XtraEditors.SimpleButton btnReplacement;
        private DevExpress.XtraEditors.SimpleButton btnEditAbsence;
        private DevExpress.XtraEditors.SimpleButton btnRemoveAbsence;
        private DevExpress.XtraEditors.SimpleButton btnNewAbsent;
        private DevExpress.XtraGrid.Columns.GridColumn gridCoDriverName;
        private DevExpress.XtraGrid.Columns.GridColumn gridCoReason;
        private System.Windows.Forms.Button btnAssignDrivers;
    }
}

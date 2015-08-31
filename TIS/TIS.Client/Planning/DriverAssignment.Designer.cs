namespace TIS.Client.Planning
{
    partial class DriverAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverAssignment));
            this.gridAssigned = new DevExpress.XtraGrid.GridControl();
            this.gridvAssigned = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridcoTruckName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcoDispatcherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.gridUnassigned = new DevExpress.XtraGrid.GridControl();
            this.gridvUnassigned = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcoName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAssigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvAssigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnassigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvUnassigned)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAssigned
            // 
            this.gridAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAssigned.Location = new System.Drawing.Point(12, 243);
            this.gridAssigned.MainView = this.gridvAssigned;
            this.gridAssigned.Name = "gridAssigned";
            this.gridAssigned.Size = new System.Drawing.Size(630, 210);
            this.gridAssigned.TabIndex = 24;
            this.gridAssigned.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvAssigned});
            // 
            // gridvAssigned
            // 
            this.gridvAssigned.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridcoTruckName,
            this.gridcoDispatcherName});
            this.gridvAssigned.GridControl = this.gridAssigned;
            this.gridvAssigned.Name = "gridvAssigned";
            this.gridvAssigned.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvAssigned.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvAssigned.OptionsBehavior.Editable = false;
            // 
            // gridcoTruckName
            // 
            this.gridcoTruckName.Caption = "Naam Chauffeur";
            this.gridcoTruckName.FieldName = "DriverName";
            this.gridcoTruckName.Name = "gridcoTruckName";
            this.gridcoTruckName.Visible = true;
            this.gridcoTruckName.VisibleIndex = 0;
            // 
            // gridcoDispatcherName
            // 
            this.gridcoDispatcherName.Caption = "Naam Dispatcher";
            this.gridcoDispatcherName.FieldName = "DispatcherName";
            this.gridcoDispatcherName.Name = "gridcoDispatcherName";
            this.gridcoDispatcherName.Visible = true;
            this.gridcoDispatcherName.VisibleIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageIndex = 136;
            this.btnOK.Location = new System.Drawing.Point(557, 460);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 47);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gridUnassigned
            // 
            this.gridUnassigned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUnassigned.Location = new System.Drawing.Point(12, 12);
            this.gridUnassigned.MainView = this.gridvUnassigned;
            this.gridUnassigned.Name = "gridUnassigned";
            this.gridUnassigned.Size = new System.Drawing.Size(630, 225);
            this.gridUnassigned.TabIndex = 22;
            this.gridUnassigned.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvUnassigned});
            this.gridUnassigned.DoubleClick += new System.EventHandler(this.gridUnassigned_DoubleClick);
            // 
            // gridvUnassigned
            // 
            this.gridvUnassigned.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcoName});
            this.gridvUnassigned.GridControl = this.gridUnassigned;
            this.gridvUnassigned.Name = "gridvUnassigned";
            this.gridvUnassigned.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvUnassigned.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridvUnassigned.OptionsBehavior.Editable = false;
            // 
            // grdcoName
            // 
            this.grdcoName.Caption = "Naam";
            this.grdcoName.FieldName = "DisplayName";
            this.grdcoName.Name = "grdcoName";
            this.grdcoName.Visible = true;
            this.grdcoName.VisibleIndex = 0;
            // 
            // DriverAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 516);
            this.Controls.Add(this.gridAssigned);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gridUnassigned);
            this.Name = "DriverAssignment";
            this.Text = "DriverAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.gridAssigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvAssigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnassigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvUnassigned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAssigned;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvAssigned;
        private DevExpress.XtraGrid.Columns.GridColumn gridcoTruckName;
        private DevExpress.XtraGrid.Columns.GridColumn gridcoDispatcherName;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraGrid.GridControl gridUnassigned;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvUnassigned;
        private DevExpress.XtraGrid.Columns.GridColumn grdcoName;


    }
}
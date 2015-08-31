namespace TIS.Client.Vacation
{
    partial class Vacations
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
            this.gdcVacation = new DevExpress.XtraGrid.GridControl();
            this.gdvVacation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcoEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDispatcherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcoDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVacation)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcVacation
            // 
            this.gdcVacation.Location = new System.Drawing.Point(3, 3);
            this.gdcVacation.MainView = this.gdvVacation;
            this.gdcVacation.Name = "gdcVacation";
            this.gdcVacation.Size = new System.Drawing.Size(977, 527);
            this.gdcVacation.TabIndex = 0;
            this.gdcVacation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvVacation});
            // 
            // gdvVacation
            // 
            this.gdvVacation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcoEmployeeName,
            this.gdcoDispatcherName,
            this.gdcoDate});
            this.gdvVacation.GridControl = this.gdcVacation;
            this.gdvVacation.Name = "gdvVacation";
            this.gdvVacation.OptionsFind.AlwaysVisible = true;
            this.gdvVacation.OptionsView.ShowGroupPanel = false;
            // 
            // gdcoEmployeeName
            // 
            this.gdcoEmployeeName.Caption = "Werknemer";
            this.gdcoEmployeeName.FieldName = "Employee.DisplayName";
            this.gdcoEmployeeName.Name = "gdcoEmployeeName";
            this.gdcoEmployeeName.Visible = true;
            this.gdcoEmployeeName.VisibleIndex = 0;
            // 
            // gdcoDispatcherName
            // 
            this.gdcoDispatcherName.Caption = "Dispatcher";
            this.gdcoDispatcherName.FieldName = "Dispatcher.DisplayName";
            this.gdcoDispatcherName.Name = "gdcoDispatcherName";
            this.gdcoDispatcherName.Visible = true;
            this.gdcoDispatcherName.VisibleIndex = 1;
            // 
            // gdcoDate
            // 
            this.gdcoDate.Caption = "Datum";
            this.gdcoDate.DisplayFormat.FormatString = "d";
            this.gdcoDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gdcoDate.FieldName = "Date";
            this.gdcoDate.Name = "gdcoDate";
            this.gdcoDate.Visible = true;
            this.gdcoDate.VisibleIndex = 2;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(897, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Vacations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 533);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.gdcVacation);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Vacations";
            ((System.ComponentModel.ISupportInitialize)(this.gdcVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvVacation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gdcoEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDispatcherName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcoDate;
        public DevExpress.XtraGrid.GridControl gdcVacation;
        public DevExpress.XtraGrid.Views.Grid.GridView gdvVacation;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
    }
}
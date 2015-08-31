namespace TIS.Client.Planning
{
    partial class JobDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetail));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoad = new DevExpress.XtraEditors.TextEdit();
            this.chkFile = new System.Windows.Forms.CheckBox();
            this.chkNotified = new System.Windows.Forms.CheckBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cboTrucks = new System.Windows.Forms.ComboBox();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dteJobDate = new DevExpress.XtraEditors.DateEdit();
            this.txtComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteJobDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteJobDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Trekker: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Chauffeur: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Vracht: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opmerking: ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(723, 2);
            this.label2.TabIndex = 5;
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(98, 85);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(211, 22);
            this.txtLoad.TabIndex = 9;
            // 
            // chkFile
            // 
            this.chkFile.AutoSize = true;
            this.chkFile.Location = new System.Drawing.Point(13, 156);
            this.chkFile.Name = "chkFile";
            this.chkFile.Size = new System.Drawing.Size(102, 21);
            this.chkFile.TabIndex = 13;
            this.chkFile.Text = "Dossier Ok?";
            this.chkFile.UseVisualStyleBackColor = true;
            // 
            // chkNotified
            // 
            this.chkNotified.AutoSize = true;
            this.chkNotified.Location = new System.Drawing.Point(13, 183);
            this.chkNotified.Name = "chkNotified";
            this.chkNotified.Size = new System.Drawing.Size(125, 21);
            this.chkNotified.TabIndex = 14;
            this.chkNotified.Text = "Op De Hoogte?";
            this.chkNotified.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageIndex = 136;
            this.btnSave.Location = new System.Drawing.Point(650, 157);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 47);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageIndex = 120;
            this.btnCancel.Location = new System.Drawing.Point(558, 157);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboTrucks
            // 
            this.cboTrucks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrucks.FormattingEnabled = true;
            this.cboTrucks.Location = new System.Drawing.Point(98, 12);
            this.cboTrucks.Name = "cboTrucks";
            this.cboTrucks.Size = new System.Drawing.Size(211, 24);
            this.cboTrucks.TabIndex = 20;
            this.cboTrucks.SelectedIndexChanged += new System.EventHandler(this.cboTrucks_SelectedIndexChanged);
            // 
            // cboDriver
            // 
            this.cboDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.Location = new System.Drawing.Point(98, 47);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(211, 24);
            this.cboDriver.TabIndex = 21;
            this.cboDriver.SelectedIndexChanged += new System.EventHandler(this.cboDriver_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 16);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Datum Rit: ";
            // 
            // dteJobDate
            // 
            this.dteJobDate.EditValue = null;
            this.dteJobDate.Location = new System.Drawing.Point(98, 119);
            this.dteJobDate.Name = "dteJobDate";
            this.dteJobDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteJobDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteJobDate.Size = new System.Drawing.Size(211, 22);
            this.dteJobDate.TabIndex = 23;
            this.dteJobDate.EditValueChanged += new System.EventHandler(this.dteJobDate_EditValueChanged);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(318, 36);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(418, 105);
            this.txtComment.TabIndex = 24;
            // 
            // JobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 211);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.dteJobDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cboDriver);
            this.Controls.Add(this.cboTrucks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkNotified);
            this.Controls.Add(this.chkFile);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Name = "JobDetail";
            this.Text = "NewJob";
            ((System.ComponentModel.ISupportInitialize)(this.txtLoad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteJobDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteJobDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtLoad;
        private System.Windows.Forms.CheckBox chkFile;
        private System.Windows.Forms.CheckBox chkNotified;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ComboBox cboTrucks;
        private System.Windows.Forms.ComboBox cboDriver;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dteJobDate;
        private System.Windows.Forms.TextBox txtComment;
    }
}
namespace TIS.Client.Planning
{
    partial class AbsentDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsentDetail));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblChauffeur = new System.Windows.Forms.Label();
            this.cboDrivers = new System.Windows.Forms.ComboBox();
            this.rdbWerkloos = new System.Windows.Forms.RadioButton();
            this.rdbVerlof = new System.Windows.Forms.RadioButton();
            this.rdbZiek = new System.Windows.Forms.RadioButton();
            this.grpReasons = new System.Windows.Forms.GroupBox();
            this.dteDate = new DevExpress.XtraEditors.DateEdit();
            this.grpReasons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageIndex = 136;
            this.btnSave.Location = new System.Drawing.Point(225, 104);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 47);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageIndex = 120;
            this.btnCancel.Location = new System.Drawing.Point(134, 104);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblChauffeur
            // 
            this.lblChauffeur.AutoSize = true;
            this.lblChauffeur.Location = new System.Drawing.Point(12, 9);
            this.lblChauffeur.Name = "lblChauffeur";
            this.lblChauffeur.Size = new System.Drawing.Size(77, 17);
            this.lblChauffeur.TabIndex = 22;
            this.lblChauffeur.Text = "Chauffeur: ";
            // 
            // cboDrivers
            // 
            this.cboDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrivers.FormattingEnabled = true;
            this.cboDrivers.Location = new System.Drawing.Point(95, 6);
            this.cboDrivers.Name = "cboDrivers";
            this.cboDrivers.Size = new System.Drawing.Size(215, 24);
            this.cboDrivers.TabIndex = 23;
            this.cboDrivers.SelectedIndexChanged += new System.EventHandler(this.cboDrivers_SelectedIndexChanged);
            // 
            // rdbWerkloos
            // 
            this.rdbWerkloos.AutoSize = true;
            this.rdbWerkloos.Location = new System.Drawing.Point(75, 22);
            this.rdbWerkloos.Name = "rdbWerkloos";
            this.rdbWerkloos.Size = new System.Drawing.Size(86, 21);
            this.rdbWerkloos.TabIndex = 24;
            this.rdbWerkloos.TabStop = true;
            this.rdbWerkloos.Text = "Werkloos";
            this.rdbWerkloos.UseVisualStyleBackColor = true;
            this.rdbWerkloos.CheckedChanged += new System.EventHandler(this.rdbWerkloos_CheckedChanged);
            // 
            // rdbVerlof
            // 
            this.rdbVerlof.AutoSize = true;
            this.rdbVerlof.Location = new System.Drawing.Point(167, 22);
            this.rdbVerlof.Name = "rdbVerlof";
            this.rdbVerlof.Size = new System.Drawing.Size(63, 21);
            this.rdbVerlof.TabIndex = 25;
            this.rdbVerlof.TabStop = true;
            this.rdbVerlof.Text = "Verlof";
            this.rdbVerlof.UseVisualStyleBackColor = true;
            this.rdbVerlof.CheckedChanged += new System.EventHandler(this.rdbVerlof_CheckedChanged);
            // 
            // rdbZiek
            // 
            this.rdbZiek.AutoSize = true;
            this.rdbZiek.Location = new System.Drawing.Point(236, 22);
            this.rdbZiek.Name = "rdbZiek";
            this.rdbZiek.Size = new System.Drawing.Size(53, 21);
            this.rdbZiek.TabIndex = 26;
            this.rdbZiek.TabStop = true;
            this.rdbZiek.Text = "Ziek";
            this.rdbZiek.UseVisualStyleBackColor = true;
            this.rdbZiek.CheckedChanged += new System.EventHandler(this.rdbZiek_CheckedChanged);
            // 
            // grpReasons
            // 
            this.grpReasons.Controls.Add(this.rdbWerkloos);
            this.grpReasons.Controls.Add(this.rdbZiek);
            this.grpReasons.Controls.Add(this.rdbVerlof);
            this.grpReasons.Location = new System.Drawing.Point(15, 36);
            this.grpReasons.Name = "grpReasons";
            this.grpReasons.Size = new System.Drawing.Size(295, 61);
            this.grpReasons.TabIndex = 27;
            this.grpReasons.TabStop = false;
            this.grpReasons.Text = "Reden";
            // 
            // dteDate
            // 
            this.dteDate.EditValue = null;
            this.dteDate.Location = new System.Drawing.Point(15, 103);
            this.dteDate.Name = "dteDate";
            this.dteDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDate.Size = new System.Drawing.Size(100, 22);
            this.dteDate.TabIndex = 28;
            this.dteDate.EditValueChanged += new System.EventHandler(this.dteDate_EditValueChanged);
            // 
            // AbsentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 162);
            this.Controls.Add(this.dteDate);
            this.Controls.Add(this.grpReasons);
            this.Controls.Add(this.cboDrivers);
            this.Controls.Add(this.lblChauffeur);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AbsentDetail";
            this.Text = "AbsentDetail";
            this.grpReasons.ResumeLayout(false);
            this.grpReasons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label lblChauffeur;
        private System.Windows.Forms.ComboBox cboDrivers;
        private System.Windows.Forms.RadioButton rdbWerkloos;
        private System.Windows.Forms.RadioButton rdbVerlof;
        private System.Windows.Forms.RadioButton rdbZiek;
        private System.Windows.Forms.GroupBox grpReasons;
        private DevExpress.XtraEditors.DateEdit dteDate;

    }
}
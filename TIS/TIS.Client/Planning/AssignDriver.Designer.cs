namespace TIS.Client.Planning
{
    partial class AssignDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignDriver));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.lblDispatcher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDispatcher = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageIndex = 136;
            this.btnSave.Location = new System.Drawing.Point(486, 93);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 47);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageIndex = 120;
            this.btnCancel.Location = new System.Drawing.Point(394, 93);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDriver
            // 
            this.txtDriver.Enabled = false;
            this.txtDriver.Location = new System.Drawing.Point(100, 6);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(471, 23);
            this.txtDriver.TabIndex = 25;
            // 
            // lblDispatcher
            // 
            this.lblDispatcher.AutoSize = true;
            this.lblDispatcher.Location = new System.Drawing.Point(12, 49);
            this.lblDispatcher.Name = "lblDispatcher";
            this.lblDispatcher.Size = new System.Drawing.Size(82, 17);
            this.lblDispatcher.TabIndex = 24;
            this.lblDispatcher.Text = "Dispatcher: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Chauffeur: ";
            // 
            // cboDispatcher
            // 
            this.cboDispatcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDispatcher.FormattingEnabled = true;
            this.cboDispatcher.Location = new System.Drawing.Point(100, 46);
            this.cboDispatcher.Name = "cboDispatcher";
            this.cboDispatcher.Size = new System.Drawing.Size(471, 24);
            this.cboDispatcher.TabIndex = 22;
            this.cboDispatcher.SelectedIndexChanged += new System.EventHandler(this.cboDispatcher_SelectedIndexChanged);
            // 
            // AssignDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 150);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.lblDispatcher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDispatcher);
            this.Name = "AssignDriver";
            this.Text = "AssignDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Label lblDispatcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDispatcher;
    }
}
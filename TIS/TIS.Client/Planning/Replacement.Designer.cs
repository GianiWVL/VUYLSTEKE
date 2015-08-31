namespace TIS.Client.Planning
{
    partial class Replacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replacement));
            this.lblReplacement = new System.Windows.Forms.Label();
            this.cboReplacement = new System.Windows.Forms.ComboBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblReplacement
            // 
            this.lblReplacement.AutoSize = true;
            this.lblReplacement.Location = new System.Drawing.Point(12, 11);
            this.lblReplacement.Name = "lblReplacement";
            this.lblReplacement.Size = new System.Drawing.Size(76, 17);
            this.lblReplacement.TabIndex = 0;
            this.lblReplacement.Text = "Vervanger:";
            // 
            // cboReplacement
            // 
            this.cboReplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReplacement.FormattingEnabled = true;
            this.cboReplacement.Location = new System.Drawing.Point(94, 8);
            this.cboReplacement.Name = "cboReplacement";
            this.cboReplacement.Size = new System.Drawing.Size(244, 24);
            this.cboReplacement.TabIndex = 1;
            this.cboReplacement.SelectedIndexChanged += new System.EventHandler(this.cboReplacement_SelectedIndexChanged);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(344, 10);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(70, 21);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Actief?";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageIndex = 136;
            this.btnSave.Location = new System.Drawing.Point(329, 53);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 47);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageIndex = 120;
            this.btnCancel.Location = new System.Drawing.Point(238, 53);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Replacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 112);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cboReplacement);
            this.Controls.Add(this.lblReplacement);
            this.Name = "Replacement";
            this.Text = "Replacement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReplacement;
        private System.Windows.Forms.ComboBox cboReplacement;
        private System.Windows.Forms.CheckBox chkActive;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
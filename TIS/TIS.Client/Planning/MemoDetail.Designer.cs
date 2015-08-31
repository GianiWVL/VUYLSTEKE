namespace TIS.Client.Planning
{
    partial class MemoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoDetail));
            this.lblMemoDate = new DevExpress.XtraEditors.LabelControl();
            this.dteMemoDate = new DevExpress.XtraEditors.DateEdit();
            this.lblMemoDetail = new DevExpress.XtraEditors.LabelControl();
            this.txtMemoComment = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dteMemoDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMemoDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemoDate
            // 
            this.lblMemoDate.Location = new System.Drawing.Point(12, 12);
            this.lblMemoDate.Name = "lblMemoDate";
            this.lblMemoDate.Size = new System.Drawing.Size(85, 16);
            this.lblMemoDate.TabIndex = 0;
            this.lblMemoDate.Text = "Datum Memo: ";
            // 
            // dteMemoDate
            // 
            this.dteMemoDate.EditValue = null;
            this.dteMemoDate.Location = new System.Drawing.Point(103, 9);
            this.dteMemoDate.Name = "dteMemoDate";
            this.dteMemoDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMemoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMemoDate.Size = new System.Drawing.Size(175, 22);
            this.dteMemoDate.TabIndex = 1;
            // 
            // lblMemoDetail
            // 
            this.lblMemoDetail.Location = new System.Drawing.Point(12, 46);
            this.lblMemoDetail.Name = "lblMemoDetail";
            this.lblMemoDetail.Size = new System.Drawing.Size(85, 16);
            this.lblMemoDetail.TabIndex = 2;
            this.lblMemoDetail.Text = "Datum Memo: ";
            // 
            // txtMemoComment
            // 
            this.txtMemoComment.Location = new System.Drawing.Point(12, 69);
            this.txtMemoComment.Multiline = true;
            this.txtMemoComment.Name = "txtMemoComment";
            this.txtMemoComment.Size = new System.Drawing.Size(517, 109);
            this.txtMemoComment.TabIndex = 3;
            this.txtMemoComment.TextChanged += new System.EventHandler(this.txtMemoComment_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageIndex = 136;
            this.btnSave.Location = new System.Drawing.Point(445, 185);
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
            this.btnCancel.Location = new System.Drawing.Point(354, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MemoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 239);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMemoComment);
            this.Controls.Add(this.lblMemoDetail);
            this.Controls.Add(this.dteMemoDate);
            this.Controls.Add(this.lblMemoDate);
            this.Name = "MemoDetail";
            this.Text = "MemoDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dteMemoDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMemoDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMemoDate;
        private DevExpress.XtraEditors.DateEdit dteMemoDate;
        private DevExpress.XtraEditors.LabelControl lblMemoDetail;
        private System.Windows.Forms.TextBox txtMemoComment;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
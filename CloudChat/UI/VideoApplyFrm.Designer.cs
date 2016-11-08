namespace CloudChat
{
    partial class VideoApplyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoApplyFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btn_Agree = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Refuse = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Refuse);
            this.panelControl1.Controls.Add(this.btn_Agree);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(173, 268);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(37, 39);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 0;
            // 
            // btn_Agree
            // 
            this.btn_Agree.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agree.Image")));
            this.btn_Agree.Location = new System.Drawing.Point(48, 158);
            this.btn_Agree.Name = "btn_Agree";
            this.btn_Agree.Size = new System.Drawing.Size(75, 23);
            this.btn_Agree.TabIndex = 1;
            this.btn_Agree.Text = "同意";
            this.btn_Agree.Click += new System.EventHandler(this.btn_Agree_Click);
            // 
            // btn_Refuse
            // 
            this.btn_Refuse.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refuse.Image")));
            this.btn_Refuse.Location = new System.Drawing.Point(48, 188);
            this.btn_Refuse.Name = "btn_Refuse";
            this.btn_Refuse.Size = new System.Drawing.Size(75, 23);
            this.btn_Refuse.TabIndex = 2;
            this.btn_Refuse.Text = "拒绝";
            this.btn_Refuse.Click += new System.EventHandler(this.btn_Refuse_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "XXXX请求视频通话";
            // 
            // VideoApplyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 268);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoApplyFrm";
            this.Text = "视频请求...";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Refuse;
        private DevExpress.XtraEditors.SimpleButton btn_Agree;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
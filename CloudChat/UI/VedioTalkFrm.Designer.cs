namespace CloudChat
{
    partial class VideoTalkFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoTalkFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ptb_MyselfPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_WaitingConnect = new DevExpress.XtraEditors.LabelControl();
            this.btb_BigFrienPicture = new System.Windows.Forms.PictureBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Receive = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HangUp = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.trackBarIn = new DevExpress.XtraEditors.RangeTrackBarControl();
            this.trackBarOut = new DevExpress.XtraEditors.RangeTrackBarControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MyselfPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btb_BigFrienPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOut.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(554, 424);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ptb_MyselfPicture);
            this.panelControl3.Controls.Add(this.pictureBox1);
            this.panelControl3.Controls.Add(this.lbl_WaitingConnect);
            this.panelControl3.Controls.Add(this.btb_BigFrienPicture);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(550, 359);
            this.panelControl3.TabIndex = 1;
            // 
            // ptb_MyselfPicture
            // 
            this.ptb_MyselfPicture.Image = ((System.Drawing.Image)(resources.GetObject("ptb_MyselfPicture.Image")));
            this.ptb_MyselfPicture.Location = new System.Drawing.Point(429, 238);
            this.ptb_MyselfPicture.Name = "ptb_MyselfPicture";
            this.ptb_MyselfPicture.Size = new System.Drawing.Size(116, 116);
            this.ptb_MyselfPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_MyselfPicture.TabIndex = 3;
            this.ptb_MyselfPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_WaitingConnect
            // 
            this.lbl_WaitingConnect.Appearance.BackColor = System.Drawing.Color.Black;
            this.lbl_WaitingConnect.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lbl_WaitingConnect.Location = new System.Drawing.Point(213, 55);
            this.lbl_WaitingConnect.Name = "lbl_WaitingConnect";
            this.lbl_WaitingConnect.Size = new System.Drawing.Size(124, 14);
            this.lbl_WaitingConnect.TabIndex = 0;
            this.lbl_WaitingConnect.Text = "正在等待对方回应... ...";
            // 
            // btb_BigFrienPicture
            // 
            this.btb_BigFrienPicture.BackColor = System.Drawing.Color.Black;
            this.btb_BigFrienPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btb_BigFrienPicture.Location = new System.Drawing.Point(2, 2);
            this.btb_BigFrienPicture.Name = "btb_BigFrienPicture";
            this.btb_BigFrienPicture.Size = new System.Drawing.Size(546, 355);
            this.btb_BigFrienPicture.TabIndex = 1;
            this.btb_BigFrienPicture.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Receive);
            this.panelControl2.Controls.Add(this.btn_HangUp);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 362);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(550, 60);
            this.panelControl2.TabIndex = 0;
            // 
            // btn_Receive
            // 
            this.btn_Receive.Image = ((System.Drawing.Image)(resources.GetObject("btn_Receive.Image")));
            this.btn_Receive.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Receive.Location = new System.Drawing.Point(409, 10);
            this.btn_Receive.Name = "btn_Receive";
            this.btn_Receive.Size = new System.Drawing.Size(64, 40);
            this.btn_Receive.TabIndex = 1;
            this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
            // 
            // btn_HangUp
            // 
            this.btn_HangUp.Image = ((System.Drawing.Image)(resources.GetObject("btn_HangUp.Image")));
            this.btn_HangUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_HangUp.Location = new System.Drawing.Point(479, 9);
            this.btn_HangUp.Name = "btn_HangUp";
            this.btn_HangUp.Size = new System.Drawing.Size(64, 40);
            this.btn_HangUp.TabIndex = 1;
            this.btn_HangUp.Click += new System.EventHandler(this.btn_HangUp_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.trackBarIn);
            this.groupControl1.Controls.Add(this.trackBarOut);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(392, 60);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // trackBarIn
            // 
            this.trackBarIn.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(0, 0);
            this.trackBarIn.Location = new System.Drawing.Point(191, 0);
            this.trackBarIn.Name = "trackBarIn";
            this.trackBarIn.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarIn.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarIn.Size = new System.Drawing.Size(80, 45);
            this.trackBarIn.TabIndex = 1;
            this.trackBarIn.EditValueChanged += new System.EventHandler(this.trackBarIn_EditValueChanged);
            // 
            // trackBarOut
            // 
            this.trackBarOut.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(0, 0);
            this.trackBarOut.Location = new System.Drawing.Point(48, 0);
            this.trackBarOut.Name = "trackBarOut";
            this.trackBarOut.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarOut.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarOut.Size = new System.Drawing.Size(80, 45);
            this.trackBarOut.TabIndex = 1;
            this.trackBarOut.EditValueChanged += new System.EventHandler(this.trackBarOut_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(137, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "麦克风：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "音量：";
            // 
            // VideoTalkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 424);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VideoTalkFrm";
            this.Text = "视频聊天窗口";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MyselfPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btb_BigFrienPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lbl_WaitingConnect;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_HangUp;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.PictureBox ptb_MyselfPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btb_BigFrienPicture;
        private DevExpress.XtraEditors.RangeTrackBarControl trackBarIn;
        private DevExpress.XtraEditors.RangeTrackBarControl trackBarOut;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Receive;
    }
}
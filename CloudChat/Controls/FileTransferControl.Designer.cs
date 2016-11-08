namespace CloudChat
{
    partial class FileTransferControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTransferControl));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_FileInfo = new DevExpress.XtraEditors.LabelControl();
            this.btn_Refuse = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Access = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_Process = new DevExpress.XtraEditors.LabelControl();
            this.lbl_State = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.PersentTimer = new System.Windows.Forms.Timer(this.components);
            this.receiveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_FileInfo);
            this.panelControl1.Controls.Add(this.btn_Refuse);
            this.panelControl1.Controls.Add(this.btn_Access);
            this.panelControl1.Controls.Add(this.lbl_Process);
            this.panelControl1.Controls.Add(this.lbl_State);
            this.panelControl1.Controls.Add(this.progressBarControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(133, 175);
            this.panelControl1.TabIndex = 0;
            // 
            // lbl_FileInfo
            // 
            this.lbl_FileInfo.Location = new System.Drawing.Point(16, 6);
            this.lbl_FileInfo.Name = "lbl_FileInfo";
            this.lbl_FileInfo.Size = new System.Drawing.Size(96, 14);
            this.lbl_FileInfo.TabIndex = 3;
            this.lbl_FileInfo.Text = "文件名称（大小）";
            // 
            // btn_Refuse
            // 
            this.btn_Refuse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refuse.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refuse.Image")));
            this.btn_Refuse.Location = new System.Drawing.Point(69, 141);
            this.btn_Refuse.Name = "btn_Refuse";
            this.btn_Refuse.Size = new System.Drawing.Size(56, 23);
            this.btn_Refuse.TabIndex = 2;
            this.btn_Refuse.Text = "拒绝";
            this.btn_Refuse.Click += new System.EventHandler(this.btn_Refuse_Click);
            // 
            // btn_Access
            // 
            this.btn_Access.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Access.Image = ((System.Drawing.Image)(resources.GetObject("btn_Access.Image")));
            this.btn_Access.Location = new System.Drawing.Point(7, 141);
            this.btn_Access.Name = "btn_Access";
            this.btn_Access.Size = new System.Drawing.Size(56, 23);
            this.btn_Access.TabIndex = 2;
            this.btn_Access.Text = "接收";
            this.btn_Access.Click += new System.EventHandler(this.btn_Access_Click);
            // 
            // lbl_Process
            // 
            this.lbl_Process.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Process.Location = new System.Drawing.Point(31, 101);
            this.lbl_Process.Name = "lbl_Process";
            this.lbl_Process.Size = new System.Drawing.Size(55, 14);
            this.lbl_Process.TabIndex = 1;
            this.lbl_Process.Text = "进度：0%";
            // 
            // lbl_State
            // 
            this.lbl_State.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_State.Location = new System.Drawing.Point(31, 48);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(72, 14);
            this.lbl_State.TabIndex = 1;
            this.lbl_State.Text = "正在传输中...";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.Location = new System.Drawing.Point(9, 77);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(114, 18);
            this.progressBarControl1.TabIndex = 0;
            // 
            // PersentTimer
            // 
            this.PersentTimer.Tick += new System.EventHandler(this.PersentTimer_Tick);
            // 
            // receiveTimer
            // 
            this.receiveTimer.Tick += new System.EventHandler(this.receiveTimer_Tick);
            // 
            // FileTransferControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "FileTransferControl";
            this.Size = new System.Drawing.Size(133, 175);
            this.Load += new System.EventHandler(this.FileTransferControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Refuse;
        private DevExpress.XtraEditors.SimpleButton btn_Access;
        private DevExpress.XtraEditors.LabelControl lbl_Process;
        private DevExpress.XtraEditors.LabelControl lbl_State;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Timer PersentTimer;
        private System.Windows.Forms.Timer receiveTimer;
        private DevExpress.XtraEditors.LabelControl lbl_FileInfo;
    }
}

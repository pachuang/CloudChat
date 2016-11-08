namespace CloudChat
{
    partial class TalkWinFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkWinFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Sigenature = new DevExpress.XtraEditors.LabelControl();
            this.lbl_NickName = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Send = new DevExpress.XtraEditors.SimpleButton();
            this.rec_ChatMessage = new DevExpress.XtraRichEdit.RichEditControl();
            this.rec_SendMessage = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_Sigenature);
            this.panelControl1.Controls.Add(this.lbl_NickName);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Location = new System.Drawing.Point(3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(491, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // lbl_Sigenature
            // 
            this.lbl_Sigenature.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Sigenature.Location = new System.Drawing.Point(150, 20);
            this.lbl_Sigenature.Name = "lbl_Sigenature";
            this.lbl_Sigenature.Size = new System.Drawing.Size(331, 26);
            this.lbl_Sigenature.TabIndex = 2;
            this.lbl_Sigenature.Text = "个性签名:";
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_NickName.Location = new System.Drawing.Point(68, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(125, 26);
            this.lbl_NickName.TabIndex = 1;
            this.lbl_NickName.Text = "昵      称";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(52, 51);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rec_ChatMessage);
            this.panelControl2.Location = new System.Drawing.Point(3, 59);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(491, 211);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.rec_SendMessage);
            this.panelControl3.Controls.Add(this.btn_Close);
            this.panelControl3.Controls.Add(this.btn_Send);
            this.panelControl3.Location = new System.Drawing.Point(3, 276);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(491, 145);
            this.panelControl3.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(406, 119);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "关闭";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(316, 119);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "发送";
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // rec_ChatMessage
            // 
            this.rec_ChatMessage.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rec_ChatMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rec_ChatMessage.Location = new System.Drawing.Point(2, 2);
            this.rec_ChatMessage.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rec_ChatMessage.Name = "rec_ChatMessage";
            this.rec_ChatMessage.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.rec_ChatMessage.Options.MailMerge.KeepLastParagraph = false;
            this.rec_ChatMessage.ReadOnly = true;
            this.rec_ChatMessage.Size = new System.Drawing.Size(487, 207);
            this.rec_ChatMessage.TabIndex = 1;
            // 
            // rec_SendMessage
            // 
            this.rec_SendMessage.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rec_SendMessage.Location = new System.Drawing.Point(2, 33);
            this.rec_SendMessage.Name = "rec_SendMessage";
            this.rec_SendMessage.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.rec_SendMessage.Options.MailMerge.KeepLastParagraph = false;
            this.rec_SendMessage.Size = new System.Drawing.Size(487, 80);
            this.rec_SendMessage.TabIndex = 2;
            this.rec_SendMessage.Text = "输入对话内容... ...";
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(491, 32);
            this.panelControl4.TabIndex = 3;
            // 
            // TalkWinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(496, 423);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TalkWinFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "和谁谁聊天。。。";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_Sigenature;
        private DevExpress.XtraEditors.LabelControl lbl_NickName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private DevExpress.XtraEditors.SimpleButton btn_Send;
        private DevExpress.XtraRichEdit.RichEditControl rec_ChatMessage;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraRichEdit.RichEditControl rec_SendMessage;
    }
}
namespace CloudChat
{
    partial class UserInformationSetFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformationSetFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Picture = new DevExpress.XtraEditors.SimpleButton();
            this.pte_Picture = new DevExpress.XtraEditors.PictureEdit();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lup_Sex = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_Sigenature = new DevExpress.XtraEditors.TextEdit();
            this.txt_Department = new DevExpress.XtraEditors.TextEdit();
            this.txt_NickName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pte_Picture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lup_Sex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sigenature.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NickName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Picture);
            this.panelControl1.Controls.Add(this.pte_Picture);
            this.panelControl1.Controls.Add(this.btn_Cancle);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.lup_Sex);
            this.panelControl1.Controls.Add(this.txt_Sigenature);
            this.panelControl1.Controls.Add(this.txt_Department);
            this.panelControl1.Controls.Add(this.txt_NickName);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(430, 340);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Picture
            // 
            this.btn_Picture.Location = new System.Drawing.Point(152, 175);
            this.btn_Picture.Name = "btn_Picture";
            this.btn_Picture.Size = new System.Drawing.Size(75, 23);
            this.btn_Picture.TabIndex = 6;
            this.btn_Picture.Text = "更换头像";
            this.btn_Picture.Click += new System.EventHandler(this.btn_Picture_Click);
            // 
            // pte_Picture
            // 
            this.pte_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pte_Picture.EditValue = ((object)(resources.GetObject("pte_Picture.EditValue")));
            this.pte_Picture.Location = new System.Drawing.Point(79, 134);
            this.pte_Picture.Name = "pte_Picture";
            this.pte_Picture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pte_Picture.Size = new System.Drawing.Size(66, 65);
            this.pte_Picture.TabIndex = 5;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Location = new System.Drawing.Point(243, 289);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 3;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(102, 289);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lup_Sex
            // 
            this.lup_Sex.Location = new System.Drawing.Point(254, 24);
            this.lup_Sex.Name = "lup_Sex";
            this.lup_Sex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lup_Sex.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value")});
            this.lup_Sex.Properties.NullText = "";
            this.lup_Sex.Properties.ShowFooter = false;
            this.lup_Sex.Properties.ShowHeader = false;
            this.lup_Sex.Size = new System.Drawing.Size(100, 20);
            this.lup_Sex.TabIndex = 2;
            // 
            // txt_Sigenature
            // 
            this.txt_Sigenature.Location = new System.Drawing.Point(79, 94);
            this.txt_Sigenature.Name = "txt_Sigenature";
            this.txt_Sigenature.Size = new System.Drawing.Size(313, 20);
            this.txt_Sigenature.TabIndex = 1;
            // 
            // txt_Department
            // 
            this.txt_Department.Location = new System.Drawing.Point(79, 59);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(100, 20);
            this.txt_Department.TabIndex = 1;
            // 
            // txt_NickName
            // 
            this.txt_NickName.Location = new System.Drawing.Point(79, 24);
            this.txt_NickName.Name = "txt_NickName";
            this.txt_NickName.Size = new System.Drawing.Size(100, 20);
            this.txt_NickName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(196, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "性      别：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 134);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "头      像：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "个性签名：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "部      门：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "昵      称：";
            // 
            // UserInformationSetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 340);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInformationSetFrm";
            this.Text = "用户信息设置";
            this.Load += new System.EventHandler(this.UserInformationSetFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pte_Picture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lup_Sex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sigenature.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NickName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lup_Sex;
        private DevExpress.XtraEditors.TextEdit txt_Sigenature;
        private DevExpress.XtraEditors.TextEdit txt_NickName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Department;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Picture;
        private DevExpress.XtraEditors.PictureEdit pte_Picture;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
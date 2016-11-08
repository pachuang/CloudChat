namespace CloudChat
{
    partial class MainUI
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.Picture = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.NickName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Staturs = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Signature = new DevExpress.XtraEditors.LabelControl();
            this.lbl_NikeName = new DevExpress.XtraEditors.LabelControl();
            this.TreeListImageFace = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListImageFace)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 505);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(5, 457);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(274, 41);
            this.panelControl4.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.treeList1);
            this.panelControl3.Location = new System.Drawing.Point(5, 98);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(274, 353);
            this.panelControl3.TabIndex = 1;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.Picture,
            this.NickName,
            this.Staturs});
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(936, 416, 234, 217);
            this.treeList1.Location = new System.Drawing.Point(5, 5);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TreeListImageFace});
            this.treeList1.Size = new System.Drawing.Size(262, 343);
            this.treeList1.TabIndex = 0;
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // Picture
            // 
            this.Picture.Caption = "头像";
            this.Picture.ColumnEdit = this.TreeListImageFace;
            this.Picture.FieldName = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.Visible = true;
            this.Picture.VisibleIndex = 0;
            this.Picture.Width = 71;
            // 
            // NickName
            // 
            this.NickName.Caption = "昵称";
            this.NickName.FieldName = "NickName";
            this.NickName.Name = "NickName";
            this.NickName.Visible = true;
            this.NickName.VisibleIndex = 1;
            this.NickName.Width = 125;
            // 
            // Staturs
            // 
            this.Staturs.Caption = "状态";
            this.Staturs.FieldName = "Staturs";
            this.Staturs.Name = "Staturs";
            this.Staturs.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.Staturs.Visible = true;
            this.Staturs.VisibleIndex = 2;
            this.Staturs.Width = 48;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lbl_Signature);
            this.panelControl2.Controls.Add(this.lbl_NikeName);
            this.panelControl2.Location = new System.Drawing.Point(5, 6);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(274, 86);
            this.panelControl2.TabIndex = 0;
            // 
            // lbl_Signature
            // 
            this.lbl_Signature.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Signature.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Signature.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbl_Signature.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lbl_Signature.LineVisible = true;
            this.lbl_Signature.Location = new System.Drawing.Point(8, 50);
            this.lbl_Signature.Name = "lbl_Signature";
            this.lbl_Signature.Size = new System.Drawing.Size(259, 20);
            this.lbl_Signature.TabIndex = 1;
            this.lbl_Signature.Text = "自己的专属个性签名。";
            // 
            // lbl_NikeName
            // 
            this.lbl_NikeName.Appearance.Font = new System.Drawing.Font("华文隶书", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NikeName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_NikeName.Location = new System.Drawing.Point(8, 7);
            this.lbl_NikeName.Name = "lbl_NikeName";
            this.lbl_NikeName.Size = new System.Drawing.Size(259, 36);
            this.lbl_NikeName.TabIndex = 0;
            this.lbl_NikeName.Text = "专属昵称";
            // 
            // TreeListImageFace
            // 
            this.TreeListImageFace.AutoHeight = false;
            this.TreeListImageFace.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TreeListImageFace.Name = "TreeListImageFace";
            // 
            // MainUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 505);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "畅聊";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreeListImageFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Picture;
        private DevExpress.XtraTreeList.Columns.TreeListColumn NickName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Staturs;
        private DevExpress.XtraEditors.LabelControl lbl_Signature;
        private DevExpress.XtraEditors.LabelControl lbl_NikeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit TreeListImageFace;
    }
}


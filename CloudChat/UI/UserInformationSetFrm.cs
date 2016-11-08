using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CloudChat.Entity;
using System.IO;

namespace CloudChat
{
    public partial class UserInformationSetFrm : DevExpress.XtraEditors.XtraForm
    {
        public UserInformationSetFrm()
        {
            InitializeComponent();
        }
        public UserInformationSetFrm(FriendEntity FE)
        {
            InitializeComponent();
            this.Friend = FE;
        }

        private FriendEntity Friend { get; set; }

        private void btn_Save_Click(object sender, EventArgs e)//保存
        {
            //if (DevExpress.XtraEditors.XtraMessageBox.Show("确定要保存吗？", "SystemMessage", MessageBoxButtons.OK) == DialogResult.Cancel)
            //    return;
            try
            {
                string FilePath = System.Environment.CurrentDirectory + @"\MainEntityData.xml";
                Program.MainEntity.NickName = this.txt_NickName.Text;
                Program.MainEntity.Sex = this.lup_Sex.Text;
                Program.MainEntity.Sigenature = this.txt_Sigenature.Text;
                Program.MainEntity.Department = this.txt_Department.Text;
                Program.MainEntity.Picture = this.pte_Picture.ToolTip;
                HandleMethod.ModifyEntityXMLFile(FilePath, Program.MainEntity, "M");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("保存过程出现错误:"+ex.Message);
            }

        }

        private void btn_Cancle_Click(object sender, EventArgs e)//取消
        {
            this.Close();
        }

        private void UserInformationSetFrm_Load(object sender, EventArgs e)//窗体登陆
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Key",typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("Value",typeof(string));
            dt.Columns.Add(dc);
            DataRow dr = dt.NewRow();
            dr["Key"] = "1";
            dr["Value"] = "男";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["Key"] = "2";
            dr["Value"] = "女";
            dt.Rows.Add(dr);
            this.lup_Sex.Properties.DataSource = dt;
            this.lup_Sex.Properties.DisplayMember = "Value";
            this.lup_Sex.Properties.ValueMember = "Key";
            this.lup_Sex.Properties.PopupWidth = 100;

            if (Friend != null)
            {
                this.txt_NickName.Text = Friend.NickName;
                this.txt_Department.Text = Friend.Department;
                this.txt_Sigenature.Text = Friend.Sigenature;
                if (Friend.Sex == "男")
                {
                    this.lup_Sex.ItemIndex = 0;
                }
                else
                    this.lup_Sex.ItemIndex = 1;
                if (File.Exists(System.Environment.CurrentDirectory + @"\HeadPicture" + Friend.Picture))
                {
                    this.pte_Picture.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\HeadPicture" + Friend.Picture);
                    this.pte_Picture.ToolTip = Friend.Picture;
                }
            }

        }

        private void btn_Picture_Click(object sender, EventArgs e)//更换头像
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "所有文件|*.*|img文件|*.bmp|jpg文件|*.JPG";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string SoucePath = System.Environment.CurrentDirectory + @"\HeadPicture";
                string FromPath = OFD.FileName;
                
                if (FromPath.Length > 0)
                {
                    
                   
                    string PictureName = FromPath.Substring(FromPath.LastIndexOf(@"\"));
                    string NewFile = SoucePath + PictureName;
                    if (NewFile != FromPath)
                    {
                        if (File.Exists(NewFile))
                        {
                            File.Delete(NewFile);
                        }
                        File.Copy(FromPath, NewFile);
                    }
                    this.pte_Picture.Image = Image.FromFile(NewFile);
                    this.pte_Picture.ToolTip = PictureName;//记录文件名
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CloudChat.Entity;
using System.IO;

namespace CloudChat
{
    public partial class VideoApplyFrm : DevExpress.XtraEditors.XtraForm
    {
        public VideoApplyFrm()
        {
            InitializeComponent();
        }
        public VideoApplyFrm(FriendEntity FriendInfo)
        {
            InitializeComponent();
            this.labelControl1.Text = FriendInfo.NickName + " 正在请求视频通话！";
            string PicPath = System.Environment.CurrentDirectory + @"\HeadPicture" + FriendInfo.Picture;
            if (File.Exists(PicPath))
            {
                this.pictureEdit1.Image = Image.FromFile(PicPath);
            }
        }
        private void btn_Agree_Click(object sender, EventArgs e)//同意
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_Refuse_Click(object sender, EventArgs e)//拒绝
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
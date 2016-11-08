using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CloudChat.Entity;
using System.Net;
using System.IO;
using System.Threading;


namespace CloudChat
{
    public partial class TalkWinFrm : DevExpress.XtraEditors.XtraForm
    {
        private bool AgreeConnect = false;
        private FriendEntity me;

        public TalkWinFrm()
        {
            InitializeComponent();
        }

        public TalkWinFrm(MessageEntity ME)
        {
            InitializeComponent();
            if (ME != null)
            {
                this.me = ME.MyInformation ;
                this.lbl_NickName.Text = ME.MyInformation.TrueName;
                this.lbl_Sigenature.Text = ME.MyInformation.Sigenature;
                this.Text = "和" + ME.MyInformation.TrueName+"畅聊中......";
                this.Tag = ME.MyInformation.IPAdress;//IP地址作为交流窗体的唯一标识
                this.rec_ChatMessage.Text += ME.MyInformation.TrueName + "：    " + ME.DateTime + @"
";
                this.rec_ChatMessage.Text += ME.Message + @"
";
                if (ME.MyInformation.Picture.Length > 0)
                {
                    string SoucePath = System.Environment.CurrentDirectory + @"\HeadPicture"+ME.MyInformation.Picture;
                    if (File.Exists(SoucePath))
                    {
                        this.pictureEdit1.Image = Image.FromFile(SoucePath);
                    }
                }
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(this.rec_SendMessage.Text.Length<=0)
            {
              return;
            }
            IPEndPoint Localpoint = new IPEndPoint(IPAddress.Parse(this.Tag.ToString()), 8002);
            HandleMethod.UdpBrodcastSend("Message", this.rec_SendMessage.Text, Localpoint);
            this.rec_ChatMessage.Text +=  "我：    " + DateTime.Now.ToString() + @"
";
            this.rec_ChatMessage.Text += this.rec_SendMessage.Text + @"
";
            this.rec_SendMessage.Text = "";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FreshChatMessage(MessageEntity ME)
        {
            if (ME != null)
            {
                this.rec_ChatMessage.Text += ME.MyInformation.TrueName + "：    " + ME.DateTime + @"
";
                this.rec_ChatMessage.Text += ME.Message + @"
";
            }
        }

        private void btn_VedioTalk_Click(object sender, EventArgs e)
        {
            VideoTalkFrm VideoTalk = new VideoTalkFrm(this.me);
            //Thread VedioThread = new Thread(VedioTalk.Show);
            //VideoThread.Start();
            //VideoThread.IsBackground = true;
            VideoTalk.SetParameter(IPAddress.Parse(this.Tag.ToString()), 8002,"");
            VideoTalk.Show();
        }

        private void 发送文件ToolStripMenuItem_Click(object sender, EventArgs e)//发送文件
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = true;
            fd.Filter = "所有文件|*.*";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                if (fd.FileName.Length > 0)
                {
                    FileTransferControl FileTransferCon = new FileTransferControl();
                    FileTransferCon.ReceiveOrSend = true;
                    FileTransferCon.MySelefInfo = Program.MainEntity;
                    FileTransferCon.FrieInfo = this.me;

                    //发送传输文件消息
                    FileTransferCon.FilePath = fd.FileName;
                    int IndexNum = fd.FileName.LastIndexOf('\\', 0);
                    string FileName = fd.FileName.Substring(IndexNum+1);
                    long FileLenth = new FileInfo(fd.FileName).Length; //获取文件的大小
                    string NewMessage = FileName + "," + FileLenth.ToString();
                    FileTransferCon.FileName = FileName;
                    FileTransferCon.FileSize = int.Parse(FileLenth.ToString());
                    IPEndPoint Localpoint = new IPEndPoint(IPAddress.Parse(this.Tag.ToString()), 8002);
                    HandleMethod.UdpBrodcastSend("FileAplly",NewMessage, Localpoint);

                    FileTransferCon.Parent = panelControl7;
                    FileTransferCon.Dock = System.Windows.Forms.DockStyle.Fill;

                }
            }
        }

        public void ReceiveFile(MessageEntity MessageEx)//被动接受文件方法
        {
            FileTransferControl FileTransferCon = new FileTransferControl();
            FileTransferCon.Name = "ReceiveCon";
            FileTransferCon.ReceiveOrSend = false;
            FileTransferCon.MySelefInfo = Program.MainEntity;
            FileTransferCon.FrieInfo = this.me;

            string[] FileInfoArray = MessageEx.Message.Split(',');
            if (FileInfoArray.Count() >= 2)
            {
                FileTransferCon.FileName = FileInfoArray[0];
                FileTransferCon.FileSize = int.Parse(FileInfoArray[1]);
            }

            FileTransferCon.Parent = panelControl7;
            FileTransferCon.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public void RefuseFile(MessageEntity MessgeEx,bool refuseOrCancle)//被拒绝发送文件
        {
            if (refuseOrCancle)
            {
                this.rec_ChatMessage.Text += @"对方拒绝了接收传输的文件！
";
            }else
                this.rec_ChatMessage.Text += @"对方取消了传输文件！
";
            if (panelControl7.HasChildren)
            {
                foreach (Control item in panelControl7.Controls)
                {
                    if (item.GetType().ToString() == "CloudChat.FileTransferControl")
                    {
                        item.Dispose();
                        break;
                    }
                }
            }
        }

        public void AgreeReceive(MessageEntity MessgeEx)//对方同意接受文件
        {
            //if (panelControl7.HasChildren)
            //{
            //    panelControl7.Controls
            //}
        }

    }
}

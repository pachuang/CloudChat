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

namespace CloudChat
{
    public partial class TalkWinFrm : Form
    {
        public TalkWinFrm()
        {
            InitializeComponent();
        }
        public TalkWinFrm(MessageEntity ME)
        {
            InitializeComponent();
            if (ME != null)
            {
                this.lbl_NickName.Text = ME.MyInformation.TrueName;
                this.lbl_Sigenature.Text = ME.MyInformation.Sigenature;
                this.Text = "和" + ME.MyInformation.TrueName+"畅聊中......";
                this.Tag = ME.MyInformation.IPAdress;//IP地址作为交流窗体的唯一标识
                this.rec_ChatMessage.Text += ME.MyInformation.TrueName + "：    " + ME.DateTime + @"
";
                this.rec_ChatMessage.Text += ME.Message + @"
";
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
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
    }
}

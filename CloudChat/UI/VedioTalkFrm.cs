using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IMLibrary.AV;
using CloudChat.Entity;
using System.Net;

namespace CloudChat
{
    public partial class VideoTalkFrm : DevExpress.XtraEditors.XtraForm
    {
        private IMLibrary.AV.AV VideoEntity;
        private Mixer mixer;
        private Mixer.MixerControlDetail indtl, outdtl;//音频
        private System.Net.IPAddress FriendIP;//对方的公网IP
        private int FriendPort;//对方的端口号
        private FriendEntity FrienInfo;//对方信息
        string SendID;
        private bool IsAV = false;//表示当前是否正在视频中

        public VideoTalkFrm()
        {
            InitializeComponent();
            InitializeMixing();
        }
        public VideoTalkFrm( FriendEntity friend)
        {
            InitializeComponent();
            InitializeMixing();
            if (friend != null)
            {
                this.FrienInfo = friend;
                this.FriendIP = System.Net.IPAddress.Parse(friend.IPAdress);
                this.FriendPort = int.Parse(friend.Poin);
                this.Tag = friend.IPAdress;
            }
        }
        public VideoTalkFrm(string AcceptVideo,FriendEntity friend)
        {
            InitializeComponent();
            InitializeMixing();
            if (friend != null)
            {
                this.FrienInfo = friend;
                this.FriendIP = System.Net.IPAddress.Parse(friend.IPAdress);
                this.FriendPort = int.Parse(friend.Poin);
                this.Tag = friend.IPAdress;
            }
            if (AcceptVideo == "Accept")
            {
                this.Connect(friend.IPAdress,int.Parse(friend.Poin));
                this.IsAV = true;
            }
            
        }
        #region  AV传输事件

        public delegate void AVReceveEventHandler(object sender, bool isSelf);//接收AV对话事件
        public event AVReceveEventHandler AVReceve;

        public delegate void AVCancelEventHandler(object sender, bool isSelf);//取消AV对话事件
        public event AVCancelEventHandler AVCancel;

        #endregion

        private void InitializeMixing()//初始化声卡麦克风
        {
            mixer = new Mixer(this);
            mixer.MixerControlChange += new EventHandler(mixer_MixerControlChange);

            this.outdtl = new Mixer.MixerControlDetail(mixer, Mixer.MIXERLINE_COMPONENTTYPE_DST_SPEAKERS);
            this.trackBarOut.Properties.Minimum = this.outdtl.Min;
            this.trackBarOut.Properties.Maximum = this.outdtl.Max;
            this.trackBarOut.Properties.TickFrequency = this.outdtl.Volume;

            this.indtl = new Mixer.MixerControlDetail(mixer, Mixer.MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE);
            this.trackBarIn.Properties.Minimum = indtl.Min;
            this.trackBarIn.Properties.Maximum = indtl.Max;
            this.trackBarIn.Properties.TickFrequency = this.indtl.Volume;
        }
        public void SetParameter(System.Net.IPAddress ip, int port, string sendID)
        {
            this.FriendIP = ip;
            this.FriendPort = port;
            this.SendID = sendID;
            this.ReadyConnect();
        }

        public void ColseAV()//关闭当前正在进行的视频对话
        {
            IsAV = false;
            //this.linkLabelReceve.Visible = false;
            try
            {
                this.VideoEntity.AVChanel.Close();
            }
            catch { }
            try
            {
                this.VideoEntity.Chanel.Close();
            }
            catch { }
            try
            {
                this.VideoEntity.Dispose();
            }
            catch { }
        }

        private void mixer_MixerControlChange(object sender, EventArgs e)
        {
            this.trackBarIn.Properties.TickFrequency = this.indtl.Volume;
            this.trackBarOut.Properties.TickFrequency = this.outdtl.Volume;
        }

        public void Initialize()//初始化视频图片与sock
        {
            if (VideoEntity != null) this.VideoEntity.Dispose();
            this.VideoEntity = new AV(this.ptb_MyselfPicture, this.btb_BigFrienPicture);
            this.VideoEntity.IniChanel();
        }

        public AV AV
        {
            get { return this.VideoEntity; }
        }

        private void ReadyConnect()//准备连接，并告诉对方本地IP与端口，让其联接
        {
            if (!IsAV)
            {
                Initialize();
                ////此处方法需修改
                //byte[] msg = IMLibrary.TextEncoder.textToBytes(this.SendID);
                //byte[] buf = new byte[msg.Length + 2];
                //buf[0] = 255;//合法用户标识
                //buf[1] = 20;//消息类型
                //Buffer.BlockCopy(msg, 0, buf, 2, msg.Length);
                //this.VideoEntity.ReadyStrat(buf, this.FriendIP, this.FriendPort);

                IPEndPoint Localpoint = new IPEndPoint(IPAddress.Parse(this.FrienInfo.IPAdress), 8002);
                HandleMethod.UdpBrodcastSend("VideoApply","请求视频聊天！",Localpoint);
            }
            else
            {
                this.VideoEntity.AVChanel.Close();
                this.VideoEntity.Chanel.Close();
            }
            IsAV = !IsAV;
            //UDP打洞
        }

        public void Connect(string ip, int port)//连接到对方并且开始发送AV数据
        {
            this.VideoEntity.IniAudio();
            this.VideoEntity.IniVideo();
            this.VideoEntity.Start(ip, port);
        }

        public void Stop()//结束
        {
            if (this.VideoEntity != null) this.VideoEntity.Dispose();
        }
        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        mixer.MixerControlChange -= new EventHandler(mixer_MixerControlChange);
        //        try
        //        {
        //            this.VideoEntity.AVChanel.Close();
        //        }
        //        catch { }
        //        try
        //        {
        //            this.VideoEntity.Chanel.Close();
        //        }
        //        catch { }
        //        try
        //        {
        //            this.VideoEntity.Dispose();
        //        }
        //        catch { }

        //        if (components != null)
        //        {
        //            components.Dispose();
        //        }
        //    }
        //    base.Dispose(disposing);
        //}

        private void trackBarOut_EditValueChanged(object sender, EventArgs e)//音量滑块
        {
            this.outdtl.Volume = this.trackBarOut.Properties.TickFrequency;
        }

        private void trackBarIn_EditValueChanged(object sender, EventArgs e)//麦克风滑块
        {
            this.indtl.Volume = this.trackBarIn.Properties.TickFrequency;
        }

        private void btn_HangUp_Click(object sender, EventArgs e)//挂断
        {
            IsAV = false;

            try
            {
                this.VideoEntity.AVChanel.Close();
                this.VideoEntity.Chanel.Close();
                this.VideoEntity.Dispose();
            }
            catch { }
            this.AVCancel(this, true);//触发终止事件
        }

        private void btn_Receive_Click(object sender, EventArgs e)//接收
        {
            this.btn_Receive.Enabled = false;
            this.AVReceve(this, true);//触发接收事件
            Initialize();//初始化视频设备
            this.VideoEntity.IniAudio();//初始化音频设备
            this.VideoEntity.IniVideo();//初始化视频设备

            byte[] msg = IMLibrary.TextEncoder.textToBytes(this.SendID);

            byte[] buf = new byte[msg.Length + 2];
            buf[0] = 255;//合法用户标识
            buf[1] = 21;//消息类型
            Buffer.BlockCopy(msg, 0, buf, 2, msg.Length);

            this.AV.BeginAV(buf, this.FriendIP, this.FriendPort);//告诉对方可以开始视频
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;
using System.IO;
using CloudChat.Entity;
using IMLibrary;

namespace CloudChat
{
    public partial class MainUI : Form
    {
        private UdpClient UdpReseiveClient;
        private UdpClient UdpSendClient;
        private IPEndPoint BrodeAdress;
        private Thread BackGrounMonitor;
        private delegate void ReceaveDelegate(byte[] ByteArray);//接收数据的代理
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            //首先获取本机信息，定制终端点，个人信息等保存到MainEntity
            Program.MainEntity.IPAdress = Dns.GetHostAddresses("")
                                             .Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                             .First().ToString();
            Program.MainEntity.Poin = "8002";//默认端口8002
            //获取当前用户的设置
            if (File.Exists(System.Environment.CurrentDirectory + @"\MainEntityData.xml"))
            {
                HandleMethod.ReadXmlConf();
            }
            else
            {
                //获得主机名
                string HostName = Dns.GetHostName();
                string FilePath = System.Environment.CurrentDirectory + @"\MainEntityData.xml";
                HandleMethod.CreateEntityXMLFile(FilePath, HostName, Program.MainEntity.IPAdress, HostName, HostName, "男/女", "", "", "1", "撰写属于自己的个性签名");
                HandleMethod.ReadXmlConf();
            }
            this.lbl_NikeName.Text = Program.MainEntity.NickName;
            this.lbl_Signature.Text = Program.MainEntity.Sigenature;
            //广播自己上线  消息协议：[Login/out/Message],[IP：Port],[主机名或IP],[消息体]
            HandleMethod.UdpBrodcastSend("Login", "", null);
            //启动新线程监视端口接收消息
            BackGrounMonitor = new Thread(UdpBrodcastReseive);
            BackGrounMonitor.IsBackground = true;
            BackGrounMonitor.Start();

        }
        

        /// <summary>
        /// 监听端口消息
        /// </summary>
        private void UdpBrodcastReseive()//接受其他IP的数据
        {
            IPEndPoint Localpoint = new IPEndPoint(IPAddress.Parse(Program.MainEntity.IPAdress), 8002);
            UdpReseiveClient = new UdpClient(Localpoint);
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8002);
            while (true)
            {
                try
                {
                    // 关闭receiveUdpClient时此时会产生异常
                    byte[] receiveBytes = UdpReseiveClient.Receive(ref remoteIpEndPoint);

                    // 消息内容处理
                    //HandleReceiveByte(receiveBytes);
                    if (this.treeList1.InvokeRequired)
                    {
                        ReceaveDelegate RD = new ReceaveDelegate(HandleReceiveByte);
                        this.Invoke(RD,receiveBytes);
                    }

                }
                catch(Exception ex)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// 消息处理方法
        /// </summary>
        /// <param name="ByteArray">收到的消息体</param>
        private void HandleReceiveByte(byte[] ByteArray)//消息处理
        {
            var ReceiveMessage = (MessageEntity)null;   
            try
            {
                ReceiveMessage = (MessageEntity)IMLibrary.Serializers.ByteToObj(ByteArray);
                if (string.IsNullOrEmpty(ReceiveMessage.Flag))
                    return;
                if (string.IsNullOrEmpty(ReceiveMessage.Adress))
                    return;
            }
            catch (Exception ex)
            {

            }
            switch (ReceiveMessage.Flag)
            {
                case "Login":
                    //如果有此IP则忽略，否则增加好友列表并给此IP发送消息
                    var FriendList = from item in Program.FriendList where item.IPAdress == ReceiveMessage.Adress select item;
                    if (FriendList.Count() < 1)
                    {
                        Program.FriendList.Add(ReceiveMessage.MyInformation);
                        HandleMethod.UdpBrodcastSend("Login", "", new IPEndPoint(IPAddress.Parse(ReceiveMessage.Adress), 8002));
                        this.treeList1.DataSource = null;
                        this.treeList1.DataSource = Program.FriendList;
                        this.treeList1.Refresh();
                    }
                    break;
                case "Out":
                    //如果有此IP则删除好友，否则忽略
                    FriendList = from item in Program.FriendList where item.IPAdress == ReceiveMessage.Adress select item;
                    if (FriendList.Count() > 0)
                    {
                        foreach (var item in Program.FriendList)
                        {
                            if (item.IPAdress == ReceiveMessage.Adress)
                            {
                                Program.FriendList.Remove(item);
                                this.treeList1.DataSource = null;
                                this.treeList1.DataSource = Program.FriendList;
                                this.treeList1.Refresh();
                                break;
                            }
                        }
                    }
                    break;
                case "Message":
                    //查找好友列表中IP，如果存在，则头像闪烁并记录消息
                    FriendList = from item in Program.FriendList where item.IPAdress == ReceiveMessage.Adress select item;
                    if (FriendList.Count() > 0)
                    {
                        AccessMethod AccMethod = new AccessMethod();
                        var Frm =AccMethod.findForm(ReceiveMessage.Adress);
                        if (Frm != null)
                        {
                            //消息加入对话窗体控件显示窗体
                            TalkWinFrm frm = (TalkWinFrm)Frm;
                            frm.FreshChatMessage(ReceiveMessage);

                        }
                        else
                        {
                            TalkWinFrm NewFrm = new TalkWinFrm(ReceiveMessage);
                            //NewFrm.Name = ReceiveMessage.CumputerName;
                            //NewFrm.Tag = ReceiveMessage.Adress;
                            ////消息加入对话窗体控件展示
                            //NewFrm.Text = "和" + ReceiveMessage.MyInformation.TrueName + "聊天中...";
                            NewFrm.Show();
                        }
                    }
                    else
                        Program.FriendList.Add(ReceiveMessage.MyInformation);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 客户端退出时广播自己下线通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)//退出广播自己下线
        {
            HandleMethod.UdpBrodcastSend("Out", "", null);
        }





        private void SendMessage2Byte(object MessObj)
        {
            byte[] compresseddata = IMLibrary.Serializers.ObjToByte(MessObj);
        }
        private bool IFExit(string ConStr)//判断是否存在
        {
            return true;
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            if (this.treeList1.DataSource != null && this.treeList1.FocusedNode != null)
            {
                MessageEntity ME = new MessageEntity();
                string IP = this.treeList1.FocusedNode["IPAdress"].ToString();
                var FE = from item in Program.FriendList where item.IPAdress == IP select item;
                ME.MyInformation = FE.First();
                TalkWinFrm frm = new TalkWinFrm(ME);
                frm.Show();
            }
        }
    }
}

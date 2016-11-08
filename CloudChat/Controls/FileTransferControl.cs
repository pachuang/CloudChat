using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CloudChat.Entity;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace CloudChat
{
    public partial class FileTransferControl : UserControl
    {
        public FileTransferControl()
        {
            InitializeComponent();
        }
        //属性
        public FriendEntity FrieInfo{get;set;}
        public FriendEntity MySelefInfo { get; set; }
        public string FileName { get; set; }//文件名
        public int FileSize { get; set; }//文件大小
        TcpClient tcpClient = null;//TCP客户端
        TcpListener tcplis = null;//TCP监听
        TCPTransferFile tcpTrans = new TCPTransferFile();
        public string FilePath { get; set; }//文件全路径
        private delegate void  AcceptConnDelegate ();
        string ErrMsg = "";
        Thread FileThread = null;
        /// <summary>
        /// 发送时true接收是false
        /// </summary>
        public bool ReceiveOrSend { get; set; }
        

        private void FileTransferControl_Load(object sender, EventArgs e)//登陆事件
        {
            if (!this.ReceiveOrSend)
            {
                this.lbl_FileInfo.Text = this.FileName + string.Format(" ({0})", FileSize);
                this.lbl_State.Text = "是否同意接收？";
            }
            else
            {
                this.lbl_FileInfo.Text = this.FileName + string.Format(" ({0})", FileSize);
                this.lbl_State.Text = "等待对方接收！";
                this.btn_Access.Enabled = false;
                this.btn_Refuse.Text = "取消";
                this.receiveTimer.Start();
                //this.tcpClient = new TcpClient();

            }
        }

        private void btn_Access_Click(object sender, EventArgs e)//同意接收
        {
            if (this.btn_Access.Text == "接收")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = this.FileName;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    FilePath = saveFile.FileName;
                }
                else
                    return;
                if (FilePath.Length < 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("请输入保存的文件名！");
                    return;
                }
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }
                tcplis = new TcpListener(IPAddress.Parse(this.MySelefInfo.IPAdress), 8003);//暂时默认8003，后期需更改为随记分配空闲端口
                tcplis.Start();
                //监听创建链接
                //tcpClient = tcplis.AcceptTcpClient();
                AcceptConnDelegate AccConDel = new AcceptConnDelegate(this.AcceptConnect);
                this.BeginInvoke(AccConDel);

                this.lbl_State.Text = "创建连接中......";
                this.receiveTimer.Start();
            }
            else if (this.btn_Access.Text == "打开文件")
            {
                OpenFileDialog opd = new OpenFileDialog();
                opd.FileName = this.FilePath;
                opd.ShowDialog();
            }
            else if (this.btn_Access.Text == "关闭")
            {
                this.Dispose();
            }
        }

        private void btn_Refuse_Click(object sender, EventArgs e)//拒绝接收
        {
            IPEndPoint Friendpoint = new IPEndPoint(IPAddress.Parse(FrieInfo.IPAdress), 8002);
            if (this.btn_Refuse.Text == "拒绝")
            {
                //发回拒绝的消息
                HandleMethod.UdpBrodcastSend("FileRefuse", "拒绝接收文件", Friendpoint);
                this.Dispose();
            }
            else if (this.btn_Refuse.Text == "取消")
            {
                //发回取消消息
                HandleMethod.UdpBrodcastSend("FileCancle", "取消发送文件", Friendpoint);
                this.Dispose();
            }
            else if (this.btn_Refuse.Text == "文件位置")
            {
                OpenFileDialog opd = new OpenFileDialog();
                opd.FileName = this.FilePath;
                opd.ShowDialog();
            }

        }

        private void receiveTimer_Tick(object sender, EventArgs e)//检测传输是否连接
        {
            if (this.tcpClient!=null&&this.tcpClient.Connected)
            {
                this.receiveTimer.Stop();
                if (!ReceiveOrSend)
                {
                    //this.FileThread = new Thread();
                    var ReceiDela = new TCPTransferFile.TCPReceiveDelegate(tcpTrans.ReceiveFile);
                    ReceiDela.BeginInvoke(tcpClient, FilePath, out ErrMsg, new AsyncCallback(this.TransferOver), null);
                    this.lbl_State.Text = "正在传输......";
                    this.PersentTimer.Start();
                }
                else
                {
                    var ReceiDela = new TCPTransferFile.TCPSendDelegate(tcpTrans.SendFile);
                    ReceiDela.BeginInvoke(tcpClient, FilePath, out ErrMsg, new AsyncCallback(this.TransferOver), null);
                    this.lbl_State.Text = "正在传输......";
                    this.PersentTimer.Start();
                }
            }
            else
            {
                if (ReceiveOrSend == true)
                {
                    try
                    {
                        if (tcpClient == null)
                            tcpClient = new TcpClient();
                        tcpClient.Connect(IPAddress.Parse(this.FrieInfo.IPAdress), 8003);
                    }
                    catch
                    {
                        //防止程序跳出
                    }
                }
            }
        }

        private void PersentTimer_Tick(object sender, EventArgs e)//检测传输进度
        {
            this.progressBarControl1.Properties.Maximum = tcpTrans.Size;
            this.progressBarControl1.Position = tcpTrans.Len;
            double Per = double.Parse(tcpTrans.Len.ToString()) / double.Parse(this.FileSize.ToString()) * 100.00;
            this.lbl_Process.Text = "已完成：" + string.Format("{0:F}",Per) + "%";

            if (tcpTrans.Len == FileSize)
            {
                this.PersentTimer.Stop();
                //this.btn_Refuse.Enabled = false;
                if (!this.ReceiveOrSend)
                {
                    this.btn_Refuse.Text = "文件位置";
                    this.btn_Access.Text = "打开文件";
                    this.btn_Access.Enabled = true;
                    this.btn_Refuse.Enabled = true;
                }
                else
                {
                    this.btn_Access.Text = "关闭";
                    this.btn_Access.Enabled = true;
                    this.btn_Refuse.Enabled = false;
                }
            }
        }

        private void TransferOver(IAsyncResult result)//传输结束
        {
            try
            {

                if (lbl_State.InvokeRequired)
                {
                    //this.Invoke( new Delegate(this.lbl_State.Text="传输完成！"));
                    //this.BeginInvoke(new Action<int>(delegate(int a) { lbl_State.Text = "传输完成!"; }));
                    this.BeginInvoke(new Func<bool>(delegate() { lbl_State.Text = "传输完成!"; return true; }));
                }
                else
                    this.lbl_State.Text = "传输完成!";
            }
            catch (Exception ex)
            {
                if (this.PersentTimer.Enabled)
                    this.PersentTimer.Stop();
                DevExpress.XtraEditors.XtraMessageBox.Show("传输完成后，回调函数报错！" + ex.Message);
            }
            finally
            {
                if (this.tcpClient != null)
                    this.tcpClient.Close();
                if (this.tcplis != null)
                    this.tcplis.Stop();
            }
        }

        private void AcceptConnect()//等待发送端连接
        {
            tcpClient = tcplis.AcceptTcpClient();
        }

    }
}

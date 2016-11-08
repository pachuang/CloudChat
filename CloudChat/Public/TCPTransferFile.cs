using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace CloudChat
{
    class TCPTransferFile
    {
        TcpClient client;

        /// <summary>
        /// 文件总大小
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// 已传输文件大小
        /// </summary>
        public int  Len { get; set; }
        public delegate bool TCPReceiveDelegate(TcpClient tcpClient, string SaveFileName, out string ErrMsg);
        public delegate bool TCPSendDelegate(TcpClient tcpClient, string SendFileName, out string ErrMsg);

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="tcpClient">TCP客户端</param>
        /// <param name="FilePathName">文件名</param>
        /// <param name="ErrMsg">错误信息</param>
        /// <returns>发送结果</returns>
        public bool SendFile(TcpClient tcpClient, string FilePathName, out string ErrMsg)
        {
            NetworkStream NetStream = null;
            FileStream Fstream = null;
            this.Size = 0;
            this.Len = 0;
            ErrMsg = "";
            if (FilePathName.Length <= 0)
            {
                ErrMsg = "请选择有效的文件！";
                return false;
            }
            if (tcpClient.Connected)
            {
                try
                {
                    NetStream = tcpClient.GetStream();
                    Fstream = new FileStream(FilePathName, FileMode.Open, FileAccess.Read);
                    while (tcpClient.Connected&&Len < Fstream.Length)
                    {
                        byte[] Butte = new byte[1024];
                        Size = Fstream.Read(Butte, 0, Butte.Length);
                        NetStream.Write(Butte, 0, Size);
                        //Size = Fstream.Length;
                        Len += Size;
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    if (Fstream != null)
                    {
                        Fstream.Flush();
                        Fstream.Close();
                    }
                    if (NetStream != null)
                    {
                        NetStream.Close();
                    }
                    
                    //if (tcpClient != null)
                    //{
                    //    tcpClient.Close();
                    //}
                }


            }
            else
            {
                ErrMsg = "没有建立TCP连接！";
                return false;
            }


        }

        /// <summary>
        /// 接收
        /// </summary>
        /// <param name="tcpclient">TCP客户端</param>
        /// <param name="FilePathName">文件名</param>
        /// <param name="ErrMsg">错误信息</param>
        /// <returns>接收结果</returns>
        public bool ReceiveFile(TcpClient tcpclient, string FilePathName, out string ErrMsg)
        {
            FileStream FStream = null;
            this.Size = 0;
            this.Len = 0;
            ErrMsg = "";
            if (FilePathName.Length <= 0)
            {
                ErrMsg = "文件名为空！";
                return false;
            }
            if (tcpclient != null)
            {
                //TcpClient tcpclient = tcpLis.AcceptTcpClient();
                if (tcpclient.Connected)
                {
                    NetworkStream NetStream = tcpclient.GetStream();
                    if (NetStream != null)
                    {

                        try
                        {
                            FStream = new FileStream(FilePathName, FileMode.Create, FileAccess.ReadWrite);
                            byte[] Butte = new byte[1024];
                            while (tcpclient.Connected&&(Size = NetStream.Read(Butte, 0, Butte.Length)) > 0)
                            {
                                FStream.Write(Butte, 0, Size);
                                Len += Size;
                            }

                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                        finally
                        {
                            if (FStream != null)
                            {
                                FStream.Flush();
                                FStream.Close();
                            }
                            if (NetStream != null)
                            {
                                //NetStream.Flush();
                                NetStream.Close();
                            }
                            
                            //if (tcpclient != null)
                            //{
                            //    tcpclient.Close();
                            //}

                        }

                    }
                    else
                        return false;
                }
                else
                {
                    ErrMsg = "没有建立TCP连接";
                    return false;
                }
            }
            else
            {
                ErrMsg = "TCP监听没有启动！";
                return false;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloudChat.Entity;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using IMLibrary;

namespace CloudChat
{
    public static class HandleMethod
    {

        private static UdpClient UdpReseiveClient;
        private static UdpClient UdpSendClient;
        private static IPEndPoint BrodeAdress;
        private static Thread BackGrounMonitor;


        /// <summary>
        /// 获取客户端配置项
        /// </summary>
        public static void  ReadXmlConf()
        {
            string XMLFilePath = string.Empty;
            try
            {
                XMLFilePath = System.Environment.CurrentDirectory;
                if (File.Exists(XMLFilePath + @"\MainEntityData.xml"))
                {
                    XElement LocalEntity = XElement.Load(XMLFilePath + @"\MainEntityData.xml");
                    IEnumerable<XElement> element = from ele in LocalEntity.Elements("FriendEntity")
                                                    where (string)ele.Attribute("name") == "LocalEntity"
                                                    select ele;
                    if (element.Count() == 1)
                    {
                        XElement TheELE = element.First();
                        Program.MainEntity.ComputerName = TheELE.Element("ComputerName").Value;
                        Program.MainEntity.NickName = TheELE.Element("NickName").Value;
                        Program.MainEntity.TrueName = TheELE.Element("TrueName").Value;
                        Program.MainEntity.Picture = TheELE.Element("Picture").Value;
                        Program.MainEntity.Sex = TheELE.Element("Sex").Value;
                        Program.MainEntity.Sigenature = TheELE.Element("Sigenature").Value;
                        Program.MainEntity.Staturs = "1";//上线
                        Program.MainEntity.Department = TheELE.Element("Department").Value;
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("获取本地客户端信息出错！");
                    }
                }
                else
                {
                    if (!CreateEntityXMLFile(XMLFilePath,"","","","","","","","",""))
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("创建客户端属性信息出错！");
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("读取本地信息出错！错误信息："+ex.Message);
            }

            #region
            //try
            //{
            //    if (File.Exists(@"E:\AppData\MainEntityData.xml"))
            //    {
            //        XmlDocument xmlDoc = new XmlDocument();
            //        xmlDoc.Load(@"E:\AppData\MainEntityData.xml");
            //        XmlNode xmlNode = xmlDoc.SelectSingleNode("MainEntity");
            //        XmlElement xmlEle = (XmlElement)xmlNode;
            //        Program.MainEntity.ComputerName = xmlEle.GetAttribute("ComputerName").ToString();
            //        Program.MainEntity.NickName = xmlEle.GetAttribute("NickName").ToString();
            //        Program.MainEntity.TrueName = xmlEle.GetAttribute("TrueName").ToString();
            //        Program.MainEntity.Picture = xmlEle.GetAttribute("Picture").ToString();
            //        Program.MainEntity.Sex = xmlEle.GetAttribute("Sex").ToString();
            //        Program.MainEntity.Sigenature = xmlEle.GetAttribute("Sigenature").ToString();
            //        Program.MainEntity.Staturs = "1";//上线
            //        Program.MainEntity.Department = xmlEle.GetAttribute("Department").ToString();
            //        //this.lbl_NikeName.Text = xmlEle.GetAttribute("NickName").ToString();
            //        //this.lbl_Signature.Text = xmlEle.GetAttribute("Sigenature").ToString();
            //    }
            //    else
            //    {
            //        //需增加获取本机信息保存至XML
            //        File.Create(@"..\AppData\MainEntityData.xml");
            //        XmlDocument xmlDoc = new XmlDocument();
            //        xmlDoc.Load(@"..\AppData\MainEntityData.xml");
            //        XmlElement xmlEle = xmlDoc.CreateElement("MainEntity");
            //        XmlAttribute xmlAtt = xmlDoc.CreateAttribute("ComputerName");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("IPAdress");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("Poin");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("NickName");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("TrueName");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("Sex");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("Picture");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("Department");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("Staturs");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlAtt = xmlDoc.CreateAttribute("Sigenature");
            //        xmlEle.SetAttributeNode(xmlAtt);
            //        xmlDoc.Save(@"..\AppData\MainEntityData.xml");
            //        ReadXmlConf();//迭代获取到本机设置信息
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return;
            //}
            #endregion
        }

        /// <summary>
        /// 创建记录设置属性XML
        /// </summary>
        /// <param name="FilePath">文件位置(包括文件名)</param>
        /// <param name="ComputeName">计算机名</param>
        /// <param name="IP">IP地址</param>
        /// <param name="NickName">昵称</param>
        /// <param name="TureName">实名</param>
        /// <param name="Sex">性别</param>
        /// <param name="Picture">头像图片</param>
        /// <param name="Department">部门</param>
        /// <param name="Staturs">状态</param>
        /// <param name="Sigenature">个性签名</param>
        /// <returns></returns>
        public static bool CreateEntityXMLFile(string FilePath, string ComputeName, string IP, string NickName, string TureName, string Sex, string Picture, string Department, string Staturs, string Sigenature)
        {
            if (FilePath.Length != 0)
            {
                try
                {
                    XDocument NewDoc = new XDocument();
                   var NewXel= new XElement("Entity",
                        new XElement("FriendEntity",new XAttribute("name","LocalEntity"),
                            new XElement("ComputerName",ComputeName),
                            new XElement("IPAdress",IP),
                            new XElement("NickName",NickName),
                            new XElement("TrueName",TureName),
                            new XElement("Sex",Sex),
                            new XElement("Picture",Picture),
                            new XElement("Department",Department),
                            new XElement("Staturs",Staturs),
                            new XElement("Sigenature",Sigenature)
                            )
                        );
                    NewDoc.Add(NewXel);
                    NewDoc.Save(FilePath);
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            else
                return false;
        }

        /// <summary>
        /// 修改或增加好友信息记录XML
        /// </summary>
        /// <param name="FilePath">文件位置</param>
        /// <param name="Friend">好友实体</param>
        /// <param name="CallStyle">调用方式 --"M"修改；"R"读取</param>   
        public static void ModifyEntityXMLFile(string FilePath,FriendEntity Friend,string CallStyle)
        {

            if (!File.Exists(FilePath))
            {
                return;
            }
            if (Friend == null)
                return;
            try
            {
                XElement NewEle = XElement.Load(FilePath);
                IEnumerable<XElement> Element = from ele in NewEle.Elements("FriendEntity")
                                                where (string)ele.Attribute("name")==Friend.ComputerName
                                                select ele;
                if (Element.Count() == 1&&CallStyle=="M")//已存在，修改
                {
                    //foreach(var ele in Element)
                    var ele = Element.First();
                    ele.Element("ComputerName").SetValue(Friend.ComputerName);
                    ele.Element("IPAdress").SetValue(Friend.IPAdress);
                    ele.Element("NickName").SetValue(Friend.NickName);
                    ele.Element("TrueName").SetValue(Friend.TrueName);
                    ele.Element("Sex").SetValue(Friend.Sex);
                    ele.Element("Picture").SetValue(Friend.Picture);
                    ele.Element("Department").SetValue(Friend.Department);
                    ele.Element("Sigenature").SetValue(Friend.Sigenature);
                    NewEle.Save(FilePath);
                }
                else if (Element.Count() > 1&&CallStyle=="M")//存在重复数据
                {
                    Element.Remove();
                    NewEle.Save(FilePath);
                    ModifyEntityXMLFile(FilePath, Friend,CallStyle);//递归增加节点
                }
                else if (Element.Count() ==0)//不存在
                {
                    XElement AddEle = new XElement("FriendEntity",
                        new XAttribute("name",Friend.ComputerName),
                        new XElement("ComputerName",Friend.ComputerName),
                        new XElement("IPAdress",Friend.IPAdress),
                        new XElement("NickName",Friend.NickName),
                        new XElement("TrueName",Friend.TrueName),
                        new XElement("Sex",Friend.Sex),
                        new XElement("Picture",Friend.Picture),
                        new XElement("Department",Friend.Department),
                        new XElement("Staturs","1"),
                        new XElement("Sigenature",Friend.Sigenature)
                        );
                    NewEle.Add(AddEle);
                    NewEle.Save(FilePath);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// 发送消息方法
        /// </summary>
        /// <param name="Flag">消息类型</param>
        /// <param name="Message">消息内容</param>
        /// <param name="endPoint">终点</param>
        public static void UdpBrodcastSend(string Flag, string Message, IPEndPoint endPoint)//发送消息
        {
            MessageEntity SendMess = new MessageEntity();
            SendMess.Flag = Flag;
            SendMess.Adress = Program.MainEntity.IPAdress;
            SendMess.Point = Program.MainEntity.Poin;
            SendMess.CumputerName = Program.MainEntity.ComputerName;
            SendMess.DateTime = DateTime.Now.ToString();
            SendMess.Message = Message;
            if (endPoint == null)
            {
                BrodeAdress = new IPEndPoint(IPAddress.Broadcast, 8002);//初始化广播地址
                SendMess.MyInformation = Program.MainEntity;
            }
            else
            {
                BrodeAdress = endPoint;
                SendMess.MyInformation = Program.MainEntity;
            }
            byte[] messagebytes = IMLibrary.Serializers.ObjToByte(SendMess);
            UdpSendClient = new UdpClient();
            // 发送消息到组播或广播地址
            UdpSendClient.Send(messagebytes, messagebytes.Length, BrodeAdress);
            UdpSendClient.Close();
        }
     
    }
}

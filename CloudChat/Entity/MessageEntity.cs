using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudChat.Entity
{
    [Serializable]
    public class MessageEntity
    {
        //消息协议：[Login/Out/Message],[IP],[Port],[主机名或IP],[消息体],[用户信息]
        public string Flag { get; set; }//消息标识
        public string Adress { get;set; }//IP
        public string Point { get; set; }//端口
        public string CumputerName { get; set; }//主机名
        public string DateTime { get; set; }//发生时间
        /// <summary>
        /// 如果是文件传输消息格式：文件名称，文件格式，文件大小...(文件信息用，隔开)
        /// </summary>
        public string Message { get;set; }//消息
        public FriendEntity MyInformation { get; set; }//用户信息
    }
}

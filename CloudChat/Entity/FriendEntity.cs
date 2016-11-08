using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudChat.Entity
{
    [Serializable]
    public class FriendEntity
    {
        public string ComputerName { get; set; }//主机名称
        public string IPAdress { get; set; }//IP地址
        public string Poin { get; set; }//端口号
        public string NickName { get; set; }//昵称
        public string TrueName { get; set; }//备注名称
        public string Sex { get; set; }//性别
        public string Picture { get; set; }//头像
        public string Department { get; set; }//部门
        public string Staturs { get; set; }//在线状态（0不在线，1在线）
        public string Sigenature { get; set; }//个性签名

    }
}

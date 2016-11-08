using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CloudChat.Entity;
using IMLibrary;
namespace CloudChat
{
    static class Program
    {
        public static FriendEntity MainEntity = new FriendEntity();
        public static List<FriendEntity> FriendList = new List<FriendEntity>();
        /// <summary>
        /// 发送消息窗口集合
        /// </summary>
        public static IMLibrary.FormCollections sendMsgForms = new IMLibrary.FormCollections();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUI());
        }
    }
}

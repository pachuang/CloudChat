using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloudChat;
using IMLibrary;
using System.Windows.Forms;

namespace CloudChat
{
    class AccessMethod
    {
        #region 查找发送消息窗口
        /// <summary>
        /// 查找发送消息窗口
        /// </summary>
        /// <param name="formId">窗口ID</param>
        /// <returns>返回发送消息窗口</returns>
        public Form findForm(string formId)
        {
            Form sendMsg = null;
            foreach (Form Frm in Application.OpenForms)//(Form f in Program.sendMsgForms)
                if (Frm.Tag!=null&&Frm.Tag.ToString() == formId)
                {
                    sendMsg = Frm;
                    break;//退出循环
                }
            return sendMsg;
        }
        #endregion

        /// <summary>
        /// 查找视频窗体
        /// </summary>
        /// <param name="formTag"></param>
        /// <param name="formText"></param>
        /// <returns></returns>
        public Form FindVideoFrm(string formTag,string formText)
        {
            Form sendMsg = null;
            foreach (Form Frm in Application.OpenForms)//(Form f in Program.sendMsgForms)
                if (Frm.Tag != null && Frm.Tag.ToString() == formTag&&Frm.Text=="视频聊天窗口")
                {
                    sendMsg = Frm;
                    break;//退出循环
                }
            return sendMsg;
        }
    }
}

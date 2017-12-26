using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class User
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string psw;
        public string Psw
        {
            get { return psw; }
            set { psw = value; }
        }
        //1--> 管理员用户
        //2--> 普通用户
        //0--> 非法用户
        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}

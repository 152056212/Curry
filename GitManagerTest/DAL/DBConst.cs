using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DBConst
    {
        //////////////////////////////////////////////////////////
        public static string SQL_ISPROC = "select * from sysobjects where xtype='p' and name='proc_userInfo'";
        //////////////////////////////////////////////////////////
        //存储过程: 查看是否是合法用户
        public static string PROC_ISUSER = "proc_isuser";
        //存储过程: 查询用户信息
        public static string PROC_USER_INFO = "proc_userInfo";
        //存储过程: 查询所有用户的信息
        public static string PROC_ALL_USER = "proc_all_userInfo";
        //////////////////////////////////////////////////////////
        //PROC_USER——过程中的参数
        public static string PARA_USERNAME = "@para_username";
        public static string PARA_USERPSW = "@para_userpsw";
        public static string PARA_USER_TYPE = "@para_usertype";
        //////////////////////////////////////////////////////////
        //用户类型
        public static int NULL = 0;
        public static int ADMIN = 1;
        public static int PUB_USER = 2;
     }
}

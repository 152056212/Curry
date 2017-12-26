using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UAccess
    {
        public const string CLASSNAME = "userAccess";
        //实例化DBbase对象
        private DBase db;
        private DBaseManager dbm;
        private int userType = 0;
        public int UserType
        {
            get { return userType; }
        }

        public UAccess() 
        {
            db = DBase.getInstance();
            dbm = new DBaseManager(db);
        }

        //用户登陆的方法
        public void userLogin( string name,string psw ) 
        {
            
        }
        //查询用户类型
        public void checkUser(string name,string psw) 
        {
            if (db.isProc(DBConst.PROC_ISUSER))
            //存储过程合法
            {
                userType = dbm.queryUserType(DBConst.PROC_ISUSER, name, psw);
                DAL.DALUtil.Output(this,""+CLASSNAME+" "+userType);
            }
            else
            {
                userType = dbm.queryUserType(name, psw);
                DAL.DALUtil.Output(this,"" + CLASSNAME + " " + userType);
            }
        }

    }
}

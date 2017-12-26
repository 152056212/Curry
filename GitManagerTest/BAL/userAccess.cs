using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class userAccess
    {
        DAL.UAccess d_userAccess = new UAccess();

        public bool userLogin(Model.User m_userInfo ) 
        {
            d_userAccess.checkUser(m_userInfo.UserName, m_userInfo.Psw);
            if (d_userAccess.UserType == m_userInfo.Type)
            {
                BLLUtil.Output(this,"" + d_userAccess.UserType + " " + m_userInfo.Type);
                return true;
            }
            else
            {
                BLLUtil.Output(this,"" + d_userAccess.UserType + " " + m_userInfo.Type);
                return false;
            }
                
        }
        public void userQuery(Model.User m_userInfo)
        {
            d_userAccess.checkUser(m_userInfo.UserName, m_userInfo.Psw);
        }
       

    }
}

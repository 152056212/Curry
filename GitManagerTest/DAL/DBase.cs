using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DBase
    {
        public static DBase db = null;
        public const string CLASSNAME = " DBase ";
        private static string strCon;
        public static string StrCon
        {
            get { return DBase.strCon; }
        }
        private SqlConnection con;
        public SqlConnection Con
        {
            get { return con; }
        }

        private DBase() 
        {
            //读取配置文件，连接数据库的语句
            strCon = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnerction"].ConnectionString;
            //实例化连接对象                
            con = new SqlConnection(strCon);
        }
        public static DBase getInstance() {
            if( db == null ){
                db = new DBase();
            }
            return db;
        }

        //检测连接是否打开
        public bool chkConnection()
        {
            try
            {
                if (this.con.State == ConnectionState.Closed)
                {
                    this.con.Open();
                    DALUtil.Output(this, CLASSNAME + "连接成功");
                    return true;
                }
                else 
                {
                    return true;
                }

            }
            catch( Exception e )
            {
                DALUtil.Output( this,CLASSNAME+" "+e.Message);
                MessageBox.Show("数据库连接失败，请检查该服务相关配置！\n  1.数据库登录名和密码是否正确;\n  2.数据库服务是否配置", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                
            }
            return false;
        }

        public bool isProc(string procName)
        {
            bool isConnected = chkConnection();
            if (isConnected)
            {


                string sqlIsProc = "select * from sysobjects where xtype='p' and name='" + procName + "'";
                SqlCommand comm = new SqlCommand(sqlIsProc, this.Con);
                comm.CommandType = CommandType.Text;
                SqlDataReader sdr = comm.ExecuteReader();
                if (!sdr.IsClosed)
                {
                    int i = 0;
                    //判断是否有下一行数据
                    while (sdr.Read())
                    {
                        DALUtil.Output(this, "No." + (i++) + " 所查存储过程名为: " + sdr[0]);
                        if (procName.Equals(sdr[0]))
                        {
                            sdr.Close();
                            return true;
                        }

                    }
                }
                sdr.Close();
                return false;
            }
            else return false;
        }

        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void closeDB() 
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }


    }
    
}

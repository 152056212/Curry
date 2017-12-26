using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DBaseManager
    {
        private DBase db;

        public DBaseManager(DBase db)
        {
            this.db = db;
        }
        /// <summary>
        /// 执行语句，返回该语句查询的数据行的总数
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public int returnRowCount(string strSql)
        {
            db.chkConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSql, this.db.Con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0].Rows.Count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="sqlProcName"></param>
        /// <param name="username"></param>
        /// <param name="userpsw"></param>
        public void queryUsers(string sqlProcName, string username, string userpsw)
        {
            try
            {
                db.chkConnection();
                //创建一个SqlCommand对象
                SqlCommand command = new SqlCommand(sqlProcName, db.Con);
                //设置command的属性为存储过程StoredProcedure，（默认为Text）
                command.CommandType = CommandType.StoredProcedure;
                //传入参数
                command.Parameters.Add(DBConst.PARA_USERNAME, SqlDbType.NVarChar, 30).Value = username;
                command.Parameters.Add(DBConst.PARA_USERPSW, SqlDbType.NVarChar, 50).Value = userpsw;
                //执行T-SQL语句
                SqlDataReader sdr = command.ExecuteReader();
                if (!sdr.IsClosed)
                {
                    int i = 0;
                    while (sdr.Read())
                    {
                        string num = sdr[0].ToString();
                        DALUtil.Output(this,"NO." + (i++) + " 查询结果：" + num + " 用户类型： ");
                        if (num.Equals("1"))
                        {

                        }
                    }
                }

                DALUtil.Output(this,"查询结束：");
            }
            catch (SqlException sqlExc)
            {
                MessageBox.Show("" + sqlExc.Message);
            }

        }
        //使用存储过程查询用户
        public int queryUserType(string sqlProcName, string username, string userpsw)
        {
            try
            {
                db.chkConnection();
                SqlCommand command = new SqlCommand(sqlProcName, db.Con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(DBConst.PARA_USERNAME, SqlDbType.NVarChar, 30).Value = username;
                command.Parameters.Add(DBConst.PARA_USERPSW, SqlDbType.NVarChar, 50).Value = userpsw;
                command.Parameters.Add(DBConst.PARA_USER_TYPE, SqlDbType.TinyInt).Value = DBNull.Value;

                SqlParameter parReturn = new SqlParameter(DBConst.PARA_USER_TYPE, SqlDbType.TinyInt);
                parReturn.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(parReturn);
                command.ExecuteNonQuery();
                string returnValue = parReturn.Value.ToString();
                DALUtil.Output(this," 查询结果：" + returnValue);
                if (returnValue.Equals("0"))
                {
                    //MessageBox.Show("用户不存在！");
                    return DBConst.NULL;
                }
                else
                    if (returnValue.Equals("1"))
                    {
                        //MessageBox.Show("admin");
                        return DBConst.ADMIN;
                    }
                    else
                    {
                        if (returnValue.Equals("2"))
                            return DBConst.PUB_USER;
                        else
                            return DBConst.NULL;
                    }


            }
            catch (SqlException sqlExc)
            {
                MessageBox.Show("" + sqlExc.Message);
                return 4;
            }

        }
        //不使用存储过程
        public int queryUserType(string username, string userpsw) 
        {
            try
            {
                db.chkConnection();
                string str_sqlIsUser = "select usertype from users where username = '"+username+"' and userpsw = '"+userpsw+"'";
                DALUtil.Output(this,str_sqlIsUser);
                
                SqlCommand command = new SqlCommand(str_sqlIsUser, db.Con);
                command.CommandType = CommandType.Text;
                SqlDataReader sdr = command.ExecuteReader();
                try
                {
                    if (sdr.HasRows)
                        while (sdr.Read())
                        {
                            if (sdr[0] == DBNull.Value)
                            {
                                MessageBox.Show("用户不存在！");
                                return DBConst.NULL;
                            }
                            else
                                if (sdr[0].ToString().Equals("1"))
                                {
                                    DALUtil.Output(this," 查询结果： admin " + DBConst.ADMIN);
                                    return DBConst.ADMIN;
                                }
                                else
                                {
                                    if (sdr[0].ToString().Equals("2"))
                                    {
                                        DALUtil.Output(this," 查询结果： user " + DBConst.PUB_USER);
                                        return DBConst.PUB_USER;
                                    }
                                        
                                }
                        }
                }
                catch(SqlException sqlExc ) 
                {
                    MessageBox.Show( ""+sqlExc.Message );
                }
                MessageBox.Show("用户不存在！");
                return DBConst.NULL;
                
            }
            catch (SqlException sqlExc)
            {
                //查询语句异常
                MessageBox.Show("" + sqlExc.Message);
                return 4;
            }
        }
    }
}

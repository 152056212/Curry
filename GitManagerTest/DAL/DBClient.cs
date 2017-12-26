using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DBClient
    {
        private DBase db;
        private string sqlQueClient = "select * from Client where Ctype = ";
        private string sqldelete = "delete from Client where ";
        private string pro_up_client = "pro_updateClient";
        private string pro_add_client = "pro_addClient";
        private string para_cid = "@para_cid";
        private string para_cname = "@para_cname";
        private string para_ctype = "@para_ctype";
        private string para_contact = "@para_contact";
        private string para_caddress = "@para_caddress";
        private string para_postcode = "@para_postcode";
        private string para_phone = "@para_phone";
        private string para_fax = "@para_fax";
        private string para_memo = "@para_memo";

        private bool isConnected;

        public DBClient() 
        {
            db = DBase.getInstance(); ;
            
        }
        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <returns></returns>
        public DataSet getClientDataSet( int typeNo ) 
        {
            isConnected = db.chkConnection();
            if (isConnected)
            {

                SqlCommand cmd = new SqlCommand(sqlQueClient+typeNo, this.db.Con);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds,"Client");
                db.closeDB();
                return ds;

            }
            else 
            {
                db.closeDB();
                return null;
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool add(Model.Client client) 
        {
            try
            {
                isConnected = db.chkConnection();
                DALUtil.Output(this,"add方法:"+isConnected);
                if (isConnected)
                {
                    SqlCommand cmd = new SqlCommand(pro_add_client, this.db.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //设置参数
                    cmd.Parameters.Add(para_cname, SqlDbType.NVarChar, 50).Value = client.Cname;
                    cmd.Parameters.Add(para_ctype, SqlDbType.TinyInt).Value = client.ClientType;
                    cmd.Parameters.Add(para_contact, SqlDbType.NVarChar, 30).Value = client.Client_contact;
                    DALUtil.Output(this, "数据库：" + client.Client_contact);
                    cmd.Parameters.Add(para_caddress, SqlDbType.NVarChar, 50).Value = client.Address;
                    cmd.Parameters.Add(para_postcode, SqlDbType.NVarChar, 20).Value = client.Postcode;
                    cmd.Parameters.Add(para_phone, SqlDbType.Char, 22).Value = client.Phone;
                    cmd.Parameters.Add(para_fax, SqlDbType.NVarChar, 30).Value = client.Fax;
                    cmd.Parameters.Add(para_memo, SqlDbType.NVarChar, 1000).Value = client.Memo;
                    //执行T-SQL语句
                    //SqlDataReader sdr = cmd.ExecuteReader();
                    int resultLine = cmd.ExecuteNonQuery();
                    DALUtil.Output(this, "resultLine: " + resultLine);
                    if (resultLine == 1)
                    {
                        MessageBox.Show("添加成功！");
                    }
                    db.closeDB();
                    return true;
                }
                else 
                {
                    db.closeDB();
                    MessageBox.Show("添加失败，数据库未连接！");
                    return false;
                }
            }
            catch(SqlException e) 
            {
                db.closeDB();
                MessageBox.Show("程序异常，请重试！"+"("+e.Message+")");
                return false;
            }
            
            
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="clientList"></param>
        public bool delete(List<Model.Client> clientList) 
        {
            try
            {
                isConnected = db.chkConnection();
                if( isConnected )
                {
                    int effectLines = 0;
                    foreach(Model.Client cl in clientList)
                    {
                        string  sqldel = sqldelete +" cid = "+ (cl.Id).ToString().TrimEnd();
                        DALUtil.Output(this, "DAL: delete" + sqldel);
                        SqlCommand cmd = new SqlCommand(sqldel, this.db.Con);
                        int effectLine = cmd.ExecuteNonQuery();
                        if (effectLine != 0)
                        {
                            DALUtil.Output(this, "成功：" + effectLine);
                            effectLines += effectLine;
                        }
                    }
                    if( effectLines!=0 )
                    {
                        db.closeDB();
                        MessageBox.Show("成功删除"+effectLines+"个");
                        return true;
                    }
                   
                }
                db.closeDB();
                return false;
            }
            catch (SqlException e)
            {
                db.closeDB();
                MessageBox.Show("删除失败！"+e.Message);
                return false;
            }
        }

        public bool update(List<Model.Client> clientList) 
        {
            if (clientList.Count != 0)
            {
                try
                {
                    isConnected = db.chkConnection();
                    DALUtil.Output(this, "update方法:" + isConnected);
                    if (isConnected)
                    {
                        int total = 0;
                        foreach (Model.Client client in clientList)
                        {
                            SqlCommand cmd = new SqlCommand(pro_up_client, this.db.Con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //设置参数
                            cmd.Parameters.Add(para_cid, SqlDbType.Int).Value = client.Id;
                            cmd.Parameters.Add(para_cname, SqlDbType.NVarChar, 50).Value = client.Cname;
                            cmd.Parameters.Add(para_ctype, SqlDbType.TinyInt).Value = client.ClientType;
                            cmd.Parameters.Add(para_contact, SqlDbType.NVarChar, 30).Value = client.Client_contact;
                            cmd.Parameters.Add(para_caddress, SqlDbType.NVarChar, 50).Value = client.Address;
                            cmd.Parameters.Add(para_postcode, SqlDbType.NVarChar, 20).Value = client.Postcode;
                            cmd.Parameters.Add(para_phone, SqlDbType.Char, 22).Value = client.Phone;
                            cmd.Parameters.Add(para_fax, SqlDbType.NVarChar, 30).Value = client.Fax;
                            cmd.Parameters.Add(para_memo, SqlDbType.NVarChar, 1000).Value = client.Memo;
                            int resultLine = cmd.ExecuteNonQuery();
                            DALUtil.Output(this, "resultLine: " + resultLine);
                            if (resultLine == 1)
                            {
                                total += 1;
                                //MessageBox.Show("修改成功！");
                            }
                        }
                        if (total == clientList.Count)
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.closeDB();
                        return true;

                    }
                    else
                    {
                        db.closeDB();
                        MessageBox.Show("程序异常！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (SqlException e)
                {
                    db.closeDB();
                    MessageBox.Show("修改失败！" + e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else {
                db.closeDB();
                //MessageBox.Show("未选中修改内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true; 
            }
        }

        public List<Model.Client> getClients( int type ) { 
        
            List<Model.Client> clients = new List<Client>();
            bool isConn = db.chkConnection();
            if( isConn ){
                try{
                    SqlCommand  cmd = new SqlCommand( "select * from CLient where Ctype = '"+type+"\'",db.Con );
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while( sdr.Read() ){

                        Model.Client client = new Client();
                        client.Id = int.Parse( sdr[0].ToString() );
                        client.Cname = sdr[1].ToString();
                        client.ClientType = int.Parse( sdr[2].ToString() );
                        client.Client_contact = sdr[3].ToString();
                        client.Address = sdr[4].ToString();
                        client.Postcode = sdr[5].ToString();
                        client.Phone = sdr[6].ToString();
                        client.Fax = sdr[7].ToString();
                        client.Memo = sdr[8].ToString();
                        clients.Add( client );

                    }
                    sdr.Close();
                    db.closeDB();
                    return clients;
                }catch(SqlException se){

                    return clients;
                }
            }
            return clients;
        }

    }
}

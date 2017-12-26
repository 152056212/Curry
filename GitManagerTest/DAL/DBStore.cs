using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DBStore
    {
        private DBase db = null;
        private string sqlProInStore = "";
        private string para_stroename = "proc_store";
        private string storeName = "01";
        private const string para1 = "@para_storeNo";
        private List<Model.Storehouse> stos = new List<Model.Storehouse>();

        public DBStore() {
            this.db = DBase.getInstance();
        }
        public DataSet getProductSet(string storeName){

            bool isConn  =  db.chkConnection();
            if (isConn)
            {
                SqlCommand cmd = new SqlCommand(para_stroename, db.Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(para1, SqlDbType.NChar).Value = storeName;
                //SqlDataReader sdr = cmd.ExecuteReader();
                //while (sdr.Read())
                //{
                //    DALUtil.Output(this, "" + sdr[0].ToString());
                //}
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DALUtil.Output(this, "" + ds.Tables[0].Rows.Count);
                return ds;
                
            }
            else {
                MessageBox.Show("程序查询异常！对象可能不存在！");
                return null;
            }
        }

        public List<Model.Storehouse> getStoList() {
            bool isConn = db.chkConnection();
            if (isConn) {
                SqlCommand cmd = new SqlCommand( "select * from StoreHouse ",db.Con );
                SqlDataReader sdr = cmd.ExecuteReader();
                while( sdr.Read() ){
                    Model.Storehouse sto = new Model.Storehouse();
                    sto.Id = int.Parse( sdr[0].ToString() );
                    sto.Sno = sdr[1].ToString();
                    sto.Name = sdr[2].ToString();
                    sto.Shigh = int.Parse( sdr[3].ToString() );
                    stos.Add( sto );
                }
                sdr.Close();
                db.closeDB();
                return stos;
            }
            return stos;
        }
    }
}

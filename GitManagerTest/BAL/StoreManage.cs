using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class StoreManage
    {
        private DBStore dbstore;
        private DBase db;
        private string sqlUpName = "Update Storehouse set Sname = ";
        private string sqlAddStore = "insert into Storehouse(Sno,Sname) values ";
        private string sqlDel = "delete from Storehouse where Sno = ";
        private string sqlSelectSto = " select Storehouse.Sno,Storehouse.Sname from Storehouse;";
        private string sqlUpHigh = "Update Storehouse set Shigh = ";

        public StoreManage() {
            this.dbstore = new DBStore();
            db = DBase.getInstance();
        }

        public void setDataGirdView( DataGridView dgv,string storeName ) {
            DataSet ds = dbstore.getProductSet(storeName);
           dgv.DataSource = ds.Tables[0];
        }

        public List<Model.Storehouse> getStoreList() {

            db.chkConnection();
            List<Model.Storehouse> stoList = new List<Model.Storehouse>() { };
            SqlCommand cmd = new SqlCommand( sqlSelectSto,db.Con );
            SqlDataReader sdr = cmd.ExecuteReader();
            int i = 0;
            while ( sdr.Read() ){
                BLLUtil.Output(this,""+(i++).ToString());
                Model.Storehouse sto = new Model.Storehouse();
                sto.Sno = sdr[0].ToString();
                sto.Name = sdr[1].ToString();
                stoList.Add(sto);
            }
            sdr.Close();
            db.closeDB();
            return stoList;
        
        }

        public bool setName( string oldName, string newName ) {

            bool isConn = db.chkConnection();
            if( isConn  ){

                SqlCommand cmd = new SqlCommand(sqlUpName + "\'" + newName + "\'" + " " + "where Storehouse.Sname = " + "\'" + oldName + "\'", db.Con);
                int i = cmd.ExecuteNonQuery();
                db.closeDB();
                if( i!=0 ){
                    return true;
                }
                return false;
            }
            return false;
            
        }

        public bool addStore( string storeNo,string storeName ) {
            bool isConn = db.chkConnection();
            SqlCommand cmd = new SqlCommand(sqlAddStore + "(" + "\'" + storeNo + "\'" + "," + "\'" + storeName.Trim()+"\'" + ")", db.Con);
            try{
                int i = cmd.ExecuteNonQuery();
                db.closeDB();
                if (i != 0)
                {
                    return true;
                }
            }catch( SqlException se ){
                MessageBox.Show("仓库已存在，请重命名"+se.Message);
                return false;
            }
            
            return false;
        }

        public bool deleteStore( string stoNo ) {
            bool isConn = db.chkConnection();
            SqlCommand cmd = new SqlCommand(sqlDel + "\'" + stoNo + "\'", db.Con);
            try {
                int i = cmd.ExecuteNonQuery();
                db.closeDB();
                if (i != 0)
                {
                    return true;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("仓库已存在，请重命名"+se.Message);
                return false;
            }
            
            return false;
        
        }

        public bool setHighValue(string stoNo,string newHighValue) {
            db.chkConnection();
            SqlCommand cmd = new SqlCommand(sqlUpHigh + "\'" + newHighValue + "\'" + " where Sno = " + "\'"+stoNo+ "\'",db.Con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0) {
                return true;
            }
            return false;
        }


    }
}

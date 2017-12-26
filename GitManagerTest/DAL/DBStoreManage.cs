using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DBStoreManage
    {
        private DBase db;
        private DBProType dbtype;
        private string proStoreInName = "pro_StoreIn";
        private string proStoreHouse = "pro_getStore";
        private string sqlAddProduct = "insert into Product( Pno,Pname,TypeId,Pstyle,Punit,Pprice,Plow,Phigh,Valid,AlarmDays ) values( ";
        private string sqlAddStoIn = "insert into StoreIn( SIno,Pid,SItype,Pnum,StoreNo,SIerNo,OptDate,isCheck,clientId ) values( ";
        private string sqlGetId = "select Pid from Product where Pname = '";
        private string sqlGetProducts = " select * from Product";
        private string pid = "";
        private Model.Storehouse storeHouse;
        private List<Model.Storehouse> storehouses;

        public DBStoreManage()
        {
            db = DBase.getInstance();
            dbtype = new DBProType();
        }

        public DataSet init()
        {

            try
            {
                bool isConn = db.chkConnection();
                if (isConn)
                {
                    SqlCommand cmd = new SqlCommand(proStoreInName, db.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    db.closeDB();
                    return ds;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("程序异常！" + "(" + se.Message + ")");
                return null;
            }
            return null;

        }

        public List<Model.Storehouse> getStorehouses()
        {

            bool isConn = db.chkConnection();
            if (isConn)
            {

                try
                {
                    storehouses = new List<Model.Storehouse>() { };
                    SqlCommand cmd = new SqlCommand(proStoreHouse, db.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        storeHouse = new Model.Storehouse();
                        storeHouse.Id = int.Parse(sdr[0].ToString());
                        storeHouse.Sno = sdr[1].ToString();
                        storeHouse.Name = sdr[2].ToString();
                        if (!sdr[3].ToString().Equals(""))
                            storeHouse.Shigh = int.Parse(sdr[3].ToString());
                        storeHouse.Memo = sdr[4].ToString();
                        storehouses.Add(storeHouse);
                    }
                    sdr.Close();
                    db.closeDB();
                    return storehouses;
                }
                catch (SqlException se)
                {
                    db.closeDB();
                    return null;
                }
            }
            db.closeDB();
            return null;

        }

        public bool addStoreIn(Model.StoreIn stoIn)
        {

            bool isConn = db.chkConnection();
            try
            {
                if (isConn)
                {
                    //string  stoInNo = stoIn.SiNo+"-"+;
                    //string sqladd = sqlAddStoIn+  +")";
                    
                    SqlCommand cmd = new SqlCommand(sqlAddStoIn + "\'" + stoIn.SiNo + "\'" + "," + "\'" + stoIn.PId + "\'" + "," + "\'" + stoIn.Stype + "\'" + "," + "\'" + stoIn.Pnum + "\'" + "," + "\'" + stoIn.StoreNo + "\'" + "," + "\'" + stoIn.SierNo + "\'" + "," + "\'" + stoIn.Optdate + "\'" +","+"\'"+ Convert.ToInt32( stoIn.IsCheck )+"\'"+","+"\'"+stoIn.ClientId+"\'"+")", db.Con);
                    int i = cmd.ExecuteNonQuery();
                    if( i!=0 ){
                        return true;
                    }
                }
            }
            catch (SqlException se)
            {
                return false;
            }
            return false;
        }

        public bool addProduct(Model.Product product) {

            bool isConn = db.chkConnection();
            if (isConn) {
                try {
                    string typeid = dbtype.getTypeId(product.TypeName);
                    if (!typeid.Equals(""))
                    {
                        db.chkConnection();
                        int i = 0;
                        bool isExsits = this.isProduct( product.Pname );
                        if (isExsits)
                        {
                            SqlCommand cmd = new SqlCommand("select proSum from Product where Pname = '" + product.Pname + "\'",db.Con);
                            SqlDataReader sdr = cmd.ExecuteReader();
                            int num = 0;
                            while (sdr.Read()) {
                                if (sdr[0]!=null || sdr[0].ToString().Equals("") )
                                {
                                    num = int.Parse(sdr[0].ToString());
                                }
                            }
                            sdr.Close();
                            int sum = int.Parse(product.Pnum)+num;
                            SqlCommand cmd1 = new SqlCommand("update Product set Product.Prosum = " + "\'" + (sum) + "\' ,Product.Pprice = \'" + product.Price + "\'" + " where Product.Pname = " + "\'" + product.Pname + "\'", db.Con);
                                i = cmd1.ExecuteNonQuery(); 
                            
                                                       
                        }
                        else {
                            SqlCommand cmd = new SqlCommand(sqlAddProduct + "\'" + product.Pno + "\'" + "," + "\'" + product.Pname + "\'" + "," + "\'" + typeid + "\'" + "," + "\'" + product.Pstyle + "\'" + "," + "\'" + product.Unit + "\'" + "," + "\'" + product.Price + "\'" + "," + "\'" + product.Plow + "\'" + "," + "\'" + product.Phigh + "\'" + "," + "\'" + product.Valid + "\'" + "," + "\'" + product.Alramdays + "\'" + " )", db.Con);
                            i = cmd.ExecuteNonQuery();                            
                        }
                        if (i != 0)
                        {
                            db.closeDB();
                            return true;
                        }
                    }
                }catch(SqlException se){
                    MessageBox.Show(se.Message);
                    return false;
                }
                
            }
            return false;

        }

        public string getMaxPid()
        {

            bool isConn = db.chkConnection();
            string pid = "";
            if (isConn)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select Product.Pid from Product order by Product.Pid desc ", db.Con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        pid = sdr[0].ToString();
                        break;
                    }
                    sdr.Close();
                    db.closeDB();
                    return pid;                    
                }
                catch (SqlException se)
                {
                    DALUtil.Output(this, se.Message);
                    return pid;
                }

            }
            return pid;
        }

        public string getPid(string pname) {

            bool isConn = db.chkConnection();
            if (isConn) {
                try {

                    SqlCommand cmd = new SqlCommand(sqlGetId + pname + "\'", db.Con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read() ){
                        this.pid = sdr[0].ToString();
                    }
                    sdr.Close();
                    db.closeDB();
                    return this.pid;
                }catch(SqlException se ){
                    //MessageBox.Show(se.Message);
                    return this.pid;
                }
            }
            return this.pid;
        }

        public bool isProduct( string pname ) {

            bool isConn = db.chkConnection();
            if( isConn ){

                SqlCommand cmd = new SqlCommand( "select pid from Product where Pname = '"+pname+"\'",db.Con );
                int i = cmd.ExecuteNonQuery();
                if( i!=0 ){
                    return true;
                }

            }
            return false;

        }

        public List<Model.Product> getProList() {
            bool isConn = db.chkConnection();
            List<Model.Product> pros = new List<Model.Product>();
            if( isConn ){
                try
                {
                    
                    SqlCommand cmd = new SqlCommand( sqlGetProducts ,db.Con );
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read()) {
                        Model.Product pro = new Model.Product();
                        pro.Pid = int.Parse( sdr[0].ToString() );
                        pro.Pno = sdr[1].ToString();
                        pro.Pname = sdr[2].ToString();
                        pro.Price = double.Parse( sdr[6].ToString() );
                        pro.Plow = int.Parse( sdr[7].ToString() );
                        pro.Phigh =int.Parse( sdr[8].ToString() );
                        pro.Valid = int.Parse( sdr[9].ToString() );
                        pro.Alramdays = int.Parse( sdr[10].ToString() );
                        pro.Pnum = sdr[12].ToString();
                        pros.Add(pro);

                    }
                    sdr.Close();
                    db.closeDB();
                    return pros;
                }
                catch (SqlException se) {
                    DALUtil.Output(this,""+se.Message);
                    return pros;
                }
            }
            return pros;
        }
        /// <summary>
        /// 生成出库单
        /// </summary>
        /// <param name="stoOut"></param>
        /// <param name="oldNum">出库前商品库存数</param>
        /// <returns></returns>
        public bool addStoreOut( Model.StoreOut stoOut,int oldNum ) {

            bool isConn = db.chkConnection();
            if (isConn) {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into StoreOut( SOno,PId,SOType,Pnum,StoreNo,SOerNo,OptDate,isCheck,clientId,POprice ) values( "+
                        "\'"+stoOut.SOno1+"\'"+","  +"\'"+stoOut.PId+"\'"+","+ "\'"+stoOut.Sotype+"\'"+"," +"\'"+stoOut.Pnum+"\'"+","  + "\'"+ stoOut.StoreNo+"\'"+","+
                        "\'" + stoOut.SoerNo + "\'" + "," + "\'" + stoOut.Optdate + "\'" + "," + "\'" + Convert.ToInt32(stoOut.IsCheck) + "\'" + "," + "\'" + stoOut.ClientId + "\'" + "," + "\'" + stoOut.POprice1 + "\'" + ")", db.Con);

                    int i = cmd.ExecuteNonQuery();
                    if (i != 0) {
                        if (stoOut.IsCheck)
                        {
                            int newNum = oldNum - stoOut.Pnum;
                            SqlCommand cmd1 = new SqlCommand("update Product set Product.proSum = " + newNum + " where Pid = " + stoOut.PId, db.Con);
                            int k = cmd1.ExecuteNonQuery();
                            if (k != 0)
                            {
                                DALUtil.Output(this, "更新成功！");

                            }
                        }
                        return true;
                    }
                }
                catch (SqlException se) {
                    DALUtil.Output(this, "" + se.Message);
                    return false;
                }
                
            }
            return false;
        }

        public int getAdjustCheck() { 
            return 0;
        }
        public int getInChecked() {
            int num = 0;
            bool isConn = db.chkConnection();
            if( isConn ){
                SqlCommand cmd = new SqlCommand( "select count(SIno) from StoreIn where isCheck = 0 ",db.Con );
                SqlDataReader sdr = cmd.ExecuteReader();
                while( sdr.Read() ){
                    if( sdr[0]!=null || !sdr[0].ToString().Equals("") )
                        num = int.Parse(sdr[0].ToString());
                }
                sdr.Close();
                db.closeDB();
                return num;

            }
            return 0;
        }

        public int getOutChecked()
        {
            int num = 0;
            bool isConn = db.chkConnection();
            if (isConn) {
                SqlCommand cmd = new SqlCommand("select count(SOno) from StoreOut where isCheck = 0",db.Con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while( sdr.Read() ){
                    num = int.Parse(sdr[0].ToString());
                }
                sdr.Close();
                db.closeDB();
                return num;
            }

            return 0;    
        }

    }
}

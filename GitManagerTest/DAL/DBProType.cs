using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBProType
    {
        private DBase db;
        private string proQueryType = "pro_queryType";
        private string sqlgetId = "select TypeId from ProType where TypeName = ";
        private string sqlgetTypeList = " select * from ProType ";
        private List<Model.ProType> typelist = new List<ProType>();


        public DBProType() {
            db = DBase.getInstance();
        }
        public List<Model.ProType> getTypeList()
        {
            bool isConn = db.chkConnection();
            if (isConn)
            {
                try {
                    List<Model.ProType> listType = new List<ProType>() { };
                    SqlCommand cmd = new SqlCommand(proQueryType, db.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Model.ProType proType;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        proType = new ProType();
                        //id
                        proType.Id = int.Parse(sdr[0].ToString());
                        //no编号
                        proType.No = sdr[1].ToString();
                        //name
                        proType.Name = sdr[2].ToString();
                        //upperid
                        DALUtil.Output(this, "111:" + sdr[3].ToString());
                        if (!sdr[3].ToString().Equals(""))
                        {
                            proType.UpId = int.Parse(sdr[3].ToString());
                        }
                        
                        listType.Add(proType);
                    }
                    sdr.Close();
                    db.closeDB();
                    return listType;
                
                }
                catch( SqlException se ){
                    return null;
                }
                
            }
            return null;
        }

        public string getTypeId( string typename ) {

            bool isConn = db.chkConnection();
            if( isConn ){
                SqlCommand cmd = new SqlCommand( sqlgetId+"\'"+typename+"\'",db.Con );
                SqlDataReader sdr = cmd.ExecuteReader();
                string typeid = "";
                while( sdr.Read() ){
                    typeid = sdr[0].ToString();
                }
                sdr.Close();
                db.closeDB();
                return typeid;
            }
            return "";
             
        }

        public List<Model.ProType> getTypelistNew() {

            bool isConn = db.chkConnection();
            if (isConn) {
                try {
                    SqlCommand cmd = new SqlCommand(sqlgetTypeList, db.Con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {

                        Model.ProType ptype = new ProType();
                        ptype.Id = int.Parse(sdr[0].ToString());
                        ptype.No = sdr[1].ToString();
                        ptype.Name = sdr[2].ToString();
                        if (sdr[3] != null && !sdr[3].ToString().Equals(""))
                        {
                            ptype.UpId = int.Parse(sdr[3].ToString());
                        }
                        this.typelist.Add(ptype);

                    }
                    sdr.Close();
                    db.closeDB();
                    return typelist;
                }catch(SqlException se){
                    DALUtil.Output(this, "" + se.Message);
                    return typelist;
                }
               
            }

            return typelist;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBEmployer
    {
        private DBase db;
        private string proGetEmployer = "pro_getInEmployer";
        private List<Model.Employer> ems = new List<Model.Employer>();
        private List<Model.Employer> emsNew = new List<Model.Employer>();


        public DBEmployer() {
            db = DBase.getInstance();
        }
        public List<Model.Employer> getInEmployers() {

            bool isConn = db.chkConnection();
            if (isConn)
            {
                try
                {
                    Model.Employer em;
                    SqlCommand cmd = new SqlCommand(proGetEmployer, db.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        em = new Model.Employer();
                        em.Emno = sdr[0].ToString();
                        em.Emname = sdr[1].ToString();
                        em.StoNo = sdr[2].ToString();
                        em.EmPhone = sdr[3].ToString();
                        em.Memo = sdr[4].ToString();
                        ems.Add( em );
                        
                    }
                    sdr.Close();
                    db.closeDB();
                    return ems;
                }
                catch (SqlException se)
                {
                    db.closeDB();
                    return null;
                }
            }
            else {
                return null;
            }
           

        }

        public List<Model.Employer> getInEmployers( int type )
        {

            bool isConn = db.chkConnection();
            if (isConn)
            {
                try
                {
                    Model.Employer em;
                    SqlCommand cmd = new SqlCommand("select * from Employer where EmType = '" + type + "\'", db.Con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        em = new Model.Employer();
                        em.Emno = sdr[0].ToString();
                        em.Emname = sdr[1].ToString();
                        em.StoNo = sdr[2].ToString();
                        em.EmPhone = sdr[3].ToString();
                        em.Memo = sdr[4].ToString();
                        emsNew.Add(em);

                    }
                    sdr.Close();
                    db.closeDB();
                    return emsNew;
                }
                catch (SqlException se)
                {
                    db.closeDB();
                    return emsNew;
                }
            }
            else
            {
                return emsNew;
            }


        }

    }
}

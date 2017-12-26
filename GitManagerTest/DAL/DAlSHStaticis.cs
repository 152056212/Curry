using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
     public class DAlSHStaticis
    {
         private DBase db;
         private string sqlGet_KuCun_CK = "select sum(proSum),StoreNo from Product,StoreIn where StoreIn.PId = Product.Pid group by StoreIn.StoreNo";
         private string sqlGet_MonthIn = "select sum(Pnum),MONTH(OptDate) from StoreIn group by MONTH(OptDate)";
         private string sqlGet_MonthOut = "select sum(Pnum),MONTH(OptDate) from StoreOut group by MONTH(OptDate)";
         private string sqlGet_TypeNum = "select sum(proSum),Product.TypeId  from Product group by Product.TypeId";
         private string sqlGet_TypeName = "select * from ProType;";
         private string sqlGet_stoInType = "select sum(Pnum),SIType from StoreIn group by SIType";
         private string sqlGet_stoOutType = "select sum(Pnum),SOType from StoreOut group by SOType";

         private Dictionary<int, string> dicTypeName = new Dictionary<int, string>();
         private List<int> stoNum_StoHou = new List<int>();
         /// <summary>
         /// 库存量--仓库编号
         /// </summary>
         public List<int> StoNum_StoHou
         {
             get { return stoNum_StoHou; }
             set { stoNum_StoHou = value; }
         }

         private List<string> stoNo = new List<string>();
         /// <summary>
         /// 库存量--仓库编号
         /// </summary>
         public List<string> StoNo
         {
             get { return stoNo; }
             set { stoNo = value; }
         }

         private List<int> monthInNum = new List<int>();
         /// <summary>
         /// 月入库量--月份编号
         /// </summary>
         public List<int> MonthInNum
         {
             get { return monthInNum; }
             set { monthInNum = value; }
         }
         private List<int> InmonthNo = new List<int>() { };
         /// <summary>
         /// 月入库量--月份编号
         /// </summary>
         public List<int> InMonthNo
         {
             get { return InmonthNo; }
             set { InmonthNo = value; }
         }

         private List<int> monthOutNum = new List<int>();
         /// <summary>
         /// 月出库量--月份编号
         /// </summary>
         public List<int> MonthOutNum
         {
             get { return monthOutNum; }
             set { monthOutNum = value; }
         }
         private List<int> OutmonthNo = new List<int>() { };
         /// <summary>
         /// 月出库量--月份编号
         /// </summary>
         public List<int> OutMonthNo
         {
             get { return OutmonthNo; }
             set { OutmonthNo = value; }
         }
         
         private List<int> stoNum_Type = new List<int>();
         /// <summary>
         /// 库存量--商品类型
         /// </summary>
         public List<int> StoNum_Type
         {
             get { return stoNum_Type; }
             set { stoNum_Type = value; }
         }

         private List<int> productType = new List<int>();
         /// <summary>
         /// 库存量--商品类型
         /// </summary>
         public List<int> ProductType
         {
             get { return productType; }
             set { productType = value; }
         }

         private List<int> stoNum_stoInType = new List<int>();
         /// <summary>
         /// 入库量--入库类型
         /// </summary>
         public List<int> StoNum_stoInType
         {
             get { return stoNum_stoInType; }
             set { stoNum_stoInType = value; }
         }

         private List<string> stoInType = new List<string>();
         /// <summary>
         /// 入库量--入库类型
         /// </summary>
         public List<string> StoInType
         {
             get { return stoInType; }
             set { stoInType = value; }
         }

         private List<int> stoNum_outType = new List<int>();
         /// <summary>
         /// 出库量--出库类型
         /// </summary>
         public List<int> StoNum_outType
         {
             get { return stoNum_outType; }
             set { stoNum_outType = value; }
         }

         private List<string> stoOutType = new List<string>();
         /// <summary>
         /// 出库量--出库类型
         /// </summary>
         public List<string> StoOutType
         {
             get { return stoOutType; }
             set { stoOutType = value; }
         }




         /// <summary>
         /// 初始化：库存量--仓库编号
         /// </summary>
         /// <returns></returns>
         public bool set_KuCun_CK() {

             bool isConn = db.chkConnection();
             if( isConn ){
                 SqlCommand cmd = new SqlCommand( sqlGet_KuCun_CK ,db.Con );
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while( sdr.Read() ){
                     //库存量
                     if( sdr[0]!=null  ){
                        int num = int.Parse( sdr[0].ToString() );
                        stoNum_StoHou.Add(num);
                     }
                     //仓库编号
                     if( sdr[1]!=null ){
                         stoNo.Add(sdr[1].ToString());
                     }
                     
                 }
                 sdr.Close();
                 db.closeDB();
                 return true;
             }

             return false;
         }
         /// <summary>
         /// 初始化：月入库量--月份编号
         /// </summary>
         /// <returns></returns>
         public bool set_MonthInNum() {

             bool isConn = db.chkConnection();
             if( isConn ){
                 SqlCommand cmd = new SqlCommand( sqlGet_MonthIn,db.Con );
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while( sdr.Read() ){
                     if (sdr[1] != null) {
                         int month = int.Parse(sdr[1].ToString());
                         InmonthNo.Add(month);
                     }
                     if( sdr[0]!=null ){
                         MonthInNum.Add(int.Parse(sdr[0].ToString()));
                     }
                 }
                 sdr.Close();
                 db.closeDB();
                 return true;


             }
             return false;
         }
         /// <summary>
         /// 初始化：月出库量--月份编号
         /// </summary>
         /// <returns></returns>
         public bool set_MonthOutNum() {

             bool isConn = db.chkConnection();
             if(isConn){
                 SqlCommand cmd = new SqlCommand(sqlGet_MonthOut, db.Con);
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while( sdr.Read() ){
                    if( sdr[0]!=null ){
                        monthOutNum.Add(int.Parse(sdr[0].ToString()));

                    }
                     if( sdr[1]!=null ){
                         OutmonthNo.Add( int.Parse( sdr[1].ToString() ) );
                     }
                 }
                 sdr.Close();
                 db.closeDB();
                 return true;
             }

             return false;
         }
         /// <summary>
         /// 初始化:每种类型的数量
         /// </summary>
         /// <returns></returns>
         public bool set_StoNum_Type() {
             bool isConn = db.chkConnection();
             if (isConn)
             {
                 SqlCommand cmd = new SqlCommand( sqlGet_TypeNum , db.Con);
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while (sdr.Read())
                 {
                     if (sdr[0] != null)
                     {
                         stoNum_Type.Add(int.Parse(sdr[0].ToString()));
                     }
                     if (sdr[1] != null)
                     {
                         productType.Add( int.Parse( sdr[1].ToString() ));
                     }
                 }
                 sdr.Close();
                 db.closeDB();
                 dicTypeName = set_Type_Name();
                 return true;
             }

             return false;
         }

         public Dictionary<int,string> set_Type_Name()
         {
             Dictionary<int, string> dicType = new Dictionary<int, string>();
             bool isConn = db.chkConnection();
             if (isConn)
             {
                 SqlCommand cmd = new SqlCommand( sqlGet_TypeName , db.Con);
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while (sdr.Read())
                 {
                     dicType.Add(int.Parse(sdr[0].ToString()), sdr[2].ToString());
                 }
                 sdr.Close();
                 db.closeDB();


                 return dicType;
             }

             return dicType;
         }

         /// <summary>
         /// 初始化：入库量--入库类型
         /// </summary>
         /// <returns></returns>
         public bool set_stoNum_stoInType()
         {
             bool isConn = db.chkConnection();
             if (isConn)
             {
                 SqlCommand cmd = new SqlCommand(sqlGet_stoInType, db.Con);
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while (sdr.Read())
                 {
                     if (sdr[0] != null)
                     {
                         stoNum_stoInType.Add( int.Parse( sdr[0].ToString() ) );
                     }
                     if (sdr[1] != null)
                     {
                         stoInType.Add( sdr[1].ToString() ); 
                     }
                 }
                 sdr.Close();
                 db.closeDB();
                 
                 return true;
             }

             return false;
         }
         /// <summary>
         /// 初始化：出库量--出库类型
         /// </summary>
         /// <returns></returns>
         public bool set_stoNum_stoOutType()
         {
             bool isConn = db.chkConnection();
             if (isConn)
             {
                 SqlCommand cmd = new SqlCommand(sqlGet_stoInType, db.Con);
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while (sdr.Read())
                 {
                     if (sdr[0] != null)
                     {
                         stoNum_outType.Add(int.Parse(sdr[0].ToString()));
                     }
                     if (sdr[1] != null)
                     {
                         StoOutType.Add(sdr[1].ToString());
                     }
                 }
                 sdr.Close();
                 db.closeDB();

                 return true;
             }

             return false;
         }


         public DAlSHStaticis() {
             db = DBase.getInstance();
             this.set_KuCun_CK();
             this.set_MonthInNum();
             this.set_MonthOutNum();
             this.set_stoNum_stoInType();
             this.set_StoNum_Type();
             this.set_Type_Name();
             this.set_stoNum_stoOutType();

             DALUtil.Output(this, "库存量--仓库编号:" + StoNum_StoHou.Count + " " + StoNo.Count);
             DALUtil.Output(this, "月入库量--月份编号:" + MonthInNum.Count + " " + InmonthNo.Count);
             DALUtil.Output(this, "月出库量--月份编号:" + MonthOutNum.Count + " " + OutMonthNo.Count);
             DALUtil.Output(this, "每种类型的数量编号:" + StoNum_Type.Count + " " + ProductType.Count+" "+dicTypeName.Count);
             DALUtil.Output(this, "入库量--入库类型编号:" + StoNum_stoInType.Count + " " + StoInType.Count);
             

         
         }
         

    }
}

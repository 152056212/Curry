using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Product
    {
        /// <summary>
        /// 商品id
        /// </summary>
        private int pid;
        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        /// <summary>
        /// 商品编号( 12位：01-001-00001 )
        /// </summary>
        private string pno;
        public string Pno
        {
            get { return pno; }
            set { pno = value; }
        }
        /// <summary>
        /// 商品名称
        /// </summary>
        private string pname;
        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        /// <summary>
        /// 商品类型编号
        /// </summary>
        private string typeno;
        public string TypeNo
        {
            get { return typeno; }
            set { typeno = value; }
        }
        /// <summary>
        /// 商品类型名称
        /// </summary>
        private string typeName;
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        /// <summary>
        /// 商品规格(GB)
        /// </summary>
        private string pstyle;
        public string Pstyle
        {
            get { return pstyle; }
            set { pstyle = value; }
        }
        /// <summary>
        /// 商品计量单位(个)
        /// </summary>
        private string unit = "个";
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        /// <summary>
        /// 商品价格
        /// </summary>
        private double price = 0;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// 商品存储下限
        /// </summary>
        private int plow = 0 ;
        public int Plow
        {
            get { return plow; }
            set { plow = value; }
        }
        /// <summary>
        /// 商品存储上限
        /// </summary>
        private int phigh = 0 ;
        public int Phigh
        {
            get { return phigh; }
            set { phigh = value; }
        }
        /// <summary>
        /// 商品有效期(天)
        /// </summary>
        private int valid = 0 ;
        public int Valid
        {
            get { return valid; }
            set { valid = value; }
        } 
        /// <summary>
        /// 商品存储期间隔（天）
        /// </summary>
        private int alramdays = 0 ;
        public int Alramdays
        {
            get { return alramdays; }
            set { alramdays = value; }
        }
        /// <summary>
        /// 商品所在仓库编号
        /// </summary>
        private string proStoNo;
        public string ProStoNo
        {
            get { return proStoNo; }
            set { proStoNo = value; }
        }
        /// <summary>
        /// 商品的数量
        /// </summary>
        private string pnum = "0";
        public string Pnum
        {
            get { return pnum; }
            set { pnum = value; }
        }
        /// <summary>
        /// 商品入库员
        /// </summary>
        private string stoIner;
        public string StoIner
        {
            get { return stoIner; }
            set { stoIner = value; }
        }
        /// <summary>
        /// 入库类型
        /// </summary>
        private string stoInType = "采购入库" ;
        public string StoInType
        {
            get { return stoInType; }
            set { stoInType = value; }
        }
        /// <summary>
        /// 供应商id
        /// </summary>
        private int clientId;
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        /// <summary>
        /// 是否审核
        /// </summary>
        private bool isCheck;
        public bool IsCheck
        {
            get { return isCheck; }
            set { isCheck = value; }
        }

        public Product() {
        
        }
        
    }

}

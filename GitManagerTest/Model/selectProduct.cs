using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class selectProduct
    {
        /// <summary>
        /// 商品编号（12位:01-001-00001）
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
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 商品类型
        /// </summary>
        private string proType;
        public string ProType
        {
            get { return proType; }
            set { proType = value; }
        }
        /// <summary>
        /// 商品计量单位
        /// </summary>
        private string unit;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        /// <summary>
        /// 商品价格
        /// </summary>
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// 商品的总数
        /// </summary>
        private int prosum;
        public int Prosum
        {
            get { return prosum; }
            set { prosum = value; }
        }


    }
}

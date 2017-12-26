using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class StoreOut
    {
        /// <summary>
        /// 出库单编号（18位：010-20171218160823）
        /// </summary>
        private string SOno;
        public string SOno1
        {
            get { return SOno; }
            set { SOno = value; }
        }
        /// <summary>
        /// 出库商品对应的id
        /// </summary>
        private int pid;
        public int PId
        {
            get { return pid; }
            set { pid = value; }
        }
        /// <summary>
        /// 出库类型
        /// </summary>
        private string sotype;
        public string Sotype
        {
            get { return sotype; }
            set { sotype = value; }
        }
        /// <summary>
        /// 出库商品数量
        /// </summary>
        private int pnum;
        public int Pnum
        {
            get { return pnum; }
            set { pnum = value; }
        }
        /// <summary>
        /// 对应的仓库的编号
        /// </summary>
        private string storeNo;
        public string StoreNo
        {
            get { return storeNo; }
            set { storeNo = value; }
        }
        /// <summary>
        /// 出库员编号
        /// </summary>
        private string soerNo;
        public string SoerNo
        {
            get { return soerNo; }
            set { soerNo = value; }
        }
        /// <summary>
        /// 出库日期
        /// </summary>
        private DateTime optdate;
        public DateTime Optdate
        {
            get { return optdate; }
            set { optdate = value; }
        }
        /// <summary>
        /// 商品出库的价格
        /// </summary>
        private int POprice = 0;
        public int POprice1
        {
            get { return POprice; }
            set { POprice = value; }
        }
        /// <summary>
        /// 销售商id
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
        private bool isCheck = false;
        public bool IsCheck
        {
            get { return isCheck; }
            set { isCheck = value; }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class StoreIn
    {
        /// <summary>
        /// 入库单编号（18位：010-20171218160823）
        /// </summary>
        private string siNo;
        public string SiNo
        {
            get { return siNo; }
            set { siNo = value; }
        }
        /// <summary>
        /// 入库商品对应的id
        /// </summary>
        private int pid;
        public int PId
        {
            get { return pid; }
            set { pid = value; }
        }
        /// <summary>
        /// 入库类型(  )
        /// </summary>
        private string sitype;
        public string Stype
        {
            get { return sitype; }
            set { sitype = value; }
        }
        /// <summary>
        /// 入库商品数量
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
        /// 入库员编号
        /// </summary>
        private string sierNo;
        public string SierNo
        {
            get { return sierNo; }
            set { sierNo = value; }
        }
        /// <summary>
        /// 入库日期
        /// </summary>
        private DateTime optdate;
        public DateTime Optdate
        {
            get { return optdate; }
            set { optdate = value; }
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
        /// <summary>
        /// 供应商
        /// </summary>
        private int clientId;
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }



    }
}

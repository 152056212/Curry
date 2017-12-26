using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Employer
    {
        /// <summary>
        /// 员工编号（8位：0-01-001）
        /// </summary>
        private string emno;
        public string Emno
        {
            get { return emno; }
            set { emno = value; }
        }
        /// <summary>
        /// 员工类型（入库/出库）
        /// </summary>
        private int emtype;
        public int Emtype
        {
            get { return emtype; }
            set { emtype = value; }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        private string emname;
        public string Emname
        {
            get { return emname; }
            set { emname = value; }
        }
        /// <summary>
        /// 所在仓库id
        /// </summary>
        private int storeId;
        public int StoreId
        {
            get { return storeId; }
            set { storeId = value; }
        }
        /// <summary>
        /// 员工手机
        /// </summary>
        private string emPhone;
        public string EmPhone
        {
            get { return emPhone; }
            set { emPhone = value; }
        }
        /// <summary>
        /// 员工备注
        /// </summary>
        private string memo;
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
        /// <summary>
        /// 所在仓库编号、名称
        /// </summary>
        private string stoNo;
        public string StoNo
        {
            get { return stoNo; }
            set { stoNo = value; }
        }
        private string stoName;
        public string StoName
        {
            get { return stoName; }
            set { stoName = value; }
        }

        public Employer() {


        }

    }
}

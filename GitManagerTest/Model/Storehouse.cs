using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Storehouse
    {
        public static List<string> storeNo = new List<string>() { 
            "01","02","03","04"
        };

        public static Dictionary<string, string> DicStore = new Dictionary<string, string>() { 
            
            {storeNo[0],"仓库1"},{storeNo[1],"仓库2"},{storeNo[2],"仓库3"},{storeNo[3],"仓库4"}

        };
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 仓库编号（2位）
        /// </summary>
        private string sno;
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        /// <summary>
        /// 仓库名称
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 仓库存储量上限值
        /// </summary>
        private int shigh;
        public int Shigh
        {
            get { return shigh; }
            set { shigh = value; }
        }
        private string memo;
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }

        public Storehouse() {

        }
        public Storehouse(int id, string sno, string name, int shigh ,string memo)
        {
            this.id = id;
            this.sno = sno;
            this.name = name;
            this.shigh = shigh;
            this.memo = memo;
        }


    }
}

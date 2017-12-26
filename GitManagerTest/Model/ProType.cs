using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ProType
    {

        public static List<string> nos = new List<string>(){
            "001","002","003","004","005","006","007"
        };
        public static Dictionary<string, string> dicType = new Dictionary<string, string>() { 
            {nos[0], "驱动轴与半轴"},{nos[1], "刹车系统"},
            {nos[2],"转向系统"},{nos[3], "离合器系统"},
            {nos[4], "传动系统"},{nos[5], "发动机系统"},{nos[6], "悬架产品系列"}
        };
        public static List<int> proTypeId = new List<int>() {
            2,3,5,6,7,8,9
        };
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string no;
        public string No
        {
            get { return no; }
            set { no = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int upId;
        public int UpId
        {
            get { return upId; }
            set { upId = value; }
        }


        public ProType() { 
            
        }
        
    }
}

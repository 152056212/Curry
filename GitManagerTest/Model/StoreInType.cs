using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class StoreInType
    {
        private static string Buy = "采购入库";
        public static string Buy1
        {
            get { return StoreInType.Buy; }
        }
        private static string Cancel = "退货入库";
        public static string Cancel1
        {
            get { return StoreInType.Cancel; }
        }
        private static string Return = "退料入库";
        public static string Return1
        {
            get { return StoreInType.Return; }
        }

       


    }
}

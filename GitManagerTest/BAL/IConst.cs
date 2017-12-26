using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class IConst
    {
        private static int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度
        public static int XWidth
        {
            get { return xWidth; }
            set { xWidth = value; }
        }
        private static int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度
        public static int YHeight
        {
            get { return yHeight; }
            set { yHeight = value; }
        }

    }
}

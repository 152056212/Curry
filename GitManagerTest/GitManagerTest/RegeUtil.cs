using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GitManagerTest
{
    public class RegeUtil
    {
        private static string regeStr = String.Empty;

        public static bool isPhoneNum(string str_Num) 
        {
            //匹配十一个数字
            regeStr = @"\d{11}";
            bool isMatch = Regex.IsMatch(str_Num,regeStr);
            int len = str_Num.Length;
            if( isMatch && len == 11 )
            {
                return true;
            }
            return false;
        }
        public static int getNum(string strNum) 
        {

            string result = System.Text.RegularExpressions.Regex.Replace(strNum, @"[^0-9]+", "");
            if (!result.Equals(""))
            {
                return int.Parse(result);
            }
            else {
                return -110;
            }

        }
        public static bool isNum(string str) 
        {
            regeStr = @"^[0-9]*$";
            bool isMatch = Regex.IsMatch(str, regeStr);
            if (isMatch)
            {
                return true;
            }
            return false;
        }
    }
}

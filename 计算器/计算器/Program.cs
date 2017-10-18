using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace spilt
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Y";
            while (one == "Y")
            {
                Console.WriteLine("请按顺序输入：操作数  运算符  操作数(以空格隔开)");
                Console.WriteLine("==============请选择操作类型==================");
                Console.WriteLine("              1、数字运算");
                Console.WriteLine("              2、字符串运算");
                string num = Console.ReadLine();
                int n = int.Parse(num);

                if (n == 1)
                {
                    Console.WriteLine("请按顺序输入：操作数  运算符  操作数(以空格隔开)");
                    string str = Console.ReadLine();
                    string[] op = str.Split(' ');
                    Operate ope = new Operate();
                    char sbol = Convert.ToChar(op[1]);
                    double a = Double.Parse(op[0]);
                    double b = Double.Parse(op[2]);
                    switch (sbol)
                    {
                        case '+': ope.add(a, b);
                            break;
                        case '-': ope.reduce(a, b);
                            break;
                        case '*': ope.multiply(a, b);
                            break;
                        case '/': ope.divide(a, b);
                            break;
                        default:
                            Console.WriteLine("对不起您输入的信息有错误");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("请按顺序输入：操作数  运算符  操作数(以空格隔开)");
                    string str = Console.ReadLine();
                    string[] op = str.Split(' ');
                    Operate ope = new Operate();
                    char sbol = Convert.ToChar(op[1]);
                    switch (sbol)
                    {
                        case '+': ope.mosaic(op[0], op[2]);
                            break;
                        case '-': ope.delete(op[0], op[2]);
                            break;
                        default:
                            Console.WriteLine("对不起您输入的信息有错误");
                            break;
                    }
                }
                Console.WriteLine("是否继续操作：N停止，Y继续（其他任意键退出）");
                one = Console.ReadLine();
            }
        }
    }
    //运算类
    class Operate
    {
        public Double add(double a, double b)
        {
            Console.WriteLine("结果是：" + (a + b));
            return a + b;
        }
        //字符串拼接
        public String mosaic(string a, string b)
        {
            Console.WriteLine("结果是：" + a + b);
            return a + b;
        }
        public Double reduce(double a, double b)
        {
            Console.WriteLine("结果是：" + (a - b));
            return a - b;
        }
        //字符串删除
        public String delete(string a, string b)
        {
            bool flag = a.Contains(b);
            if (flag == true)
            {
                string str = "";
                if (b.Length == 1)
                {
                    char[] strArray = a.ToCharArray();
                    char[] strArray1 = b.ToCharArray();
                    int flagChar = 0;
                    for (int i = strArray.Length - 1; i >= 0; i--)
                    {

                        if (strArray[i] == strArray1[0])
                        {
                            flagChar = i;
                            break;
                        }

                    }
                    for (int i = 0; i < strArray.Length; i++)
                    {

                        if (i != flagChar)
                        {
                            str = str + strArray[i];
                        }

                    }

                    Console.WriteLine("结果是：" + str);
                }
                else
                {
                    str = a.Replace(b, "");
                    Console.WriteLine("结果是：" + str);
                }

                return str;
            }
            else
            {
                Console.WriteLine("在此字符串中不包含下一个字符串，结果是：" + a);
                return a;
            }
        }
        public Double multiply(double a, double b)
        {
            Console.WriteLine("结果是：" + (a * b));
            return a * b;
        }
        public Double divide(double a, double b)
        {
            Console.WriteLine("结果是：" + (a / b));
            return a / b;
        }
    }

}

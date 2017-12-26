using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ProInStore
    {
        private int pid;
        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        private string proname;
        public string Proname
        {
            get { return proname; }
            set { proname = value; }
        }

        private string protype;
        public string Protype
        {
            get { return protype; }
            set { protype = value; }
        }

        private int punit;
        public int Punit
        {
            get { return punit; }
            set { punit = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int sum;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class demo
    {
        public int i = 10;

    }
    class demo1: demo
    {
        public void sqaure()
        {
            
            Console.WriteLine(i * i);
        }

        public int method(out int i)
        {
            return i;

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            demo1 d = new demo1();
            //d.sqaure();
            d.method(out i);
        
        }
    }
}

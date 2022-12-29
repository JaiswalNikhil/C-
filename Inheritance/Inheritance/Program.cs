using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class A
    {
        public int n1, n2;

        protected int add()
        {
            return n1 + n2;
        }
    }


    public class Single_Inheritance : A     // Single Inheritance
    {
        public Single_Inheritance(int a , int b)
        {
            n1 = a;
            n2 = b;

            Console.WriteLine($"Sum of {n1} and {n2} = {add()}");
        }

        protected int product(int x ,int y)
        {
            return x*y;
        }
    }


    public class MultiLevel : Single_Inheritance  // MultiLevel Inheritance
    {
        public MultiLevel(int a , int b ) : base(a,b)
        {
            n1 = a;
            n2 = b;
        }


         public void display()
        {
            Console.WriteLine($"Product of {n1} and {n2} = {product(n1,n2)}" );
        }

        ~MultiLevel()
        {

        }

    }


    public class B : A   // Hierarchical Inheritance
    {
        public B(int a, int b)
        {
            n1 = a;
            n2 = b;
           
        }

        public void display()
        {
            Console.WriteLine($"Sum of {n1} and {n2} = {add()}");
        }

        ~B()
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Single_Inheritance s = new Single_Inheritance(2,3);
            

            MultiLevel m = new MultiLevel(2,3);
            m.display();


            B b = new B(10, 20);
            b.display();
            
        }
    }
}

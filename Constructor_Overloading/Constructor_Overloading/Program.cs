using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructor c = new Constructor();   // Default Constructor
            Console.WriteLine();

            Constructor c1 = new Constructor(2,3); // Parameterized Constructor
            Console.WriteLine();

            Constructor c2 = new Constructor("Nikhil","Jaiswal"); // Parameterized Constructor
            Console.WriteLine();

            Constructor c3 = new Constructor(c1);  // Copy Constructor
        }
    }
}

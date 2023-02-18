using System;

namespace Constructor_Overloading
{
    class Constructor
    {
        int a, b;
        string fname, lname;


        //private Constructor()
        //{
        //    Console.WriteLine("Private Constructor");
        //}

        public Constructor()
        {
            Console.WriteLine("Default Constructor ");
        }


         // Static Constructor 
         static Constructor()   
         {

            Console.WriteLine("Static Constructor");
            Console.WriteLine();
         }


        public Constructor(int a , int b)
        {
            this.a = a;
            this.b = b;

            Console.WriteLine("Parameterized Constructor");

            add(this.a,this.b);
        }


        public void add(int n1 , int n2 )
        {

            Console.WriteLine($"Sum of {n1} and {n2} is {n1+n2}");
        }



        public Constructor(string f , string l )
        {
            fname = f;
            lname = l;

            Console.WriteLine("Parameterized Constructor");
            Console.WriteLine($"My name is {fname} {lname}");
        }


        public Constructor(Constructor obj)
        {
            Console.WriteLine("Copy Constructor");
            int n1 = obj.a;
            int n2 = obj.b;

            add(n1, n2);
           
        }
    }
}

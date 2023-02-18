using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            int position ,direction;
            

            int[] N = new int[6];

            Console.WriteLine("Enter 6 values in array");
            for(int i =  0; i < 6; i++)
            {
                N[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var num in N)
            {
                Console.Write(num + " , ");
            }
            Console.WriteLine();

            Console.Write("Enter the position(0 > p < ArraySize) : ");
            position = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Direction ( 0 for left and 1 for right : ");
            direction = Convert.ToInt32(Console.ReadLine());



            if(direction == 0)
            {
                if(position == 1)
                {
                    int a = N[0];
                    N[0] = N[1];
                    N[1] = N[2];
                    N[2] = N[3];
                    N[3] = N[4];
                    N[4] = N[5];
                    N[5] = a;

                    foreach (var num in N)
                    {
                        Console.Write(num + " , ");
                    }

                }
                 else if (position == 2)
                {
                    int a = N[0];
                    int b = N[1];

                    N[0] = N[2];
                    N[1] = N[3];
                    N[2] = N[4];
                    N[3] = N[5];
                    N[4] = a;
                    N[5] = b;

                    foreach (var num in N)
                    {
                        Console.Write(num + " , ");
                    }

                }
                else if (position == 3)
                {
                    int a = N[0];
                    int b = N[1];
                    int c = N[2];
                    N[0] = N[3];
                    N[1] = N[4];
                    N[2] = N[5];
                    N[3] = a;
                    N[4] = b;
                    N[5] = c;

                    foreach (var num in N)
                    {
                        Console.Write(num + " , ");
                    }
                }
                else if (position == 4)
                {
                    int a = N[0];
                    int b = N[1];
                    int c = N[2];
                    int d = N[3];

                    N[0] = N[4];
                    N[1] = N[5];
                    N[2] = a;
                    N[3] = b;
                    N[4] = c;
                    N[5] = d;

                    foreach (var num in N)
                    {
                        Console.Write(num + " , ");
                    }
                }
                else if (position == 5)
                {
                    int a = N[0];
                    int b = N[1];
                    int c = N[2];
                    int d = N[3];
                    int e = N[4];

                    N[0] = N[5];
                    N[1] = a;
                    N[2] = b;
                    N[3] = c;
                    N[4] = d;
                    N[5] = e;

                    foreach (var num in N)
                    {
                        Console.Write(num + " , ");
                    }

                }
                
            }
            

        }
    }
}

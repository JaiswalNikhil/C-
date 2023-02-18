using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basicPart1
{
    class Program
    {

        public enum ShippingMethod : Byte
        {
            a = 1,
            b = 2,
            c=3,
            d=5

        }

        static void DisplayArray(int[] arr) =>
            Console.WriteLine(string.Join(",", arr));


        static void TwodArray(int[][] arr)
        {
            foreach(int[] i in arr)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var array = new int[3][];
            array[0] = new int[4] { 1, 2, 3, 4 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[2] { 1, 2 };

            // DisplayArray(array);    

            // TwodArray(array);


            var msg = File.ReadAllText("C:\\count.txt");

            //foreach(var msg1 in msg)
            //{
            //    Console.Write(msg1);
            //}

            //string str = @"D:\abcd.py";
            //using (FileStream file = File.Create(str)) ;



            string path = @"C:\count.txt";

            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));

          
        }
    }
}

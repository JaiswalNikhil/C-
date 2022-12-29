using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace watch
{

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\n\n\t\t---------------------------------------------------");
            Console.WriteLine("\t\t|                   Stopwatch                     |");
            Console.WriteLine("\t\t---------------------------------------------------");
            Console.Write("\n\n\t\tPress \"Backspace\" Key to start or \"Home\" Key  to exist  ");
            var button = Console.ReadKey().Key;
           


            while (button  != ConsoleKey.Home)
            {
               
                if (button == ConsoleKey.Backspace)
                {
                    var obj = StopWatch.Start<TimeSpan>();
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t Time Starts Now .........");
                    Console.Write("\n\n\t\t press \"Enter\" Key to stop ");

                    button = Console.ReadKey().Key;

                    if(button == ConsoleKey.Enter)
                    {
                        var obj1 = StopWatch.Stop<TimeSpan>();

                        Console.Clear();
                        
                        StopWatch.CalculateDuration(obj, obj1);
                        Console.Write("\n\n\t\t Press \"Backspace\" Key to Restart of \"Home\" to End  ");
                        button = Console.ReadKey().Key;
  
                    }
                }      
            }           
        }
    }
}

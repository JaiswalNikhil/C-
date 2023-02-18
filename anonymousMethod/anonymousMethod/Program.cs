using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousMethod
{
    class Program
    {
        public class Student
        {
            public int id { get; set; }
            public  string name { get; set; }
        }


        //public static bool getdata(Student std)
        //{
        //   return std.id == 2;
        //}

        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();
            list.Add(new Student() { id = 1, name = "Nikhil" });
            list.Add(new Student() { id = 2, name = "Piyush" });


            // Predicate<Student> predicate = new Predicate<Student>(getdata);

            //// using lamda Expression
            Student s = list.Find(st => st.id == 2);
            Console.WriteLine("name of student is {0}", s.name);


            // using anonymous method
            //Student s = list.Find(delegate (Student st) { return st.id == 2; });
            //Console.WriteLine("name of student is {0}", s.name);

            // using delegate
            //Student s = list.Find(st => predicate(st));
            //Console.WriteLine("name of student is {0}", s.name);



            int count = list.Count(delegate (Student st)
            {
                return st.name.StartsWith("P");
            });

            Console.WriteLine(count);


            //Func<Student, string> func = st1 => "Name = " st1.name;


            IEnumerable<string> names = list.Select((Student st1) => "Name = " + st1.name);

            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Func<int, int, int, int> func = (n1, n2, n3) => n1 + n2 + n3;
            Console.WriteLine("sum = " + func(1, 2, 3));


            //int? a = null;
            //Console.WriteLine(a.GetValueOrDefault());
            //a.GetValueOrDefault();

            DateTime? date = new DateTime(2002,10,08);
            DateTime date1 = date.GetValueOrDefault();

            DateTime date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine(date2);
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);


            int x = 10;
            float y = 10.98f;
            int z = (int)y;
            Console.WriteLine(z);

            dynamic d = y;

            Console.WriteLine(d);

            dynamic  e = d;
            Console.WriteLine(e);
            Console.WriteLine();
        }
    }
}

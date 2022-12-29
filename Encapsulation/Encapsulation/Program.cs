using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    class A
    {
        private int age;
        private string name;

        public void setAge(int age )
        {
            if(age > 0 && age!=0)
            {
                this.age = age;
            }
        }

        public void getAge()
        {
            if(age > 0 && age != 0)
            {
                Console.WriteLine($"Your age = {this.age}");
            }
            else
            {
                Console.WriteLine("Invalid Age");
            }
        }

        public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.name = Name; 
            }
        }

        public void getName()
        {
            if(!string.IsNullOrEmpty(name))
            Console.WriteLine($"Your Name is {name}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.setAge(0);
            a.getAge();
            a.setName("");
            a.getName();
        }
    }
}

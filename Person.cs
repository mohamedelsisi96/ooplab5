using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Person
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public Person()
        {
            Console.WriteLine("Person Class");
        }
        public Person(int age=10,string name="omar")
        {
            Age = age;
            Name = name;
        }
        public virtual string GetDetails()
        {
            return $"Name is {Name} \t Age is {Age}";
        }

    }
}

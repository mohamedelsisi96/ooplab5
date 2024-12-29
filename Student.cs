using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab5
{
    internal class Student:Person
    {
        public int Grade { get; set; }
        public Student(string name = "omar", int age = 10, int grade = 70) : base(age, name)
        {

            Grade = grade;

        }
        public override string GetDetails()
        {
            return $"- Name of Student is {Name}, \t Age is {Age}, \t Grade is {Grade}";
        }

    }
}


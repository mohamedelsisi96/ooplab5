using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Teacher:Person
    {

     
        public string Subject { get;  set; }
        public Teacher(string name = "omar", int age = 10, string sub="Math" ) :base(age,name) { 
        
            Subject = sub;
         
        }
        public override  string GetDetails()
        {

            return    $"- Name of Teacher is {Name}, \t Age is {Age}, \t Subject is {Subject}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class ProjectTeam
    {
        public string TeamName  { get; set; }

        Teacher [] teachers = default;
        Student[] students = default;
        int a=0; int b=0;
        public ProjectTeam (string name, int x,int y)
        { 
            TeamName = name;
            teachers=new Teacher[x];
            students=new Student[y];
        }
        public void AssignTeacher(Teacher teacher)
        {
         if(teacher != null && a < teachers.Length)
            {
                teachers[a] = teacher;
                a++;
            }
            else
            {
                Console.WriteLine("the Array of Teachers is Complete");
            }
        }
        public void AssignStudent(Student student)
        {
            if (student != null && b < students.Length)
            {
                students[b] = student;
                b++;
            }
            else
            {
                Console.WriteLine("the Array of Students is Complete");
            }
        }
        public void GetTeamDetails()
        {
            Console.WriteLine($"Project Team: {TeamName}");
            Console.WriteLine("Teachers:");
            foreach (Teacher t in teachers)
            {
                Console.WriteLine($"{t.GetDetails()}");
            }
            Console.WriteLine("Students:");
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.GetDetails()}");
            }
        }

    }
}

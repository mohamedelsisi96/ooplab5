namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher("John Doe", 45, "Mathematics");
            Teacher teacher2 = new Teacher("Jane Smith", 38, "Physics");
            Teacher teacher3 = new Teacher("Omar Mohamed", 30, "Chemistry");
            Student student1 = new Student("Alice Johnson", 20, 90);
            Student student2 = new Student("Bob Brown", 22, 85);

            ProjectTeam alphaTeam = new ProjectTeam("Alpha Team",2,2);
            alphaTeam.AssignTeacher(teacher1);
            alphaTeam.AssignTeacher(teacher2);
            alphaTeam.AssignTeacher(teacher3);
            alphaTeam.AssignStudent(student1);
            alphaTeam.AssignStudent(student2);
            alphaTeam.GetTeamDetails();
        }
    }
}

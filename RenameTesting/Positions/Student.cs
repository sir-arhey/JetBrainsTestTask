using RenameTesting.Interfaces;
using static RenameTesting.Positions.FullProfessor;

namespace RenameTesting.Positions
{
    public partial class Student : IStudent
    {
        public Student(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public string Age { get; set; }
    }
}
using RenameTesting.Interfaces;

namespace RenameTesting.Positions;

public class DeanOfComputerScience: IDean 
{
    public DeanOfComputerScience(string name, string age, string group, string subject, string faculty)
    {
        Name = name;
        Age = age;
        Group = group;
        Subject = subject;
        Faculty = faculty;
    }

    public string Name { get; set; }
    public string Age { get; set; }
    public string Group { get; set; }
    private string Subject { get; set; }
    public string Faculty { get; set; }
}

//public class FullProfessor
//{
//}
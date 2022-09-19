using JetBrainsTask.Positions;

namespace RenameTesting.Positions;

public class AssistantProfessor : FullProfessor
{
    public AssistantProfessor(string name, string age, string group, string subject)
    {
        Name = name;
        Age = age;
        Group = group;
        Subject = subject;
    }

    public string Name { get; set; }
    public string Age { get; set; }
    public string Group { get; set; }
    public string Subject { get; set; }
}
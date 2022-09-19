using RenameTesting.Interfaces;


namespace RenameTesting.Positions;

public class HeadOfHarvard: IRector 
{
    public HeadOfHarvard(string name, string age, string university)
    {
        Name = name;
        Age = age;
        University = university;
    }

    public string Name { get; set; }
    public string Age { get; set; }

    public string University { get; set; }
    
    public interface IDean
        {
            string Position { get; set; }
        }

    public string FormerPosition = "FullProfessor";
    
    public FullProfessor Run(FullProfessor professor)
    {
        FullProfessor.Method1();
        FullProfessor fullProfessor = new FullProfessor();
        Console.WriteLine(nameof(FullProfessor));
        return professor;
    }
}
using RenameTesting.Interfaces;
using Alias = JetBrainsTask.Positions.FullProfessor; 
using static JetBrainsTask.Positions.FullProfessor;

namespace JetBrainsTask.Positions;

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
    
    public FullProfessor Run(FullProfessor professor) //аргументы 25 кейс
    {
        FullProfessor.Method1(); //вызов статических методов класса 27 кейс
        FullProfessor fullProfessor = new FullProfessor(); // объявление переменной и вызов конструктора
        Console.WriteLine(nameof(FullProfessor)); //28 кейс
        return professor;
    }
}
using RenameTesting.Interfaces;
using Alias = RenameTesting.Positions.FullProfessor;

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
    
    public Alias Run(Alias professor) //аргументы 25 кейс
    {
        Alias.Method1(); //вызов статических методов класса 27 кейс
        Alias fullProfessor = new Alias(); // объявление переменной и вызов конструктора
        Console.WriteLine(nameof(Alias)); //28 кейс
        return professor;
    }
}
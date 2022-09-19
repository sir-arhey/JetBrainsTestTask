namespace RenameTesting.Interfaces;

public interface IProfessor: IStudent 
{
    string Group { get; set; }
    string Subject { get; set; }
}
namespace RenameTesting.Disciplines;

public partial class Student
{
    public Student(string failedSubject)
    {
        FailedSubjects = failedSubject;
    }

    public string FailedSubjects { get; set; }
}
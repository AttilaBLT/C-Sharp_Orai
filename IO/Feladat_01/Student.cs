namespace Feladat_01;

public class Student
{
    public string Name { get; set; }
    public double Avarage { get; set; }

    public Student()
    {

    }

    public Student(string name, double avarage)
    {
        Name = name;
        Avarage = avarage;
    }

    public override string ToString()
    {
        return $"{Name}: {Avarage}";
    }
}

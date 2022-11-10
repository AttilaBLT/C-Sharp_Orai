namespace Feladat_01;

public class Student
{
    public string Name { get; set; }
    public double Avarage { get; set; }

    public string Success
    {
        get
        {
            if (Avarage < 2) return "elégtelen";
            else if (Avarage < 3) return "elégséges";
            else if(Avarage < 4) return "jó";
            else if(Avarage < 5) return "jeles";
            else return "kitünő";
        }
    }

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

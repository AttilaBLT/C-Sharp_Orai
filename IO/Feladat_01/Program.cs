string FileName = "./../../../_feladat_/adatok.txt";
List<Student> students = new List<Student>();
LoadData();

//1 - Írjuk ki minden diák adatát a képernyőre!
PrintToScreen();
//2 - Hány diák jár az osztályba?
Console.WriteLine($"Az osztályba {students.Count} diák jár.");

//3 - Mennyi az osztály átlaga?
double avarage = students.Average(x => x.Avarage);
Console.WriteLine($"Az osztál átlaga: {avarage:#.##}"); //Max 2 tizedesjegy legyen

//4 - Keressük a legtöbb pontot elért érettségizőt és írjuk ki az adatait a képernyőre.
List<Student> bestStudents = Best();
Console.WriteLine("A legnagyob atlaggal rendelkező diák(ok): ");
PrintToScreen2(bestStudents);

//5 - atlagfelett.txt allományba keressük ki azon tanulókat kiknek pontjai meghaladják az átlagot!
bool sucess = AboveAvarageToFile(avarage);

Console.ReadKey();

void LoadData()
{
    //CultureInfo cultureinfo = Thread.CurrentThread.CurrentCulture; //kultúrális területek közötti eltérés, német - magyar nem egyezik

    using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None))
        using (StreamReader sr = new StreamReader(fs, Encoding.UTF7))
        {
            Student student = null;
            string oneLineData = null;
            string[] data = null;

            while (!sr.EndOfStream)
            {
            oneLineData = sr.ReadLine();
            data = oneLineData.Split("\t");

            student = new Student();
            student.Name = data[0];
            student.Avarage = double.Parse(data[1], new CultureInfo("hu-HU"));

            students.Add(student);
            }
        }
}

void PrintToScreen()
{
    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
}

void PrintToScreen2(ICollection<Student> studentsData)
{
    foreach (Student student in studentsData)
    {
        Console.WriteLine(bestStudents);
    }
}

List<Student> Best()
{
    double bestAvarage = students.Max(x => x.Avarage);
    return students.Where(x => x.Avarage == bestAvarage).ToList();
}

bool AboveAvarageToFile(double avarage)
{
    List<Student> studentsAboveAvg = students.Where(x => x.Avarage >= avarage).ToList();

    string output = "./../../../_feladat_/atlagfelett.txt";

    try
    {
    using (FileStream fs = new FileStream(output, FileMode.Open, FileAccess.Read, FileShare.None))
    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
    {
        foreach(Student student in studentsAboveAvg)
        {
            sw.WriteLine($"{ student.Name}\t{student.Avarage}");
        }
    }
        return true;

    }
    catch(IOException ex)
    {
        return false;
    }
}
string FileName = "./../../../_feladat_/adatok.txt";
List<Student> students = LoadData();

//1 - Írjuk ki minden diák adatát a képernyőre!
PrintToScreen(students);

//2 - Hány diák jár az osztályba?
Console.WriteLine($"Az osztályba {students.Count} diák jár.");

//3 - Mennyi az osztály átlaga?
double avarage = students.Average(x => x.Avarage);
Console.WriteLine($"Az osztál átlaga: {avarage:#.##}"); //Max 2 tizedesjegy legyen

//4 - Keressük a legtöbb pontot elért érettségizőt és írjuk ki az adatait a képernyőre.
List<Student> bestStudents = Best();
Console.WriteLine("A legnagyob atlaggal rendelkező diák(ok): ");
PrintToScreen(bestStudents);

//5 - atlagfelett.txt allományba keressük ki azon tanulókat kiknek pontjai meghaladják az átlagot!
bool sucess = AboveAvarageToFile(avarage);
Console.WriteLine($"A mentés {(sucess?"sikeres":"nem volt sikeres")}.");

//6 - Van e kitünő tanulónk?
bool isAnyExcelentStudent = students.Any(x => x.Avarage == 5);
Console.WriteLine($"{(isAnyExcelentStudent ? "Van": "Nincs")} kitűnő diák.");

//7 - Hány elégtelen, elégséges, jó, jeles és kitünő tanuló van az osztályban?
//  Értékhatárok:
//-elégtelen, ha: 0.00 - 1.99
//- elégséges, ha: 2.00 - 2.99
//- jó, ha: 3.00 - 3.99
//- jeles, ha: 4.00 - 4.99
//- kitünő, ha: 5.00
string[] successTypes = new string[] { "elégtelen", "elégséges", "jó", "jeles", "kitünő" };

Dictionary<string, int> successRatio = new Dictionary<string, int>();
foreach (string successType in successTypes)
{
    int count = students.Count(x => x.Success == successType);

    successRatio.Add(successType, count);
}

PrintToScreen3(successRatio);


Console.ReadKey();

List<Student> LoadData()
{
    //CultureInfo cultureinfo = Thread.CurrentThread.CurrentCulture; //kultúrális területek közötti eltérés, német - magyar nem egyezik
    List<Student> studentData = new List<Student>();
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

            studentData.Add(student);
            }
        }
    return studentData;
}

void PrintToScreen(ICollection<Student> studentsData)
{
    foreach (Student student in studentsData)
    {
        Console.WriteLine(student);
    }
}


void PrintToScreen3(Dictionary<string, int> successRatios)
{
    foreach (KeyValuePair<string, int> successRatio in successRatios)
    {
        Console.WriteLine($"{successRatio.Key} : {successRatio.Value}");
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


    ////1. lehetőség
    //try
    //{
    //using (FileStream fs = new FileStream(output, FileMode.Open, FileAccess.Read, FileShare.None))
    //using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
    //{
    //    foreach(Student student in studentsAboveAvg)
    //    {
    //        sw.WriteLine($"{ student.Name}\t{student.Avarage}");
    //    }
    //}
    //    return true;
    //}
    //catch(IOException ex)
    //{
    //    return false;
    //}

    ////2. lehetőség
    try
    {
        List<string> contents = new List<string>();


        File.WriteAllLines(output, contents);

        foreach (Student student in studentsAboveAvg)
        {
            contents.Add($"{student.Name}\t{student.Avarage}");
        }
        File.WriteAllLines(output, contents);

            return true;
    }
    catch (IOException ex)
    {

        return false;
    }
}
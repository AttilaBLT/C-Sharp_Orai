List<Driver> drivers = LoadData("./../../../_feladat/adatok.txt");
PrintToScreen(drivers);
//3. A felhasználó álltal megagadott megyére a megye-vezetoi.txt állományba elmenti a megadott megyében lakó vezetőket.
Console.WriteLine("Kérem a megyét!");
string region = Console.ReadLine();
string filePath = "./../../../_feladat/megye-vezetoi.txt";
ListToTxt(region, filePath);

Console.ReadKey();

List<Driver> LoadData(string filePath)
{
    List<Driver> driverData = new List<Driver>();
    Driver driver = null;
    string[] data = null;
    string[] Namedata = null;
    string[] Birthdata = null;
    string[] Addressdata = null;
    string[] categorydata = null;

    foreach (string line in File.ReadLines(filePath, Encoding.UTF7))
    {
        data = line.Split("\t");
        Namedata = data[0].Split(",");
        NameInformation nameInformation = new NameInformation()
        {
            FirstName = Namedata[0],
            LastName = Namedata[1],
            MotherFirstName= Namedata[2],
            MotherLastName= Namedata[3]
        };

        Birthdata = data[1].Split(",");
        BirthInformation birthInformation = new BirthInformation()
        {
            BirthDate = Convert.ToDateTime(Birthdata[0]),
            BirthPlace = Birthdata[1],
            Region = Birthdata[2],
            Country = Birthdata[3]
        };

        Addressdata = data[2].Split(",");
        Address address = new Address()
        {
            Street = Addressdata[0],
            HouseNumber = Addressdata[1],
            PostalCode = Addressdata[2],
            City = Addressdata[3],
            Region = Addressdata[4],
            Country = Addressdata[5],
        };

        driver = new Driver()
        {
            NameInformation = nameInformation,
            BirthInformation = birthInformation,
            Address = address,
            LicenseCategory = data[3].Split(",").ToList()
        };
        driverData.Add(driver);
    }
    return driverData;
}

void PrintToScreen(List<Driver> drivers)
{
    foreach (Driver driver in drivers)
    {
        Console.WriteLine(driver);
    }
}

void ListToTxt(string region, string filePath, )
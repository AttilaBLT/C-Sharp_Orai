string email = GetEmailFromConsole();
string password = GetPasswordFromConsole();

List<User> users = LoadData("./../../../_feladat_/adatok.txt");

bool isLoggedin = users.Any(x => x.Email == email &&
                              x.Password == password);

if (isLoggedin)
{
    Log();
}

Console.WriteLine($"{(isLoggedin ? "Sikeres" : "Sikertelen ")} bejelentkezés");

Console.ReadKey();

List<User> LoadData(string filePath)
{
    List<User> userData = new List<User>(); //List<User> userData = new(); UGYANAZ!
    User user = null;
    string[] data = null;

    foreach (string line in File.ReadAllLines(filePath, Encoding.UTF8))
    {
        data = line.Split('\t');
        user = new User
        {
            Email = data[0],
            Password = data[1]
        };
        userData.Add(user);
    }
    return userData;
}

string GetEmailFromConsole()
{
    string email = string.Empty;

    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    Match match;

    do
    {
        Console.Write("Email: ");
        email = Console.ReadLine();

        match = regex.Match(email);

        if (!match.Success)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Az e-mail cím nem megfelelő");
            Console.ResetColor();
        }
    }
    while (!match.Success);
   
    return email;
}

string GetPasswordFromConsole()
{
    string password = string.Empty;

    do
    {
        Console.Write("Password: ");
        password = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(password) || password.Length < 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A jelszó nem megfelelő");
            Console.ResetColor();
        }
    }
    while (string.IsNullOrWhiteSpace(password) || password.Length < 2);

    return password;
}

void Log()
{
    string fileName = "./../../../_feladat_/log.txt";

    using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        sw.WriteLine($"{DateTime.Now:yyyy-MM-dd hh:mm:ss} : {email}"); /* DateTime.Now:yyyy-MM-ddhh:ss*/
    }
}

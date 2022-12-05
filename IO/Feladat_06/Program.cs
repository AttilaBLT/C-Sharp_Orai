List<Player> players = LoadData("./../../../_feladat_/adatok.txt");

//Írjuk ki a képernyőre az össz adatot
PrintToScreen(players);

//Keressük ki az ütő játékosokat az utok.txt állömányba
string filePath = "./../../../_feladat_/utok.txt";
List<Player> utokList = players.Where(x => x.Position.ToLower() == "ütő").ToList();
ListToFile(utokList, filePath);
filePath = string.Empty;

//A csapattagok.txt állományba mentsük a csapatokat és a hozzájuk tartozó játékosokat a következő formában:
//Telekom Baku: Yelizaveta Mammadova, Yekaterina Gamova,
filePath = "./../../../_feladat_/csapattagok.txt";
List<string> teams = players.Select(x => x.Team).Distinct().ToList();
Dictionary<string, List<Player>> teamsAndPlayers = new Dictionary<string, List<Player>>();
foreach (string team in teams)
{
    teamsAndPlayers.Add(team, players.Where(x => x.Team == team).ToList());
}
ToTxtByTeamsWithPlayers(teamsAndPlayers, filePath);
filePath = string.Empty;

//Rendezzük a játékosokat magasság szerint növekvő sorrendbe és a magaslatok.txt állományba mentsük el.
filePath = "./../../../_feladat_/magaslatok.txt";
List<Player> magassagisorrend = players.OrderBy(x => x.Height).ToList();
ListToFile(magassagisorrend, filePath);
filePath = string.Empty;

//Mutassuk be a nemzetisegek.txt állományba, hogy mely nemzetiségek képviseltetik magukat a röplabdavilágban mint játékosok és milyen számban.
filePath = "./../../../_feladat_/nemzetisegek.txt";
List<string> natiolities = players.Select(x => x.Nationality).Distinct().ToList();
Dictionary<string, int> nationalitiesAndCount = new Dictionary<string, int>();
foreach (string nation in natiolities)
{
    nationalitiesAndCount.Add(nation, players.Where(x => x.Nationality == nation).Count());
}
ToTxtNations(nationalitiesAndCount, filePath);
filePath = string.Empty;

//atlagnalmagasabbak.txt állományba keressük azon játékosok nevét és magasságát akik magasabbak mint az „adatbázisban” szereplő játékosok átlagos magasságánál.
filePath = "./../../../_feladat_/atlagnalmagasabbak.txt";
double avgHeight = players.Average(x => x.Height);
List<Player> aboveAvg = players.Where(x => x.Height > avgHeight).ToList();
ListToFile(aboveAvg, filePath);
filePath = string.Empty;

//Állítsa növekvő sorrendbe a posztok szerint a játékosok ösz magasságát
filePath = "./../../../_feladat_/posztok.txt";
List<string> positions = players.Select(x => x.Position).Distinct().ToList();
Dictionary<string, double> positionsAndHeights = new Dictionary<string, double>();
foreach (string position in positions)
{
    positionsAndHeights.Add(position, players.Where(x => x.Position == position).Sum(x => x.Height));
}
positionsAndHeights = positionsAndHeights.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
ToTxtPositions(positionsAndHeights, filePath);
filePath = string.Empty;


/*Egy szöveges állományba, „alacsonyak.txt” keresse ki a játékosok átlagmagasságától alacsonyabb játékosokat.
Az állomány tartalmazza a játékosok nevét, magasságát és hogy mennyivel alacsonyabbak az átlagnál,
2 tizedes pontossággal.*/
filePath = "./../../../_feladat_/alacsonyak.txt";
List<Player> belowAvg = players.Where(x => x.Height < avgHeight).ToList();
ToTXTPlayersBelowAVGHeight(belowAvg, filePath, avgHeight);

Console.ReadKey();

List<Player> LoadData(string filePath)
{
    List<Player> playerData = new List<Player>();
    Player player = null;
    string[] data = null;
    foreach (string line in File.ReadLines(filePath, Encoding.UTF7))
    {
        data = line.Split('\t');
        player = new Player()
        {
            Name = data[0],
            Height = int.Parse(data[1]),
            Position = data[2],
            Nationality = data[3],
            Team = data[4],
            Country = data[5]
        };
        playerData.Add(player);
    }
    return playerData;
}

void PrintToScreen(List<Player> players)
{
    foreach (Player player in players)
    {
        Console.WriteLine(player);
    }
}

void ListToFile(ICollection<Player> players, string filePath)
{
    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (Player player in players)
        {
            sw.WriteLine(player.ToString());
        }
    }
}

void ToTxtByTeamsWithPlayers(Dictionary<string, List<Player>> teamsAndPlayers, string filePath)
{
    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (KeyValuePair<string, List<Player>> line in teamsAndPlayers)
        {
            sw.Write($"{line.Key}: ");
            foreach (Player player in line.Value)
            {
                sw.Write($"{player.Name},");
            }
            sw.WriteLine();
            sw.WriteLine();
        }
    }
}

void ToTxtNations(Dictionary<string, int> nationsAndCounts, string filePath)
{
    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (KeyValuePair<string, int> line in nationsAndCounts)
        {
            sw.Write($"{line.Key}: {line.Value}");
            sw.WriteLine();
        }
    }
}

void ToTxtPositions(Dictionary<string, double> positionsAndHeights, string filePath)
{
    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (KeyValuePair<string, double> line in positionsAndHeights)
        {
            sw.Write($"{line.Key}: {line.Value}Cm");
            sw.WriteLine();
        }
    }
}

void ToTXTPlayersBelowAVGHeight(ICollection<Player> players, string filePath, double avgHeight)
{
    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (Player player in players)
        {
            double diff = avgHeight - player.Height;
            sw.WriteLine($"{player.Name}: {player.Height}Cm | {Math.Round(diff, 2)}");
        }
    }
}
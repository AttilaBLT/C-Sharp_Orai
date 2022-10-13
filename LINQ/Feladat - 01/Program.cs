using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Feladat___01
{
    internal class Program
    {
        private static List<Player> _players = new List<Player>();

        private static void LoadData()
        {
            using (FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string jsonData = sr.ReadToEnd();

                    _players = JsonConvert.DeserializeObject<List<Player>>(jsonData);
                }
            }
        }

        private static void WriteToConsole(string text, ICollection<Player> players)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', _players));
        }

        private static void WriteToConsole(string text, Player player)
        {
            Console.WriteLine(text);
            Console.WriteLine(player);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole("Data", _players);

            //Hány játékos található az adatbázisban?
            int JatekosokSzama = _players.Count;

            //Mekkora a játékosok össz súlya?
            int JatekosokOsszSulya = _players.Sum(player => player.Weight);

            //Mekkora a játékosok átlag magassága?
            double atlagMagassag = _players.Average(player => player.Height);

            //Milyen magas a legalacsonyabb játékos?
            double minHeight = _players.Min(player => player.Height);
            Console.WriteLine(minHeight);

            //Milyen magas a legmagasabb játékos?
            double maxweight = _players.Max(player => player.Weight);

            //Van-e olyan játékos aki 1.78m magas?
            bool isAnyHeight178 = _players.Any(player => player.Height == 1.78);
            Console.WriteLine(isAnyHeight178);
            //Kik játszanak a "Vasas óbuda" klubban?
            List<Player> vasasObudaPlayers = _players.Where(player => player.Club == "Vasas Óbuda")
                                                     .ToList();

            //Keresse ki azon játékosok nevét akik a "vasas Óbuda" klubban játszanak?
            List<string> vasasObudaPlayerNames = _players.Where(player => player.Club == "Vasas Óbuda")
                                                         .Select(player => player.Name)
                                                         .ToList();

            //Keresse ki azon játékosok nevét akik a "Vasas Óbuda" klubban játszanak és rendezze őket növekvő sorrendbe magassag szerint
            List<string> vasasObudaPlayerNamesOrderByHeight = _players.Where(player => player.Club == "Vasas Óbuda")
                                                                      .OrderBy(player => player.Height) //OrderBy növekvő; OrderByDescending csökkenő
                                                                      .Select(player => player.Name)
                                                                      .ToList();
            Console.ReadKey();
        }
    }
}

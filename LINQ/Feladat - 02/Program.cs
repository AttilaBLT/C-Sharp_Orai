using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Feladat___02
{
    internal class Program
    {
        private static List<Game> _games = new List<Game>();

        private static void LoadData()
        {
            using (FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string jsonData = sr.ReadToEnd();

                    _games = JsonConvert.DeserializeObject<List<Game>>(jsonData);
                }
            }
        }

        private static void WriteToConsole(string text, ICollection<Game> games)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', _games));
        }

        private static void WriteToConsole(string text, Game game)
        {
            Console.WriteLine(text);
            Console.WriteLine(game);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole("Data", _games);

            /*
             1. Hány adat van a listában?
            */
            int adatokSzama = _games.Count;

            /*
             2. Keressük ki azon játékokat, melyek MMORPG tipusuak (genre).
            */
            List<Game> mmorpgGames = _games.Where(game => game.Genre.ToLower() == "mmorpg")
                                           .ToList();

            /*
            3. Keressük ki azon játékokat, melyek 2013-ban jelentek meg.
           */
            List<Game> gamesin2013 = _games.Where(game => game.Release_date != "0000-00-00")
                                           .Where(game => DateTime.Parse(game.Release_date).Year == 2013)
                                           .ToList();

            /*
            4. Keressük ki azon játékokat, melyek Darkflow Distribution KFR fejlesztett.
           */
            List<Game> DDK = _games.Where(game => game.Developer.ToLower() == "darkflow distribution kfr").ToList();
            /*
            5. Keressük ki hány shooter játék van a listában.
           */
            int ShooterCount = _games.Count(game => game.Genre.ToLower() == "shooter");

            /*
            Van-e olyan játék melyet Cryptic Studios fejleszett?
           */
            bool crypticgame = _games.Any(game => game.Developer.ToLower() == "cryptic studios");

            /*
            Keressük ki azon játékokat, melyek a címében (title) szerepel a ,,winter,, szó.
           */
            List<Game> wintergames = _games.Where(game => game.Title.Contains("Winter"))
                                           .ToList();


            /*
            Keressük ki a platformokat, de úgy, hogy mindegyik csak egyszer forduljon elő az eredménybe.
           */
            List<string> gamePlatform = _games.Select(game => game.Platform)
                                              .Distinct()
                                              .ToList();

            /*
            Keressük ki , hogy típusonként (genre) hány játék van.
           */
            int count = 0;
            Dictionary<string, int> genreCountDictionary = new Dictionary<string, int>();
            List<string> genres = _games.Select(game => game.Genre)
                                        .Distinct()
                                        .ToList();

            foreach (string genre in genres)
            {
                count = _games.Count(game => game.Genre.ToLower() == genre.ToLower());
                genreCountDictionary.Add(genre, count);
            }


            /*
            Keressük ki az Electronic Arts álltal fejlesztett játékokat, melyek shooter típusúak.
           */
            List<Game> eagames = _games.Where(game => game.Developer.ToLower() == "electronic arts").ToList();

            /*
            Keressük ki a listában szereplő fejlesztők  játékainak címét.
           */
            Dictionary<string, List<string>> developerGames = new Dictionary<string, List<string>>();
            List<string> developers = _games.Select(game => game.Developer)
                                            .Distinct()
                                            .ToList();

            foreach (string developer in developers)
            {
                List<string> developerGameTitles = _games.Where(game => game.Developer == developer)
                                                         .Select(game => game.Title)
                                                         .ToList();
                developerGames.Add(developer, developerGameTitles);
            }

            /*
            Keressük ki azt a játékot mely legkorábban jelent meg.
           */
            //Game earliestGame = _games.Where(game => game.Release_date != "0000-00-00")
            //                          .OrderBy(game => game.Release_date)
            //                          .First();

            DateTime earliestDate = _games.Where(game => game.Release_date != "0000-00-00")
                                          .Min(game => DateTime.Parse(game.Release_date));

            Game earlygame = _games.FirstOrDefault(game => DateTime.Parse(game.Release_date).Date == earliestDate.Date);


            /*
            Keressük ki azon játékok címét, melyeket az Ubisoft jelenített meg, 
            a Blue Byte fejlesztett ki 2010 és 2015 közt.
           */
            List<string> ubisoftGamesByBB = _games.Where(game => game.Publisher.ToLower() == "ubisoft")
                                                  .Where(game => game.Developer.ToLower() == "Blue Byte")
                                                  .Where(game => DateTime.Parse(game.Release_date).Year > 2010)
                                                  .Where(game => DateTime.Parse(game.Release_date).Year < 2015)
                                                  .Select(game => game.Title)
                                                  .ToList();


        }
    }
}


//18 Peti 19 én
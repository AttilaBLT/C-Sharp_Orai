using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Linq;

namespace Feladat___01
{
    internal class Program
    {
        private static List<User> _users = new List<User>();

        private static void LoadData()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            options.Converters.Add(new CurrencyJsonConverter());
            options.Converters.Add(new DateTimeJsonConverter());

            using FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None);
            using StreamReader sr = new StreamReader(fs, Encoding.UTF8);
           
            string jsonData = sr.ReadToEnd();
            _users = JsonSerializer.Deserialize<List<User>>(jsonData, options);
        }

        private static void WriteToConsole(string text, ICollection<User> players)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', _users));
        }

        private static void WriteToConsole(string text, User player)
        {
            Console.WriteLine(text);
            Console.WriteLine(player);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole("Data", _users);

        /*
            5 -> 24 - 27
            4 -> 20 - 23
            3 -> 14 - 20
            2 -> 10 - 13
            1 -> 00 - 09
         */

            //Hány felhasználónk van? (1)
            int userCount = _users.Count();

            //Mekkora a felhasználók átlagos életkora? (1)
            double avglife = _users.Average(x => x.Age);

            //Mekkora a felhasználók össz egyenlege? (1)
            int balanceSum = _users.Sum(x => int.Parse(x.Balance));

            //Milyen idős a legfiatalanbb felhasználónk?  Feltételezzük, hogy nincs ugyanazon a napon született több felhasználó! (2)
            int legfiatalabb = _users.Min(x => x.Age);

            //Van-e olyan felhasználónk aki '1996-04-12' regisztrált? (1)
            bool isAnyregisteredin1996 = _users.Any(x => x.Registered == DateTime.Parse("1996-04-12"));


            //Keresse ki a nem aktiv felhasználók e-mail címét. (1)
            List<string> notActiveUsers = _users.Where(x => x.IsActive == false)
                                                .Select(x => x.Email)
                                                .ToList();

            //Milyen a férfi/női arány a felhszálók közt? (3)
            int Males = _users.Where(x => x.Gender.ToLower() == "male")
                              .Count();

            int feMales = _users.Where(x => x.Gender.ToLower() == "female")
                                 .Count();


            double ferfiakNokAranya = feMales / Males;


            //Ki az a felhasználó (név) aki a '113 Fleet Street' címen lakik? (1)
            var livesin113fleetstreet = _users.Where(x => x.Address == "113 Fleet Street")
                                              .Select(x => x.Name);

            //Kik azok a felhasználók akik a magukról megadott mezőbe (about) több mint 100 karakter adtak meg. (2)
            List<User> morthan100char = _users.Where(x => x.About.Length > 100)
                                                .ToList();

            //Keressük ki a cégek nevét és rendezzük őket abc szerint csökkenő sorrendbe. (2)
            List<User> companyNames = _users.OrderByDescending(x => x.Company)
                                            .ToList();

            //Mi az e-mail címe azoknak a felhasználóknak akik a 'FROLIX' cégben dolgoznak? (1)
            List<string> frolixMails = _users.Where(x => x.Company == "FROLIX")
                                             .Select(x => x.Email)
                                             .ToList();

            //Ki az az egy felhasználó aki a '764 Vanderveer Street, Roulette, District Of Columbia, 6194' címen lakik? (1)
            var only764vanerveerst = _users.Single(x => x.Address.ToLower() == "764 Vanderveer Street, Roulette, District Of Columbia, 6194");

            //Keresse ki azon felhasználok nevét akik aktívak,  nő neműek, fekete szeműek, 30 és 40 életkor közöttiek és rendezze őket név szerint növekvő sorrendbe majd életkor alapján. (3)
            List<User> activeFemalesBlackeyes = _users.Where(x => x.IsActive == true)
                                                        .Where(x => x.Gender == "female")
                                                        .Where(x => x.EyeColor == "black")
                                                        .Where(x => x.Age > 30)
                                                        .Where(x => x.Age < 40)
                                                        .OrderBy(x => x.Name)
                                                        .ThenBy(x => x.Age)
                                                        .ToList();

            //Keresse ki azon a felhasználók nevét, telefonszámát és e-mail címét akik telefonszáma '+49'-el kezdődik? (3)
            List<NamePhoneNumberEmailAddress> phonenumberswith49 = _users.Where(x => x.Phone.Contains("+49"))
                                                                         .Select(x => new NamePhoneNumberEmailAddress(x.Name, x.Phone, x.Email))
                                                                         .ToList();

            //Keresse ki, hogy szem szín szerint hány felhasználónk van? (4)
            int count = 0;
            Dictionary<string, int> eyeColorsCount = new Dictionary<string, int>();
            List<string> eyeColors = _users.Select(x => x.EyeColor)
                                            .Distinct()
                                            .ToList();


            foreach (string color in eyeColors)
            {
                count = _users.Where(x => x.EyeColor.ToLower() == color)
                              .Count();

                eyeColorsCount.Add(color, count);
            }

        }
    }
}

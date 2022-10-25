using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Feladat___04
{
    internal class Program
    {
        private static List<Movie> _movies = new List<Movie>();

        private static void LoadData()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
            };

            options.Converters.Add(new DateFormatConverter());

            using (FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string jsonData = sr.ReadToEnd();

                    _movies = JsonSerializer.Deserialize<List<Movie>>(jsonData, options);
                }
            }
        }

        private static void WriteToConsole(string text, ICollection<Movie> movies)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', _movies));
        }

        private static void WriteToConsole(string text, Movie movie)
        {
            Console.WriteLine(text);
            Console.WriteLine(movie);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole($"Data ({_movies.Count})", _movies);

            // 1 - Hány film adatát dolgozzuk fel?

            int db = _movies.Count();

            // 2 - Mekkora bevételt hoztak a filmek Amerikában?

            int incomeUSA = _movies.Where(x => x.USGross.HasValue) // "int?"-nak lehet null értéke, ezért szűrünk, szum nem szereti a null-t
                                    .Sum(x => x.USGross.Value); // .HasValue a "szűrés" -> van-e értéke? | nullable típusnak kérjük az értékét ".Value"
                                                                //Nullable<int> == int?   |   szóval ez új típus, új metódusokkal

            // 3 - Mekkora bevételt hoztak a filmek Világszerte?

            long incomeWW = _movies.Where(x => x.WorldwideGross.HasValue)
                                  .Sum(x => x.WorldwideGross.Value);

            // 4 - Hány film jelent meg az 1990-es években?

            int filmek90 = _movies.Where(x => x.ReleaseDate.Year >= 1990)
                                  .Where(x => x.ReleaseDate.Year <= 2000).Count();

            // 5 - Hányan szavaztak összessen az IMDB-n?

            int hanyanSzavaztak = _movies.Where(x => x.IMDBVotes.HasValue)
                                         .Sum(x => x.IMDBVotes.Value);

            // 6 - Hányan szavaztak átlagossan az IMDB-n?

            double hanyanSzavaztakAtlag = _movies.Where(x => x.IMDBVotes.HasValue)
                                        .Average(x => x.IMDBVotes.Value);

            // 7 - A filmek  világszerte átlagban mennyit hoztak a konyhára?

            double vilagszerteAvg = _movies.Where(x => x.WorldwideGross.HasValue)
                                        .Average(x => x.WorldwideGross.Value);

            // 8 - Hány filmet rendezett 'Christopher Nolan' ?

            int chrisFilms = _movies.Where(x => x.Director.ToLower() == "christopher nolan").Count();

            // 9 - Melyik filmeket rendezte 'James Cameron'?

            List<string> jamesFilms = _movies.Where(x => x.Director.ToLower() == "james cameron")
                                             .Select(x => x.Title)
                                             .ToList();

            // 10 - Keresse ki a 'Fantasy' kaland (Adventure) zsáner kategóriájjú filmeket.

            List<Movie> fantasy = _movies.Where(x => x.MajorGenre.ToLower() == "fantasy")
                                             .ToList();

            // 11 - Kik rendeztek akció (Action) filmeket és mikor?

            List<DirectorAndReleaseDate> rendezoEsEvszam = _movies.Where(x => x.CreativeType.ToLower() == "action")
                                                                  .Select(x => new DirectorAndReleaseDate(x.Director, x.ReleaseDate))
                                                                  .ToList();

            // 12 - 'Paramount Pictures' horror filmjeinek cime?

            List<string> paramountHorror = _movies.Where(x => x.Director.ToLower() == "paramount pictures")
                                                  .Where(x => x.Distributor.ToLower() == "horror")
                                                  .Select(x => x.Title)
                                                  .ToList();

            // 13 - Van-e olyan film melyet 'Tom Crusie' rendezett?

            bool vanETom = _movies.Any(x => x.Distributor.ToLower() == "tom crusie");

            // 14 - A 'Little Miss Sunshine' filme mekkora össz bevételt hozott?

            double lmsBevetel = _movies.Where(x => x.Title.ToLower() == "little miss sunshine")
                                       .Where(x => x.WorldwideGross.HasValue)
                                       .Where(x => x.USGross.HasValue)
                                       .Sum(x => x.WorldwideGross.Value + x.USGross.Value); //IDK miért amerika + világ = világ

            // 15 - Hány olyan film van amely az IMDB-n 6 feletti osztályzatot ért el és a 'Rotten Tomatoes'-n pedig legalább 25-t?

            int hanyilyen = _movies.Where(x => x.IMDBRating > 6 && x.RottenTomatoesRating >= 25).Count();

            // 16 - 'Michael Bay' filmjei átlagban mekkora bevételt hoztak?

            double michaelBayGrossAvg = _movies.Where(x => x.Director.ToLower() == "michael bay")
                                            .Where(x => x.WorldwideGross.HasValue)
                                            .Average(x => x.WorldwideGross.Value);

            // 17 - Melyek azok a 'Michael Bay' a 'Walt Disney Pictures' által forgalmazott fimek melyek legalább 150min hosszúak.

            List<Movie> mBDisney150 = _movies.Where(x => x.Director.ToLower() == "michael bay")
                                             .Where(x => x.Distributor.ToLower() == "walt disney pictures")
                                             .Where(x => x.RunningTime >= 150)
                                             .ToList();

            // 18 - Listázza ki a forgalmazókat úgy, hogy mindegyik csak egyszer jelenjen meg!

            List<string> forgalmazok = _movies.Select(x => x.Distributor)
                                              .Distinct()
                                              .ToList();

            // 19 - Rendezze a filmeket az 'IMDB Votes' szerint  növekvő sorrendbe.

            List<Movie> imdbSorrend = _movies.OrderBy(x => x.IMDBRating)
                                             .ToList();

            // 20 - Rendezze a filmeket címük szerint csökkenő sorrendbe!

            List<Movie> descmovies = _movies.OrderByDescending(x => x.Title)
                                            .ToList();

            // 21 - Melyek azok a filmek melyek hossza meghaladja a 120 percet?

            List<Movie> hosszabbMint120 = _movies.Where(x => x.RunningTime > 120)
                                                 .ToList();

            // 22 - Hány film jelent meg december hónapban?

            int decemberiFilmek = _movies.Where(x => x.ReleaseDate.Month == 12)
                                         .Count();

            // 23 - Egyes besorolásokban (Rating) hány film található?

            int count = 0;
            Dictionary<string, int> ratingFilmek = new Dictionary<string, int>();
            List<string> ratings = _movies.Select(x => x.Rating)
                                         .Distinct()
                                         .ToList();
            foreach (string rating in ratings)
            {
                count = _movies.Where(x => x.Rating.ToLower() == rating)
                               .Count();
                ratingFilmek.Add(rating, count);
            }


            // 24 - Keresse ki azokat a filmeket melyeket 'Ron Howard' rendezett a 2000 években,
            // 'PG-13' bsorolású, lagalább 80 perc hosszú és az IMDB legalább 6.5 átlagot ért el.

            List<Movie> ronHowardFilmek = _movies.Where(x => x.Director.ToLower() == "ron howard")
                                                 .Where(x => x.ReleaseDate.Year >= 2000)
                                                 .Where(x => x.ReleaseDate.Year <= 2009)
                                                 .Where(x => x.Rating.ToLower() == "pg-13")
                                                 .Where(x => x.RunningTime >= 80)
                                                 .Where(x => x.IMDBRating >= 6.5)
                                                 .ToList();

            // 25 - A 'Lionsgate' kiadónál kik rendeztek filmeket?

            List<string> lionsgateRendezok = _movies.Where(x => x.Distributor.ToLower() == "lionsgate")
                                                    .Select(x => x.Director)
                                                    .ToList();

            // 26 - Az 'Universal' forgalmazó átlagban mennyit kültött film forgatására?

            double universalAvg = _movies.Where(x => x.Distributor.ToLower() == "universal")
                                         .Where(x => x.ProductionBudget.HasValue)
                                         .Average(x => x.ProductionBudget.Value);

            // 27 - Az 'IMDB Votes' alapján melyek azok a filmek, melyeket többen értékeltek min 30 000-n?

            List<Movie> tobbMint30k = _movies.Where(x => x.IMDBVotes > 30000)
                                             .ToList();

            // 28 - Az 'American Pie' című filmnek hány része van?

            int americanPies = _movies.Where(x => x.Title.ToLower().Contains("american pie"))
                                      .Count();

            // 29 - Van-e olyan film melynek a címében szerepel a 'fantasy' szó és a zsánere 'Adventure'?

            bool vaneFantasyVAdventure = _movies.Any(x => x.Title.ToLower().Contains("fantasy") && x.MajorGenre.ToLower() == "adventure");


            // 30 - Átlagban hányan szavaztak az IMDB-n?

            double imdbVotesAvg = _movies.Where(x => x.IMDBVotes.HasValue)
                                         .Average(x => x.IMDBVotes.Value);

            // 31 - Kik rendeztek a 'Warner Bros.' forgalmazónál dráma filmeket 1970 és 1975 közt 
            // melyre az 'IMDB Votes' alapján többen szavaztak az átlagnál?

            List<string> warnerbrosRendezok = _movies.Where(x => x.Distributor.ToLower() == "warner bros.")
                                                     .Where(x => x.MajorGenre.ToLower() == "drama")
                                                     .Where(x => x.ReleaseDate.Year >= 1970)
                                                     .Where(x => x.ReleaseDate.Year <= 1975)
                                                     .Where(x => x.IMDBVotes > imdbVotesAvg)
                                                     .Select(x => x.Director)
                                                     .ToList();

            // 32 - Van e olyan film amely karácsony napján jelent meg?

            bool vanEKaracsonykorMegjelent = _movies.Any(x => x.ReleaseDate.Month == 12 && x.ReleaseDate.Day == 25);

            // 33 - 'Spider-Man' című filmek USA-ban mekkora bevételt hoztak?

            int usaSpiderManFilms = _movies.Where(x => x.Title.ToLower().Contains("spider-man"))
                                           .Where(x => x.USGross.HasValue)
                                           .Sum(x => x.USGross.Value);

            // 34 - Keresse ki  szuperhősös (Super Hero) filmek címeit.

            List<string> superheroMovies = _movies.Where(x => x.MajorGenre.ToLower() == "superhero")
                                                  .Select(x => x.Title)
                                                  .ToList();

        }
    }
}
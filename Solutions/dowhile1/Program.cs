using System;
using System.Threading;

namespace dowhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            bool szamE = false;

            do
            {
                Console.Write("Adjon meg egy számot: ");
                szamE = int.TryParse(Console.ReadLine(), out szam);

                if (!szamE)
                {
                    Console.WriteLine("Nem számot adott meg!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else if (szam < 0 || szam > 9)
                {
                    Console.WriteLine("A szám nem a megadott határéték között van!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                
            } while (!szamE || szam < 0 || szam > 9);

            Console.WriteLine($"A szám:{szam}");
            Console.ReadKey();
        }
    }
}

using System;

namespace ciklusok17
{
    class Program
    {
        static void Main(string[] args)
        {
            double atlag = 0;
            double sum = 0;
            int db = 0;

            Console.WriteLine("Adja meg az első számot:");
            double kezdoErtek = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a második számot:");
            double vegErtek = int.Parse(Console.ReadLine());

            for (double i = kezdoErtek; i <= vegErtek; i++)
            {
                sum += i;
                db++;
            }
            atlag = sum / db;

            Console.WriteLine($"Az intervallum átlaga: {atlag}");
            Console.ReadKey();
        }
    }
}

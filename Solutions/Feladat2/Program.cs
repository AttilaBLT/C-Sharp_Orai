using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Adjon meg egy kezdő értéket:");
            int kezdoErtek = int.Parse(Console.ReadLine());

            Console.WriteLine("Adjon meg egy vég értéket:");
            int vegErtek = int.Parse(Console.ReadLine());

            for (int i = kezdoErtek; i <= vegErtek; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Az összeg: {sum}");
            Console.ReadKey();
        }
    }
}

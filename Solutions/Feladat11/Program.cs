using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot:");
            int num = int.Parse(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("A szám páros!");
            }
            else
            {
                Console.WriteLine("A szám páratlan!");
            }

            if (num == 0)
            {
                Console.WriteLine("A szám nulla!");
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine("A szám pozitív!");
                }
                else
                {
                    Console.WriteLine("A szám negatív!");
                }
            }

            if (num % 5 == 0)
            {
                Console.WriteLine("A szám osztható 5-el!");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 5-el!");
            }


            Console.ReadKey();
        }
    }
}

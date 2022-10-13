using System;

namespace for_ciklus18_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;

            Console.WriteLine("Adja meg az kezdő értéket:");
            int kezdoErtek = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg az vég értéket:");
            int vegErtek = int.Parse(Console.ReadLine());

            for (int i = kezdoErtek; i <= vegErtek; i++)
            {
                if (kezdoErtek % 2 == 0)
                {
                    if (i % 2 == 0)
                    {
                        osszeg += i;
                    }
                    else
                    {
                        osszeg -= i;
                    }
                }

                else
                {
                    if (i % 2 == 0)
                    {
                        osszeg -= i;
                    }
                    else
                    {
                        osszeg += i;
                    }
                }     
            }

            Console.WriteLine($"Az összeg: {osszeg}");
            Console.ReadKey();
        }
    }
}

using System;

namespace sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {
            Negyzet negyzet = new Negyzet(5);
            Console.WriteLine($"A négyzet kerülete: {negyzet.Kerulet()}");
            Console.WriteLine($"A négyzet területe: {negyzet.Terulet()}");
            Console.WriteLine();

            Teglalap teglalap = new Teglalap(5, 10);
            Console.WriteLine($"A téglalap kerülete: {teglalap.Kerulet()}");
            Console.WriteLine($"A téglalap területe: {teglalap.Terulet()}");
            Console.WriteLine();

            Kor kor = new Kor(6.5);
            Console.WriteLine($"A kör kerülete: {kor.Kerulet()}");
            Console.WriteLine($"A kör területe: {kor.Terulet()}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

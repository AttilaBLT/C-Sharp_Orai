using System;

namespace Gepjarmu
{
    class Program
    {
        static void Main(string[] args)
        {
            Tulajdonos en = new Tulajdonos("Jánovszki", "Attila", new DateTime(2003, 08, 10));
            Gepjarmu mazda = new Gepjarmu("Mazda", "CX30","1.8SkyActiveG", UzemanyagTipus.Benzin, "AAA000", en );
            Gepjarmu tesla = new Gepjarmu("Tesla", "Model Y", "long range", UzemanyagTipus.Elektromos, "ABA001", en);

            en.GepjarmuetVesz(mazda);
            en.GepjarmuetVesz(tesla);
            foreach (Gepjarmu gepjarmu in en.Gepjarmuvek)
            {
                Console.WriteLine(gepjarmu);
                Console.WriteLine();
            }
            Console.ReadKey();            
        }
    }
}

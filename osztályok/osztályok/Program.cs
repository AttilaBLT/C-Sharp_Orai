using System;

namespace osztályok
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto nissan = new Auto();
            nissan.Marka = "Nissan";
            nissan.Tipus = "Skyline GT-R R32";
            nissan.GyartasiEvKezdete = 1989;
            nissan.GyartasiEvVege = 1993;

            Auto toyota = new Auto("Toyota", "Supra Mk4", 1992, 2002);

            Console.WriteLine(nissan);
            Console.WriteLine(toyota);


            Fogasok hekk = new Fogasok();
            hekk.Horgasz = "Hekk Elek";
            hekk.Hal = "Hekk";

            Fogasok csuka = new Fogasok("Kiss Pál", "Csuka");
            Console.WriteLine(hekk);
            Console.WriteLine(csuka);


            pizza margareta = new pizza();

            pizza magyaros = new pizza();
            magyaros.Pizza = "Magyaros";
            magyaros.Rendelo = "Erős Pista";
            Console.WriteLine(margareta);
            Console.WriteLine(magyaros);

            Console.ReadKey();
        }
    }
}

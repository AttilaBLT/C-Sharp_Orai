using System;

namespace motorkerékpár
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor honda = new Motor();
            honda.Gyarto = "Honda";
            honda.Model = "CB600F Hornet";
            honda.Kobcenti = 599;

            Motor yamaha = new Motor("Yamaha", "FZ-6N", 600);

            Motor ktm = new Motor
            {
                Gyarto = "KTM",
                Model = "Duke",
                Kobcenti = 650
            };

            Console.WriteLine(honda);
            honda.Dudal();
            Console.WriteLine(yamaha);
            yamaha.Indul();

            Console.WriteLine(ktm);
            ktm.Fekez();

            Quad kawasaki = new Quad("Kawasaki", "Kfx", 450, false);
            Console.WriteLine(kawasaki);
            kawasaki.Dudal();
            kawasaki.Indul();
            kawasaki.Fekez();


            /*
             POLIMORFIZMUS
             */
            Gepjarmu negykereku = new Quad("Suzuki", "SV900", 900, true);
            Gepjarmu ketkereku = new Motor("Suzuki", "SV900", 900);

            Console.WriteLine(negykereku);

            /*
             * Interace példanyosítás
             */
            Ifekez keeway = new Motor();
            Ifekez hjusong = new Quad();

            Console.ReadKey();
        }
    }
}

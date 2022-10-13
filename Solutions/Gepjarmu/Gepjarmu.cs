using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu
{
    public class Gepjarmu
    {
        public string Gyarto { get; set; }
        public string Model { get; set; }
        public string Tipus { get; set; }
        public UzemanyagTipus Uzemanyag { get; set; }
        public string Rendszam { get; set; }
        public Tulajdonos Tulajdonos { get; set; } = new Tulajdonos();

        public Gepjarmu()
        {
        }

        public Gepjarmu(string gyarto, string model, string tipus, UzemanyagTipus uzemanyag, string rendszam, Tulajdonos tulajdonos)
        {
            Gyarto = gyarto;
            Model = model;
            Tipus = tipus;
            Uzemanyag = uzemanyag;
            Rendszam = rendszam;
            Tulajdonos = tulajdonos ?? new Tulajdonos(); //ha null érték jön akkor példányosít és alapértéket irat ki

            /*if (tulajdonos is null)
            {
                 Tulajdonos = new Tulajdonos(); 
            }*/

        }

        public override string ToString() => $"{Rendszam} : {Gyarto} {Model} {Tipus} ({Uzemanyag})\nTulajdonos: {Tulajdonos}";
    }
}

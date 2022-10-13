using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu
{
    public class Tulajdonos
    {
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public DateTime SzuletesiIdo { get; set; }
        public List<Gepjarmu> Gepjarmuvek { get; set; } = new List<Gepjarmu>();
        public Lakcim Haz { get; set; } = new Lakcim();

        public Tulajdonos()
        {
        }

        public Tulajdonos(string vezeteknev, string keresztnev, DateTime szuletesiido, Lakcim lakcim)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            SzuletesiIdo = szuletesiido;
            Haz = lakcim;
        }

        public void GepjarmuetVesz(Gepjarmu gepjarmu) => Gepjarmuvek.Add(gepjarmu);

        public override string ToString() => $"{Vezeteknev} {Keresztnev}, Született: {SzuletesiIdo:yyyy.MM.dd}";
    }
}

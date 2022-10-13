using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmu
{
    public class Lakcim
    {
        public string Iranyitoszam { get; set; }
        public string Telepules { get; set; }
        public string Utca { get; set; }
        public string Hazszam { get; set; }

        public Lakcim()
        {
        }

        public Lakcim(string iranyitoszam, string telepules, string utca, string hazszam)
        {
            Iranyitoszam = iranyitoszam;
            Telepules = telepules;
            Utca = utca;
            Hazszam = hazszam;
        }
    }
}

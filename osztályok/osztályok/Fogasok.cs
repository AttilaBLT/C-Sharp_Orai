using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztályok
{
    public class Fogasok
    {
        public string Horgasz { get; set; }
        public string Hal { get; set; }

        public Fogasok()
        {

        }
        public Fogasok(string horgasz, string hal)
        {
            Horgasz = horgasz;
            Hal = hal;
        }
        public override string ToString() => $"A horgász neve: {Horgasz}, a fogott hal: {Hal}";
    }
}

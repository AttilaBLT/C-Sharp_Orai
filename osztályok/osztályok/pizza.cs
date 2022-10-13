using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztályok
{
    class pizza
    {
        public string Pizza { get; set; }
        public string Rendelo { get; set; }

        public pizza()
        {
            Pizza = "Margaréta";
            Rendelo = "Gál Béla";
        }

        public pizza(string pizza, string rendelo)
        {
            Pizza = pizza;
            Rendelo = rendelo;
        }
        public override string ToString() => $"A pizza: {Pizza}, A rendelő: {Rendelo}";
    }
}

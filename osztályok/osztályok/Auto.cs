using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztályok
{
    public class Auto
    {
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int GyartasiEvKezdete { get; set; }
        public int GyartasiEvVege { get; set; }


        public Auto()
        {

        }
        public Auto(string marka, string tipus, int gyartasi_Ev_Kezdete, int gyartasi_Ev_Vege)
        {
            Marka = marka;
            Tipus = tipus;
            GyartasiEvKezdete = gyartasi_Ev_Kezdete;
            GyartasiEvVege = gyartasi_Ev_Vege;
        }
        public override string ToString() => $"A márkája: {Marka}, tipusa: {Tipus}, Gyártási évek: {GyartasiEvKezdete} - {GyartasiEvVege}";
    }
}

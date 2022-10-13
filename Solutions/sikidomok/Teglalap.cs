using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    public class Teglalap: Sikidom
    {
        public double AOldal { get;  set; }
        public double BOldal { get;  set; }

        public Teglalap(double aoldal, double boldal)
        {
            AOldal = aoldal;
            BOldal = boldal;
        }
        public override double Kerulet()
        {
            return (AOldal + BOldal) * 2;
        }

        public override double Terulet()
        {
            return AOldal * BOldal;
        }
    }
}

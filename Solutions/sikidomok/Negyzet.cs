using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    public class Negyzet: Sikidom
    {
        public double AOldal { get;  set; }
        
        public Negyzet(double aoldal)
        {
            AOldal = aoldal;
        }
        public override double Kerulet()
        {
            return 4 * AOldal;
        }

        public override double Terulet()
        {
            return AOldal*AOldal;
        }
    }
}

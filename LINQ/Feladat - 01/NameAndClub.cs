using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat___01
{
    public class NameAndClub
    {
        public string Name { get; set; }
        public string Club { get; set; }

        public NameAndClub()
        {
        }

        public NameAndClub(string name, string club)
        {
            Name = name;
            Club = club;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorkerékpár
{
    public class Quad: Gepjarmu, Ifekez
    {
        public bool Negykerekhajtas { get; set; }
        public Quad() : base()
        {
        }

        public override void Dudal()
        {
            Console.Beep(500, 800);
            Console.Beep(1500, 500);
        }

        public Quad(string gyarto, string model, int kobcenti, bool negykerekhajtas):base(gyarto, model, kobcenti)
        {
            Negykerekhajtas = negykerekhajtas;
        }

        public override void Indul() => Console.WriteLine("wrummmm Elindult");
        public override string ToString() => $"{base.ToString()}, Négykeréhajtás: {Negykerekhajtas}";

        public void Fekez()
        {
            Console.WriteLine("Fek Fek Fek!!!!");
        }
    }
}

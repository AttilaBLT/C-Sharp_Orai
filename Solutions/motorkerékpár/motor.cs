using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorkerékpár
{
    public class Motor: Gepjarmu, Ifekez
    { 
        #region konstruktorok
        public Motor()
        {

        }

        public Motor(string gyarto, string model, int kobcenti)
        {
            Gyarto = gyarto;
            Model = model;
            Kobcenti = kobcenti;
        } 
        public Motor(Motor motor)
        {
            Gyarto = motor.Gyarto;
            Model = motor.Model;
            Kobcenti = motor.Kobcenti;
        }
        #endregion

        #region fuggvenyek
        public override void Dudal() => Console.Beep(1000,500);
        #endregion

        #region interface implementation
        public void Fekez()
        {
            Console.WriteLine("FÉÉÉÉÉÉÉÉÉÉÉÉÉÉK!!!!!!");
        }
        #endregion
    }
}

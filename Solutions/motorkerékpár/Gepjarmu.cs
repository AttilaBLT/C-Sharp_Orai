namespace motorkerékpár
{
    public abstract class Gepjarmu
    {
        #region adattagok
        public string Gyarto { get; set; }
        public string Model { get; set; }
        public int Kobcenti { get; set; }
        #endregion

        #region konstruktor
        public Gepjarmu()
        {        
        }

        protected Gepjarmu(string gyarto, string model, int kobcenti)
        {
            Gyarto = gyarto;
            Model = model;
            Kobcenti = kobcenti;
        }
        #endregion

        #region fuggvenyek
        public abstract void Dudal();
        #endregion

        public virtual void Indul() => System.Console.WriteLine("Elindult");

        #region feluldefinialt fuggvenyek(override methods)
        public override string ToString() => $"{Gyarto} {Model} {Kobcenti} ccm3";
        #endregion
    }
}

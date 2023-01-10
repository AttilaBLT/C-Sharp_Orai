namespace Feladat_07
{
    public class BirthInformation
    {
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public BirthInformation()
        {

        }

        public BirthInformation(DateTime birthDate, string birthPlace, string region, string country)
        {
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            this.Region = region;
            this.Country = country;
        }

        public override string ToString() => $"{BirthDate:yyyy MMM dd} {BirthPlace} {Region} {Country}";
    }
}

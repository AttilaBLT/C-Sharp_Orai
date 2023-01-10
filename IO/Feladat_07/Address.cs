namespace Feladat_07
{
    public class Address
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public Address()
        {

        }

        public Address(string street, string houseNumber, string city, string region, string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            City = city;
            Region = region;
            Country = country;
        }

        public override string ToString() => $"{Street} {HouseNumber} {PostalCode} {City} {Region} {Country}";
    }
}

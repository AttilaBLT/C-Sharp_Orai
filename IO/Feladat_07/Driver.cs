namespace Feladat_07
{
    public class Driver
    {
        public NameInformation NameInformation { get; set; }
        public BirthInformation BirthInformation { get; set; }
        public Address Address { get; set; }
        public List<string> LicenseCategory { get; set; }

        public Driver()
        {

        }

        public Driver(NameInformation nameInformation, BirthInformation birthInformation, Address address, List<string> licenseCategory)
        {
            NameInformation = nameInformation;
            BirthInformation = birthInformation;
            Address = address;
            LicenseCategory = licenseCategory;
        }

        public override string ToString() => $"{NameInformation}\t{BirthInformation}\t{Address}\t{string.Join(", ", LicenseCategory)}";
    }
}

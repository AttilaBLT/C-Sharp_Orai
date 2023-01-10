namespace Feladat_07
{
    public class NameInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherLastName { get; set; }

        public NameInformation()
        {

        }

        public NameInformation(string firstName, string lastName, string motherFirstName, string motherLastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MotherFirstName = motherFirstName;
            MotherLastName = motherLastName;
        }

        public override string ToString() => $"{FirstName} {LastName}, {MotherFirstName} {MotherLastName}";
    }
}

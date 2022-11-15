namespace Feladat_05;
    public class Book
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Releaser { get; set; }
        public string ReleaseDate { get; set; }
        public int Price { get; set; }
        public string Theme { get; set; }
        public int PageNumber { get; set; }
        public int Honor { get; set; }

    public Book()
    {

    }

    public Book(string firstName, string lastName, string birthDate, string title, string iSBN, string releaser, string releaseDate, int price, string theme, int pageNumber, int honor)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Title = title;
        ISBN = iSBN;
        Releaser = releaser;
        ReleaseDate = releaseDate;
        Price = price;
        Theme = theme;
        PageNumber = pageNumber;
        Honor = honor;
    }
}


List<Book> books = LoadData("./../../../_feladat_/adatok.txt");

PrintToScreen(books);

Console.ReadKey();


List<Book> LoadData(string filePath)
{
    List<Book> bookData = new List<Book>();
    Book book = null;
    string[] data = null;

    foreach (string line in File.ReadLines(filePath, Encoding.UTF7))
    {
        data = line.Split('\t');
        book = new Book()
        {
            FirstName = data[0],
            LastName = data[1],
            BirthDate = data[2],
            Title = data[3],
            ISBN = data[4],
            Releaser = data[5],
            ReleaseDate = data[6],
            Price = int.Parse(data[7]),
            Theme = data[8],
            PageNumber = int.Parse(data[9]),
            Honor = int.Parse(data[10])
        };
        bookData.Add(book);
    }
    return bookData;
}

void PrintToScreen(ICollection<Book> booksdata)
{
    foreach (Book book in booksdata)
    {
        Console.WriteLine(book);
    }
}
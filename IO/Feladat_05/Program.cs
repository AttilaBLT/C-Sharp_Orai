﻿List<Book> books = LoadData("./../../../_feladat_/adatok.txt");


//1. - Írjuk ki a képernyőre az össz adatot

PrintToScreen(books);

//2.- Keressük ki az informatika témajú könyveket és mentsük el őket az informatika.txt állömányba

List<Book> itBooks = books.Where(x => x.Theme.ToLower() == "informatika")
                          .ToList();
ITThematicBooks(itBooks);

//3.- Az 1900.txt állományba mentsük el azokat a könyveket amelyek az 1900-as években íródtak

List<Book> _1900books = books.Where(x => x.ReleaseDate >= 1900 && x.ReleaseDate <= 1999).ToList();
Booksin1900s(_1900books);

//4.- Rendezzük az adatokat a könyvek oldalainak száma szerint csökkenő sorrendbe
//és a sorbarakott.txt állományba mentsük el.

List<Book> orderByPageNumber = books.OrderByDescending(x => x.PageNumber).ToList();
OrderByPageNumber(orderByPageNumber);

//5.- „kategoriak.txt” állományba mentse el a könyveket téma szerint.

List<string> themes = books.Select(x => x.Theme).Distinct().ToList();
OrderByTheme(themes, books);

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
            ReleaseDate = int.Parse(data[6]),
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

void ITThematicBooks(ICollection<Book> books)
{
    string fileName = "./../../../_feladat_/informatika.txt";
    using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (Book line in books)
        {
            sw.WriteLine(line.ToString());
        }
    }
}
void Booksin1900s(ICollection<Book> Booksin1900s)
{
    string filename = "./../../../_feladat_/1900.txt";
    using (FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (Book line in Booksin1900s)
        {
            sw.WriteLine(line.ToString());
        }
    }
}
void OrderByPageNumber(ICollection<Book> listorder)
{
    string fileName = "./../../../_feladat_/sorbarakott.txt";
    using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (Book line in listorder)
        {
            sw.WriteLine(line.ToString());
        }
    }
}
void OrderByTheme(ICollection<string> themes, ICollection<Book> books)
{
    string fileName = "./../../../_feladat_/kategoriak.txt";
    using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.None))
    {
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
        foreach (string theme in themes)
        {
            sw.WriteLine($"\t{theme}:");
            foreach (Book book in books)
            {
                if (book.Theme == theme)
                {
                    sw.WriteLine(book.ToString());
                }
            }
        }
    }
}
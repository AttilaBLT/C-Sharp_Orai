List<Book> books = LoadData("./../../../_feladat_/adatok.txt");

Console.ReadKey();


List<Book> LoadData(string filePath)
{
    List<Book> bookData = new List<Book>();
    Book book = null;
    string[] data = null;

    foreach (string line in File.ReadLines(filePath, Encoding.UTF8))
    {

    }
}
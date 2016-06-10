using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }

    public static Book ReadBook()
    {
        var tokens = Console.ReadLine().Split(' ').ToList();
        decimal price = Decimal.Parse(tokens[5]);
        DateTime date = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Book book = new Book() { Title = tokens[0], Author = tokens[1], Publisher = tokens[2], ReleaseDate = date, ISBN = tokens[4], Price = price };
        return book;
    }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }


}


class BookLibraryModification
{
    static void Main(string[] args)
    {
        int numberOfBooks = Int32.Parse(Console.ReadLine());
        Library lib = new Library();
        lib.Books = new List<Book>();
        lib.Name = "OMFG";

        for (int i = 0; i < numberOfBooks; i++)
        {
            Book currentBook = Book.ReadBook();
            lib.Books.Add(currentBook);
        }

        DateTime keyDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Dictionary<string, DateTime> libDict = new Dictionary<string, DateTime>();
        foreach (var book in lib.Books)
        {
            if (book.ReleaseDate > keyDate)
            {
                libDict.Add(book.Title, book.ReleaseDate);
            }
        }

        var toPrint = libDict.OrderBy(r => r.Value).ThenBy(r => r.Key);

        foreach (var pair in toPrint)
        {
            Console.WriteLine("{0} -> {1:dd.MM.yyyy}", pair.Key, pair.Value);
        }

    }
}
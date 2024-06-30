namespace _6_28_24;

public class Library:Base
{
    public Book[] books = {};
    private static int id;
    public Library(string name):base(name)
    {
        Name = name;
        Id=++id;
    }
    public void AddBook(Book book)
    {
        Array.Resize(ref books,books.Length+1);
        books[books.Length-1] = book;
    }
    public void ListAllBooks()
    {
        if (books.Length > 0)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        else
        Console.WriteLine( "Kitab yoxdur");
    }
}

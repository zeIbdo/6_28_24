namespace _6_28_24;

public class Book:Base
{
    private static int id;
    public string Author { get; set; }
    public Category category { get; set; }
    public Book(string name,string author,Category categori):base(name)
    {
        Id = ++id;
        Author = author;
        category = categori;

    }
}

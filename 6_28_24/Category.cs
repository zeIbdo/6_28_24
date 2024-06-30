namespace _6_28_24;

public class Category:Base
{
    private static int id;
    public Category(string name):base(name) 
    {
        Id=++id;
    }
}

namespace _6_28_24;

public abstract class Base
{
    public int Id { get; protected set; }
    public string Name { get; protected set; }
    public Base(string name)
    {
         Name = name;
    }
    public override string ToString()
    {
        return $"{Id} {Name} ";
    }
}

namespace _6_28_24.Exceptions;

public class BookAlreadyExists:Exception
{
    public BookAlreadyExists(string message) : base(message) { }

}
public class BookNotFoundException : Exception
{
    public BookNotFoundException(string message) : base(message) { }
}

public class CategoryNotFoundException : Exception
{
    public CategoryNotFoundException(string message) : base(message) { }
}

public class LibraryNotFoundException : Exception
{
    public LibraryNotFoundException(string message) : base(message) { }
}

public class WrongInputException : Exception
{
    public WrongInputException(string message) : base(message) { }
}
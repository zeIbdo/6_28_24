namespace _6_28_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library[] libraries = new Library[0];
            Book[] books = new Book[0];
            Category[] categories = new Category[0];
            Restart:
            Console.WriteLine("[1]Yeni kitabxana yarat\n" +
                "[2] yeni kateqoriya yarat\n" +
                "[3]yeni kitab yarat\n" +
                "[4]kitabxanaya daxil ol\n" +
                "[0]cix");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Kitabxananin adini daxil et");
                    string libraryName = Console.ReadLine();
                    Library library = new(libraryName);
                    Array.Resize(ref libraries,libraries.Length+1);
                    libraries[libraries.Length-1] = library;
                    Console.WriteLine($"{libraryName} yaradildi");
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    goto Restart;                    
                case "2":
                    Console.WriteLine("Kateqoriyanin adini daxil et");
                    string categoryName = Console.ReadLine();
                    Category category = new(categoryName);
                    Array.Resize(ref categories, categories.Length + 1);
                    categories[^1] = category;
                    Console.WriteLine($"{categoryName} yaradildi");
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    goto Restart;
                    case"3":
                    Console.WriteLine("Yeni kitab yarad");
                    Console.WriteLine("kitabin adini daxil et");
                    string bookName = Console.ReadLine();
                    Console.WriteLine("yazarin adini daxil et");
                    string author = Console.ReadLine();
                    Console.WriteLine("kateqoriya sec");
                    if (categories.Length > 0)
                    {
                        foreach (var item in categories)
                        {
                            Console.WriteLine(item);
                        }
                    Category:
                        Console.WriteLine("Id daxil edin");
                        int id = int.Parse(Console.ReadLine());
                        bool notFound=true;
                        foreach (var item in categories)
                        {
                            if (item.Id == id)
                            {
                                Book book = new(bookName, author, item);
                                Array.Resize(ref books, books.Length + 1);
                                books[books.Length - 1] = book;
                                Console.WriteLine($"{bookName} yaradildi");
                                notFound = false;
                                goto Restart;
                            }                            
                        }
                        if (notFound == true)
                        {
                            Console.WriteLine("kateqoriya tapilmadi");
                            goto Category;
                        }
                    }
                    else
                    {
                        Console.WriteLine("kateqoriya yoxdur, kitab yaradmadan evvel elave edin");
                        goto Restart;
                    }
                    goto Restart;
                    case"4":
                    Console.WriteLine("Kitabxana sec");
                    if(libraries.Length > 0)
                    {
                        foreach(var item in libraries)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.WriteLine("id daxil et");
                        int id = int.Parse(Console.ReadLine()) ;
                        foreach(var item in libraries)
                        {
                            if (item.Id == id)
                            {
                                Library:
                                Console.WriteLine("[1]Kitab elave et\n" +
                                    "[2]kitablari goster\n"+
                                    "[0]kitabxanadan cix\n");
                                string inputLib = Console.ReadLine();
                                switch (inputLib)
                                {
                                    default:
                                        Console.WriteLine("duzgun input daxil et");
                                        goto Library;
                                    case "1":
                                        Console.WriteLine("Kitablar");
                                        foreach(var book in books)
                                        {
                                            Console.WriteLine(book.ToString());
                                        }
                                        Console.WriteLine("id daxil edin");
                                        int idBook = int.Parse(Console.ReadLine()) ;
                                        foreach (var kitab in item.books) 
                                        {
                                            if (idBook == kitab.Id)
                                            {
                                                Console.WriteLine("kitabxanada kitab artiq var");
                                                goto Library;
                                            }
                                            else
                                            {
                                                foreach (var book in books)
                                                {
                                                    if (book.Id == idBook)
                                                    {
                                                        item.AddBook(book);
                                                        Console.WriteLine($"elave olundu");
                                                        goto Library;
                                                    }

                                                    else
                                                    {
                                                        Console.WriteLine("Id tapilmadi");
                                                        goto Library;
                                                    }

                                                }
                                            }
                                        }
                                        goto Library;
                                        case "2":
                                        item.ListAllBooks();
                                        goto Library;
                                        
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kitabxana yoxdur, yarad ");
                        goto Restart;
                    }
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Duzgun input daxil et");
                    goto Restart;
            }
        }
    }
}

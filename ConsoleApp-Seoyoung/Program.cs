// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using ConsoleApp_Seoyoung;

public class Program
{

    public static void Main(string[] args)
    {
        Book book1 = new Book(1,"123-456789","Harry Potter","J.K.Rowling",19.99);
        Book book2 = new Book(2,"987-654321","Project Hailmary","Andy Weir",13.99);
        
        Console.WriteLine(book1.Title);
        Console.WriteLine(book2.Title);
        Console.WriteLine(book1.Author);
        Console.WriteLine(book2.Author);
        Console.WriteLine(book1.Price);
        Console.WriteLine(book2.Price);

    }
}

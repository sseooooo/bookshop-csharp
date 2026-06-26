// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using ConsoleApp_Seoyoung;

public class Program
{

    public static void Main(string[] args)
    {
        Book book1 = new Book(1,"123-456789","Harry Potter","J.K.Rowling",19.99, Genre.Fiction);
        Book book2 = new Book(2,"987-654321","Project Hailmary","Andy Weir",13.99,Genre.Fiction);
        Book book3 = new Book(3, "112-23344", "Sherlock Holmes","Arthur Conan Doyle",20.99,Genre.Crime);
        
        Console.WriteLine(book1.Title);
        Console.WriteLine(book2.Title);
        Console.WriteLine(book3.Title);
        Console.WriteLine(book1.Author);
        Console.WriteLine(book2.Author);
        Console.WriteLine(book3.Author);
        Console.WriteLine(book1.Price);
        Console.WriteLine(book2.Price);
        Console.WriteLine(book3.Price);
        Console.WriteLine(book1.Genre);
        Console.WriteLine(book2.Genre);
        Console.WriteLine(book3.Genre);
        

    }
}

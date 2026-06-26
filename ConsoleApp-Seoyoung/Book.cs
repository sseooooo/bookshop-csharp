namespace ConsoleApp_Seoyoung;

public class Book
{
    private int Id{get;set;}
    public string Isbn {get;set;}
    public string Title{get;set;}
    public string Author{get;set;}
    public double Price{get;set;}
    

    public Book(int id, string isbn, string title,string author,double price)
    {
        this.Id = id;
        this.Isbn = isbn;
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

}
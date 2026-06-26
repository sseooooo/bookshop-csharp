namespace ConsoleApp_Seoyoung;

public class Book
{
    //private int Id{get;set;} 
    public int Id { get; private set; }
    public string Isbn {get; private set;} 
    public string Title{get;set;} 
    public string Author{get;set;} 
    public double Price{get;set;}
    public Genre Genre{get;set;}
            

    public Book(int id, string isbn, string title, string author, double price,Genre genre)
    {
        this.Id = id; 
        this.Isbn = isbn; 
        this.Title = title; 
        this.Author = author; 
        this.Price = price;
        this.Genre = genre;
        
    } 
}
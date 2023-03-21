using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Library
{
    public List<User> users = new List<User>();
    private List<Document> documents = new List<Document>();

    public void SetUser(string name, string surname, string email, string password, int number)
    {
        users.Add(new User(name, surname, email, password, number));

        Console.WriteLine($"-------------------------------------" +
            $"{Environment.NewLine}you have registered successfully{Environment.NewLine}" +
            $"-------------------------------------");
    }

    public void SetBook(string title, int year, string sector, string shelf, string[] author, int pages)
    {
        documents.Add(new Book(title, year, sector, shelf, author, pages));

        Console.WriteLine($"-------------------------------------" +
            $"{Environment.NewLine}new book added to library{Environment.NewLine}" +
            $"-------------------------------------");

    }

    public void SetDvd(string title, int year, string sector, string shelf, string[] author, int seconds)
    {
        documents.Add(new Dvd(title, year, sector, shelf, author, seconds));

        Console.WriteLine($"-------------------------------------" +
            $"{Environment.NewLine}new DVD added to library{Environment.NewLine}" +
            $"-------------------------------------");

    }

}

public class Document
{
    private string code;
    private string title;
    private int year;
    private string sector;
    private string shelf;
    private string[] author = new string[2];

    //constructor
    public Document(string title, int year, string sector, string shelf, string[] author)
    {
        Random rnd = new Random();
        code = rnd.Next().ToString();
        this.title = title;
        this.year = year;
        this.sector = sector;
        this.shelf = shelf;
        this.author = author;
    }
}

public class Book : Document
{
    private readonly int pages;

    //constructor
    public Book(string title, int year, string sector, string shelf, string[] author, int pages) : base(title, year, sector, shelf, author)
    {
        this.pages = pages;
    }


}

public class Dvd : Document
{
    private readonly int seconds;

    public Dvd(string title, int year, string sector, string shelf, string[] author, int seconds) : base(title, year, sector, shelf, author)
    {
        this.seconds = seconds;
    }
}
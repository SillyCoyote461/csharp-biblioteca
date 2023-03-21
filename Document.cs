using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
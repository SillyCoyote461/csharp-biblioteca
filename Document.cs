using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Document
{
    protected string code;
    protected string title;
    protected int year;
    protected string sector;
    protected string shelf;
    protected string[] author = new string[2];

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

    public override string ToString()
    {
        return $"//////////////////{Environment.NewLine}" +
            $"Title: {title} {Environment.NewLine}" +
            $"Genre: {sector} {Environment.NewLine}" +
            $"Release year: {year} {Environment.NewLine}" +
            $"Pages: {pages} {Environment.NewLine}" +
            $"Author: {author[0]} {author[1]} {Environment.NewLine}" +
            $"Shelf: {shelf}{Environment.NewLine}" +
            $"ID: {code}{Environment.NewLine}" +
            $"//////////////////";
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
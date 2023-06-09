﻿using System;
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
    public string Title
    {
        get { return title; }
    }
    public string Code
    {
        get { return code; }
    }

    public string SecondsToMinutes(int seconds)
    {
        int minutes = 0;
        int hours = 0;
        do
        {
            minutes += seconds / 60;
            hours += minutes / 60;
            seconds = seconds % 60;

        } while (seconds >= 60);
        if(hours == 0) return $" {hours}:{minutes}:{seconds} ";
        else return $" {minutes}:{seconds} ";
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

    public override string ToString()
    {
        return $"//////////////////{Environment.NewLine}" +
            $"Title: {title} {Environment.NewLine}" +
            $"Genre: {sector} {Environment.NewLine}" +
            $"Release year: {year} {Environment.NewLine}" +
            $"seconds: {SecondsToMinutes(seconds)} {Environment.NewLine}" +
            $"Author: {author[0]} {author[1]} {Environment.NewLine}" +
            $"Shelf: {shelf}{Environment.NewLine}" +
            $"ID: {code}{Environment.NewLine}" +
            $"//////////////////";
    }

}


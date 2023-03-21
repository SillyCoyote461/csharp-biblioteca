using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class User
{
    public string name;
    public string surname;
    public string email;
    public string password;
    public int number;

    //constructor
    public User(string name, string surname, string email, string password, int number)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.number = number;
    }
    public string Password
    {
        get { return password; }
    }

    public string Email
    {
        get { return email; }
    }

    public string Name
    {
        get { return name; }
    }

    public string Surname
    {
        get { return surname; }
    }

    public int Number
    {
        get { return number;}
    }


}

public class Loan : User
{
    public string code;
    public string title;
    public string start;
    public string end;
    public Loan(string code, string title, string start, string end ,string name, string surname, string email, string password, int number) : base(name, surname, email, password, number)
    {
        this.code = code;
        this.title = title;
        this.start = start;
        this.end = end;
    }

    public override string ToString()
    {
        return $"--------------------{Environment.NewLine}" +
            $"Title: {title}{Environment.NewLine}" +
            $"Document ID: {code}{Environment.NewLine}" +
            $"Loan made on: {start}{Environment.NewLine}" +
            $"Loan ends in: {end}{Environment.NewLine}";
    }
}

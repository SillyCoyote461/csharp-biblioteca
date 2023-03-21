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
}


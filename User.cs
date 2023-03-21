using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class User
{
    private string name;
    private string surname;
    private string email;
    private string password;
    private int number;

    //constructor
    public User(string name, string surname, string email, string password, int number)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.number = number;
    }

}


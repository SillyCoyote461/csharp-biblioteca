using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Library
{
    public List<User> users = new List<User>();
    public List<Document> documents = new List<Document>();
    public List<Loan> loans = new List<Loan>();

    //set user
    public bool SetUser(string name, string surname, string email, string password, int number)
    {
        //check already used email
        bool match = false;
        foreach (User user in users)
        {
            if (user.email == email && user.password == password)
            {
                match = true;
            }
        }
        //if is used:
        if (match)
        {
            Console.WriteLine($"-------------------------------------" +
                $"{Environment.NewLine}This email is already used{Environment.NewLine}" +
                $"-------------------------------------");
            return false;
        }
        //if not:
        else
        {
            users.Add(new User(name, surname, email, password, number));

            Console.WriteLine($"-------------------------------------" +
                $"{Environment.NewLine}you have registered successfully{Environment.NewLine}" +
                $"-------------------------------------");
            return true;
        }
    }
    
    //set books
    public void SetBook(string title, int year, string sector, string shelf, string[] author, int pages)
    {
        documents.Add(new Book(title, year, sector, shelf, author, pages));

        Console.WriteLine($"-------------------------------------" +
            $"{Environment.NewLine}new book added to library{Environment.NewLine}" +
            $"-------------------------------------");

    }

    //set dvd
    public void SetDvd(string title, int year, string sector, string shelf, string[] author, int seconds)
    {
        documents.Add(new Dvd(title, year, sector, shelf, author, seconds));

        Console.WriteLine($"-------------------------------------" +
            $"{Environment.NewLine}new DVD added to library{Environment.NewLine}" +
            $"-------------------------------------");

    }

    //get document's list
    public void GetDocuments()
    {
        if(documents.Count is 0)
        {
            Console.WriteLine($"The library is empty{Environment.NewLine}-------------------------------------");
        }
        else
        {
            foreach (Document item in documents)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-------------------------------------");
        }
    }

    //search document
    public void SearchDocument(string title)
    {
        List<string> filtered = new List<string>();

        for(int i = 0; i < documents.Count; i++)
        {
            if (documents[i].Title == title)
            {
                filtered.Add(documents[i].Code);
                Console.WriteLine($"------------------------------------- {Environment.NewLine}" +
                    $"{ documents[i].ToString()}" +
                    $"{Environment.NewLine}-------------------------------------");
            }
        }

        
    }

    //login method
    public bool Authenticate(string email, string password)
    {
        //check email and password then return
        bool match = false;
        foreach(User user in users)
        {
            if(user.email == email && user.password == password)
            {
                match = true;
            } 
        }
        return match;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Library
{
    public List<User> users = new List<User>();
    private List<Document> documents = new List<Document>();

    //set user
    public void SetUser(string name, string surname, string email, string password, int number)
    {
        users.Add(new User(name, surname, email, password, number));

        Console.WriteLine($"-------------------------------------" +
            $"{Environment.NewLine}you have registered successfully{Environment.NewLine}" +
            $"-------------------------------------");
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

        }
    }
}

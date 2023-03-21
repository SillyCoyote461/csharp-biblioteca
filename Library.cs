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

        for(int i = 0; i < documents.Count; i++)
        {
            if (documents[i].Title == title)
            {
                Console.WriteLine($"------------------------------------- {Environment.NewLine}" +
                    $"{ documents[i].ToString()}" +
                    $"{Environment.NewLine}-------------------------------------");
            }
        }
    }

    public void LoanDocument(string code, User user)
    {
        Document filtered = null;
        for (int i = 0; i < documents.Count; i++)
        {
            if (documents[i].Code == code)
            {
                filtered = documents[i];
                Console.Write("Insert starting loan date");
                string start = Console.ReadLine() ?? "";
                Console.WriteLine("Insert ending loan date");
                string end = Console.ReadLine() ?? "";
                LoanAfter(user, filtered, start, end);
            }
        }
        if (filtered is null) Console.WriteLine("Document not found");
    }

    public void LoanAfter(User user, Document doc, string start, string end)
    {
        loans.Add(new Loan(doc.Code, doc.Title, start, end, user.Name, user.Surname, user.Email, user.Password, user.Number));
    }

    public void CheckLoans(User user)
    {
        
        if (documents.Count is 0)
        {
            Console.WriteLine($"You have no loans{Environment.NewLine}-------------------------------------");
        }
        else
        {
            Console.WriteLine("Your loans: ");
            foreach (Loan item in loans)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-------------------------------------");
        }


    }

    //login method
    public User Authenticate(string email, string password)
    {
        //check email and password then return
        
        foreach(User user in users)
        {
            if(user.email == email && user.password == password)
            {
                
                return user;
            } 
        }
        return null;
    }
}

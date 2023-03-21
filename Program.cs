var nl = Environment.NewLine;
var library = new Library();

bool login = false;
User user = null;
while (true)
{

    Console.WriteLine($"Type the command you want to use:{nl}{nl}" +
        $"register: allows you to register to the library{nl}" +
        $"login: allows you to log in{nl}" +
        $"logout: allows you to log out {nl}" +
        $"list: allows you to see the document's list{nl}" +
        $"search: allows you to search by title {nl}" +
        $"loan: allows you to loan a document{nl}" +
        $"check: list of your loans{nl}" +
        $"add: allows you to add a new document{nl}{nl}");
    Console.Write("Type a command: ");
    string cmd = Console.ReadLine() ?? "";
    Console.WriteLine("-------------------------------------");

    switch (cmd)
    {
        //register case
        case "register":
            if (login)
            {
                Console.WriteLine($"you can't register a new user while logged in{nl}" +
                    $"-------------------------------------");
            }
            else
            {
                //get data
                Console.Write($"Type your...{nl}name: ");
                string name = Console.ReadLine() ?? "";
                Console.Write($"surname: ");
                string surname = Console.ReadLine() ?? "";
                Console.Write($"email: ");
                string email = Console.ReadLine() ?? "";
                Console.Write($"password: ");
                string password = Console.ReadLine() ?? "";
                Console.Write($"telephone number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                //register user

                login = library.SetUser(name, surname, email, password, number);
                 
            }
            break;

        case "login":
            if (login)
            {
                Console.WriteLine($"-------------------------------------{nl}" +
                $"You're already logged in {nl}" +
                $"-------------------------------------");
            }
            else
            {
                Console.Write($"email: ");
                string email = Console.ReadLine() ?? "";
                Console.Write($"password: ");
                string password = Console.ReadLine() ?? "";
                user = library.Authenticate(email, password);

                if (user != null) login = true; 
                else login = false;
              
                if (login)
                {
                    Console.WriteLine($"-------------------------------------{nl}" +
                        $"You have logged in successfully{nl}" +
                        $"-------------------------------------");
                }
                else
                {
                    Console.WriteLine($"-------------------------------------{nl}" +
                        $"User not registered or credentials wrong{nl}" +
                        $"-------------------------------------");
                }
            }
            break;

        case "logout":
            if (login)
            {
                login = false;
                user = null;
                Console.WriteLine($"-------------------------------------{nl}" +
                $"you have successfully logged out {nl}" +
                $"-------------------------------------");
            }
            else
            {
                Console.WriteLine($"-------------------------------------{nl}" +
                    $"you can't log out if you are not even logged in. {nl}" +
                    $"-------------------------------------");
            }
            break;


        //new document
        case "add":
            if (login)
            {        
                //type selector
                Console.WriteLine("What type of document do you want to add? book|dvd");
                string type = Console.ReadLine() ?? "";

                if (type is "book")
                {
                    Console.Write($"Type book's informations...{nl}title: ");
                    string title = Console.ReadLine() ?? "";
                    Console.Write($"release year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"book genre: ");
                    string sector = Console.ReadLine() ?? "";
                    Console.Write($"shelf: ");
                    string shelf = Console.ReadLine() ?? "";
                    Console.Write($"author's name: ");
                    string[] author = new string[2];
                    author[0] = Console.ReadLine() ?? "";
                    Console.Write($"author's surname: ");
                    author[1] = Console.ReadLine() ?? "";
                    Console.Write($"book's pages: ");
                    int pages = Convert.ToInt32(Console.ReadLine());

                    library.SetBook(title, year, sector, shelf, author, pages);
                }
                else if (type is "dvd")
                {
                    Console.Write($"Type DVD's informations...{nl}title: ");
                    string title = Console.ReadLine() ?? "";
                    Console.Write($"release year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"DVD genre: ");
                    string sector = Console.ReadLine() ?? "";
                    Console.Write($"shelf: ");
                    string shelf = Console.ReadLine() ?? "";
                    Console.Write($"author's name: ");
                    string[] author = new string[2];
                    author[0] = Console.ReadLine() ?? "";
                    Console.Write($"author's surname: ");
                    author[1] = Console.ReadLine() ?? "";
                    Console.Write($"DVD's time(expressed in seconds): ");
                    int seconds = Convert.ToInt32(Console.ReadLine());

                    library.SetBook(title, year, sector, shelf, author, seconds);
                }
                else
                {
                    Console.WriteLine($"-------------------------------------" +
                        $"{nl}there is no '{type}' type of document avaiable{nl}" +
                        $"-------------------------------------");

                }
            }
            else
            {
                Console.WriteLine("You must me logged in to add a new document in the library");
            }
            break;

        case "loan":
            if (login)
            {
                Console.Write("Digit document code: ");
                var code = Console.ReadLine();
                library.LoanDocument(code, user);
            }
            else
            {
                Console.WriteLine("You must be logged in");
            }
            break;

        case "check":
            if (login)
            {
                library.CheckLoans(user);
            }
            else
            {
                Console.WriteLine("You must be logged in");
            }
            break;

        case "list":
            library.GetDocuments();
            break;

        case "search":
            Console.Write("Type the book's title to search: ");
            string filter = Console.ReadLine() ?? "";
            library.SearchDocument(filter);
            break;

        //default case
        default:
            Console.WriteLine($"{nl}there is no '{cmd}' command avaiable{nl}");
            break;
    }
}
var nl = Environment.NewLine;
var library = new Library();
while (true)
{
    Console.WriteLine($"Type the command you want to use:{nl}{nl}" +
        $"register: allows you to register to the library{nl}" +
        $"list: allows you to see the document's list{nl}" +
        $"add: allows you to add a new document{nl}{nl}");
    Console.Write("Type a command: ");
    string cmd = Console.ReadLine() ?? "";
    Console.WriteLine("-------------------------------------");

    switch (cmd)
    {
        //register case
        case "register":
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
            library.SetUser(name, surname, email, password, number);
            break;

        //new document
        case "add":
            //type selector
            Console.WriteLine("What type of document do you want to add? book|dvd");
            string type = Console.ReadLine() ?? "";

            if(type is "book")
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
            else if(type is "dvd")
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

            break;

        case "list":
            library.GetDocuments();
            break;
        //default case
        default:
            Console.WriteLine($"{nl}there is no '{cmd}' command avaiable{nl}");
            break;
    }
}
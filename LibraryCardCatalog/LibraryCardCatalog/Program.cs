using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the existing file name (or create a new one) ");
            string fileName = Console.ReadLine();
            CardCatalog c = new CardCatalog(fileName);
            Console.Clear();
            int option = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. List All books");
                Console.WriteLine("2. Add a book ");
                Console.WriteLine("3. Save and Exit");
                string inputChoice = Console.ReadLine();
                int.TryParse(inputChoice, out option);
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        foreach (var book in c.ListBooks())
                        {
                            Console.WriteLine("{ 0} by {1}", book.Title, book.Author, book.Subject);
                        }
                        Console.WriteLine("Press to go back!");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter a book title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the subject of the book");
                        string subject = Console.ReadLine();
                        Console.WriteLine("Enter the author");
                        string author = Console.ReadLine();
                        c.AddBook(new Book { Author = author, Title = title, Subject = subject });
                        break;
                    case 3:
                        Console.Clear();
                        c.Save();
                        break;
                }
            } while (option != 3);
        }
    }
}

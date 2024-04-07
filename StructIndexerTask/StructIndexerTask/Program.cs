using Core;
using Core.Models;

namespace StructIndexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string choice;
            string name;
            string authorName;
            int pageCount;
            Library library = new Library();
            do
            {
                Console.WriteLine("1.Kitab elave et");
                Console.WriteLine("2.Axtarmag istediyiniz kitabin adini daxil et");
                Console.WriteLine("3.Silmek istediyiniz kitabin adini daxil et");
                Console.WriteLine("4.Kitabin adini, muellifini, sehife sayini yazaraq axtaris et");
                Console.WriteLine("0.Programdan cix");

                Console.Write("Secim edin: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Kitabin adini daxil edin: ");
                        name = Console.ReadLine();

                        Console.Write("Kitabin muellifinin adini daxil edin: ");
                        authorName = Console.ReadLine();

                        do
                        {
                            Console.Write("Kitabin sehifesini daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out pageCount));

                        Book book = new Book(name, authorName, pageCount);

                        library.AddBook(book);
                        break;
                    case "2":
                        Console.Write("Axtarmag istediyiniz kitabin adini daxil edin: ");
                        name = Console.ReadLine();

                        foreach (Book item in library.FindAllBooksByName(name))
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        Console.Write("Silmek istediyiniz kitabin adini daxil edin: ");
                        name = Console.ReadLine();

                        foreach (Book item in library.RemoveAllBookByName(name))
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "4":
                        Console.Write("Axtaris etmek istediyiniz kitabin adini daxil edin: ");
                        name = Console.ReadLine();

                        Console.Write("Axtaris etmek istediyiniz kitabin muellifinin adini daxil edin: ");
                        authorName = Console.ReadLine();

                        do
                        {
                            Console.Write("Axtaris etme istediyiniz kitabin sehife sayini daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out pageCount));

                        foreach (Book item in library.SearchBooks(name, authorName, pageCount))
                        {
                            Console.WriteLine(item);
                        }

                        break;
                }
            }
            while (choice != "0");

        }
    }
}
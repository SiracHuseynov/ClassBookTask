using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Library
    {
        Book[] Books = new Book[] { };

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] FindAllBooksByName(string name)
        {
            Book[] newBooks = new Book[] { };
            bool f = false;

            if(Books.Length > 0)
            {
                foreach (Book book in Books)
                {
                    if (book.Name == name)
                    {
                        f = true;
                        Array.Resize(ref newBooks, newBooks.Length + 1);
                        newBooks[newBooks.Length - 1] = book;
                    }
                }
                if(f == false)
                {
                    Console.WriteLine($"{name} adli kitab yoxdur!");
                }
            }
            else
            {
                Console.WriteLine("Kitab yoxdur!");
            }

            return newBooks;
        }

        public Book[] RemoveAllBookByName(string name)
        {
            Book[] newBooks = new Book[] { };

            if(Books.Length > 0)
            {
                foreach (Book book in Books)
                {
                    if (book.Name != name)
                    {
                        Array.Resize(ref newBooks, newBooks.Length + 1);
                        newBooks[newBooks.Length - 1] = book;
                    }
                }
            }
            else
            {
                Console.WriteLine("Kitab yoxdur!");
            }

            Books = newBooks;

            return Books;
        }

        public Book[] SearchBooks(string name, string authorName, int pageCount)
        {
            Book[] newBooks = new Book[] { };
            bool f = false;

            if(Books.Length > 0)
            {
                foreach (Book book in Books)
                {
                    if (book.Name == name || book.AuthorName == authorName || book.PageCount == pageCount)
                    {
                        f = true;
                        Array.Resize(ref newBooks, newBooks.Length + 1);
                        newBooks[newBooks.Length - 1] = book;
                    }
                }
                if(f == false)
                {
                    Console.WriteLine($"Adi {name} veya muellifi {authorName} veya kitab sehife sayi {pageCount} olan kitab tapilmadi!");
                }
            }
            else
            {
                Console.WriteLine("Kitab yoxdur!");
            }

            return newBooks;
        }


    }
}

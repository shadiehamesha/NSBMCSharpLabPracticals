using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        class LibraryBook
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public bool Available { get; private set; }

            public LibraryBook(string title, string author, bool available = true)
            {
                Title = title;
                Author = author;
                Available = available;
            }

            public void BorrowBook()
            {
                if (Available)
                {
                    Available = false;
                    Console.WriteLine("Book borrowed.");
                }
                else
                {
                    Console.WriteLine("Book is not available.");
                }
            }
        }

        static void Main(string[] args)
        {
            LibraryBook book10 = new LibraryBook("A Study in Scarlet", "Arthur Conan Doyle");
            LibraryBook book20 = new LibraryBook("The Sign of the Four", "Arthur Conan Doyle");
            LibraryBook book30 = new LibraryBook("The Hound of the Baskervilles", "Arthur Conan Doyle");

            book10.BorrowBook();
            book20.BorrowBook();
            book30.BorrowBook();

            Console.ReadLine();
        }
    }
}
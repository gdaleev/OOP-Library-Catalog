using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryCatalog.Classes
{
    public class ManageBooks
    {
        List<Book> books = new List<Book>
        {
            new Book{ Title = "IT", ISBN = "111111", isAvailable = true },
            new Book{ Title = "Bibliqta", ISBN = "222222", isAvailable = true },
            new Book{ Title = "Voina i mir", ISBN = "333333", isAvailable = false,
                DateToReturn = new DateTime(2020,05,06,00,00,00)},
            new Book{ Title = "Malkiqt princ", ISBN = "444444", isAvailable = false,
                DateToReturn = new DateTime(2023,12,16,00,00,00)}
        };

        public void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter title: ");
            book.Title = Console.ReadLine();
            Console.WriteLine("Enter ISBN: ");
            book.ISBN = Console.ReadLine();
            book.isAvailable = true;
            books.Add(book);
        }
        public void DeleteBook()
        {
            Console.WriteLine("Write the index of the book you would like to remove: ");
            int numberOfBook = int.Parse(Console.ReadLine());
            books.RemoveAt(numberOfBook);
        }
        public void ShowBooks()
        {
            Console.WriteLine();
            foreach (Book book in books)
            {
               Console.WriteLine(book.Title +", "+ book.ISBN + ", " + book.isAvailable);
            }
            Console.WriteLine();
        }
        static DateTime RandomDate()
        {
            DateTime start = new DateTime(2024, 1, 1);
            Random gen = new Random();
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        public void CheckOutBook()
        {
            Console.WriteLine("Write the index of the book you would like to check out: ");
            int numberOfBook = int.Parse(Console.ReadLine());
            if (books[numberOfBook].isAvailable)
            {
                books[numberOfBook].isAvailable = false;
                books[numberOfBook].DateToReturn = RandomDate();
            }
            else
            {
                Console.WriteLine("Book isn't available!");
            }
        }
        public void CompareCurrentToReturnDate()
        {
            Console.WriteLine("Write the index of the book you would like to return: ");
            int numberOfBook = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            if (books[numberOfBook].DateToReturn < today)
            {
                Console.WriteLine("You will be charged a fee of 20$!");
            }
            else if(books[numberOfBook].DateToReturn > today)
            {
                books[numberOfBook].isAvailable = true;
                Console.WriteLine("Thank you! Have a nice day!");
            }
        }
    }
    
}

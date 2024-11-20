using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalog.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public bool isAvailable { get; set; }
        public DateTime DateToReturn { get; set; }
        public Book(string title, string isbn, bool available, DateTime returnDate)
        {
            Title = title;
            ISBN = isbn;
            isAvailable = available;
            DateToReturn = returnDate;
        }
        public Book()
        {
        }
    }
}

using LibraryCatalog.Classes;
using System;
using System.Collections.Generic;

namespace LibraryCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the virtual library!");
            int numberOfOption = 0;
            ManageBooks manageBooks = new ManageBooks();
            bool exitProgram = false;
            
            do
            {
                Console.WriteLine("Please choose one of the following options from the menu:");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Remove a book");
                Console.WriteLine("3. Check out a book");
                Console.WriteLine("4. Return a book");
                Console.WriteLine("5. Exit the program");
                numberOfOption = int.Parse(Console.ReadLine());


                if (numberOfOption == 1){
                    manageBooks.AddBook();
                    manageBooks.ShowBooks();
                    
                }
                else if (numberOfOption == 2){
                    manageBooks.ShowBooks();
                    manageBooks.DeleteBook();
                    
                }
                else if (numberOfOption == 3)
                {
                    manageBooks.ShowBooks();
                    manageBooks.CheckOutBook();
                    
                }
                else if (numberOfOption == 4)
                {
                    manageBooks.ShowBooks();
                    manageBooks.CompareCurrentToReturnDate();
                    
                }
                else if (numberOfOption == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please pick one of the options shown above!");
                    break;
                }
                
            } while (numberOfOption > 0 || numberOfOption <= 5);
        }
    }
}

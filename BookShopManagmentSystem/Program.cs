using BookShop.Model;
using System;

namespace BookShopManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Abel Book Store!");

            Console.WriteLine($"Press 1: To Add Books");
            Console.WriteLine($"Press 2: To Sell Books");
            Console.WriteLine($"Press 3: To Check");
            Console.WriteLine($"Press any key: To Exit");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("INPUT is Empty");
            }
            input = input.Trim();
            int menuSelection;
            bool result = Int32.TryParse(input, out menuSelection);
            if (!result)
            {
                Console.WriteLine($"Attempted Coversion is Failed {input}");
            }

            switch (menuSelection)
            {
                case 1:
                    Console.WriteLine($"{menuSelection} is selected, book is to be added");
                    Books book = new Books();
                    Console.WriteLine("Enter Book Title? ");
                    book.Title =  Console.ReadLine();
                    
                    //Add Book 
                    

                    break;
                case 2:
                    Console.WriteLine($"{menuSelection} is selected, book is now sold");
                    break;
                case 3:
                    Console.WriteLine($"{menuSelection} is selected, book is now retrieved");
                    break;
                default:
                    Console.WriteLine($"exit from the menu.");
                    break;
            }

        }
    }
}

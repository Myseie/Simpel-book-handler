using Simple_Book_handler;
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        BookManager manager = new BookManager();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nVälj ett alternativ");
            Console.WriteLine("1. Lägg till en bok");
            Console.WriteLine("2. Ta bort en bok");
            Console.WriteLine("3. Visa alla böcker");
            Console.WriteLine("4. Avsluta");


            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.WriteLine("Ange titel : ");
                    string title = Console.ReadLine();

                    Console.WriteLine("Ange författare : ");
                    string author = Console.ReadLine();

                    Console.WriteLine("Ange vilket år :");
                    int year = int.Parse(Console.ReadLine());

                    Book newBook = new Book(title, author, year);
                    manager.AddBook(newBook);
                    break;
                case "2":
                    Console.WriteLine("Ange titeln du vill ta bort : ");
                    string titleToRemve = Console.ReadLine();
                    manager.RemoveBook(titleToRemve);

                    break;
                case "3":
                    manager.ShowBooks();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ogiltligt val. Försök igen");
                    break;


            }
        }
    }
}
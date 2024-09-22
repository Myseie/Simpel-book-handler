using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Book_handler
{
    class BookManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Boken {book.Title} har lagts till");
        }

        public void RemoveBook(string title)
        {
            Book bookToRemove = books.Find(b => b.Title.ToLower() == title.ToLower());

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Boken {title} har tagits bort");
            }
            else
            {
                Console.WriteLine($"Ingen bok med titeln '{title}' hittades");
            }
           
           

        }

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Där är inga böcker i samlingen");
            }
            else
            {
                Console.WriteLine("Böcker i samlingen är :");
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}

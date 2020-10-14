using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public class Book
    {
        String bookId;
        public String bookName;
        String bookAuthor;
        String bookGenre;
        public int bookPrice;
        string bookPublishedDate;

        public void GetBookDetails()
        {
            Console.WriteLine("Enter BookID: ");
            bookId = Console.ReadLine();
            Console.WriteLine("Enter Book Name: ");
            bookName = Console.ReadLine();
            Console.WriteLine("Enter Author Name: ");
            bookAuthor = Console.ReadLine();
            Console.WriteLine("Enter Book Genre: ");
            bookGenre = Console.ReadLine();
            Console.WriteLine("Enter Book Price: ");
            bookPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Published Date: ");
            bookPublishedDate = Console.ReadLine();
        }
         public void DisplayBookDetails()
        {
            Console.WriteLine("BookID: {0}", bookId);
            Console.WriteLine("Book Name: {0}", bookName);
            Console.WriteLine("Author Name: {0}", bookAuthor);
            Console.WriteLine("Genre: {0}", bookGenre);
            Console.WriteLine("Price: {0}", bookPrice);
            Console.WriteLine("Published Date: {0}", bookPublishedDate);
        }
        public Book() { }
        public Book(String bookId, String bookName, String bookAuthor, String bookGenre, int bookPrice, String bookPublishedDate)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookGenre = bookGenre;
            this.bookPrice = bookPrice;
            this.bookPublishedDate = bookPublishedDate;
        }
        class NameSizeException : Exception
        {
            public string message;
            public NameSizeException(String message)
            {
                this.message = message;
            }

        }

        class PriceException : Exception
        {
            public string message;
            public PriceException(String message)
            {
                this.message = message;
            }
        }

    }
}

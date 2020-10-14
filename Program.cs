using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
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
    class Program
    {
        static void Main(string[] args)
        {
            Book obj1 = new Book();
            for (int i = 0; i < 5; i++)
            {


                try
                {
                    obj1.GetBookDetails();
                    if (obj1.bookName.Length < 20)
                    {
                        throw new NameSizeException("The name size should be more than 20 characters");
                    }
                    if (obj1.bookPrice > 1999)
                    {
                        throw new PriceException("The price should be less than  2000");
                    }
                    obj1.DisplayBookDetails();
                }

                catch (PriceException obj)
                {
                    Console.WriteLine(obj.message);

                }
                catch (NameSizeException obj)
                {
                    Console.WriteLine(obj.message);
                }
                catch (Exception obj)
                {
                    Console.WriteLine(obj.Message);
                }
            }
        }
    }
}

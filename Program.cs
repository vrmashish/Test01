using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Book obj1 = new Book();
            for (int i = 0; i < 2; i++)
            {


                try
                {
                    obj1.GetBookDetails();
                    if (obj1.bookName.Length < 20)
                    {
                        throw new Exception1.NameSizeException("The name size should be more than 20 characters");
                    }
                    if (obj1.bookPrice > 1999)
                    {
                        throw new Exception1.PriceException("The price should be less than  2000");
                    }
                    obj1.DisplayBookDetails();
                }
                
                catch (Exception1.PriceException obj)
                {
                    Console.WriteLine(obj.message);

                }
                catch (Exception1.NameSizeException obj)
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

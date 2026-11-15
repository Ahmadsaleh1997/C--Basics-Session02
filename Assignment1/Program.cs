using System.Runtime.InteropServices;

namespace Assignment1
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; }
            public int Pages { get; set; }
        }
        static void Main(string[] args)
        {  
            
            // 1- Create a Book class with a Title (string) and Pages (int). Create a Book object and store  it in a variable of type object.Print it.

            Book bookobject = new Book { Title = "C# Basices", Pages = 180 };
            Console.WriteLine($"{bookobject.Title} , {bookobject.Pages} pages.");

            // 2- Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            Book book1 = new Book { Title = "C++ Basices", Pages = 200 };

            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(bookobject));
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());

            //4- Write code that divides 10 by 0 inside a try block, catches the exception, prints " divide by zero", and then prints "Done" in a finally block.

            try
            {
                int zero =  0;
                int result = 10 / zero;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

        }

    }
    }

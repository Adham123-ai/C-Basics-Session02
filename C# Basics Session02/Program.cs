using System.ComponentModel;
using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_Session02;
class Book
{
  public string Title;
public int Pages;
}

internal class Program
{
    static void Main(string[] args)
    {
        #region Q1
        ///Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
        /// variable of type object.Print it.
        ///Book b = new Book();

        ///b.Title = "Adham Book";
        ///b.Pages = 300;



        ///Console.WriteLine(book);
        ///Console.WriteLine($"the book title is {b.Title} \n the book pages is {b.Pages} ");
        ///}

        #endregion
        #region Q2
        //Using the Book class above, print the result of calling ToString(), Equals() (compare book with
        //itself), GetHashCode(), and GetType() on book.

        ///Console.WriteLine(b.ToString());

        /// Console.WriteLine(b.Equals(b));

        /// Console.WriteLine(b.GetHashCode());

        ///Console.WriteLine(b.GetType());
        #endregion
        #region Q3
        ///Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
        ///int pages = "464";
        /// Compile - Time Error
        /// int pages = 464;
        #endregion
        #region Q4
        //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
        //zero", and then prints "Done" in a finally block
        ///int x = 2;
        ///int y = 0;
        ///try
        ///{
        ///  int w = x / y;
        /// }
        /// catch (Exception ex)
        ///{
        ///   Console.WriteLine("Cannot divide by zero");
        /// }
        /// finally { Console.WriteLine("Done");

        /// }
        #endregion
        #region Q5
        /// Declare an int pages = 300; then store it in a double variable without using a cast.
        ///int pages = 300;
        ///double totalpages = pages;
        ///Console.WriteLine(totalpages);
        #endregion
        #region Q6
        // Declare a double price = 49.99; then convert it into an int using a cast.
        double price = 49.99;
        int intPrice = (int)price;
        Console.WriteLine(intPrice);
        #endregion
    }
}









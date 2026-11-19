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
        Book b = new Book();

         b.Title = "Adham Book";
         b.Pages = 300;

     

        ///Console.WriteLine(book);
        ///Console.WriteLine($"the book title is {b.Title} \n the book pages is {b.Pages} ");
        ///}

        #endregion
        #region Q2
        //Using the Book class above, print the result of calling ToString(), Equals() (compare book with
        //itself), GetHashCode(), and GetType() on book.

        Console.WriteLine(b.ToString());

        Console.WriteLine(b.Equals(b));

        Console.WriteLine(b.GetHashCode());

        Console.WriteLine(b.GetType());
        #endregion

    }
}









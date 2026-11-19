namespace C__Basics_Session02;
     #region Q1
///Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
/// variable of type object.Print it.

    class Book
{
    public string Title;
    public int Pages;
}
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Book b = new Book();

                b.Title = "Adham Book";
                b.Pages = 300;

                object book = b;

                Console.WriteLine(book);
        Console.WriteLine($"the book title is {b.Title} \n the book pages is {b.Pages} ");
            }
        }

            #endregion





    


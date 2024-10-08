
using System;
using System.Net.Http.Headers;
class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;
    private string bookISBN;

    //Constructor for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages )
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;

    }

    void DisplayInfo()
    {
        //Output
        Console.WriteLine("Book information");
        Console.WriteLine("________________");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Number of Pages {NoOfPages}");
    }
        static void Main(string[] args)
    {
        Book book = new Book("C# for beginners", "Bill Gates", "1234567", 200);
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "1234567", 50);

        book.DisplayInfo();
        book2.DisplayInfo();



    }
}
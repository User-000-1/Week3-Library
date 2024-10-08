
using System;
class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    void DisplayInfo()
    {
        Console.WriteLine("Book information");
        Console.WriteLine("________________");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
    }
        static void main(string[] args)
    {
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "1234567";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# Second book";
        book2.Author = "Microsoft";
        book2.ISBN = "12345678";
        book2.NoOfPages = 50;

        book.DisplayInfo();
        book2.DisplayInfo();


    }
}
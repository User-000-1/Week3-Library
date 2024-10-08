
using System;
class Book
{
    string Title;
    string Author;
    string ISBN;

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
        Book.Title = "C# for beginners";
        Book.Author = "Bill Gates";
        Book.ISBN = "1234567";

        Book Book2 = new Book();
        Book.Title = "";
        Book.Author = "";
        Book.ISBN = "";


    }
}
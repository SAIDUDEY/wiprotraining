using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id;
    public string Title;
    public string Author;
    public bool IsAvailable;

    public Book(int id, string title, string author, bool isAvailable)
    {
        Id = id;
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    
    public void AddBook(Book book)
    {
        books.Add(book);
    }

   
    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
    }

   
    public List<Book> SearchByTitle(string title)
    {
        return books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
    }
}


class Program
{
    static void Main()
    {
        Library myLibrary = new Library();

       
        myLibrary.AddBook(new Book(1, "The Alchemist", "Paulo Coelho", true));
        myLibrary.AddBook(new Book(2, "Clean Code", "Robert Martin", true));
        myLibrary.AddBook(new Book(3, "C# Basics", "John Smith", false));
        myLibrary.AddBook(new Book(4, "The Monk Who Sold His Ferrari", "Robin Sharma", true));

       
        var authorResults = myLibrary.SearchByAuthor("paulo");
        Console.WriteLine("Books by author 'paulo':");
        foreach (var book in authorResults)
        {
            Console.WriteLine($"Title: {book.Title}, Available: {book.IsAvailable}");
        }

       
        var titleResults = myLibrary.SearchByTitle("code");
        Console.WriteLine("\nBooks with 'code' in title:");
        foreach (var book in titleResults)
        {
            Console.WriteLine($"Title: {book.Title}, Available: {book.IsAvailable}");
        }
    }
}
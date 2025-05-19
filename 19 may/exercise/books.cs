using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}";
    }
}

public class LibraryManagement
{
    public static void Main(string[] args)
    {
        // Queue for borrowed books
        Queue<Book> borrowedBooksQueue = new Queue<Book>();

        // Add 5 borrowed books
        borrowedBooksQueue.Enqueue(new Book("The Lord of the Rings", "J.R.R. Tolkien"));
        borrowedBooksQueue.Enqueue(new Book("Pride and Prejudice", "Jane Austen"));
        borrowedBooksQueue.Enqueue(new Book("1984", "George Orwell"));
        borrowedBooksQueue.Enqueue(new Book("To Kill a Mockingbird", "Harper Lee"));
        borrowedBooksQueue.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzgerald"));

        Console.WriteLine("--- Borrowed Books Queue ---");

        // Display the next book to be returned
        if (borrowedBooksQueue.Count > 0)
        {
            Console.WriteLine($"Next book to be returned: {borrowedBooksQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("No books currently borrowed.");
        }

        // Remove the book after it is returned
        if (borrowedBooksQueue.Count > 0)
        {
            Book returnedBook = borrowedBooksQueue.Dequeue();
            Console.WriteLine($"Book returned: {returnedBook}");
        }

        // Print remaining borrowed books
        Console.WriteLine("\nRemaining borrowed books:");
        foreach (Book book in borrowedBooksQueue)
        {
            Console.WriteLine(book);
        }

        // Stack for newly purchased books
        Stack<Book> newBooksStack = new Stack<Book>();

        // Add 3 new books
        newBooksStack.Push(new Book("The Silent Patient", "Alex Michaelides"));
        newBooksStack.Push(new Book("Where the Crawdads Sing", "Delia Owens"));
        newBooksStack.Push(new Book("Project Hail Mary", "Andy Weir"));

        Console.WriteLine("\n--- Newly Purchased Books Stack ---");

        // Display the last book purchased
        if (newBooksStack.Count > 0)
        {
            Console.WriteLine($"Last book purchased: {newBooksStack.Peek()}");
        }
        else
        {
            Console.WriteLine("No new books in the stack.");
        }

        // Remove a book after it is processed
        if (newBooksStack.Count > 0)
        {
            Book processedBook = newBooksStack.Pop();
            Console.WriteLine($"Book processed: {processedBook}");
        }

        // Print remaining new books
        Console.WriteLine("\nRemaining new books:");
        foreach (Book book in newBooksStack)
        {
            Console.WriteLine(book);
        }
    }
}

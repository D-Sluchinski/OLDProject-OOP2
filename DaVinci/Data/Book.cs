// Importing necessary namespaces
using System;
using SQLite;

// Defining a class "Books" which inherits from "BookBase"
namespace DaVinci.Data
{
    public class Book : BookBase
    {
        // Declaring private member variables
        private string bookId;
        private string title;
        private string isbn;
        private string authorName;
        private string category;
        private int quantity;
        private string language;

        // Default constructor
        public Book() { }

        // Parameterized constructor
        public Book(string bookId, string title, string isbn, string authorName, string category, int quantity, string language)
        {
            // Assigning parameter values to the class variables
            this.bookId = bookId;
            this.title = title;
            this.isbn = isbn;
            this.AuthorName = authorName;
            this.category = category;
            this.quantity = quantity;
            this.Language = language;
        }

        // Defining properties for class variables
        [PrimaryKey, AutoIncrement]
        public string BookId { get => bookId; set => bookId = value; }
        public string Category { get => category; set => category = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Language { get => language; set => language = value; }

        // Overriding the ToString() method to return the details of a book in a formatted string
        public override string ToString()
        {
            return "Book ID: " + BookId +
                   "\nTitle: " + Title +
                   "\nISBN: " + Isbn +
                   "\nAuthor: " + AuthorName +
                   "\nCategory: " + Category +
                   "\nLanguage" + Language +
                   "\nQuantity: " + Quantity;

        }

        // Implementing the abstract methods declared in the base class
        public override void Add()
        {
            // Implementation code for adding a book to the database
        }
        public override void Remove()
        {
            // Implementation code for removing a book from the database
        }
        public override void Update()
        {
            // Implementation code for updating a book in the database
        }
    }
}

using System;

// Creating the "Books" class, which derives from "BookBase"
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



        // Constructor with parameters
        public Book(string bookId, string title, string isbn, string authorName, string category, int quantity, string language) : base(isbn, title, quantity)
        {
            // Giving the class variables parameter values
            this.bookId = bookId;
            this.title = title;
            this.isbn = isbn;
            this.AuthorName = authorName;
            this.category = category;
            this.quantity = quantity;
            this.Language = language;
        }

        // Defining properties for class variables

        public string BookId { get => bookId; set => bookId = value; }
        public string Category { get => category; set => category = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Language { get => language; set => language = value; }



        // Using an override of the ToString() function to return a formatted string containing a book's details
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

        // Putting the abstract methods specified in the base class into practice
        public override void Add()
        {
            // The code that implements adding a book to the database
        }
        public override void Remove()
        {
            // Code that implements deleting a book from the database
        }
        public override void Update()
        {
            // Code that updates a book in the database through implementation
        }


        // sets the format of drop down of ReturnBook
        public string AsOption()
        {
            return $"{Title},{AuthorName},{category},{language}";
        }
    }
}

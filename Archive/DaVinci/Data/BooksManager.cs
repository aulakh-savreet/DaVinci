using System;
using System.Diagnostics;
using System.IO;
namespace DaVinci.Data
{
    public class BooksManager
    {
        public const string Directory = GlobalDirectory.Directory;
        public const string filepathbooks = $@"{Directory}/Resources/Files/readBooks.csv";

        // Lists for author and book information storage

        public static List<Book> bookList = new List<Book>();
        public BooksManager()
        {
            // Populate author and book data lists upon object initialization
            PopulateBookData();
        }

        // How to use a file to fill the author data list


        // Procedure for adding book data to list from file
        private void PopulateBookData()
        {
            foreach (string line in File.ReadAllLines(filepathbooks))
            {
                // Split each line of data into parts separated by commas
                string[] parts = line.Split(",");
                // Parse relevant data into variables
                string bookID = parts[0];
                string bookTitle = parts[1];
                string ISBN = parts[2];
                string authorName = parts[3];
                string bookcategory = parts[4];
                int quantity = int.Parse(parts[5]);
                string language = parts[6];
                // Create new Books object with parsed data and add to bookList
                bookList.Add(new Book(bookID, bookTitle, ISBN, authorName, bookcategory, quantity, language));
            }
        }

        // Method to get author details list


        // Method to get book details list
        public static List<Book> GetBookDetails()
        {
            return bookList;
        }

        public static List<Book> FindMatchingBooks(string userInput, string category, string authorName, string language, List<Book> bookList)
        {
            // Create a new list to store the matching books
            var matchingBooks = new List<Book>();


            // Loop through each book in the bookList
            foreach (var book in bookList)
            {


                // Check if the user input matches any part of the book title
                if (string.IsNullOrEmpty(userInput) == false)
                {

                    // Check if the book matches the selected category, author name, and language
                    if ((book.Category.ToLower().Equals(category.ToLower()) || category.ToLower().Equals("any")) &&
                        (book.AuthorName.ToLower().Equals(authorName.ToLower()) || authorName.ToLower().Equals("any")) &&
                        (book.Language.ToLower().Equals(language.ToLower()) || language.ToLower().Equals("any")))
                    {
                        // Add the book to the matchingBooks list
                        matchingBooks.Add(book);
                    }
                }
            }

            // Return the list of matching books
            return matchingBooks;
        }

        public static Book GetBook(string bookID)
        {
            foreach (var book in bookList)
            {
                if (bookID == book.BookId)
                {
                    return book;
                }
            }
            //if book doesnt exist
            return null;
        }

        // gets the Book title for the display alert
        public static string GetBookTitle(string booktitle)
        {
            foreach (var book in bookList)
            {
                if (booktitle == book.BookId)
                {
                    return book.Title;
                }
            }
            //if book doesnt exist
            return null;
        }

        // gets the book id
        public static string GetBookID(string BId)
        {
            foreach (var book in bookList)
            {
                if (BId == book.BookId)
                {
                    return book.BookId;
                }
            }
            //if book doesnt exist
            return null;
        }

        //
        public static List<Book> GetBookList()
        {
            return bookList;
        }


        public static List<Book> selectedBooks;
        public static List<Book> AddMatchingBooks(string title, string authorName, string language, string category, string isbn, List<Book> matchingBooks)
        {
            selectedBooks = new List<Book>();



            foreach (var book in matchingBooks)
            {
                selectedBooks.Add(book);
            }



            return selectedBooks;
        }



        public static List<Book> GetSelectedBook()
        {
            return selectedBooks;
        }

    }
}

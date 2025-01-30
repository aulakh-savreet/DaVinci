using System;
namespace DaVinci.Data
{
    public class PopulateListManager
    {
        // File paths for author and book data files
        private const string Directory = GlobalDirectory.Directory; 
        public const string filepathauthors = @$"{Directory}Resources\Files\authors.txt";
        public const string filepathbooks = @$"{Directory}Resources\Files\books.txt";

        // Lists to store author and book data
        public static List<Author> authorList = new List<Author>();
        public static List<Book> bookList = new List<Book>();

        public PopulateListManager()
        {
            PopulateAuthorData();
            PopulateBookData();
        }

        // Method to populate author data list from file
        private void PopulateAuthorData()
        {
            foreach (string line in File.ReadAllLines(filepathauthors))
            {
                // Split each line of data into parts separated by commas
                string[] parts = line.Split(",");
                // Parse relevant data into variables
                int authorID = int.Parse(parts[0]);
                string authorName = parts[1];
                string authorNationality = parts[2];
                // Create new Author object with parsed data and add to authorList
                authorList.Add(new Author(authorID, authorName, authorNationality));
            }
        }

        // Method to populate book data list from file
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
        public static List<Author> GetAuthorDetails()
        {
            return authorList;
        }

        // Method to get book details list
        public static List<Book> GetBookDetails()
        {
            return bookList;
        }
    }
}

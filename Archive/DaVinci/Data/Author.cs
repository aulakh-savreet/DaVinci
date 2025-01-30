using System;

namespace DaVinci.Data
{
    // Depicts a book author in a library
    public class Author : ILibraryItem
    {
        private int authorID;
        private string authorName;
        private string authorNationality;

        // Default constructor
        public Author()
        {
        }

        // Parameterized constructor
        public Author(int authorID, string authorName, string authorNationality)
        {
            this.authorID = authorID;
            this.authorName = authorName;
            this.authorNationality = authorNationality;
        }

        // Properties for the author's ID, name, and nationality
        public int AuthorID { get => authorID; set => authorID = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string AuthorNationality { get => authorNationality; set => authorNationality = value; }

        // Overrides the ToString method to display author details
        public override string ToString()
        {
            return "Author ID: " + AuthorID +
                "\nAuthorName: " + AuthorName +
                "\nNationality: " + AuthorNationality;
        }
    }
}

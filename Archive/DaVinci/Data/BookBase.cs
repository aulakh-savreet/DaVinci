using System;
namespace DaVinci.Data
{

    // Defines an abstract base class for books
    public abstract class BookBase
    {
        // Private fields for storing the ISBN, title, and quantity of the book
        private string _isbn;
        private string _title;
        private int _quantity;


        public BookBase()
        {
            new AuthorManager();
            new BooksManager();
        }


        protected BookBase(string isbn, string title, int quantity)
        {
            _isbn = isbn;
            _title = title;
            _quantity = quantity;
        }

        // Public property for accessing and modifying the ISBN
        public string Isbn
        {
            // Getter returns the ISBN
            get => _isbn;
            // Setter ensures that the ISBN is not null or empty
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("ISBN cannot be null or empty.");
                _isbn = value;
            }
        }

        // Public property for accessing and modifying the title
        public string Title
        {
            // Getter returns the title
            get => _title;
            // Setter ensures that the title is not null or empty
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Title cannot be null or empty.");
                _title = value;
            }
        }

        // Public property for accessing and modifying the quantity
        public int Quantity
        {
            // Getter returns the quantity
            get => _quantity;
            // Setter ensures that the quantity is not negative
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                _quantity = value;
            }
        }

        // Abstract methods for adding, removing, and updating books, which will be implemented by derived classes
        public abstract void Add();
        public abstract void Remove();
        public abstract void Update();
    }


}


using System;

// Define the namespace for the code
namespace DaVinci.Data
{
    // Define the Borrower class that implements the ILibraryItem interface
    public class Borrower : ILibraryItem
    {
        // Declare private fields for the borrower ID, name, address, and phone number
        private string borrowerID;
        private string name;
        private string address;
        private int phoneNumber;

        // Define a default constructor for the Borrower class
        public Borrower()
        {

        }

        // Define a parameterized constructor for the Borrower class
        public Borrower(string borrowerID, string name, string address, int phoneNumber)
        {
            // Set the borrower ID, name, address, and phone number fields
            this.borrowerID = borrowerID;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        // Define public properties for the borrower ID, name, address, and phone number fields
        public string BorrowerID { get => borrowerID; set => borrowerID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        // Override the ToString method to return a string representation of the Borrower object
        public override string ToString()
        {
            return "Borrower ID: " + BorrowerID +
                "\nName: " + Name +
                "\nAddress: " + Address +
                "\nPhone Number: " + PhoneNumber;
        }
    }
}

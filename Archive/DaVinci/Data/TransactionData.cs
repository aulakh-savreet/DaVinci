namespace DaVinci.Data
{
    public class TransactionData
    {

        
        private string _patronID = LoginManager.Patron; 
        private string _bookISBN;
        private string _bookTitle;
        private string _patron; 
        private static string _loanedDate;
        private string _returnDate;
        private string _status = "borrowed";


        public string PatronId { get => _patronID; set => _patronID = value; }
        public string Patron { get => _patron; set => _patron = value; }
        public string BookISBN { get => _bookISBN; set => _bookISBN = value; }
        public string BookTitle { get => _bookTitle; set => _bookTitle = value; }
        public static string LoanedDate { get => _loanedDate; set => _loanedDate = value; }
        public string ReturnDate { get => _returnDate; set => _returnDate = value; }
        public string Status { get => _status; set => _status = value; }


        // constructor
        public TransactionData(string patronId, string bookISBN, string loanedDate) 
        {
            PatronId = patronId;

            BookISBN = bookISBN;
            
            LoanedDate = loanedDate;
            
        }

        public string GetPatronID()
        {
            return PatronId;
        }

        public string GetPatron()
        {
            return Patron;
        }

        public void updateStatus()
        {

            if (_status == "borrowed")
            {
                _status = "returned";
            }
        }

        public string GetBookISBN()
        {
            return BookISBN;
        }

        public string GetBookTitle()
        {
            return BookTitle;
        }
        public string GetLoanedDate()
        {
            return LoanedDate;

        }

        
        public override string ToString()
        {
            return $"{PatronId},{BookISBN},{LoanedDate}";
        }

    }
}

using DaVinci.Data;

namespace DaVinci.Pages
{
    public partial class ReturnBook
    {

        /*  BOOK BORROWD FOR DROPDOWN SELECTOR*/
        private int _isbn;
        private string _bookTitle;
        private string _loanedDate;
        private string authorName;
        private string _genre;


        public int ISBN { get => _isbn; set => _isbn = value; }
        public string BookTitle { get => _bookTitle; set => _bookTitle = value; }
        public string LoanedDate { get => _loanedDate; set => _loanedDate = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Genre { get => _genre; set => _genre = value; }// catagory




        // for search
        private string _sBookTitle;

        public string SBookTitle { get => _sBookTitle; set => _sBookTitle = value; }



        public string BookID;

        public ReturnBook()
        {
            // used to not create a null error
            new AuthorManager();
            new BooksManager();

            //


            //TESTING
            TestNavtGod();
            
        }


        /*  Constuctor for Drop Down List*/
        public ReturnBook(int isbn, string bookTitle, string authourName, string loanedDate)
        {
            ISBN = isbn;
            BookTitle = bookTitle;
            AuthorName = authourName;
            LoanedDate = loanedDate;

        }

        /*  DEVMODE FOR TESTING */


        public void TestNavtGod()
        {
            //TESTING


            string CurrentDate = DatesManager.GetCurrentDate();

            string LoanedDate2 = "22/03/2023";
            string LoanedDate3 = "29/03/2024";

            // book: The Catcher in the Rye
            RBM.AddTransactions(new TransactionData("navtgod", "B005", CurrentDate));
            // book: The Last day of a Condemed Man
            RBM.AddTransactions(new TransactionData("navtgod", "B010", LoanedDate2));
            // book: The Da Vinci Code
            RBM.AddTransactions(new TransactionData("navtgod", "B007", LoanedDate3));


            string LoanedDate4 = "03/03/2023";
            string LoanedDate5 = "02/02/2023";
            // book: 1984
            RBM.AddTransactions(new TransactionData("DevMode", "B004", LoanedDate4));
            // book: Harry Potter and the Sorcerer's Stone
            RBM.AddTransactions(new TransactionData("DevMode", "B009", LoanedDate5));
            // book: The Great Gatsby
            RBM.AddTransactions(new TransactionData("DevMode", "B003", CurrentDate));
        }

    }
}

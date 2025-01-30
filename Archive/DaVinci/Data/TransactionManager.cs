using Microsoft.AspNetCore.Components;
using System.Runtime.Intrinsics.Arm;


namespace DaVinci.Data
{
    public class TransactionManager
    {

        private const string Directory = GlobalDirectory.Directory;
       
        private static List<TransactionData> _returnBookDatas = new List<TransactionData>();

        public static List<TransactionData> ReturnBookDatas { get => _returnBookDatas; set => _returnBookDatas = value; }

        public static List<TransactionData> GetTransaction()
        {
            return ReturnBookDatas;
        }

        public TransactionManager()
        {
        }


        //TO POPULATE LIST
        public List<TransactionData> searchByPatronID(string PatronID)
        {
            int found = 0;

            List<TransactionData> transactions = new List<TransactionData>();

            // searches through the list
            foreach (var transaction in _returnBookDatas)
            {
                if  (transaction.GetPatronID() == PatronID )
                {
                    transactions.Add(transaction);


                    found++;
                }

            }

            App.Current.MainPage.DisplayAlert($"found {found} loaned books", $" from: {PatronID}", "continue");

            // returns all the books associated with the ID
            return transactions;

        }



        public void AddTransactions(TransactionData transaction)
        {
            ReturnBookDatas.Add(transaction);
        }

        

    }


    
}

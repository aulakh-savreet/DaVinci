using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Data
{
    public static class DatesManager
    {
        /*  SHOWS THE CURRENT DATE DD/MM/YYYY*/
        public static string CurrentDate = DateTime.Now.ToString("dd/MM/yyyy");

        
        public static int currentDay = int.Parse(DateTime.Now.ToString($"dd"));
        public static int currentMonth = int.Parse(DateTime.Now.ToString($"MM"));
        public static int currentYear = int.Parse(DateTime.Now.ToString($"yyyy"));


        /* TOTAL DAYS IN THE MONTH */
        public static int daysInMonth = System.DateTime.DaysInMonth(currentYear, currentMonth);


        public static string DueDate;




        /*  DATE OF THE DUE DATE    */
        public static bool IsOverdue(string DateLoaned)
        {

            int DueDateDay = (currentDay + 7) % daysInMonth;
            int DueDateMonth = currentMonth;
            int DueDateYear = currentYear;

            bool isOverDueDate = false;

            
            if (DueDateDay < currentDay)
            {
                // 
                DueDateMonth = (currentMonth + 1) % 12;
            }

            // if the Dec, then we increase the year
            if(DueDateMonth < currentMonth)
            {
                DueDateYear = currentYear + 1;
            }

            // changes DateLoaned into a DateTime
            

            var Due = DateTime.Parse(CalculateDueDate(DateLoaned)).Date;

            var today = DateTime.Now;

            var daysLate = (Due - today).TotalDays;


            Application.Current.MainPage.DisplayAlert("Thank you", $"{daysLate}", "Continue");

            if (daysLate <= 7)
            {
                isOverDueDate = false;
            }

            else
            {
                isOverDueDate = true;
            }

            return isOverDueDate;

        }


        // Loan date
        public static string LoanedDate(string DateLoaned)
        {
            int LoanedDay;
            int LoanedMonth;
            int LoanedYear;

            string[] part = DateLoaned.Split("/");
            LoanedDay = int.Parse(part[0]);
            LoanedMonth = int.Parse(part[1]);
            LoanedYear = int.Parse(part[2]);


            return DateTime.Now.ToString($"{LoanedDay}/{LoanedMonth}/{LoanedYear}");
        }


        /*  CALCULATES THE DUE DATE USING THE LOANED DATE       */
        public static string CalculateDueDate(string DateLoaned)
        {
            //using the Loaned date of when taken out
            int LoanedDay;
            int LoanedMonth;
            int LoanedYear;

            // splits the loaned dates
            string[] part = DateLoaned.Split("/");
            LoanedDay = int.Parse(part[0]);
            LoanedMonth = int.Parse(part[1]);
            LoanedYear= int.Parse(part[2]);

            //gets the loaned month days
            int loanedDaysInMonth = DateTime.DaysInMonth(LoanedYear, LoanedMonth);

            //checks when the Due date would be
            int DueDateDay = (LoanedDay + 7) % loanedDaysInMonth;
            int DueDateMonth = LoanedMonth;
            int DueDateYear = LoanedYear;

            if (DueDateDay < LoanedDay)
            {
                // 
                DueDateMonth = (LoanedMonth + 1) % 12;
            }

            if (DueDateMonth < LoanedMonth)
            {
                DueDateYear = LoanedYear + 1;
            }

            

            return DateTime.Now.ToString($"{DueDateDay}/{DueDateMonth}/{DueDateYear}");
        }



        public static string GetCurrentDate()

        { 
            return $"{currentDay}/{currentMonth}/{currentYear}"; 
        }


        public static int GetCurrentDay()
        {
            return currentDay;
        }

        public static int GetCurrentMonth()
        {
            return currentMonth;
        }

        public static int GetDaysInMonth() 
        { 
            return daysInMonth;
        }

        public static int GetCurrentYear()
        {
            return currentYear;
        }
    }
}

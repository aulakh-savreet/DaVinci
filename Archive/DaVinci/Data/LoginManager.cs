namespace DaVinci.Data
{
    public class LoginManager
    {
        
        private const string Directory = GlobalDirectory.Directory;
        private const string FilePath = $@"{Directory}\Resources\Files\account.txt";

        public static List<Login> LoginList = new List<Login>();

        public static string Patron = "Guest";

        //creating a no parameter cosntructor that returns a populated list of logins
        public LoginManager()
        {
            PopulateLogins();
        }

        //method for reading the file and spliting and storing the username and password in their own vairables
        private void PopulateLogins()
        {
            Login login;
            foreach (string line in File.ReadLines(FilePath))
            {
                string[] parts = line.Split(';');
                string username = parts[0]; ;
                string password = parts[1];

                login = new Login(username, password);

                LoginList.Add(login);
            }
        }

        //method for comparing the user enter username and password with the file to make sure there is a log in that matches
        public static List<Login> FindMatchingLogins(string username, string password)
        {
            var matchingLogin = new List<Login>();


            //default is false so if none are found it will create a display
            bool founduser = false;

            foreach (var login in LoginList)
            {
                if (login.Username.Equals(username) && login.Password.Equals(password))
                {
                    matchingLogin.Add(login);
                    //sets this up for search functions and other
                    //pages to use
                    Patron = login.Username;
                    // bool for the popup alert confirming login
                    founduser = true;
                    
                }
            }
            // displays welcome when logged in
            if (founduser == true)
            {
                App.Current.MainPage.DisplayAlert($"Welcome To DaVinci", $"{Patron}", "Continue");
            }
            else
            {
                // displays if empty or wrong password or Username
                App.Current.MainPage.DisplayAlert($"Login Denied", $"Username or password is incorrect", "Continue");
            }

            return matchingLogin;

        }

        public static string GetPatron()
        {
            return Patron;
        }

    }
}

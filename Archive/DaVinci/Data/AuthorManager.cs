namespace DaVinci.Data
{
    public class AuthorManager
    {
        //Establishing a Constant for the Path of Files
        public const string Directory = GlobalDirectory.Directory;
        public const string filepathauthors = @$"{Directory}\Resources\Files\readAuthors.csv";

        //making a list to keep track of all the writers
        public static List<Author> authorList = new List<Author>();

        //building a constructor to fill in author information
        public AuthorManager()
        {
            PopulateAuthorData();
        }

        //reads the file and seperates the authors from each other
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

        //returns the list of authors
        public static List<Author> GetAuthorDetails()
        {
            return authorList;
        }
    }
}


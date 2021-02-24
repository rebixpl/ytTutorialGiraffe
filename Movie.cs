namespace ytTutorialGiraffe
{
    internal class Movie
    {
        private string title;
        private string director;
        private string rating;

        //static attribute will be the same across all class objects
        public static int movieCount = 0;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;

            // every time the movie is created increment the movieCount static value
            movieCount++;
        }

        // Property with getter and setter
        public string Rating
        {
            get { return rating; }
            set { 
            if (value == "G" || value == "PG" || value == "PG-13" ||
                    value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
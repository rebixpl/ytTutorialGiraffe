using System;

namespace ytTutorialGiraffe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //---------------- Classes and objects --------------------------
            Book book1 = new Book("Mein Kampf", "Mein Kampf", 384);
            Book bookEmpty = new Book();
            Movie movie1 = new Movie("Mein Kampf", "Mein Kampf", "FDSFDF");

            movie1.Rating = "R";
            Console.WriteLine(movie1.Rating);
            Console.WriteLine(Movie.movieCount);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
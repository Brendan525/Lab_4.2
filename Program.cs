using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_4._2
{

    class Movie
    {
        private string _title; // Field
        private string _category; // Field

        public string Title
        {
            get
            {
                return _title;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
        }

        public Movie(string title, string category) // Constructor that take string title and string category
        {
            _title = title;
            _category = category;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool done = true;

            List<Movie> movieList = new List<Movie>(); // A list that takes the Movie constructor and is called movieList.

            movieList.Add(new Movie("The Dark Knight", "action")); // Takes the movieList and adds a new Movie object to the list
            movieList.Add(new Movie("The Wolf of Wall Street", "comedy"));
            movieList.Add(new Movie("Django", "action"));
            movieList.Add(new Movie("Pulp Fiction", "crime"));
            movieList.Add(new Movie("Get Out", "suspense"));
            movieList.Add(new Movie("Avengers Infinity War", "scifi"));
            movieList.Add(new Movie("The Departed", "thriller"));
            movieList.Add(new Movie("Spider-Man: Into The Spider-Verse", "animation"));
            movieList.Add(new Movie("28 Days Later", "horror"));
            movieList.Add(new Movie("28 Weeks Later", "horror"));
            movieList.Add(new Movie("AppleJacks", "comedy"));

            Console.WriteLine("Welcome to the Movie List Application!");

            Console.WriteLine();

            Console.WriteLine($"There are {movieList.Count} movies in this list");

            Console.WriteLine();

            do
            {
                Console.WriteLine("What category are you interested in? ");

                string input = Console.ReadLine().ToLower();

                Console.WriteLine();
                for (int i = 0; i < movieList.Count; i++) // For every item/element in movieList (Count, counts all of the items/elements in the list
                {
                    if (input == movieList[i].Category) // If input is equal to the movieList Category
                    {
                        Console.WriteLine(movieList[i].Title); // Prints the title
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Would you like to continue? (y/n)");

                string input2 = Console.ReadLine().ToLower();

                if (input2 == "y")
                {
                    Console.WriteLine();
                    done = true;
                }
                else if (input2 == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye");
                    done = false;
                }
            } while (done); 
        }
    }
}

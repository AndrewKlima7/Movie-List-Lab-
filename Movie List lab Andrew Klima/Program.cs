using System;
using System.Collections.Generic;

namespace Movie_List_lab_Andrew_Klima
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                List<Movie> movies = new List<Movie>();
                
                Movie m1 = new Movie("Chucky", Genre.Horror);
                movies.Add(m1);
                Movie m2 = new Movie("Back to the Future", Genre.Scifi);
                movies.Add(m2);
                Movie m3 = new Movie("Momma Mia", Genre.Drama);
                movies.Add(m3);
                Movie m4 = new Movie("Spirited Away", Genre.Animated);
                movies.Add(m4);
                Movie m5 = new Movie("Friday the 13th", Genre.Horror);
                movies.Add(m5);
                Movie m6 = new Movie("Star Wars", Genre.Scifi);
                movies.Add(m6);
                Movie m7 = new Movie("1917", Genre.Drama);
                movies.Add(m7);
                Movie m8 = new Movie("Lilo and Stitch", Genre.Animated);
                movies.Add(m8);
                Movie m9 = new Movie("Halloween", Genre.Horror);
                movies.Add(m9);
                Movie m10 = new Movie("Rio", Genre.Animated);
                movies.Add(m10);

                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine();
                bool validate = true;
                while (validate == true)
                {
                    Console.WriteLine($"There are 10 movies");
                    Console.WriteLine("Here are the accepted genres:");

                    for (int i = 0; i < 4; i++)
                    {
                        Movie mov = movies[i];
                        string movGenre = mov.genre.ToString();
                        Console.WriteLine($"{i} : {movGenre}");
                    }
                    Console.WriteLine("What genre are you interested in?");
                    string input = Console.ReadLine();
                    if (input.Length == 0)
                    {
                        Console.WriteLine("Must be a valid input try again");
                        validate = true;
                    }
                    else
                    {
                        try
                        {
                            Genre inputGenre = (Genre)Enum.Parse(typeof(Genre), input);
                            Console.WriteLine();
                            Console.WriteLine($"Here are the movies from {inputGenre}");
                            //List<Movie> Sorted = new List<Movie>();
                            //Sorted.Add(movies.Sort());
                            // failed attempt to sort alphabetically

                            foreach (Movie m in movies)
                            {
                                if (m.genre == inputGenre)
                                {
                                    Console.WriteLine(m.Title);
                                }
                            }
                        }
                        catch (FormatException)
                        {

                        }
                        validate = false;
                    }
                }
                again = GoAgain();
            }
        }
        public static bool GoAgain()
        {
            Console.Write("Continue? (Y/N) ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y" || input.ToUpper() == "YES")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                return true;
            }
            else if (input.ToUpper() == "N" || input.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Must input a valid response.");
                return GoAgain();
            }
        }
    }
}


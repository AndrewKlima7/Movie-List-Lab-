using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List_lab_Andrew_Klima
{
    public enum Genre
    {
        Horror, 
        Scifi,
        Drama,
        Animated
    }
    class Movie
    {
        public string Title { get; set; }

        public Genre genre { get; set; }

        public Movie (string title, Genre genre)
        {
            Title = title;
            this.genre = genre;
        }
    }
}

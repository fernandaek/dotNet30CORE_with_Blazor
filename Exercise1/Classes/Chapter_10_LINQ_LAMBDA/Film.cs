using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_10_LINQ_LAMBDA
{
    public class Film
    {
        public string Title { get; }
        public int Year { get; }
        public int Id { get; }

        public List<Genre> Genres { get; } = new List<Genre>();

        public Film(string title, int year, int id, Genre genres = default)
        {
            Title = title;
            Year = year;
            Id = id;
            this.AddGenre(genres);
        }
    }
}

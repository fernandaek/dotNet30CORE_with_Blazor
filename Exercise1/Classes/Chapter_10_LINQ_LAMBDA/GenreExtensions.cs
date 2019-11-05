using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_10_LINQ_LAMBDA
{
    public static class GenreExtensions
    {
        public static List<Genre> AddGenre(this List<Genre> genres, string name)
        {
            if(name.Length > 0 && name != default)
            {
                int id = genres.Count.Equals(0) ? 1 : genres.Max(m => m.Id) + 1;
                var genre = new Genre(name, id);
                genres.Add(genre);
            }
            return genres;
        }

        public static Film AddGenre(this Film film, Genre genre)
        {
            if (genre != default) film.Genres.Add(genre);
            return film;
        }


    }
}

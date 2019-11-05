using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercise1.Classes.Chapter_10_LINQ_LAMBDA;

namespace Exercises.Tests.Chapter_10
{
    public class FilmTests
    {
        [Fact]
        public void CanCreateGenreInstanceWithGenre()
        {
            Genre genre = new Genre("Action", 1);
            Film film = new Film("The walking dead", 2019, 1, genre);

            Assert.NotNull(film);
            Assert.Equal(1, film.Id);
            Assert.Equal(2019, film.Year);
            Assert.Equal("The walking dead", film.Title);
            Assert.NotEmpty(film.Genres);
        }

        [Fact]
        public void CanCreateInstanceWithoutGenre()
        {
            var film = new Film("The Title", 1920, 1);

            Assert.NotNull(film);
            Assert.Equal(1, film.Id);
            Assert.Equal(1920, film.Year);
            Assert.Equal("The Title", film.Title);
            Assert.Empty(film.Genres);
        }
    
    }
}

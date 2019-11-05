using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercise1.Classes.Chapter_10_LINQ_LAMBDA;

namespace Exercises.Tests.Chapter_10
{
    public class GenreTests
    {
        [Fact]
        public void CanCreateGenreInstance()
        {
            var genre = new Genre("Action", 1);

            Assert.NotNull(genre);
            Assert.Equal(1, genre.Id);
            Assert.Equal("Action", genre.Name);
        }
    }
}

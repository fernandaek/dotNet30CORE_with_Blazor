using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_10_LINQ_LAMBDA
{
    public class Genre
    {
        public string Name { get; }
        public int Id { get; }

        public Genre(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}

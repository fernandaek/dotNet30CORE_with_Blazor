﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_10_LINQ_LAMBDA
{
    public class Shop
    {
        public SortOrder SortOrder { get; }
        private List<Genre> _genres = new List<Genre>();
        private List<Film> _films = new List<Film>();

        public List<Genre> Genres => SortOrder.Equals(SortOrder.Ascending) 
            ? _genres.OrderBy(g => g.Name).ToList() 
            : _genres.OrderByDescending(g => g.Name).ToList();

        public List<Film> Films => SortOrder.Equals(SortOrder.Ascending)
            ? _films.OrderBy(f => f.Title).ToList()
            : _films.OrderByDescending(f => f.Title).ToList();

        public Shop(SortOrder sortOrder)
        {

            SeedData();
        }

        private void SeedData()
        {
            _genres.AddGenre("Action");
            _genres.AddGenre("Fantasy");
            _genres.AddGenre("Adventure");
            _genres.AddGenre("Crime");
            _genres.AddGenre("Romance");
            _genres.AddGenre("Drama");
            _genres.AddGenre("Horror");

            var action = _genres.First(g => g.Name.Equals("Action"));
            var fantasy = _genres.First(g => g.Name.Equals("Fantasy"));
            var adventure = _genres.First(g => g.Name.Equals("Adventure"));
            var crime = _genres.First(g => g.Name.Equals("Crime"));
            var romance = _genres.First(g => g.Name.Equals("Romance"));
            var drama = _genres.First(g => g.Name.Equals("Drama"));
            var horror = _genres.First(g => g.Name.Equals("Horror"));

            AddFilm("The Shawshank Redemption", 1994, drama.Id);
            AddFilm("The Godfather", 1972, drama.Id)
                .AddGenre(crime);
            AddFilm("The Dark Knight", 2008, action.Id)
                .AddGenre(drama).AddGenre(crime);
            AddFilm("Forrest Gump", 1994, romance.Id)
                .AddGenre(drama);
            AddFilm("LOTR: The Return of the King", 2003, fantasy.Id)
                .AddGenre(adventure).AddGenre(drama);
            AddFilm("LOTR: The Two Towers", 2002, fantasy.Id)
                .AddGenre(adventure).AddGenre(drama);
            AddFilm("LOTR: The Fellowship of the Ring", 2001, fantasy.Id)
                .AddGenre(adventure).AddGenre(drama);
        }

        public Film AddFilm(string title, int year, int genreId)
        {
            try
            {
                if (title == default || title == string.Empty) throw new ArgumentException("A film must have a title");
                else if (year < 1800) throw new ArgumentException("Invalid");

                var genre = Genres.SingleOrDefault(g => g.Id.Equals(genreId));

                if (genre == default) throw new ArgumentException("Invalid genre.");

                var id = Films.Count.Equals(0) ? 1 : Films.Max(m => m.Id) + 1;
                var film = new Film(title, year, id, genre);

                _films.Add(film);

                return Films.Single(f => f.Id.Equals(id));

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddGenre(string name)
        {
            _genres.AddGenre(name);
        }

        public List<Genre> GenresInFilms()
        {
            List<Genre> genres = new List<Genre>();

            try
            {
                foreach( var film in Films)
                {
                    var joinedGenres = Genres.Join(film.Genres, genre => genre.Id, filmGenre => filmGenre.Id, (genre, filmGenre) => genre);

                    genres.AddRange(joinedGenres);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return genres.Distinct().OrderBy(g => g.Name).ToList();
        }

        public int FilmsInGenre(int genreId)
        {
            try
            {
                var genre = Genres.Single(g => g.Id.Equals(genreId));
                var count = Films.Count(f => f.Genres.Contains(genre));

                return count;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public List<Film> FilterFilms(string filter)
        {
            try
            {
                if (filter == default || filter.Length <= 1) return Films;

                return Films.Where(f => f.Title.ToLower().Contains(filter.ToLower())).ToList();

            }
            catch
            {
                return new List<Film>();
            }
        }
        public List<Film> FilterFilms(string filter, int skip, int take)
        {
            IEnumerable<Film> films;

            try
            {
                films = FilterFilms(filter);

                if (skip >= 0) films = films.Skip(skip);
                if (take > 0) films = films.Take(take);
            }
            catch
            {
                films = new List<Film>();
            }

            return films.ToList();
        }
        public List<Film> UnionFilms()
        {
            IEnumerable<Film> films;

            try
            {
                var films1 = Films.Take(2);
                var films2 = Films.Skip(4).Take(1);

                films = films1.Union(films2);
            }
            catch
            {
                films = new List<Film>();
            }

            return films.ToList();
        }
    }
}

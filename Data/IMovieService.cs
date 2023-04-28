using System;
namespace Lab5.Data
{
    public interface IMovieService
    {

        public List<Movie> ReadFromFile();

        public List<Movie> GetMovies(Func<Movie, bool> filter);


    }
}


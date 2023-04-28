using System;
namespace Lab5.Data
{
	public class MovieService : IMovieService
	{
        List<Movie> MovieList;

		public List<Movie> ReadFromFile()
		{
            string filePath = Directory.GetCurrentDirectory().ToString();
            Console.WriteLine(filePath);
            StreamReader sr = new StreamReader(filePath + "/Data/movies.psv");
            List<Movie> movieList = new List<Movie>();
            while (!sr.EndOfStream)
            {
                string[] movieLine = sr.ReadLine().Split('|');
                Movie movie = new Movie(movieLine[0], Int32.Parse(movieLine[1]), movieLine[2]);
                movieList.Add(movie);
            }
            return movieList;
        }
		public List<Movie> GetMovies(Func<Movie, bool> filter)
		{
            var movieList = ReadFromFile();
            return movieList.Where(x => filter(x)).ToList();
		}
	}
}


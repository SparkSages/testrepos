using System;
namespace Lab5.Data
{
	public class Movie
	{
		public string Title { get; private set; }
		public int Year { get; private set; }
		public string Genre { get; private set; }
		public Movie(string title, int year, string genre)
		{
			Title = title;
			Year = year;
			Genre = genre;
		}
	}
}


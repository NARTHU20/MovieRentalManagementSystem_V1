using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieRentalManagementSystem
{
    internal class MovieManager
    {
        public List<Movie> MoviesList = new List<Movie>();
        public MovieManager() { }


        public  void CreateMovie(string movieId, string title, string director, string rentalPrice)
        {
            Movie movie = new Movie(movieId, title, director, rentalPrice);
            MoviesList.Add(movie);
        }
        public void ReadMovies(int movieId)
        {
            if (MoviesList.Count == 0)
            {
                Console.WriteLine("Movie not found");
            }
            else
            {
                foreach (Movie movie in MoviesList)
                {
                    Console.WriteLine(movie);
                }
            }
        }
        public void UpdateMovie(string Id , string newtitle ,string newdirector , string newrentalPrice)
        {
            var Movie = MoviesList.FirstOrDefault(m => m.movieId == Id);
            if (Movie != null)
            {
                Movie.Title = newtitle;
                Movie.Director = newdirector;
                Movie.RentalPrice = newrentalPrice;
            }
            else
            {
                Console.WriteLine("Movie not Found");
            }
        }

        public void DeleteMovie(int id)
        {
            var Movie = MoviesList.FirstOrDefault(m => m.movieId == id);
            if (Movie != null)
            {
                var movie = MoviesList.Remove();
            }
            else
            {
                Console.WriteLine("Movie not Found");
            }
        }
        
    }
}

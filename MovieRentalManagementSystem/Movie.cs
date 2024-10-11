using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieRentalManagementSystem
{
    internal class Movie
    {
        

        private string movieId { get; set; }
        private string title { get; set; }
        private string director { get; set; }
        private string rentalPrice { get; set; }
       

        public Movie(string movieId, string title, string director, string rentalPrice)
        {
            this.movieId = movieId;
            this.title = title;
            this.director = director;
            this.rentalPrice = rentalPrice;
        }


        public override string ToString()
        {
            return $"movieIdId: {{ MovieId}}, title: {{ Title}}, director: {{ Director}}, rentalPrice: {{ RentalPrice }} ";
        }
    }
}

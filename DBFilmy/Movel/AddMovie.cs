using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFilmy
{
    class AddMovie
    {
        private readonly ILogger _logger;
        public AddMovie(string title, string director, string category, int price, int penalty, int numOfCopies, int yearLimitation, DateTime releaseTime)
        {
            Movie movie = new Movie();
            movie.Title = title;
            movie.Director = director;
            movie.Category = category;
            movie.Price = price;
            movie.Penalty = penalty;
            movie.Year_Limitation = yearLimitation;
            movie.Relase_Date = releaseTime;
            int ID;
            new Thread(()=> MessageBox.Show("Film jest dodawany do bazy danych")).Start();
            using (filmyEntities f = new filmyEntities())
            {
                if (f.Movie.FirstOrDefault(c => c.Title == title && c.Director == director && c.Relase_Date == releaseTime) != null)
                {
                    _logger.LogError("Film o podanych parametrach już istnieje w bazie danych");
                    return;
                }
                f.Movie.Add(movie);
                f.SaveChanges();
                ID = movie.ID_Movie;
            }
          
            for (int i = 0; i < numOfCopies; i++)// dodaję egzemplaże
            {
                using (filmyEntities f = new filmyEntities())
                {
                    Movie_Instance instance = new Movie_Instance();
                    instance.FK_ID_Movie = ID;
                    instance.Is_Rented = false;
                    f.Movie_Instance.Add(instance);
                    f.SaveChanges();
                }
            }
            _logger.LogMessage("Film został dodany!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBFilmy.Forms
{
    public class ModifyMovie
    {
        private List<Movie> _movieList;
        private readonly DataGridViewRow _rowData;
        private readonly int _indexOfRow;

        public ModifyMovie(List<Movie> movieList, DataGridViewRow rowData, int indexOfRow)
        {
            _movieList = movieList;
            _rowData = rowData;
            _indexOfRow = indexOfRow;
        }

        public void ChangeData()
        {
            using (filmyEntities entities = new filmyEntities())
            {
                var movie = entities.Movie.Find(_movieList[_indexOfRow].ID_Movie);
                movie.Title = _rowData.Cells["Title"].Value.ToString();
                movie.Director = _rowData.Cells["Director"].Value.ToString();
                movie.Relase_Date = DateTime.Parse(_rowData.Cells["ReleaseDate"].Value.ToString());
                movie.Category = _rowData.Cells["Category"].Value.ToString();
                movie.Price = Int32.Parse(_rowData.Cells["Price"].Value.ToString());
                movie.Penalty = Int32.Parse(_rowData.Cells["Penalty"].Value.ToString());
                movie.Year_Limitation = Int32.Parse(_rowData.Cells["YearLimitation"].Value.ToString());
                entities.SaveChanges();
            }
        }
        
    }
}
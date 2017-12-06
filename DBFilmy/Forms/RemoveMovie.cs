using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DBFilmy.Forms
{
    public class RemoveMovie
    {
        private List<Movie> _movieList;
        private readonly DataGridViewRow _rowData;
        private readonly int _indexOfRow;

        public RemoveMovie(List<Movie> movieList, DataGridViewRow rowData, int indexOfRow)
        {
            _movieList = movieList;
            _rowData = rowData;
            _indexOfRow = indexOfRow;
        }
        public void ChangeData()
        {
            using (filmyEntities entities = new filmyEntities())
            {
                entities.Movie_Instance.RemoveRange(entities.Movie_Instance.Where(e => e.FK_ID_Movie == _movieList[_indexOfRow].ID_Movie));
                entities.Movie.Remove(_movieList[_indexOfRow]);//remove movie
                entities.SaveChanges();
            }
        }
    }
}
﻿using System.Collections.Generic;
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
                // find and delete all Transactions
                int IDToCheck = _movieList[_indexOfRow].ID_Movie;
                var movieInstancesContainingMovieID = entities.Movie_Instance.Where(e => e.FK_ID_Movie == IDToCheck).ToList(); // find all instances
                foreach (var instance in movieInstancesContainingMovieID)
                {
                    IDToCheck = instance.ID_Movie_Instance;
                    entities.Transactions.RemoveRange(entities.Transactions.Where(e =>
                        e.FK_ID_Movie_Instance == IDToCheck)); // get IDs of that instances and remove it form transaction
                }
                // remove instances
                IDToCheck = _movieList[_indexOfRow].ID_Movie;
                entities.Movie_Instance.RemoveRange(entities.Movie_Instance.Where(e => e.FK_ID_Movie == IDToCheck));
                // removd movie
                var x = _movieList[_indexOfRow].ID_Movie;
                entities.Movie.RemoveRange(entities.Movie.Where(e => e.ID_Movie ==x));
                entities.SaveChanges();
            }
        }
    }
}
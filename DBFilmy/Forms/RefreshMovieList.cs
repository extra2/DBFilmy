﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DBFilmy.Forms
{
    public class RefreshMovieList
    {
        private DataGridView _movies;
        private string _title;
        private string _director;
        private string _category;

        public RefreshMovieList(DataGridView moviesList, string title, string director, string category)
        {
            _movies = moviesList;
            _title = title;
            _director = director;
            _category = category;
           // Refresh();
        }

        public void Refresh()
        {
            if (string.IsNullOrEmpty(_title)) _title = "";
            if (string.IsNullOrEmpty(_director)) _director = "";
            if (string.IsNullOrEmpty(_category)) _category = "";
            using (filmyEntities entities = new filmyEntities())
            {
                var x = entities.Movie.Where(c => c.Title.Contains(_title) && c.Director.Contains(_director) && c.Category.Contains(_category));
                _movies.Rows.Clear();
                foreach (var movie in x)
                {
                    DataGridViewRow r = _movies.Rows[_movies.Rows.Add()];//new DataGridViewRow();
                    r.Cells["Title"].Value = movie.Title;
                    r.Cells["Director"].Value = movie.Director;
                    r.Cells["ReleaseDate"].Value = movie.Relase_Date;
                    r.Cells["Category"].Value = movie.Category;
                    r.Cells["Price"].Value = movie.Price;
                    r.Cells["Penalty"].Value = movie.Penalty;
                    r.Cells["YearLimitation"].Value = movie.Year_Limitation;
                    // count number of copies
                    var querry = entities.Movie.Join(entities.Movie_Instance,
                            s => s.ID_Movie,
                            c => c.FK_ID_Movie,
                            (s, c) => new {s, c}).Where(sc => sc.c.FK_ID_Movie == movie.ID_Movie && sc.c.Is_Rented == false).Select(sc => sc.s)
                        .Count();
                    r.Cells["Copies"].Value = querry;
                }
            }
        }
    }
}
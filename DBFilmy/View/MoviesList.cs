using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFilmy.Forms
{
    public partial class MoviesList : Form
    {
        private readonly ILogger _logger;
        private List<Movie> movieList = new List<Movie>();
        public MoviesList(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
            buttonRefresh_Click(null, null);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            movieList = new RefreshMovieList(dataGridViewMovies, textBoxTitle.Text, textBoxDirector.Text, textBoxCategory.Text, ref movieList).Refresh();
        }

        private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                if (e.ColumnIndex == 9)
                {
                    new ModifyMovie(movieList, dataGridViewMovies.Rows[rowIndex], rowIndex).ChangeData();
                    movieList = new RefreshMovieList(dataGridViewMovies, textBoxTitle.Text, textBoxDirector.Text, textBoxCategory.Text, ref movieList).Refresh();
                }
                if (e.ColumnIndex == 10)
                {
                    new RemoveMovie(movieList, dataGridViewMovies.Rows[rowIndex], rowIndex).ChangeData();
                    movieList = new RefreshMovieList(dataGridViewMovies, textBoxTitle.Text, textBoxDirector.Text, textBoxCategory.Text, ref movieList).Refresh();
                }
            }
        }
    }
}

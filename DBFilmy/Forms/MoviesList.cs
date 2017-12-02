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

        public MoviesList(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            new RefreshMovieList(dataGridViewMovies, textBoxTitle.Text, textBoxDirector.Text, textBoxCategory.Text).Refresh();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFilmy.Forms;

namespace DBFilmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        { // add client not movie
            new AddUser(new MessageBoxLogger()).Show();
        }

        private void buttonAddNewMovie_Click(object sender, EventArgs e)
        {
            new AddNewMovie(new MessageBoxLogger()).Show();
        }

        private void buttonListOfMovies_Click(object sender, EventArgs e)
        {
            new MoviesList(new MessageBoxLogger()).Show();
        }
    }
}

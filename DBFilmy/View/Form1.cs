using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFilmy.Forms;
using DBFilmy.View;

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
        private void buttonRent_Click(object sender, EventArgs e)
        {
            new RentForm(new MessageBoxLogger()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ReturnMovie(new MessageBoxLogger()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ClientTransactions().Show();
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            new Statistics().Show();
        }
    }
}

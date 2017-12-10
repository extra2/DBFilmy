using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFilmy
{
    public partial class RentForm : Form
    {
        private ILogger _logger;
        public RentForm(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            new Rent(textBoxIDClient.Text, textBoxIDMovie.Text).RentMovie();
        }
    }
}

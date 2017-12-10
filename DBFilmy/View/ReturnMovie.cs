using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFilmy
{
    public partial class ReturnMovie : Form
    {
        private readonly ILogger _logger;

        public ReturnMovie(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void buttonCalculateBill_Click(object sender, EventArgs e)
        {
            new CalculateBill(textBoxMovieID.Text).Calculate();
        }

        private void buttonReturnMovie_Click(object sender, EventArgs e)
        {
            new ReturnMovieToDb(textBoxMovieID.Text).Return();
        }
    }
}

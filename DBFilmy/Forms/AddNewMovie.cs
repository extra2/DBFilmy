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
    public partial class AddNewMovie : Form
    {
        private readonly ILogger _logger;

        public AddNewMovie(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCategory.Text) && !string.IsNullOrEmpty(textBoxDirector.Text) && !string.IsNullOrEmpty(textBoxNumOfCopies.Text) &&
                !string.IsNullOrEmpty(textBoxPenalty.Text) && !string.IsNullOrEmpty(textBoxPrice.Text) && !string.IsNullOrEmpty(textBoxTitle.Text) &&
                !string.IsNullOrEmpty(textBoxYearLimit.Text))
            {
                try
                {
                    Int32.Parse(textBoxPenalty.Text);
                    Int32.Parse(textBoxYearLimit.Text);
                    Int32.Parse(textBoxPrice.Text);
                    Int32.Parse(textBoxNumOfCopies.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sprawdź pola:\nOgraniczenie wiekowe\nCena za tydzień\nKara za przetrzymanie\nIlość sztuk");
                    return;
                }
                new AddMovie(textBoxTitle.Text, textBoxDirector.Text, textBoxCategory.Text, Int32.Parse(textBoxPrice.Text), Int32.Parse(textBoxPenalty.Text), Int32.Parse(textBoxNumOfCopies.Text), Int32.Parse(textBoxYearLimit.Text), dateTimePickerReleaseDate.Value.Date);
                this.Close();
            }
        }
    }
}

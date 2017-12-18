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
    public partial class Statistics : Form
    {
        private string stats = "";
        public Statistics()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadStatistics()
        {
            using (filmyEntities entities = new filmyEntities())
            {
                var x = entities.TopFilm().ToList();
                if (x == null)
                {
                    MessageBox.Show("Brak statystyk do wyświetlenia");
                    this.Close();
                }
                stats = "Najczęściej wypożyczany film: " + x[0].Title;
                stats += "\r\nZostał wypożyczony " + x[0].Count.ToString() + " razy";
            }
            textBoxStats.Text = stats;
        }
    }
}

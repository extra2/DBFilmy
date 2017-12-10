using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFilmy.View
{
    public partial class ClientTransactions : Form
    {
        public ClientTransactions()
        {
            InitializeComponent();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(textBoxRefresh.Text);
            }
            catch (Exception exception)
            {
                Thread cantParse = new Thread(() => MessageBox.Show("Sprawdź ID klienta."));
                return;
            }
            new PresentUserData(textBoxRefresh.Text, ref dataGridView1).ShowData();
        }
    }

    public class PresentUserData
    {
        private readonly string _id;
        private DataGridView _dataGrid;

        public PresentUserData(string ID, ref DataGridView dataGrid)
        {
            _id = ID;
            _dataGrid = dataGrid;
        }

        public void ShowData()
        {
            using (filmyEntities entities = new filmyEntities())
            {
                int id = Int32.Parse(_id);
                var view = entities.MoviesRentedByAUser.Where(e => e.ID_client == id).ToList();
                foreach (var _view in view)
                {
                    DataGridViewRow row = _dataGrid.Rows[_dataGrid.Rows.Add()];
                    row.Cells["ClientID"].Value = _view.ID_client;
                    row.Cells["Client"].Value = _view.Name + " " + _view.Surname;
                    row.Cells["Title"].Value = _view.Title;
                    // is returned?
                    string isReturned = "";
                    if (_view.Is_Rented.Value == true) isReturned = "NIE";
                    else isReturned = "TAK";
                    row.Cells["Returned"].Value = isReturned;
                    // total cost
                    DateTime rentTime = _view.rental_date.Value;
                    int cost = _view.Price.Value;
                    if ((DateTime.Now - rentTime).TotalMinutes > 60 * 24 * 7)
                    {
                        cost += _view.Penalty.Value * (((int)(DateTime.Now - rentTime).TotalMinutes - 60 * 24 * 7) / (60 * 24) + 1);
                    }
                    row.Cells["Cost"].Value = cost.ToString();
                }
            }
        }
    }
}

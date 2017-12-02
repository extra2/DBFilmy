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
    public partial class AddUser : Form
    {
        private readonly ILogger _logger;

        public AddUser(ILogger logger)
        {
            _logger = logger;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxSurname.Text) && !string.IsNullOrEmpty(textBoxPESEL.Text) &&
                !string.IsNullOrEmpty(textBoxStreet.Text) && !string.IsNullOrEmpty(textBoxCity.Text) && !string.IsNullOrEmpty(textBoxPostCode.Text) && !string.IsNullOrEmpty(textBoxHouseNum.Text))
            {
                if (!textBoxPESEL.Text.IsValidPESEL())
                {
                    _logger.LogError("Zły numer PESEL");
                    return;
                }
                if(textBoxPostCode.Text.Length != 6)
                {
                    _logger.LogError("Zły kod pocztowy");
                    return;
                }
                try
                {
                    Int32.Parse(textBoxHouseNum.Text);
                    Int32.Parse(textBoxFlatNum.Text);
                }
                catch (Exception)
                {
                    _logger.LogError("Zły numer domu lub numer budynku");
                    return;
                }
                new AddNewUser(textBoxName.Text, textBoxSurname.Text, textBoxPESEL.Text, textBoxStreet.Text, textBoxCity.Text, textBoxPostCode.Text, Int32.Parse(textBoxHouseNum.Text), Int32.Parse(textBoxFlatNum.Text));
                this.Close();
            }
            else
            {
                _logger.LogError("Wszystkie pola muszą być wypełnione");
            }
        }
       
    }
}

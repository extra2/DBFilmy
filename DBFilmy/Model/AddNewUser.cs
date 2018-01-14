using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFilmy
{
    class AddNewUser
    {
        public AddNewUser(string name, string surname, string PESEL, string Street, string City, string PostNumber, int HouseNum, int FlatNum)
        {
            Client client = new Client();
            client.Name = name;
            client.Surname = surname;
            client.PESEL = PESEL;
            client.street = Street;
            client.city = City;
            client.post_number = PostNumber;
            client.house_number = HouseNum;
            client.flat_number = FlatNum;
            using (filmyEntities f = new filmyEntities())
            {
                if(f.Client.FirstOrDefault(c => c.PESEL == client.PESEL) != null)
                {
                    MessageBox.Show("Klient z numerem PESEL " + client.PESEL + " jest już zarejestrowany", "Klient istnieje");
                    return;
                }
                f.Client.Add(client);
                f.SaveChanges();
                MessageBox.Show("Klient " + client.Name + " " + client.Surname + " dodany.\nNumer ID klienta: " + client.ID_client, "Klient dodany");
            }
        }
    }
}

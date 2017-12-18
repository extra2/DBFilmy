using System;
using System.Threading;
using System.Windows.Forms;

namespace DBFilmy
{
    public class Rent
    {
        private readonly string _userId;
        private readonly string _movieId;

        public Rent(string userId, string movieId)
        {
            _userId = userId;
            _movieId = movieId;
        }

        public void RentMovie()
        {
            try
            {
                Int32.Parse(_userId);
                Int32.Parse(_movieId);
            }
            catch (Exception e)
            {
                Thread badData = new Thread(() => MessageBox.Show("Wprowadzono niepoprawne dane!"));
                badData.Start();
                return;
            }
            using (filmyEntities entities = new filmyEntities())
            {
                int userID = Int32.Parse(_userId);
                int movieID = Int32.Parse(_movieId);
                var instance = entities.Movie_Instance.Find(movieID);
                var user = entities.Client.Find(userID);
                if (user == null)
                {
                    Thread badData2 = new Thread(() => MessageBox.Show("Użytkownik o podanym ID nie istnieje!"));
                    badData2.Start();
                    return;
                }
                if (instance == null)
                {
                    Thread badData21 = new Thread(() => MessageBox.Show("Płyta o podanym ID nie istnieje!"));
                    badData21.Start();
                    return;
                }
                if (instance.Is_Rented == true)
                {
                    Thread badData3 = new Thread(() => MessageBox.Show("Ta kopia filmu jest już wypożyczona!"));
                    badData3.Start();
                    return;
                }
                Transactions newTransaction = new Transactions();
                newTransaction.FK_ID_Movie_Instance = instance.ID_Movie_Instance;
                newTransaction.FK_ID_Clients = user.ID_client;
                newTransaction.rental_date = DateTime.Now;
                instance.Is_Rented = true;
                //entities.Movie_Instance.
                //entities.Movie_Instance.AddOrUpdate(instance);
                entities.Transactions.Add(newTransaction);
                entities.SaveChanges();
                Thread badData4 = new Thread(() => MessageBox.Show("Film został wypożyczony!"));
                badData4.Start();
            }
        }
    }
}
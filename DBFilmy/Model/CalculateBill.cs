using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DBFilmy
{
    public class CalculateBill
    {
        private readonly string _id;

        public CalculateBill(string ID)
        {
            _id = ID;
        }

        public void Calculate()
        {
            try
            {
                Int32.Parse(_id);
            }
            catch (Exception e)
            {
                Thread errorParsing = new Thread(() => MessageBox.Show("Nie można przekonwertować ID. Wprowadź poprawne dane!"));
                errorParsing.Start();
                return;
            }
            int ID = Int32.Parse(_id);
            using (filmyEntities entities = new filmyEntities())
            {
                var transaction = entities.Transactions.OrderByDescending(e => e.rental_date)
                    .FirstOrDefault(e => e.FK_ID_Movie_Instance == ID);
                if (transaction == null)
                {
                    Thread errorNoTransaciton = new Thread(() => MessageBox.Show("Transakcja nie została znaleziona!"));
                    errorNoTransaciton.Start();
                    return;
                }
                DateTime rentedTime = transaction.rental_date.Value;
                if (rentedTime == DateTime.MinValue)
                {
                    Thread errorNotRented = new Thread(() => MessageBox.Show("Film nie jest wypożyczony!"));
                    errorNotRented.Start();
                    return;
                }
                var instance = entities.Movie_Instance.Find(ID);
                if (instance.Is_Rented.Value == false)
                {
                    Thread notRented = new Thread(() => MessageBox.Show("Film nie jest wypożyczony!"));
                    notRented.Start();
                    return;
                }
                int movieID = instance.FK_ID_Movie.Value;
                var movie = entities.Movie.Find(movieID);
                var rentedTimeDiff = DateTime.Now - rentedTime;
                int overTime = (int)rentedTimeDiff.TotalMinutes - 60*24*7;
                if (overTime <= 0)
                {
                    MessageBox.Show("Film: " + movie.Title + "\nDo zapłaty: " + movie.Price + "zł");
                    return;
                }
                else
                {
                    int penalty = movie.Penalty.Value * (overTime / 60 * 24 * 7 + 1);
                    MessageBox.Show("Film: " + movie.Title + "\nDo zapłaty: " + movie.Price + "zł\n" + "Kara za przetrzymanie: " + penalty);
                    return;
                }
            }
        }
    }
}
using System;
using System.Threading;
using System.Windows.Forms;

namespace DBFilmy
{
    public class ReturnMovieToDb
    {
        private readonly string _id;

        public ReturnMovieToDb(string ID)
        {
           _id = ID;
        }

        public void Return()
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
                var movie_instance = entities.Movie_Instance.Find(ID);
                if (movie_instance.Is_Rented == false)
                {
                    Thread notRented = new Thread(() => MessageBox.Show("Film nie jest wypożyczony"));
                    notRented.Start();
                    return;
                }
                movie_instance.Is_Rented = false;
                entities.SaveChanges();
                Thread returned = new Thread(() => MessageBox.Show("Film został zwrócony"));
                returned.Start();
                return;
            }
        }
    }
}
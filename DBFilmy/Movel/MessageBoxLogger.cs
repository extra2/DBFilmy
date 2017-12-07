using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFilmy
{
    class MessageBoxLogger: ILogger
    {
        public void LogMessage(string message)
        {
            MessageBox.Show(message, "Message");
        }

        public void LogError(string message)
        {
            MessageBox.Show(message, "ERROR");
        }

        public void LogMessage(string path, string message)
        {
            throw new NotImplementedException();
        }
    }
}

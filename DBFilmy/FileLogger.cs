using System;
using System.IO;

namespace DBFilmy
{
    class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(string path, string message)
        {
            File.AppendAllText(path, message + "\r\n");
        }
    }
}
namespace DBFilmy
{
    public interface ILogger
    {
        void LogMessage(string message);
        void LogError(string message);
        void LogMessage(string path, string message);
    }
}
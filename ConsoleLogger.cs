using System;

namespace Extensibility
{
    /// <summary>
    /// Emite mensagens de log no console
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        private void Log(string message, string messageType)
        {
            Console.WriteLine($"({DateTime.Now:dd/MM/yyyy HH:mm:ss}) {messageType}: {message}");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogWarning(string message)
        {
            Log(message, "WARNING");
        }
    }
}
using System;
using System.IO;

namespace Extensibility
{
    /// <summary>
    /// Grava mensagens de log em arquivo de texto
    /// </summary>
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void Log(string message, string messageType)
        {
            using var streamWriter = new StreamWriter(_path, true);
            streamWriter.WriteLine($"({DateTime.Now:dd/MM/yyyy HH:mm:ss}) {messageType}: {message}");
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
namespace Extensibility
{
    /// <summary>
    /// Assinatura padrão para as classes que emitem/gravam logs
    /// </summary>
    public interface ILogger
    {
        public void LogInfo(string message);

        public void LogError(string message);

        public void LogWarning(string message);
    }
}
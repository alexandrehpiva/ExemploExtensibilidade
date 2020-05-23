using System.IO;

namespace Extensibility
{
    /// <summary>
    /// Como exemplo de extensibilidade, esse projeto demonstra uma classe AccessControl
    /// que controla o acesso ao sistema.
    ///
    /// Entre na classe AccessControl assim como nas classes que implementam a interface
    /// ILogger para melhor entendimento.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var username = "alexandre";
            var password = "Abc123!";

            // Exemplo de logs usando console
            var secondAccessExample = new AccessControl(new ConsoleLogger());
            secondAccessExample.Login(username, password);

            // Exemplo de gravação de logs em arquivo de texto
            var logDirectory = $"{Directory.GetCurrentDirectory()}\\log.txt";
            var firstAccessExample = new AccessControl(new FileLogger(logDirectory));
            firstAccessExample.Login(username, password);
        }
    }
}

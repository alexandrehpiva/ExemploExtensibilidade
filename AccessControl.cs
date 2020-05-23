namespace Extensibility
{
    /// <summary>
    /// Responsável por controlar entrada/login de usuários
    /// 
    /// A classe AccessControl não está acoplada diretamente com nenhuma classe que grava
    /// logs, mas sim com uma inteface, que é como um acordo comum que determina o que uma
    /// classe do tipo ILogger precisa fazer.
    /// </summary>
    public class AccessControl
    {
        private readonly ILogger _logger;

        public AccessControl(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Simples exemplo de Login utilizando Usuário e Senha
        /// </summary>
        /// <param name="username">Nome de acesso do usuário</param>
        /// <param name="password">Senha de acesso do usuário</param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                _logger.LogError("Dados inválidos.");
                return false;
            }

            // TODO: Implementação da verificação dos dados do usuário e login
            if (username != "alexandre" || password != "Abc123!")
            {
                _logger.LogWarning($"Tentativa falha de login utilizando o usuário: {username}.");
                return false;
            }

            _logger.LogInfo($"O usuário {username} efetuou login.");
            return true;
        }
    }
}
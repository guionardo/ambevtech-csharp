namespace _04_02_ConfigClass
{
    /// <summary>
    /// Classe de configuração
    /// </summary>
    /// <exception cref="Exception">Lança exceção em caso de variáveis de ambiente com conteúdo inválido</exception>
    public record ConfigClass
    {
        /// <summary>
        /// String de conexão ao MongoDB: Deve iniciar com mongodb://
        /// </summary>
        public string DbConnectionString { get; }
        public int MaxConnectedUsers { get; }
        public bool Debug { get; }

        public ConfigClass()
        {
            DbConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            // Deve iniciar com "mongodb://"
            if (string.IsNullOrEmpty(DbConnectionString))
            {
                throw new Exception("DB_CONNECTION_STRING É VAZIA");
            }
            if (!DbConnectionString.StartsWith("mongodb://"))
            {
                throw new Exception("DB_CONNECTION_STRING COM VALOR INVÁLIDO");
            }
            
            // Deve ser um inteiro entre 10 e 1000
            if (int.TryParse(Environment.GetEnvironmentVariable("MAX_CONNECTED_USERS"),out var maxConnectedUsers))
            {
                if (maxConnectedUsers < 10 || maxConnectedUsers > 1000)
                {
                    throw new Exception("MAX_CONNECTED_USERS FORA DO INTERVALO");
                }
                MaxConnectedUsers= maxConnectedUsers;
            }
            else
            {
                throw new Exception("MAX_CONNECTED_USERS INVÁLIDO");
            }

            // True deve ser representado por "1"
            Debug = Environment.GetEnvironmentVariable("DEBUG") == "1";
        }

    }
}
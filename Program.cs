using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Carregar as configurações do appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // Obter a string de conexão
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Testar a conexão
        using (var connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexão com o banco de dados bem-sucedida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na conexão: " + ex.Message);
            }
        }
    }
}

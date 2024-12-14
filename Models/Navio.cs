using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

public class Navio
{
    public int ID_NAVIO { get; set; }
    public string NOME_NAVIO { get; set; }
    public string PORTO { get; set; }
    public string MODAL { get; set; }

    //Construtor
    public Navio (int id_navio, string nome_navio, string porto, string modal)
    {
        this.ID_NAVIO = id_navio;
        this.NOME_NAVIO = nome_navio;
        this.PORTO = porto;
        this.MODAL = modal;
    }

    //Metodo para buscar navios
    public static List<Navio> buscarNavio()
    {
        List<Navio> Navio = new List<Navio>();

        string query = "SELECT ID_NAVIO, NOME_NAVIO, PORTO, MODAL FROM Navio";
        
        try
        {
            using(MySqlConnection connection = new Conexao().GetConnection())
            {
                connection.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            //Criando o objeto Navio com tudo que existe na tabela
                            Navio navio = new Navio(
                                reader.GetInt32("ID_NAVIO"),
                                reader.GetString("NOME_NAVIO"),
                                reader.GetString("PORTO"),
                                reader.GetString("MODAL")
                            );

                            Navio.Add(navio);
                        }
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Erro" + ex.Message);
        }
        return Navio;
    }
}
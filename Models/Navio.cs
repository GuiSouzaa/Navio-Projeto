using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
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

    public static void cadastrarNavio(int id_navio, string nome_navio, string porto, string modal)
    {
        string query = "INSERT INTO Navio (ID_NAVIO, NOME_NAVIO, PORTO, MODAL)" +
                       "VALUES (@ID_NAVIO, @NOME_NAVIO, @PORTO, @MODAL)";
        
        try
        {
            using(MySqlConnection connection = new Conexao().GetConnection())
            {
                connection.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_NAVIO", id_navio);
                    cmd.Parameters.AddWithValue("@NOME_NAVIO", nome_navio);
                    cmd.Parameters.AddWithValue("@PORTO", porto);
                    cmd.Parameters.AddWithValue("@MODAL", modal);

                    cmd.ExecuteNonQuery();
                }

            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Erro" + ex.Message);
        }
    }

    public static void atualizarNavio(int id_navio, string nome_navio, string porto, string modal)
    {   
        string query = "UPDATE Navio SET " +
                       "NOME_NAVIO = @NOME_NAVIO, " +
                       "PORTO = @PORTO, " +
                       "MODAL = @MODAL " +
                       "WHERE ID_NAVIO = @ID_NAVIO";
           
        try
        {
            using(MySqlConnection connection = new Conexao().GetConnection())
            {
                connection.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_NAVIO", id_navio);
                    cmd.Parameters.AddWithValue("@NOME_NAVIO", nome_navio);
                    cmd.Parameters.AddWithValue("@PORTO", porto);
                    cmd.Parameters.AddWithValue("@MODAL", modal);

                    int rowsAfected = cmd.ExecuteNonQuery();

                    if(rowsAfected > 0)
                    {
                        Console.WriteLine("Navio atualizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Erro!");
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Erro" + ex.Message);
        }
      
    }

    public static void deletarNavio (int id_navio)
    {
        string query = "DELETE FROM Navio WHERE ID_NAVIO = @ID_NAVIO";

        try
        {
            using(MySqlConnection connection = new Conexao().GetConnection())
            {
                connection.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_NAVIO", id_navio);
                    int rowsAfected = cmd.ExecuteNonQuery();

                    if (rowsAfected > 0)
                    {
                        Console.WriteLine($"O navio com o id:'{id_navio}'foi deletado");
                    }
                    else
                    {
                       Console.WriteLine("Erro!");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro" + ex.Message);
        }
    }
}
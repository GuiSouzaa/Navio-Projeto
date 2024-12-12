using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class Fornecedor
{
    public string ID_FORNECEDOR { get; set; }
    public string REFERENCIA_ID { get; set; }
    public string NOME_FORNECEDOR { get; set; }
    public string NOME_CONTATO { get; set; }
    public string FONE_ZAP { get; set; }
    public string EMAIL { get; set; }

    // Construtor
    public Fornecedor(string id_fornecedor, string referencia_id, string nome_fornecedor, string nome_contato, string fone_zap, string email)
    {
        this.ID_FORNECEDOR = id_fornecedor;
        this.REFERENCIA_ID = referencia_id;
        this.NOME_FORNECEDOR = nome_fornecedor;
        this.NOME_CONTATO = nome_contato;
        this.FONE_ZAP = fone_zap;
        this.EMAIL = email;
    }

    // Método estático para buscar os fornecedores dentro do banco de dados
    public static List<Fornecedor> BuscarFornecedores()
    {
        List<Fornecedor> Fornecedor = new List<Fornecedor>();
        
        string query = "SELECT ID_FORNECEDOR, REFERENCIA_ID, NOME_FORNECEDOR, NOME_CONTATO, FONE_ZAP, EMAIL FROM Fornecedor";

        try
        {
            using (MySqlConnection connection = new Conexao().GetConnection()) // Obtendo a conexão com o banco de dados
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Criando o objeto Fornecedor com todos os dados do banco
                            Fornecedor fornecedor = new Fornecedor(
                                reader.GetString("ID_FORNECEDOR"),
                                reader.GetString("REFERENCIA_ID"),
                                reader.GetString("NOME_FORNECEDOR"),
                                reader.GetString("NOME_CONTATO"),
                                reader.GetString("FONE_ZAP"),
                                reader.GetString("EMAIL")
                            );

                            Fornecedor.Add(fornecedor); // Adicionando o fornecedor à lista
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
        }

        return Fornecedor; // Retornando a lista de fornecedores
    }


    //Metodo para adicionar fornecedores
  public static void CadastrarFornecedor(string id_fornecedor, string referencia_id, string nome_fornecedor, string nome_contato, string fone_zap, string email)
{
    string query = "INSERT INTO Fornecedor (ID_FORNECEDOR, REFERENCIA_ID, NOME_FORNECEDOR, NOME_CONTATO, FONE_ZAP, EMAIL) " +
                   "VALUES (@ID_FORNECEDOR, @REFERENCIA_ID, @NOME_FORNECEDOR, @NOME_CONTATO, @FONE_ZAP, @EMAIL)";

    try
    {
        using (MySqlConnection connection = new Conexao().GetConnection()) // Faz a conexão com o banco de dados
        {
            connection.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                // Adiciona os parâmetros à consulta SQL
                cmd.Parameters.AddWithValue("@ID_FORNECEDOR", id_fornecedor);
                cmd.Parameters.AddWithValue("@REFERENCIA_ID", referencia_id);
                cmd.Parameters.AddWithValue("@NOME_FORNECEDOR", nome_fornecedor);
                cmd.Parameters.AddWithValue("@NOME_CONTATO", nome_contato);
                cmd.Parameters.AddWithValue("@FONE_ZAP", fone_zap);
                cmd.Parameters.AddWithValue("@EMAIL", email);

                // Executa a consulta SQL
                cmd.ExecuteNonQuery();
            }
        }

        //Console.WriteLine("Fornecedor cadastrado com sucesso!"); //Já tem um CW no principal.
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro ao cadastrar fornecedor: " + ex.Message);
    }
}

}

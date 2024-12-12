using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Chama a função para cadastrar um fornecedor
        //CadastrarFornecedor();

        // Chama a função para buscar e exibir todos os fornecedores cadastrados
        BuscarFornecedores();
    }

    // Função para cadastrar um fornecedor
    public static void CadastrarFornecedor()
    {
        string id_fornecedor = "f500";
        string referencia_id = "REF005";
        string nome_fornecedor = "Fornecedor ibsen";
        string nome_contato = "Contato B";
        string fone_zap = "12389";
        string email = "ibsen@exemplo.com";

        // Chama o método para cadastrar o fornecedor
        Fornecedor.CadastrarFornecedor(id_fornecedor, referencia_id, nome_fornecedor, nome_contato, fone_zap, email);
        Console.WriteLine("Fornecedor cadastrado com sucesso!");
    }

    // Função para buscar e exibir todos os fornecedores cadastrados
    public static void BuscarFornecedores()
    {
        List<Fornecedor> fornecedores = Fornecedor.BuscarFornecedores();

        foreach (var fornecedor in fornecedores)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"ID_FORNECEDOR: {fornecedor.ID_FORNECEDOR}");
            Console.WriteLine($"REFERENCIA_ID: {fornecedor.REFERENCIA_ID}");
            Console.WriteLine($"NOME_FORNECEDOR: {fornecedor.NOME_FORNECEDOR}");
            Console.WriteLine($"NOME_CONTATO: {fornecedor.NOME_CONTATO}");
            Console.WriteLine($"FONE_ZAP: {fornecedor.FONE_ZAP}");
            Console.WriteLine($"EMAIL: {fornecedor.EMAIL}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}

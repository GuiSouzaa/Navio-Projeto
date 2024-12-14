using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {   //--------------------------------------------------------------------------------------

        // Bloco para chamar funções e realizar testes unitarios CLASSE FORNECEDOR! CRUD

            //CadastrarFornecedor();
            //BuscarFornecedores();
            //AtualizarFornecedor();
            //DeletarFornecedor();

        //--------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------

        // Bloco para chamar funções e realizar testes unitarios CLASSE NAVIO!

            //buscarNavio();

        //--------------------------------------------------------------------------------------
    }


    //Funções Fornecedor

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

     public static void AtualizarFornecedor()
    {
        string id_fornecedor = "f800";
        string referencia_id = "REF999";
        string nome_fornecedor = "guilherme Alterado";
        string nome_contato = "Contato Alterado";
        string fone_zap = "98765";
        string email = "fornecedor_alterado@exemplo.com";

        Fornecedor.AtualizarFornecedor(id_fornecedor, referencia_id, nome_fornecedor, nome_contato, fone_zap, email);
        Console.WriteLine("Fornecedor atualizado com sucesso!");
    }

    public static void DeletarFornecedor()
    {
        //Definir o id que eu quero deletar
        string id_fornecedor = "f500";

        //Chama a função para realizar o delete
        Fornecedor.DeletarFornecedor(id_fornecedor);

        Console.WriteLine($"Processo de exclusão do fornecedor com ID {id_fornecedor} finalizado.");
    }

        // Funções dos Navios
    public static void buscarNavio()
    {
        List<Navio> navios = Navio.buscarNavio();
        foreach (var navio in navios)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"ID_NAVIO: {navio.ID_NAVIO}");
            Console.WriteLine($"NOME_NAVIO: {navio.NOME_NAVIO}");
            Console.WriteLine($"PORTO: {navio.PORTO}");
            Console.WriteLine($"MODAL: {navio.MODAL}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}

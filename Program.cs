public class Program
{
    public static void Main(string[] args)
    {
        List<Fornecedor> fornecedores = Fornecedor.BuscarFornecedores();

        foreach (var fornecedor in fornecedores)
        {
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

public class Program
{
    public static void Main(string[] args)
    {
        // Instanciando o objeto Fornecedor
        Fornecedor Ibsen = new Fornecedor(1);
        Fornecedor Guilherme = new Fornecedor(2);

        //Exibir oque eles tem, lembrando que por conta do id eu sei oque cada um pode ter
        Ibsen.ExibirProdutos();
        Guilherme.ExibirProdutos();
        
    }
}
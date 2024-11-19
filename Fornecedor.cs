public class Fornecedor
{
    public int Id { get; set; }
    public List<String> Produtos {get; set;}

    // Construtor
    public Fornecedor(int id)
    {
        Id = id;
        Produtos = new List<String>(); //Incia a lista de produtos vazia.
        DefinirProdutos(); //Vai definir com base no ID.
    }

    //Metodo que define os produtos com base no ID do fornecedor.
    public void DefinirProdutos()
    {
        if(Id == 1)
        {
            Produtos.Add("Carne de boi");
            Produtos.Add("Carne de Frango");
        }

        else if(Id == 2)
        {
            Produtos.Add("Frutas vermelhas");
        }

        else
        {
            Console.WriteLine("Fornecedor não cadastrado no sistema");
        }

    }
    
    public void ExibirProdutos()
    {
        System.Console.WriteLine($"O fornecedor {Id} pode oferecer os seguintes Produtos: ");

        foreach (var produto in Produtos)
        {
            System.Console.WriteLine(produto);
        }
    }
};

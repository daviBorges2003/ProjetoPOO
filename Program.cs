using trabalho.Model.Produtos;
using trabalho.Model.Users;

class SistemaEstadio
{
    static void Main(string[] args)
    {
        // Criando produtos
        Ingresso ingresso = new Ingresso(1, "Final do Campeonato", 150.0, 1, new DateTime(2024, 12, 15));
        ProdutoEsportivo camisa = new ProdutoEsportivo(2, "Camisa Oficial", 120.0, "Vestuário", "M");

        Usuario comprador1 = new Usuario(1 , "Davi" , "198796587-60" , "joao.silva@gmail.com" , "@Joao2024!");

        comprador1.ComprarProduto(ingresso);

    }
}
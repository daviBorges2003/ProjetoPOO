using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho.Model.Produtos;

namespace trabalho.Model.Users
{
    public class Usuario : Pessoa
    {
        public List<Produto> HistoricoCompras { get; private set; }

        public Usuario(int id, string nome, string cpf , string email, string senha) : base(id, nome, cpf ,email, senha)
        {
            HistoricoCompras = new List<Produto>();
        }
        
        public void ComprarProduto(Produto produto)
        {
            produto.Comprador = this;
            HistoricoCompras.Add(produto);
            Console.WriteLine($"Produto comprado: {produto.Nome}");
        }

        public void ExibirHistoricoDeCompra()
        {
            foreach (var produtos in HistoricoCompras)
            {
                   Console.WriteLine($"Produto:{produtos.Nome} -- Preço:{produtos.Preco}");
            }
        }
        public override string ExibirInformacoes()
        {
            return $"Comprador: {Nome}, CPF: {Cpf}, email: {Email}";
        }
    }
}
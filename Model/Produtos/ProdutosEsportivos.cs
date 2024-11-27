using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trabalho.Model.Produtos
{
    class ProdutoEsportivo : Produto
    {
        public string Tipo { get; set; }
        public string Tamanho { get; set; }

        public ProdutoEsportivo(int id, string nome, double preco, string tipo, string tamanho)
            : base(id, nome, preco)
        {
            Tipo = tipo;
            Tamanho = tamanho;
        }

        public override string ExibirDetalhes()
        {
            string detalhesComprador = Comprador != null ? $"Comprado por: {Comprador.Nome}" : "Ainda não comprado";
            return $"Produto Esportivo: {Nome}, Tipo: {Tipo}, Tamanho: {Tamanho}, Preço: {Preco:C} , Comprador: {detalhesComprador}";
        }
    }
}
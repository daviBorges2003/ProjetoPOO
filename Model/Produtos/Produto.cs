using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho.Model.Users;

namespace trabalho.Model.Produtos
{
    public abstract class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Usuario? Comprador { get; set; }

        protected Produto(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Comprador = null ;
        }

        public abstract string ExibirDetalhes();
    }
}
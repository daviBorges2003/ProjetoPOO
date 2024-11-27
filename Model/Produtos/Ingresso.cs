using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho.enums;

namespace trabalho.Model.Produtos
{
    class Ingresso : Produto
{
    public int NumeroCadeira { get; set; }
    public TypeSetor Setor { get; set; }
    public DateTime DataEvento { get; set; }

    public Ingresso(int id, string nome, double preco, double setor, DateTime dataEvento)
        : base(id, nome, preco)
    {
        Setor = (TypeSetor)setor;
        DataEvento = dataEvento;
    }

    public override string ExibirDetalhes()
    {
        string detalhesComprador = Comprador != null ? $"Comprado por: {Comprador.Nome}" : "Não Vendido!";
        return $"Ingresso: {Nome}, Cadeira: {NumeroCadeira} , Setor: {Setor}, Data: {DataEvento.ToShortDateString()}, Preço: {Preco:C}, Comprador: {detalhesComprador}";
    }
}
}
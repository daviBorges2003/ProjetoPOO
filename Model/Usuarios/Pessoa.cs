using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho.enums;

namespace trabalho.Model
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        protected Pessoa(int id, string nome, string cpf, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
        }

        public abstract string ExibirInformacoes();
    }
}
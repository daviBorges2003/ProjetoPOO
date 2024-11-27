using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho.enums;
using trabalho.Model;

namespace trabalho.Model
{
    public class Funcionario : Pessoa
    {
        public TypeFunc Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, string email, string cpf, string senha , decimal cargo , double salario) : base(id, nome, cpf ,email, senha)
        {
            Cargo = (TypeFunc)cargo;
            Salario = salario;
        }

        public override string ExibirInformacoes()
        {
            return $"Funcionário: {Nome}, Cargo: {Cargo}, Salário: {Salario}";
        }
    }
}
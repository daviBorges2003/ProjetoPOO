using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabalho.interfaces;

namespace trabalho.Model.Authenticação
{
    public class Autenticação : iAuth
    {
        private List<Pessoa> usuariosRegistrados;

        public Autenticação()
        {
            usuariosRegistrados = new List<Pessoa>();
        }

        public void RegistrarPessoa(Pessoa pessoa)
        {
            usuariosRegistrados.Add(pessoa);
        }

        public bool Autenticar(string email, string senha)
        {
            foreach (var pessoa in usuariosRegistrados)
            {
                if (pessoa.Email == email && pessoa.Senha == senha)
                {
                    Console.WriteLine($"Autenticação bem-sucedida: {pessoa.Nome}");
                    return true;
                }
            }
            
            Console.WriteLine("Autenticação falhou.");
            return false;
        }
    }
}
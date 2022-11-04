using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCRUD
{
    public class Pessoa
    {
        // Propriedades estáticas
        public static int id = 1;

        // Propriedades de uma pessoa
        public string nome;
        public string email;
        public int numeroPessoa;
        public int idade;

        public Pessoa(string _nome, string _email, int _idade)
        {
            this.nome = _nome;
            this.email = _email;
            this.idade = _idade;
            this.numeroPessoa = id;
            
            id++;
        }
    }
}

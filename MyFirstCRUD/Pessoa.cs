using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCRUD
{
    internal class Pessoa
    {
        // Propriedades estáticas
        public static int id;

        // Propriedades de uma pessoa
        public string nome;
        public string email;
        public int idade;
        public List<Pessoa> pessoas;

        public Pessoa(string _nome, string _email, int _idade)
        {
            this.nome = _nome;
            this.email = _email;
            this.idade = _idade;

            id++;
        }

        public void WritePessoa()
        {
            System.Console.WriteLine("Nome: " + this.nome);
            System.Console.WriteLine("E-mail: " + this.email);
            System.Console.WriteLine("Idade: " + this.idade);
            System.Console.WriteLine("O ID da pessoa é:" + id);
        }

        public void Create()
        {
            if (this.nome == "")
            {
                System.Console.WriteLine("Digite um nome válido!");
                return;
            }else if (this.email == "")
            {
                System.Console.WriteLine("Digite um e-mail válido!");
                return;
            }else if (this.idade < 0 || this.idade == 0)
            {
                System.Console.WriteLine("Digite uma idade válida!");
                return;
            }
            else
            {

                pessoas.Add(new Pessoa(this.nome, this.email, this.idade));
            }
        }
    }
}

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
        public static int id;

        // Propriedades de uma pessoa
        public string nome;
        public string email;
        public int idade;
        public static List<Pessoa> pessoas;

        public Pessoa()
        {
            this.nome = "";
            this.email = "";
            this.idade = 0;
        }

        public Pessoa(string _nome, string _email, int _idade)
        {
            this.nome = _nome;
            this.email = _email;
            this.idade = _idade;
            
            id++;
        }

        public void AddRandomPeople()
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("João", "joao@gmail.com", 20));
        }


        public void WritePessoa()
        {
            System.Console.WriteLine($"Pessoa {id}:");
            System.Console.WriteLine();
            System.Console.WriteLine("Nome: " + this.nome);
            System.Console.WriteLine("E-mail: " + this.email);
            System.Console.WriteLine("Idade: " + this.idade);
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine();
        }

        public void Create()
        {
            this.nome = Console.ReadName();
            this.email = Console.ReadEmail();
            this.idade = Console.ReadAge();
            
            // Verifica se os dados estão corretos
            if (this.nome == "")
            {
                System.Console.WriteLine("Digite um nome válido!");
            }
            else if (this.email == "")
            {
                System.Console.WriteLine("Digite um e-mail válido!");
            }
            else if (this.idade < 0 || this.idade == 0)
            {
                System.Console.WriteLine("Digite uma idade válida!");
            }
            else
            {
                pessoas.Add(new Pessoa(this.nome, this.email, this.idade));
            }
        }

        // Método para ler as pessoas na lista
        public void Read()
        {
            foreach (var pessoa in pessoas)
            {
                pessoa.WritePessoa();
            }
        }

        public void Update()
        {
            System.Console.WriteLine("Digite o ID da pessoa que deseja atualizar:");
            int id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Digite o novo nome:");
            string nome = System.Console.ReadLine();
            System.Console.WriteLine("Digite o novo e-mail:");
            string email = System.Console.ReadLine();
            System.Console.WriteLine("Digite a nova idade:");
            int idade = Convert.ToInt32(System.Console.ReadLine());

            foreach (var pessoa in pessoas)
            {
                if (pessoa.id == id)
                {
                    pessoa.nome = nome;
                    pessoa.email = email;
                    pessoa.idade = idade;
                }
            }
        }

        public void Delete()
        {
            System.Console.WriteLine("Digite o ID da pessoa que deseja deletar:");
            int id = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Tem certeza que deseja deletar essa pessoa? (S/N)");
            string answ = System.Console.ReadLine().ToUpper();
            if (answ == "S")
            {
                foreach (var pessoa in pessoas)
                {
                    if (pessoa.id == id)
                    {
                        pessoas.Remove(pessoa);
                    }
                }
            }
        }
    }
}

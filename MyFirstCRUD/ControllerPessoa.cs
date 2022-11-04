using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCRUD
{
    internal class ControllerPessoa
    {
        // Propriedades
        public List<Pessoa> pessoas = new List<Pessoa>();
        public string nomeP = null!;
        public string emailP = null!;
        public int idadeP;
        public int numPessoaController;

        public bool IsFind(int posicao)
        {
            this.numPessoaController = 0;
            foreach (var pessoa in pessoas!)
            {
                if (posicao == pessoa.numeroPessoa)
                {
                    return true;
                }

                this.numPessoaController++;
            }

            return false;
        }
        
        public void AddRandomPeople()
        {
            pessoas = new List<Pessoa> { new Pessoa("João", "joao@gmail.com", 20) };
        }

        public void WritePessoa()
        {
            System.Console.WriteLine($"         Pessoa {pessoas[this.numPessoaController].numeroPessoa}");
            System.Console.WriteLine("                              "                                   );
            System.Console.WriteLine($"Nome: {pessoas[numPessoaController].nome}"                  );
            System.Console.WriteLine($"E-mail: {pessoas[numPessoaController].email}"               );
            System.Console.WriteLine($"Idade: {pessoas[numPessoaController].idade}"                );
            System.Console.WriteLine(                                                                   );
            System.Console.WriteLine("------------------------------+"                                  );
            System.Console.WriteLine(                                                                   );
        }

        public void Create()
        {
            System.Console.Clear();
            if (IsFind(Console.ReadAccountNumber()))
            {
                System.Console.Clear();
                WritePessoa();
                System.Console.WriteLine();
                System.Console.WriteLine("Achamos alguém com essa ID, o que deseja fazer?");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Atualizar o cadastro de uma pessoa");
                System.Console.WriteLine("2 - Deletar uma pessoa");
                System.Console.WriteLine("3 - Sair");

                while (true)
                {
                    var userOption = Console.ReadOption();
                    if (userOption == 1)
                    {
                        System.Console.Clear();
                        Update();
                        Console.UserWantToContinue();
                    }
                    else if (userOption == 2)
                    {
                        System.Console.Clear();
                        Delete();
                        Console.UserWantToContinue();
                    }
                    else if (userOption == 3)
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("Obrigado por usar o sistema!");
                        break;
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Conta não encontrada :/");
                System.Console.WriteLine("Deseja criar uma conta? (S/N)");
                
                var ans = System.Console.ReadLine()!.ToUpper();
                
                // Se quiser criar uma conta
                if (ans == "S")
                {
                    this.nomeP = Console.ReadName();
                    this.emailP = Console.ReadEmail();
                    this.idadeP = Console.ReadAge();

                    // Verifica se os dados estão corretos
                    if (this.nomeP == "")
                    {
                        System.Console.WriteLine("Digite um nome válido!");
                    }
                    else if (this.emailP == "")
                    {
                        System.Console.WriteLine("Digite um e-mail válido!");
                    }
                    else if (this.idadeP < 0 || this.idadeP == 0)
                    {
                        System.Console.WriteLine("Digite uma idade válida!");
                    }
                    else
                    {
                        pessoas.Add(new Pessoa(this.nomeP, this.emailP, this.idadeP));
                    }
                }
                // Se não quiser criar uma conta
                else if(ans == "N")
                {
                    Console.UserWantToContinue();
                }
            }
        }

        // Método para ler as pessoas na lista
        public void Read()
        {
            System.Console.Clear();
            for (int x = 0; x < this.pessoas.Count; x++)
            {
                this.numPessoaController = x;
                WritePessoa();
            }
        }

        // Método para atualizar uma pessoa
        public void Update()
        {
            System.Console.Clear();
            if (IsFind(Console.ReadAccountNumber()))
            {
                System.Console.WriteLine("Digite o novo nome:");
                this.nomeP = System.Console.ReadLine()!;

                System.Console.WriteLine("Digite o novo e-mail:");
                this.emailP = System.Console.ReadLine()!;

                System.Console.WriteLine("Digite a nova idade:");
                this.idadeP = Convert.ToInt32(System.Console.ReadLine());
                
                System.Console.WriteLine("Confirma alteração? (S/N)");
                var ans = System.Console.ReadLine()!.ToUpper();
                if (ans == "S")
                {
                    this.pessoas![this.numPessoaController].nome = this.nomeP;
                    this.pessoas[this.numPessoaController].email = this.emailP;
                    this.pessoas[this.numPessoaController].idade = this.idadeP;
                    Thread.Sleep(800);
                    System.Console.WriteLine("Alteração realizada com sucesso");

                }
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Número de conta não encontrado.");
            }
        }

        // Método para deletar uma pessoa
        public void Delete()
        {
            if (IsFind(Console.ReadAccountNumber()))
            {
                System.Console.WriteLine("Tem certeza que deseja deletar esse cadastro? (S/N)");
                string ans = System.Console.ReadLine()!.ToUpper();
                if (ans == "S")
                {
                    this.pessoas!.RemoveAt(this.numPessoaController);
                }
            }
        }

        public void CRUD()
        {
            Console.ShowMenu();
            while (true)
            {
                int userOption = Console.ReadOption();
                if (userOption == 1)
                {
                    System.Console.Clear();
                    Read();
                    Console.UserWantToContinue();
                }
                else if (userOption == 2)
                {
                    System.Console.Clear();
                    Create();
                    Console.UserWantToContinue();
                }
                else if (userOption == 3)
                {
                    System.Console.Clear();
                    Update();
                    Console.UserWantToContinue();
                }
                else if (userOption == 4)
                {
                    System.Console.Clear();
                    Delete();
                    Console.UserWantToContinue();
                }
                else if (userOption == 5)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Obrigado por usar o sistema!");
                    break;
                }
            }
        }
    }
}

using System.Net.Sockets;

namespace MyFirstCRUD
{
    public class Console
    {
        public static void ShowMenu()
        {
            System.Console.WriteLine("1 - Listar todas as pessoas cadastradas");
            System.Console.WriteLine("2 - Cadastrar uma pessoa");
            System.Console.WriteLine("3 - Atualizar o cadastro de uma pessoa");
            System.Console.WriteLine("4 - Deletar uma pessoa");
            System.Console.WriteLine("5 - Sair");
        }

        // Método para ler número da conta
        public static int ReadAccountNumber()
        {
            System.Console.WriteLine("Para verificarmos se você já está cadastrado, digite o número da sua conta:");
            int accountNumber = Convert.ToInt32(System.Console.ReadLine());
            return accountNumber;
        }

        // Método para ler opção do menu
        public static int ReadOption()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("O que quer fazer?");

            while (true)
            {
                string? option = System.Console.ReadLine();
                if (option == "")
                {
                    System.Console.WriteLine("Digite uma opção válida!");
                }
                else
                {
                    if (option == "1")
                    {
                        return 1;
                    }
                    else if (option == "2")
                    {
                        return 2;
                    }
                    else if (option == "3")
                    {
                        return 3;
                    }
                    else if (option == "4")
                    {
                        return 4;
                    }
                    else if (option == "5")
                    {
                        return 5;
                    }
                }
            }
        }

        // Método para ler nome do usuário
        public static string ReadName()
        {
            System.Console.Write("Nome: ");
            string n = System.Console.ReadLine()!;
            return n;
        }

        // Método para ler e-mail do usuário
        public static string ReadEmail()
        {
            System.Console.Write("E-mail: ");
            return System.Console.ReadLine()!;
        }

        // Método para ler idade do usuário
        public static int ReadAge()
        {
            int age = 0;
            do
            {
                System.Console.Write("Idade: ");
                try
                {
                    age = Convert.ToInt32(System.Console.ReadLine());
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Idade inválida!");
                }
            } while (age < 0);
            return age;
        }

        public static void UserWantToContinue()
        {
            System.Console.WriteLine("Deseja continuar e ir para o menu? (S/N)");
            string? option = System.Console.ReadLine()!.ToUpper();
            if (option == "S")
            {
                System.Console.Clear();
                ShowMenu();
            }
            else if (option == "N")
            {
                System.Console.Clear();
                System.Console.WriteLine("Obrigado por usar o sistema!");
                Thread.Sleep(1500);
                System.Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("Opção inválida!");
                Thread.Sleep(500);
                Console.ShowMenu();
            }
        }
    }
}
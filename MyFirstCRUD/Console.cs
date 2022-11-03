namespace MyFirstCRUD
{
    public class Console
    {
        public static void ShowMenu()
        {
            System.Console.WriteLine("Escolha uma opção:");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar todos os clientes");
            System.Console.WriteLine("2 - Cadastrar um cliente");
            System.Console.WriteLine("3 - Atualizar o cadastro de um cliente");
            System.Console.WriteLine("4 - Deletar um registro de cliente");
            System.Console.WriteLine("5 - Sair");
        }

        // Método para ler opção do menu
        public static int ReadOption()
        {
            int option = 0;
            do
            {
                System.Console.Write("Opção: ");
                try
                {
                    option = Convert.ToInt32(System.Console.ReadLine());
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Opção inválida!");
                }
            } while (option < 1 || option > 5);

            return option;
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
            return System.Console.ReadLine();
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

        // Método para limpar tela
        public static void ClearScreen()
        {
            System.Console.Clear();
        }

        // Método para pausar execução
        public static void Pause()
        {
            System.Console.WriteLine("Pressione qualquer tecla para continuar...");
            System.Console.ReadKey();
        }
    }
}
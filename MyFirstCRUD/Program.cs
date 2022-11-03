using MyFirstCRUD;
using Console = MyFirstCRUD.Console;

// TO DO

// 1. Criar uma lista de pessoas (check)
// 2. Criar um objeto do tipo Pessoa e cadastrar em uma lista (check)
// 3. Criar um método para listar todas as pessoas cadastradas (check)
// 4. Criar um método para atualizar um cadastro (check)
// 5. Criar um método para deletar um cadastro (check)

Console.ShowMenu();
Pessoa pessoas = new Pessoa();
pessoas.AddRandomPeople(); // Adiciona uma pessoa só para o banco de dados não ser null


while (true)
{
    if (Console.ReadOption() == 1)
    {
        pessoas.Read();
        break;
    }
    if (Console.ReadOption() == 2)
    {
        pessoas.Create();
        break;
    }
    if (Console.ReadOption() == 3)
    {
        pessoas.Update();
        break;
    }
    if (Console.ReadOption() == 4)
    {
        pessoas.Delete();
        break;
    }
}


System.Console.ReadLine();
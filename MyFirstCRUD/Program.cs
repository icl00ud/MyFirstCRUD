using MyFirstCRUD;
using Console = MyFirstCRUD.Console;

// TO DO

// 1. Criar uma lista de pessoas (check)
// 2. Criar um objeto do tipo Pessoa e cadastrar em uma lista (check)
// 3. Criar um método para listar todas as pessoas cadastradas (check)
// 4. Criar um método para atualizar um cadastro (check)
// 5. Criar um método para deletar um cadastro (check)
// 6. Criar um método para ler a opção do menu (check)
// 7. Criar um método para ler o nome do usuário (check)
// 8. Criar um método para ler o e-mail do usuário (check)
// 9. Criar um método para ler a idade do usuário (check)

// TO DO

ControllerPessoa pessoas = new ControllerPessoa();

pessoas.AddRandomPeople(); // Adiciona uma pessoa só para o banco de dados não ser null

pessoas.CRUD();

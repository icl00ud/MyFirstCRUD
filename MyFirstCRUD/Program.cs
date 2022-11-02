using MyFirstCRUD;

// public Pessoa(string _nome, string _email, string _idade, List<Pessoa> _pessoas)
Pessoa pessoa = new Pessoa("Daniele Schroeder", "danischroederm@gmail.com",19);
pessoa.Create();
pessoa.WritePessoa();
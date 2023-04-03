using CadastroPessoaFST14.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Kalango";
novaPF.cpf = "11111111111";

Console.WriteLine (novaPF.nome);    

Console.WriteLine("Nome: "+ novaPF.nome +" - CPF:" + novaPF.cpf);
Console.WriteLine($"Nome: {novaPF.nome} - CPF: {novaPF.cpf}");
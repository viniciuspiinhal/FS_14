using Back_End_ER04.Classes;

PessoaFisica novaPF = new PessoaFisica();
Endereco novoEndPF = new Endereco();

novaPF.nome = "Vinicius Pinhal";
novaPF.cpf = "123456";
novaPF.rendimento = 18600.5f;
novaPF.dataNasc = new DateTime(2001, 06, 17);

novoEndPF.logradouro = "Rua Particular";
novoEndPF.numero = 704;
novoEndPF.complemento = "Udi";
novoEndPF.endComercial = true;

novaPF.endereco = novoEndPF;

//interpolação
Console.WriteLine(@$"
Nome: {novaPF.nome}
Endereço: {novoEndPF.logradouro}, Num: {novoEndPF.numero}
Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
");

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");

// concatenação 
// Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
// Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");

// // Pessoa Fisica =======================================================================
// float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine($"{impostaPagar:0.00}");
// Console.WriteLine(impostaPagar.ToString("C"));

// // Pessoa Juridica =========================================================================
// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));


// DateTime temp = new DateTime(2006, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("2005/02/01"));






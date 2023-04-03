using Back_End_ER04.Classes;

// PessoaFisica novaPF = new PessoaFisica();
// Endereco novoEndPF = new Endereco();

PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novaEndPJ = new Endereco();

// DADOS DA PESSOA JURIDICA ************************************************************

//Console.WriteLine(novaPJ.ValidarCnpj("76773415000160"));
//Console.WriteLine(novaPJ.ValidarCnpj("76.773.415/0001-60"));

novaPJ.nome = "Empresa Particular";
novaPJ.cnpj = "00.000.000/0001-00";
novaPJ.rendimento = 77600.5f;

novaEndPJ.logradouro = "Rua Particular";
novaEndPJ.numero = 500;
novaEndPJ.complemento = "Particular";
novaEndPJ.endComercial = false;

novaPJ.endereco = novaEndPJ;

//interpolação
Console.WriteLine(@$"
Nome: {novaPJ.nome}
Endereço: {novaEndPJ.logradouro}, Num: {novaEndPJ.numero}
CNPJ: {novaPJ.cnpj} - Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
");




using CadastroPessoaFST14.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Kalango";
novaPF.cpf = "11111111111";
novaPF.rendimento = 12500.5f;

Console.WriteLine (novaPF.nome);    

Console.WriteLine("Nome: "+ novaPF.nome +" - CPF:" + novaPF.cpf);
Console.WriteLine($"Nome: {novaPF.nome} - CPF: {novaPF.cpf}");

float impostoPagoOk = novaPF.CalcularImposto (novaPF.rendimento);

Console.WriteLine(impostoPagoOk.ToString("C"));
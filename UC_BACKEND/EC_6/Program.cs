﻿using Back_End_ER04.Classes;
using Back_End_ER05.Classes;

string? opcao;

Utils.BarraCarregamento("Inicializando");
Console.Clear();

Console.WriteLine(@$"
            =================================================
            |      Bem Vindo ao Sistema de Cadastro de      |
            |            Pessoa Física e Jurídica          |
            =================================================
");
Thread.Sleep(2000);



do
{
    Console.Clear();
    Console.WriteLine(@$"
            =================================================
            |        Digite uma das opções abaixo           |
            |        e tecle Enter para continuar           |
            =================================================
            |                                               |
            |             1 - Pessoa Jurídica               |
            |             2 - Pessoa Física                 |
            |                                               |
            |             0 - Sair                          |
            =================================================
");

    opcao = Console.ReadLine();
    //Console.WriteLine($"Você digitou: {opcao}");

    switch (opcao)
    {
        case "1":
            // DADOS DA PESSOA JURIDICA ************************************************************
            PessoaJuridica novaPJ = new PessoaJuridica();
            Endereco novaEndPJ = new Endereco();

            //Console.WriteLine(novaPJ.ValidarCnpj("76773415000160"));
            //Console.WriteLine(novaPJ.ValidarCnpj("76.773.415/0001-60"));

            novaPJ.nome = "Empresa Particular";
            novaPJ.cnpj = "00.000.000/0001-00";
            novaPJ.rendimento = 22600.5f;

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

            // Pessoa Juridica =========================================================================
            //Console.WriteLine(novaPJ.CalcularImposto(6600.5f));
            Thread.Sleep(10000);
            break;

        case "2":
            //DADOS DA PESSOA FISICA ************************************************************

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

            novaPF.nome = "Vinicius";
            novaPF.cpf = "123456";
            novaPF.rendimento = 18500.5f;
            novaPF.dataNasc = new DateTime(2001, 17, 06);

            novoEndPF.logradouro = "Rua Particular";
            novoEndPF.numero = 704;
            novoEndPF.complemento = "Particular";
            novoEndPF.endComercial = true;

            novaPF.endereco = novoEndPF;

            //interpolação
            Console.WriteLine(@$"
        Nome: {novaPF.nome}
        Endereço: {novoEndPF.logradouro}, Num: {novoEndPF.numero}
        Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
        ");

            // Pessoa Fisica =======================================================================
            //float impostaPagar = novaPF.CalcularImposto(novaPF.rendimento);
            //Console.WriteLine($"{impostaPagar:0.00}");
            //Console.WriteLine(impostaPagar.ToString("C"));
            //DateTime temp = new DateTime(2006, 01, 01);
            //Console.WriteLine(novaPF.ValidarDataNasc("2005/02/01"));


            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadLine();
            break;

        case "0":
            Utils.BarraCarregamento("Finalizando");
            Console.Clear();
            break;
            

        default:
            Console.WriteLine($"digite o valor correto");
            Thread.Sleep(2000);
            break;
    }

} while (opcao != "0");


//********************************************************

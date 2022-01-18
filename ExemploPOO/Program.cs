using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\Isabel.sleigman\\source\\Bel\\Abstração\\orientacao-objeto-dotnet-cshap\\TrabalhoComArquivos";
            var caminhoArquivo = Path.Combine(caminho, "Arquivo-teste-stream.txt");
            var lista = new List<string>{"Linha 1", "Linha 2", "Linha 3"};

            FileHelper helper = new FileHelper();

            //helper.ListarDiretorios(caminho);
           // helper.CriarDiretorio(Path.Combine(caminho, "Pasta Teste 3", "SubPartaTeste3"));
           //helper.ApagarDiretorio(caminho, true);
           //helper.CriarArquivoTexto(caminhoArquivo, "Olá teste de escrita de arquivo");

            helper.CriarArquivoTextoStream(caminhoArquivo, lista);



            // Computador comp = new Computador();

            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();

            // c.Creditar(100);
            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,20));

            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,20,30));

            // Aluno p1 = new Aluno();

            // p1.Nome = "Isabel";
            // p1.Idade = 30;
            // p1.Nota = 10;
            // p1.Documento = "123456";
            // p1.Aprensentar();



            // //Valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);

            // Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            
            // Console.WriteLine($"Área: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Isabel";
            // p1.Idade = 30;

            // p1.Aprensentar();
        }
    }
}

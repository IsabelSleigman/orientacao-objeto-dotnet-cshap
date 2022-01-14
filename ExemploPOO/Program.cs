using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();

            p1.Nome = "Isabel";
            p1.Idade = 30;
            p1.Nota = 10;

            p1.Aprensentar();



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

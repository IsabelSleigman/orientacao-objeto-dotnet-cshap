using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Isabel";
            p1.Idade = 30;

            p1.Aprensentar();
        }
    }
}

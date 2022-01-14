using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

          public override void Aprensentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome} e sou professor, e ganho {Salario}");
        }

    }
}
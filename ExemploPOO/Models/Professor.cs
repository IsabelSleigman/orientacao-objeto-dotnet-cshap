using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa    // para selar uma classe ou metodo usar sealed
    {
        public double Salario { get; set; }

        public override void Aprensentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome} e sou professor, e ganho {Salario}");
        }

    }
}
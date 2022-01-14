using System;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        
        public override void Aprensentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome} e sou professor, e ganho {Salario}");
        }
    }
}